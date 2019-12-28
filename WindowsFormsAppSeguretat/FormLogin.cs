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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonAcceptar_Click(object sender, EventArgs e)
        {
            bool error = false;
            Hash hash = new Hash();

            errorProviderLogin.Clear();

            if (textBoxEmail.Text == "")
            {
                error = true;
                errorProviderLogin.SetError(textBoxEmail, "Correu és obligatori");
            }
            
            if (textBoxContrasenya.Text == "")
            {
                error = true;
                errorProviderLogin.SetError(textBoxContrasenya, "Contrasenya és obligatoria");
            }

            if (!error)
            {
                if (!BD.SelectUsuari(textBoxEmail.Text, hash.Sha512(textBoxContrasenya.Text)))
                {
                    errorProviderLogin.SetError(textBoxEmail, "Usuari o contrasenya incorrectes");
                }
                else
                {
                    this.Close();
                }

            }


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
