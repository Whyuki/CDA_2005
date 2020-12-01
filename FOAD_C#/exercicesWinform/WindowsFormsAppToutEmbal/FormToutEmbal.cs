﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryProduction;

namespace WindowsFormsAppToutEmbal
{
    public partial class FormToutEmbal : Form
    {
        #region Champs
        private delegate void DelegateMiseAJourIHM();
        private DelegateMiseAJourIHM miseAjourIHM;

        private List<Production> productions;
        private Production prodTypeA;
        private Production prodTypeB;
        private Production prodTypeC;

        private const int NombreMilliSecondesParHeure = 1000 * 60 * 60;

        #endregion

        #region Constructeurs
        public FormToutEmbal() : this(new Production("A", 10000, 1000), new Production("B", 25000, 5000), new Production("C", 120000, 10000))
        {

        }

        public FormToutEmbal(Production prod1, Production prod2, Production prod3)
        {
            InitializeComponent();
            timerHeure.Start();

            toolStripStatusLabelHeure.Text = DateTime.Now.ToString("t");

            this.prodTypeA = prod1;
            this.prodTypeB = prod2;
            this.prodTypeC = prod3;
            productions = new List<Production>();
            productions.Add(prodTypeA);
            productions.Add(prodTypeB);
            productions.Add(prodTypeC);

            //event & thread
            prodTypeA.ChangementStatutProduction += ProdTypeA_ChangementStatutProduction;
            prodTypeB.ChangementStatutProduction += ProdTypeB_ChangementStatutProduction;
            prodTypeC.ChangementStatutProduction += ProdTypeC_ChangementStatutProduction;

            prodTypeA.ChangementNbCaisses += ProdTypeA_ChangementNbCaisses;
            prodTypeB.ChangementNbCaisses += ProdTypeB_ChangementNbCaisses;
            prodTypeC.ChangementNbCaisses += ProdTypeC_ChangementNbCaisses;

            miseAjourIHM = new DelegateMiseAJourIHM(MiseAjourIHM);
            this.miseAjourIHM();
        }

        #endregion

        #region Event changement nombre de caisses
        private void ProdTypeC_ChangementNbCaisses(Production prodSender, StatutProduction prodStatut)
        {
            this.Invoke(this.miseAjourIHM);
        }

        private void ProdTypeB_ChangementNbCaisses(Production prodSender, StatutProduction prodStatut)
        {
            this.Invoke(this.miseAjourIHM);
        }

        private void ProdTypeA_ChangementNbCaisses(Production prodSender, StatutProduction prodStatut)
        {
            this.Invoke(this.miseAjourIHM);
        }
        #endregion

        #region Event changement statut de la production
        private void ProdTypeC_ChangementStatutProduction(Production prodSender, StatutProduction prodStatut)
        {
            Thread t = new Thread(() => MajInvok(prodTypeC));
            t.Start();
        }

        private void ProdTypeB_ChangementStatutProduction(Production prodSender, StatutProduction prodStatut)
        {
            Thread t = new Thread(() => MajInvok(prodTypeB));
            t.Start();
        }

        private void ProdTypeA_ChangementStatutProduction(Production prodSender, StatutProduction prodStatut)
        {
            Thread t = new Thread(() => MajInvok(prodTypeA));
            t.Start();
        }
        #endregion

        #region Thread production
        public void MajInvok(Production prod)
        {
            int dureeDodo = NombreMilliSecondesParHeure / prod.NbCaissesAProduireParHeure;
            bool continuerThread = true;
            while (continuerThread)
            {
                if (prod.StatutDeLaProduction == StatutProduction.Demarré || prod.StatutDeLaProduction == StatutProduction.Redemarré)
                {
                    Thread.Sleep(dureeDodo);
                    this.Produire(prod);
                    this.Invoke(this.miseAjourIHM);
                }
                else
                {
                    if (prod.StatutDeLaProduction == StatutProduction.Terminé)
                    {
                        MessageBox.Show("Production " + prod.Nom + " terminée !");
                    }
                    continuerThread = false;
                }
            }
        }
        #endregion

        #region Mise a jour de l'IHM
        private void MiseAjourIHM()
        {
            this.ActiverDesactiverBoutonsActions();
            this.ProgressBarsAJour();
            this.StatutProductionLabelAJour();
            this.TauxDefautHeureAJour();
            this.TauxDefautDepuisDemarrageAJour();
            this.NombreCaissesDepuisDemarrageAjour();
            this.AvancementAJour();
        }

        private void NombreCaissesDepuisDemarrageAjour()
        {
            textBoxNbCaisseDepuisDemarrageTypeA.Text = prodTypeA.NbCaissesDepuisDemarrageTotal.ToString();
            textBoxNbCaisseDepuisDemarrageTypeB.Text = prodTypeB.NbCaissesDepuisDemarrageTotal.ToString();
            textBoxNbCaisseDepuisDemarrageTypeC.Text = prodTypeC.NbCaissesDepuisDemarrageTotal.ToString();
        }
        private void TauxDefautHeureAJour()
        {
            if (!prodTypeA.IsTermine())
            {
                textBoxTauxDefautHeureTypeA.Text = prodTypeA.CalculTauxDefautHeure().ToString();
            }
            if (!prodTypeB.IsTermine())
            {
                textBoxTauxDefautHeureTypeB.Text = prodTypeB.CalculTauxDefautHeure().ToString();
            }
            if (!prodTypeC.IsTermine())
            {
                textBoxTauxDefautHeureTypeC.Text = prodTypeC.CalculTauxDefautHeure().ToString();
            }
        }
        private void TauxDefautDepuisDemarrageAJour()
        {
            textBoxTauxDefautDepuisDemarrageTypeA.Text = prodTypeA.CalculTauxDefautDepuisDemarrage().ToString();
            textBoxTauxDefautDepuisDemarrageTypeB.Text = prodTypeB.CalculTauxDefautDepuisDemarrage().ToString();
            textBoxTauxDefautDepuisDemarrageTypeC.Text = prodTypeC.CalculTauxDefautDepuisDemarrage().ToString();
        }
        private void StatutProductionLabelAJour()
        {
            toolStripStatusLabelCaisseAEtat.Text = prodTypeA.StatutDeLaProduction.ToString();
            toolStripStatusLabelCaisseBEtat.Text = prodTypeB.StatutDeLaProduction.ToString();
            toolStripStatusLabelCaisseCEtat.Text = prodTypeC.StatutDeLaProduction.ToString();
        }
        private void ProgressBarsAJour()
        {
            progressBarProdA.Value = prodTypeA.CalculAvancementEnPourcentage();
            progressBarProdB.Value = prodTypeB.CalculAvancementEnPourcentage();
            progressBarProdC.Value = prodTypeC.CalculAvancementEnPourcentage();
        }
        private void ActiverDesactiverBoutonsActions()
        {
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

            if (DemarragePossible(prodTypeA) || ReprisePossible(prodTypeA))
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

            if (DemarragePossible(prodTypeB) || ReprisePossible(prodTypeB))
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

            if (DemarragePossible(prodTypeC) || ReprisePossible(prodTypeC))
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
        }
        private void AvancementAJour()
        {
            labelAvancementA.Text = prodTypeA.NbCaissesDepuisDemarrageTotal.ToString() + "/" + prodTypeA.NbCaissesAProduire.ToString() + " : " + prodTypeA.CalculAvancementEnPourcentage().ToString() + "%";
            labelAvancementB.Text = prodTypeB.NbCaissesDepuisDemarrageTotal.ToString() + "/" + prodTypeB.NbCaissesAProduire.ToString() + " : " + prodTypeB.CalculAvancementEnPourcentage().ToString() + "%";
            labelAvancementC.Text = prodTypeC.NbCaissesDepuisDemarrageTotal.ToString() + "/" + prodTypeC.NbCaissesAProduire.ToString() + " : " + prodTypeC.CalculAvancementEnPourcentage().ToString() + "%";

        }

        #endregion

        #region Actions possibles
        private bool DemarragePossible(Production prod)
        {
            if (prod.StatutDeLaProduction == StatutProduction.NonDemarré
                    || prod.StatutDeLaProduction == StatutProduction.Terminé)
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

        #region Demarrer / Redemarrer
        private void Demarrer(Production prod)
        {
            if (prod.IsTermine())
            {
                prod.DemarrerProduction();
            }
            else if (ReprisePossible(prod))
            {
                DialogResult result = MessageBox.Show("Cette action redémarre la production: êtes vous sûr de vouloir redémarrer ? \nPour reprendre la production cliquez sur NON\nPour annuler cliquez sur ANNULER", "REDEMARRER OU CONTINUER", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    prod.DemarrerProduction();
                }
                else if (result == DialogResult.No)
                {
                    prod.ContinuerProduction();
                }
            }
            else if (DemarragePossible(prod))
            {
                prod.DemarrerProduction();
            }
            this.miseAjourIHM();
        }

        #endregion

        #region Arreter
        private void Arreter(Production prod)
        {
            if (ArretPossible(prod))
            {
                prod.ArreterProduction();
            }
            this.miseAjourIHM();

        }
        #endregion

        #region Continuer
        private void Continuer(Production prod)
        {
            if (ReprisePossible(prod))
            {
                prod.ContinuerProduction();
            }
            this.miseAjourIHM();

        }
        #endregion

        #region Produire
        private void Produire(Production prod)
        {
            if (prod.StatutDeLaProduction == StatutProduction.Demarré
           || prod.StatutDeLaProduction == StatutProduction.Redemarré)
            {
                prod.ProduireUneCaisse();
            }
        }
        #endregion

        #region Timer Heure
        private void timerHeure_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHeure.Text = DateTime.Now.ToString("t");
        }
        #endregion

        #region Actions prod A
        private void toolStripButtonDemarrerA_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeA);
            tabControlOngletsType.SelectedTab = tabTypeA;
        }

        private void toolStripMenuItemDemarrerA_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeA);
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
            tabControlOngletsType.SelectedTab = tabTypeB;
        }

        private void toolStripMenuItemDemarrerB_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeB);
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
            tabControlOngletsType.SelectedTab = tabTypeC;
        }

        private void toolStripMenuItemDemarrerC_Click(object sender, EventArgs e)
        {
            this.Demarrer(prodTypeC);
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

        #region Quitter
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormToutEmbal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
           ("Fin de l’application", "Quitter",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
        #endregion

    }
}

