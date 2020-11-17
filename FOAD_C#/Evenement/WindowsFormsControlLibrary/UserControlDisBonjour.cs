using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class UserControlDisBonjour : UserControl
    {
        private string nomSurLequelIlFautReagir;

        public string NomSurLequelIlFautReagir { get => nomSurLequelIlFautReagir; set => nomSurLequelIlFautReagir = value; }

        //declarer l'evenement graphique
        public event EventHandler NomTrouve;

        public UserControlDisBonjour()
        {
            InitializeComponent();
        }

        
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxNom.Text.Equals(nomSurLequelIlFautReagir))
            {
                if (NomTrouve != null)//si qq 'un c'est enregistre sur l'evenement
                {
                    //envoyer l'evenement
                    NomTrouve(this, new EventArgs());
                }
            }
        }
    }
}
