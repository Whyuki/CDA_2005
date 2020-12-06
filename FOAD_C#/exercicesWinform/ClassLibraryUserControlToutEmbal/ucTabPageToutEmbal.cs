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
    public partial class ucTabPageToutEmbal : TabPage
    {
        public ucTabPageToutEmbal(string nom)
        {
            InitializeComponent();
            this.Name = "tabPage" + nom;
            this.Text = "Type " + nom;
            this.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
