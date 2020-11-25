using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMenu
{
    public partial class FormLogin : Form
    {

        private bool loginIsOk;

        public FormLogin()
        {
            InitializeComponent();
            loginIsOk = false;
        }

        public bool LoginIsOk { get => loginIsOk; set => loginIsOk = value; }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValiderSaisie()
        {
            if (textBoxLogin.Text == "nyadmin" && textBoxPassword.Text == "nyadmin")
            {
                loginIsOk = true;
                this.Close();
            }
            else
            {
                errorProviderLogin.SetError(buttonOk, "Echec de l'identification");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.ValiderSaisie();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();

        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValiderSaisie();
        }



        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValiderSaisie();
        }

        private void click_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.ValiderSaisie();
            }
        }
    }
}
