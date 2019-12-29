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
    public partial class FormSeguretat : Form
    {
        public FormSeguretat()
        {
            InitializeComponent();
        }

        private void rolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRols f = new FormRols();

            f.ShowDialog();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuarisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuaris f = new FormUsuaris();
            f.ShowDialog();
        }

        private void FormSeguretat_Load(object sender, EventArgs e)
        {
            //FormLogin f = new FormLogin();

            //f.ShowDialog();
        }
    }
}
