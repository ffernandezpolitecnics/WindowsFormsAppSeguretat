using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSeguretat
{
    public partial class FormUsuaris : Form
    {
        public FormUsuaris()
        {
            InitializeComponent();
        }

        private void FormUsuaris_Load(object sender, EventArgs e)
        {
            dataGridViewUsuaris.AutoGenerateColumns = false;
            OmplirUsuaris();
        }

        private void OmplirUsuaris()
        {
            dataGridViewUsuaris.DataSource = BD.SelectUsuaris();
        }

        private void toolStripButtonAfegir_Click(object sender, EventArgs e)
        {
            FormUsuari f = new FormUsuari();
            f.ShowDialog();
            OmplirUsuaris();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonEsborrar_Click(object sender, EventArgs e)
        {
            String missatge;

            if (dataGridViewUsuaris.SelectedRows.Count > 0)
            {
                DialogResult resultat =
                MessageBox.Show("Estas segur d'esborrar l'usuari?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultat == DialogResult.Yes)
                {
                    missatge = BD.DeleteUsuari((int)dataGridViewUsuaris.SelectedRows[0].Cells["id"].Value);

                    if (!missatge.Equals(""))
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        OmplirUsuaris();
                    }
                }
            }
        }

        private void dataGridViewUsuaris_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUsuari f = new FormUsuari(
                                (int)dataGridViewUsuaris.SelectedRows[0].Cells["id"].Value,
                                dataGridViewUsuaris.SelectedRows[0].Cells["eMail"].Value.ToString(),
                                dataGridViewUsuaris.SelectedRows[0].Cells["nom"].Value.ToString(),
                                (int)dataGridViewUsuaris.SelectedRows[0].Cells["idRol"].Value);
            f.ShowDialog();
            OmplirUsuaris();
        }

        private void dataGridViewUsuaris_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = BD.SelectRol((int)dataGridViewUsuaris.Rows[e.RowIndex].Cells["idRol"].Value);
            }
        }
    }
}

