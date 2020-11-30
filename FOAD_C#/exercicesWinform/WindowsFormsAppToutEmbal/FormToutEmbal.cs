using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryProduction;

namespace WindowsFormsAppToutEmbal
{
    public partial class FormToutEmbal : Form
    {
        #region Champs
        private Production prodTypeA;
        private Production prodTypeB;
        private Production prodTypeC;
        #endregion

        #region Constructeur
        public FormToutEmbal()
        {
            InitializeComponent();
            timerHeure.Start();

            toolStripStatusLabelHeure.Text = DateTime.Now.ToString("t");

            this.prodTypeA = new Production(10000, 1000);
            this.prodTypeB = new Production(25000, 5000);
            this.prodTypeC = new Production(120000, 10000);

            #region tests rapide
            // pour tests rapide
            //this.prodTypeA = new Production(100, 10);
            //this.prodTypeB = new Production(250, 50);
            //this.prodTypeC = new Production(120, 10);
            //timerProdA.Interval = 100;
            //timerProdB.Interval = 100;
            //timerProdC.Interval = 100;
            #endregion

            this.ParametrerTimer(timerProdA, prodTypeA);
            this.ParametrerTimer(timerProdB, prodTypeB);
            this.ParametrerTimer(timerProdC, prodTypeC);

            this.MiseAJourDeLaVue();
        }
        #endregion

        #region Parametrer timer
        public void ParametrerTimer(Timer timer, Production prod)
        {
            timer.Interval = 3600000 / prod.NbCaissesAProduireParHeure;
        }
        #endregion

        #region Mise à jour de la vue
        public void MiseAJourDeLaVue()
        {
            this.MiseAJourBoutonsProduction();
            this.MiseAJourTBCausseDepuisDemarrage();
            this.MiseAJourTBTauxDefautDepuisDemarrage();
            this.MiseAJourTBTauxDefautHeure();
            this.MiseAJourStatusLabel();
            this.MiseAJourProgressBars();
        }
        #endregion

        #region Méthodes de mise à jour de la vue 
        public void MiseAJourProgressBars()
        {
            progressBarProdA.Value = prodTypeA.CalculAvancementEnPourcentage();
            progressBarProdB.Value = prodTypeB.CalculAvancementEnPourcentage();
            progressBarProdC.Value = prodTypeC.CalculAvancementEnPourcentage();
        }

        public void MiseAJourStatusLabel()
        {
            toolStripStatusLabelCaisseAEtat.Text = prodTypeA.StatutDeLaProduction.ToString();
            toolStripStatusLabelCaisseBEtat.Text = prodTypeB.StatutDeLaProduction.ToString();
            toolStripStatusLabelCaisseCEtat.Text = prodTypeC.StatutDeLaProduction.ToString();
        }

        public void MiseAJourTBTauxDefautHeure()
        {
            textBoxTauxDefautHeureTypeA.Text = prodTypeA.CalculTauxDefautHeure().ToString();
            textBoxTauxDefautHeureTypeB.Text = prodTypeB.CalculTauxDefautHeure().ToString();
            textBoxTauxDefautHeureTypeC.Text = prodTypeC.CalculTauxDefautHeure().ToString();
        }
        public void MiseAJourTBTauxDefautDepuisDemarrage()
        {
            textBoxTauxDefautDepuisDemarrageTypeA.Text = prodTypeA.CalculTauxDefautDepuisDemarrage().ToString();
            textBoxTauxDefautDepuisDemarrageTypeB.Text = prodTypeB.CalculTauxDefautDepuisDemarrage().ToString();
            textBoxTauxDefautDepuisDemarrageTypeC.Text = prodTypeC.CalculTauxDefautDepuisDemarrage().ToString();
        }

        public void MiseAJourTBCausseDepuisDemarrage()
        {
            textBoxNbCaisseDepuisDemarrageTypeA.Text = prodTypeA.NbCaissesDepuisDemarrageTotal.ToString();
            textBoxNbCaisseDepuisDemarrageTypeB.Text = prodTypeB.NbCaissesDepuisDemarrageTotal.ToString();
            textBoxNbCaisseDepuisDemarrageTypeC.Text = prodTypeC.NbCaissesDepuisDemarrageTotal.ToString();
        }

        public void MiseAJourBoutonsProduction()
        {
            #region reinitialisation desactiver tous les boutons
            foreach (ToolStripButton item in toolStripFeuxTricolore.Items)
            {
                item.Enabled = false;
            }

            foreach (ToolStripMenuItem item in démarrerToolStripMenuItem.DropDownItems)
            {
                item.Enabled = false;
            }
            foreach (ToolStripMenuItem item in arrêterToolStripMenuItem.DropDownItems)
            {
                item.Enabled = false;
            }
            foreach (ToolStripMenuItem item in continuerToolStripMenuItem.DropDownItems)
            {
                item.Enabled = false;
            }
            #endregion

            #region Affichage boutons prod A
            if (DemarragePossible(prodTypeA))
            {
                toolStripButtonDemarrerA.Enabled = true;
                toolStripMenuItemDemarrerA.Enabled = true;
            }

            if (ArretPossible(prodTypeA))
            {
                toolStripButtonSuspendreA.Enabled = true;
                toolStripMenuItemArreterA.Enabled = true;
            }

            if (ReprisePossible(prodTypeA))
            {
                toolStripButtonContinuerA.Enabled = true;
                toolStripMenuItemContinuerA.Enabled = true;
            }
            #endregion

            #region Affichage boutons prod B
            if (DemarragePossible(prodTypeB))
            {
                toolStripButtonDemarrerB.Enabled = true;
                toolStripMenuItemDemarrerB.Enabled = true;
            }

            if (ArretPossible(prodTypeB))
            {
                toolStripButtonSuspendreB.Enabled = true;
                toolStripMenuItemArreterB.Enabled = true;
            }

            if (ReprisePossible(prodTypeB))
            {
                toolStripButtonContinuerB.Enabled = true;
                toolStripMenuItemContinuerB.Enabled = true;
            }
            #endregion

            #region Affichage boutons prod C
            if (DemarragePossible(prodTypeC))
            {
                toolStripButtonDemarrerC.Enabled = true;
                toolStripMenuItemDemarrerC.Enabled = true;
            }

            if (ArretPossible(prodTypeC))
            {
                toolStripButtonSuspendreC.Enabled = true;
                toolStripMenuItemArreterC.Enabled = true;
            }

            if (ReprisePossible(prodTypeC))
            {
                toolStripButtonContinuerC.Enabled = true;
                toolStripMenuItemContinuerC.Enabled = true;
            }
            #endregion
        }
        #endregion

        #region Actions possibles
        private bool DemarragePossible(Production prod)
        {
            if (prod.StatutDeLaProduction == StatutProduction.NonDemarré
                    || prod.StatutDeLaProduction == StatutProduction.Terminé
                    || prod.StatutDeLaProduction == StatutProduction.Suspendu)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ArretPossible(Production prod)
        {
            if (prod.StatutDeLaProduction == StatutProduction.Redemarré
                || prod.StatutDeLaProduction == StatutProduction.Demarré)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ReprisePossible(Production prod)
        {
            if (prod.StatutDeLaProduction == StatutProduction.Suspendu)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Demarrer
        private void Demarrer(Production prod)
        {
            if (DemarragePossible(prod))
            {
                if (ReprisePossible(prod))
                {
                    DialogResult result = MessageBox.Show("Cette action redémarre la production, toute progression sera perdue: êtes vous sûr de vouloir redémarrer ? \nPour reprendre la production cliquez sur NON", "REDEMARRER OU CONTINUER", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        prod.DemarrerProduction();
                    }
                    else if (result == DialogResult.No)
                    {
                        prod.ContinuerProduction();
                    }
                }
                else if (prod.IsTermine())
                {

                    prod.DemarrerProduction();
                }
                else
                {

                    prod.DemarrerProduction();
                }
            }
            this.MiseAJourDeLaVue();
        }
        #endregion

        #region Arreter
        private void Arreter(Production prod)
        {
            if (ArretPossible(prod))
            {
                prod.ArreterProduction();

            }

            this.MiseAJourDeLaVue();
        }
        #endregion

        #region Continuer
        private void Continuer(Production prod)
        {
            if (ReprisePossible(prod))
            {
                prod.ContinuerProduction();
            }

            this.MiseAJourDeLaVue();
        }
        #endregion

        #region Produire
        private void Produire(Production prod)
        {
            if (prod.StatutDeLaProduction == StatutProduction.Demarré
           || prod.StatutDeLaProduction == StatutProduction.Redemarré)
            {
                prod.ProduireUneCaisse();
                MiseAJourDeLaVue();
            }
        }
        #endregion

        #region Timer Heure
        private void timerHeure_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHeure.Text = DateTime.Now.ToString("t");
        }
        #endregion

        #region Timer prod tick
        private void timerProdA_Tick(object sender, EventArgs e)
        {
            if (prodTypeA.IsTermine())
            {
                timerProdA.Stop();
                tabControlOngletsType.SelectedTab = tabTypeA;
                MessageBox.Show("Production A terminée !");
            }
            else
            {
                this.Produire(prodTypeA);
            }
            MiseAJourDeLaVue();

        }

        private void timerProdB_Tick(object sender, EventArgs e)
        {
            if (prodTypeB.IsTermine())
            {
                timerProdB.Stop();
                tabControlOngletsType.SelectedTab = tabTypeB;
                MessageBox.Show("Production B terminée !");
            }
            else
            {
                this.Produire(prodTypeB);
            }
            MiseAJourDeLaVue();

        }

        private void timerProdC_Tick(object sender, EventArgs e)
        {
            if (prodTypeC.IsTermine())
            {
                timerProdC.Stop();
                tabControlOngletsType.SelectedTab = tabTypeC;
                MessageBox.Show("Production C terminée !");
            }
            else
            {
                this.Produire(prodTypeC);
            }
            MiseAJourDeLaVue();

        }
        #endregion

        #region Actions prod A
        private void toolStripButtonDemarrerA_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeA);
            timerProdA.Start();

            tabControlOngletsType.SelectedTab = tabTypeA;
        }

        private void toolStripMenuItemDemarrerA_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeA);
            timerProdA.Start();

            tabControlOngletsType.SelectedTab = tabTypeA;
        }

        private void toolStripButtonSuspendreA_Click(object sender, EventArgs e)
        {
            this.Arreter(prodTypeA);
            tabControlOngletsType.SelectedTab = tabTypeA;
        }

        private void toolStripMenuItemArreterA_Click(object sender, EventArgs e)
        {
            this.Arreter(prodTypeA);
            tabControlOngletsType.SelectedTab = tabTypeA;
        }

        private void toolStripMenuItemContinuerA_Click(object sender, EventArgs e)
        {
            this.Continuer(prodTypeA);
            tabControlOngletsType.SelectedTab = tabTypeA;
        }

        private void toolStripButtonContinuerA_Click(object sender, EventArgs e)
        {
            this.Continuer(prodTypeA);
            tabControlOngletsType.SelectedTab = tabTypeA;

        }
        #endregion

        #region Actions prod B
        private void toolStripButtonDemarrerB_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeB);
            timerProdB.Start();

            tabControlOngletsType.SelectedTab = tabTypeB;
        }

        private void toolStripMenuItemDemarrerB_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeB);
            timerProdB.Start();

            tabControlOngletsType.SelectedTab = tabTypeB;

        }

        private void toolStripButtonSuspendreB_Click(object sender, EventArgs e)
        {
            this.Arreter(prodTypeB);
            tabControlOngletsType.SelectedTab = tabTypeB;

        }

        private void toolStripMenuItemArreterB_Click(object sender, EventArgs e)
        {
            this.Arreter(prodTypeB);
            tabControlOngletsType.SelectedTab = tabTypeB;

        }

        private void toolStripMenuItemContinuerB_Click(object sender, EventArgs e)
        {
            this.Continuer(prodTypeB);
            tabControlOngletsType.SelectedTab = tabTypeB;

        }

        private void toolStripButtonContinuerB_Click(object sender, EventArgs e)
        {
            this.Continuer(prodTypeB);
            tabControlOngletsType.SelectedTab = tabTypeB;

        }
        #endregion

        #region Actions prod C
        private void toolStripButtonDemarrerC_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeC);
            timerProdC.Start();

            tabControlOngletsType.SelectedTab = tabTypeC;
        }

        private void toolStripMenuItemDemarrerC_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeC);
            timerProdC.Start();

            tabControlOngletsType.SelectedTab = tabTypeC;

        }

        private void toolStripButtonSuspendreC_Click(object sender, EventArgs e)
        {
            this.Arreter(prodTypeC);
            tabControlOngletsType.SelectedTab = tabTypeC;

        }

        private void toolStripMenuItemArreterC_Click(object sender, EventArgs e)
        {
            this.Arreter(prodTypeC);
            tabControlOngletsType.SelectedTab = tabTypeC;

        }

        private void toolStripButtonContinuerC_Click(object sender, EventArgs e)
        {
            this.Continuer(prodTypeC);
            tabControlOngletsType.SelectedTab = tabTypeC;

        }

        private void toolStripMenuItemContinuerC_Click(object sender, EventArgs e)
        {
            this.Continuer(prodTypeC);
            tabControlOngletsType.SelectedTab = tabTypeC;

        }
        #endregion

        #region Clics progress bars select tab
        private void labelProgressProdA_Click(object sender, EventArgs e)
        {
            tabControlOngletsType.SelectedTab = tabTypeA;

        }

        private void labelProgressProdB_Click(object sender, EventArgs e)
        {
            tabControlOngletsType.SelectedTab = tabTypeB;

        }

        private void labelProgressProdC_Click(object sender, EventArgs e)
        {
            tabControlOngletsType.SelectedTab = tabTypeC;

        }

        private void progressBarProdA_Click(object sender, EventArgs e)
        {
            tabControlOngletsType.SelectedTab = tabTypeA;

        }

        private void progressBarProdB_Click(object sender, EventArgs e)
        {
            tabControlOngletsType.SelectedTab = tabTypeB;

        }

        private void progressBarProdC_Click(object sender, EventArgs e)
        {
            tabControlOngletsType.SelectedTab = tabTypeC;

        }
        #endregion

        #region Clics label status bars select tab
        private void toolStripStatusLabelA_Click(object sender, EventArgs e)
        {
            tabControlOngletsType.SelectedTab = tabTypeA;
        }

        private void toolStripStatusLabelB_Click(object sender, EventArgs e)
        {
            tabControlOngletsType.SelectedTab = tabTypeB;
        }

        private void toolStripStatusLabelC_Click(object sender, EventArgs e)
        {
            tabControlOngletsType.SelectedTab = tabTypeC;
        }
        #endregion

        #region Menu quitter
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
