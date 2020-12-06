using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryUserControlToutEmbal
{
    public partial class ucProgressBar : UserControl
    {
        public ucProgressBar(string nom)
        {
            InitializeComponent();
            this.Name = "progressBar" + nom;
            this.labelProgress.Text = "Production " + nom;
            this.progressBarProdA.Name = "progressBar" + nom;
        }
    }
}
