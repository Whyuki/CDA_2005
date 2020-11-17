using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibrary;

namespace WindowsFormsAppReagitAUnEvenement
{
    public partial class FormPolitesse : Form
    {
        public FormPolitesse()
        {
            InitializeComponent();
            this.button1.Click += Button1_Click2;
            this.button1.Click -= Button1_Click2;
            //m'enregistre sur l'evenement NomTrouve du userControlDisBonjour2
            this.userControlDisBonjour2.NomTrouve += UserControlDisBonjour2_NomTrouve;
        }

        private void UserControlDisBonjour2_NomTrouve(object sender, EventArgs e)
        {
            MessageBox.Show(this.userControlDisBonjour2.NomSurLequelIlFautReagir + "a ete reconnu");
        }

        private void Button1_Click2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormPolitesse_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FormPolitesse_MouseClick(object sender, MouseEventArgs e)
        {

        }

        
        private void userControlDisBonjour1_NomTrouve(object sender, EventArgs e)
        {
            UserControlDisBonjour u = (UserControlDisBonjour)sender;
            MessageBox.Show(this.userControlDisBonjour1.NomSurLequelIlFautReagir + "a ete reconnu");
        }

        private void userControlDisBonjour1_Load(object sender, EventArgs e)
        {

        }
    }
}
