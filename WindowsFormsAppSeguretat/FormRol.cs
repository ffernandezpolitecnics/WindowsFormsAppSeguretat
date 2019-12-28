using OC.Core.Crypto;
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
    public partial class FormRol : Form
    {
        bool modificar = false;
        int id;
        String nom;


        public FormRol()
        {
            InitializeComponent();
        }

        public FormRol(int id, String nom)
        {
            InitializeComponent();
            this.id = id;
            this.nom = nom;
            modificar = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String missatge;

            errorProviderRol.Clear();

            if (textBoxNom.Text.Equals(""))
            {
                errorProviderRol.SetError(textBoxNom, "El nom és obligatori");
            }

            if (modificar)
            {
                missatge = BD.UpdateRol(id, textBoxNom.Text);
            }
            else
            {
                missatge = BD.InsertRol(textBoxNom.Text);
            }

            
            if (missatge.Equals(""))
            {
                this.Close();
            }
            else
            {
                errorProviderRol.SetError(textBoxNom, missatge);
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRol_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                textBoxNom.Text = nom;
            }
        }
    }
}
