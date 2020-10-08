using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlesSaisie
{
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// constructor
        /// with init component param
        /// </summary>
        /// <param name="_nom"></param>
        /// <param name="_date"></param>
        /// <param name="_montant"></param>
        /// <param name="_cp"></param>
        public Validation(string _nom, string _date, string _montant, string _cp)
        {
            InitializeComponent();
            InitializeComponent2(_nom, _date, _montant, _cp);
        }

        /// <summary>
        /// init component param
        /// </summary>
        /// <param name="_nom"></param>
        /// <param name="_date"></param>
        /// <param name="_montant"></param>
        /// <param name="_cp"></param>
        public void InitializeComponent2(string _nom, string _date, string _montant, string _cp)
        {
            this.validNom.Text = _nom;
            this.validDate.Text = _date;
            this.validMontant.Text = _montant;
            this.validCP.Text = _cp;

        }

        /// <summary>
        /// event buttonOK_Click
        /// init & show new fin form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Fin fin = new Fin();
            fin.Show();
        }
    }
}
