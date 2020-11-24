using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMenu
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
            timerSplashScreen.Start();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            progressBarSplashScreen.Increment(25);
            if (progressBarSplashScreen.Value >100)
            {
                timerSplashScreen.Stop();
                Application.Exit();
            }
        }
    }
}
