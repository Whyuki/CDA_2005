using ClassLibraryProduction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppToutEmbal
{
    public partial class FormAccueilToutEmbal : Form
    {
        public FormAccueilToutEmbal()
        {
            InitializeComponent();
        }

        private void buttonDemo_Click(object sender, EventArgs e)
        {
            FormToutEmbalV2 formToutEmbalDemo = new FormToutEmbalV2(new Production("A", 100, 10000), new Production("B", 400, 30000), new Production("C", 600, 100000));
            formToutEmbalDemo.ShowDialog();
        }

        private void buttonExo_Click(object sender, EventArgs e)
        {
            FormToutEmbalV2 formToutEmbalExo = new FormToutEmbalV2();
            formToutEmbalExo.ShowDialog();
        }
    }
}
