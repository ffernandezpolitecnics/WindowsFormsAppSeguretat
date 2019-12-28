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
    public partial class FormRols : Form
    {
        public FormRols()
        {
            InitializeComponent();
        }

        private void toolStripButtonAfegir_Click(object sender, EventArgs e)
        {
            FormRol f = new FormRol();

            f.ShowDialog();

            OmplirRols();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRols_Load(object sender, EventArgs e)
        {
            dataGridViewRols.AutoGenerateColumns = false;
            OmplirRols();
        }

        private void OmplirRols()
        {
            dataGridViewRols.DataSource = BD.SelectRols();
        }

        private void toolStripButtonEsborrar_Click(object sender, EventArgs e)
        {
            String missatge;

            if (dataGridViewRols.SelectedRows.Count > 0)
            {
                DialogResult resultat =
                MessageBox.Show("Estas segur d'esborrar el rol?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultat == DialogResult.Yes)
                {
                    missatge = BD.DeleteRol((int)dataGridViewRols.SelectedRows[0].Cells["id"].Value);

                    if (!missatge.Equals(""))
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        OmplirRols();
                    }
                }
            }

            
        }

        private void dataGridViewRols_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormRol f = new FormRol((int)dataGridViewRols.SelectedRows[0].Cells["id"].Value,
                                    dataGridViewRols.SelectedRows[0].Cells["nom"].Value.ToString());
            f.ShowDialog();
            OmplirRols();
        }
    }
}
