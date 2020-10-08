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
    public partial class Fin : Form
    {
        public Fin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event buttonOui_Click
        /// exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOui_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// event buttonNon_Click
        /// close current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
