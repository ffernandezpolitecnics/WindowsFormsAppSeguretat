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
    public partial class FormUsuari : Form
    {
        bool modificar = false;
        int id;
        String eMail, nom;
        int idRol;

        public FormUsuari()
        {
            InitializeComponent();
        }

        public FormUsuari(int id, String eMail, String nom, int idRol)
        {
            InitializeComponent();
            modificar = true;
            this.id = id;
            this.eMail = eMail;
            this.nom = nom;
            this.idRol = idRol;
        }

        private void FormUsuari_Load(object sender, EventArgs e)
        {
            comboBoxRol.DisplayMember = "nom";
            comboBoxRol.ValueMember = "id";
            comboBoxRol.DataSource = BD.SelectRols();

            if (modificar)
            {
                labelContrasenya.Visible = false;
                textBoxContrasenya.Visible = false;
                labelConfContrasenya.Visible = false;
                textBoxConfContrasenya.Visible = false;
                textBoxEmail.Text = eMail;
                textBoxNom.Text = nom;
                comboBoxRol.SelectedValue = idRol;
            }
            else
            {
                labelContrasenya.Visible = true;
                textBoxContrasenya.Visible = true;
                labelConfContrasenya.Visible = true;
                textBoxConfContrasenya.Visible = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String missatge;
            
            if (ValidarDades())
            {
                if (modificar)
                {
                    missatge = BD.UpdateUsuari(id, textBoxNom.Text, textBoxEmail.Text, (int)comboBoxRol.SelectedValue);
                }
                else
                {
                    Hash hash = new Hash();
                    String contrasenya;

                    contrasenya = hash.Sha512(textBoxContrasenya.Text);
                    missatge = BD.InsertUsuari(textBoxNom.Text, textBoxEmail.Text, (int)comboBoxRol.SelectedValue, contrasenya);
                }

                if (missatge == "")
                {
                    this.Close();
                }
                else
                {
                    errorProviderUsuari.SetError(buttonGuardar, missatge);
                }
            }

        }

        private bool ValidarDades()
        {
            bool correcte = true;

            errorProviderUsuari.Clear();

            if (textBoxEmail.Text == "")
            {
                errorProviderUsuari.SetError(textBoxEmail, "Email obligatori");
                correcte = false;
            }

            if (textBoxNom.Text == "")
            {
                errorProviderUsuari.SetError(textBoxNom, "Nom obligatori");
                correcte = false;
            }

            if (!modificar)
            {
                if (textBoxContrasenya.Text == "")
                {
                    errorProviderUsuari.SetError(textBoxContrasenya, "Contrasenya obligatori");
                    correcte = false;
                }
                else
                {
                    if (textBoxContrasenya.Text != textBoxConfContrasenya.Text)
                    {
                        errorProviderUsuari.SetError(textBoxConfContrasenya, "Confirmació contrasenya incorrecta");
                        correcte = false;
                    }
                }
            }
            
            return correcte;
        }
    }
}
