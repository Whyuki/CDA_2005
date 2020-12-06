using ClassLibraryProduction;
using ClassLibraryUserControlToutEmbal;
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

namespace WindowsFormsAppToutEmbal
{
    public partial class FormToutEmbalV3 : Form
    {
        #region Champs
        private delegate void DelegateMiseAJourIHM(Production prodSender, StatutProduction prodStatut);
        private DelegateMiseAJourIHM miseAjourIHM;

        private List<Production> productions;

        #endregion

        #region Constructeurs

        public FormToutEmbalV3()
        {
            InitializeComponent();

            productions = new List<Production>();
            productions.Add(new Production("A", 10000, 1000));
            productions.Add(new Production("B", 25000, 5000));
            productions.Add(new Production("C", 120000, 10000));
            productions.Add(new Production("D", 85000, 10000));
            productions.Add(new Production("E", 700, 2000));
            productions.Add(new Production("F", 800, 3000));
            productions.Add(new Production("G", 500, 4000));
            productions.Add(new Production("H", 200, 7000));
            productions.Add(new Production("I", 300, 3000));

            foreach (Production prod in productions)
            {
                this.AjouterProd(prod);
            }

            timerHeure.Start();
            toolStripStatusLabelHeure.Text = DateTime.Now.ToString("t");
            miseAjourIHM = new DelegateMiseAJourIHM(MiseAjourIHM);

            for (int i = 0; i < productions.Count; i++)
            {
                this.MiseAjourIHM(productions[i], productions[i].StatutDeLaProduction);
            }

        }
        #endregion

        #region Ajout production
        /// <summary>
        /// Ajoute une production à la collection de productions
        /// </summary>
        /// <param name="prod"></param>
        private void AjouterProd(Production prod)
        {
            prod.ChangementStatutProduction += Prod_ChangementStatutProduction;
            prod.ChangementNbCaisses += Prod_ChangementNbCaisses;
            ucProgressBar progressBar = new ucProgressBar(prod.Nom);
            this.flowLayoutPanelProgressBar.Controls.Add(progressBar);

            progressBar.Name = prod.Nom;
            this.AjouterTabPage(prod);
            this.AjouterEtat(prod);

            ucBoutons ucActions = new ucBoutons(prod.Nom);
            this.flowLayoutPanelBoutonsActions.Controls.Add(ucActions);
            Button boutonDemarrer = this.Controls.Find("buttonDemarrer" + prod.Nom, true).First() as Button;
            Button boutonPause = this.Controls.Find("buttonPause" + prod.Nom, true).First() as Button;
            Button boutonContinuer = this.Controls.Find("buttonContinuer" + prod.Nom, true).First() as Button;
            boutonDemarrer.Click += delegate (object sender, EventArgs e) { BoutonDemarrer_Click(sender, e, prod); };
            boutonPause.Click += delegate (object sender, EventArgs e) { BoutonPause_Click(sender, e, prod); };
            boutonContinuer.Click += delegate (object sender, EventArgs e) { BoutonContinuer_Click(sender, e, prod); };


            this.AjouterToolStripMenuItemDemarrer(prod);
            this.AjouterToolStripMenuItemSuspendre(prod);
            this.AjouterToolStripMenuItemContinuer(prod);
        }
        #endregion

        #region Ajouter controls
        private void AjouterTabPage(Production prod)
        {
            ucTabPageToutEmbal tab = new ucTabPageToutEmbal(prod.Nom);

            ucTabContenuToutEmbal contenuTab = new ucTabContenuToutEmbal(prod.Nom);
            contenuTab.Dock = DockStyle.Fill;
            contenuTab.BringToFront();
            contenuTab.Name = "tabPage" + prod.Nom;
            tab.Controls.Add(contenuTab);
            tabControlOngletsType.Controls.Add(tab);

        }

        private void AjouterEtat(Production prod)
        {
            ucEtatProd ucetat = new ucEtatProd(prod.Nom);
            this.flowLayoutPanelEtat.Controls.Add(ucetat);
        }

        private void AjouterToolStripMenuItemDemarrer(Production prod)
        {
            ToolStripMenuItem menuDemarrer = new ToolStripMenuItem();
            menuDemarrer.Name = prod.Nom + "ToolStripMenuItem";
            menuDemarrer.Text = prod.Nom;
            menuDemarrer.Click += delegate (object sender, EventArgs e) { MenuDemarrer_Click(sender, e, prod); };

            démarrerToolStripMenuItem.DropDownItems.Add(menuDemarrer);

        }
        private void AjouterToolStripMenuItemSuspendre(Production prod)
        {
            ToolStripMenuItem menuSuspendre = new ToolStripMenuItem();
            menuSuspendre.Name = prod.Nom + "ToolStripMenuItem";
            menuSuspendre.Text = prod.Nom;
            suspendreToolStripMenuItem.DropDownItems.Add(menuSuspendre);
            menuSuspendre.Click += delegate (object sender, EventArgs e) { MenuSuspendre_Click(sender, e, prod); };

        }
        private void AjouterToolStripMenuItemContinuer(Production prod)
        {
            ToolStripMenuItem menuContinuer = new ToolStripMenuItem();
            menuContinuer.Name = prod.Nom + "ToolStripMenuItem";
            menuContinuer.Text = prod.Nom;
            continuerToolStripMenuItem.DropDownItems.Add(menuContinuer);
            menuContinuer.Click += delegate (object sender, EventArgs e) { MenuContinuer_Click(sender, e, prod); };
        }
        #endregion

        #region Actions Demarrer / Pause / Continuer
        private void ActionDemarrer(Production prod)
        {
            this.Demarrer(prod);
            TabPage tabPage = this.Controls.Find("tabPage" + prod.Nom, true).First() as TabPage;
            this.tabControlOngletsType.SelectedTab = tabPage;
            ProgressBar progressbar = this.Controls.Find("progressBar" + prod.Nom, true).First() as ProgressBar;
            progressbar.Focus();
        }
        private void ActionPause(Production prod)
        {
            this.Suspendre(prod);
            TabPage tabPage = this.Controls.Find("tabPage" + prod.Nom, true).First() as TabPage;
            this.tabControlOngletsType.SelectedTab = tabPage;
            ProgressBar progressbar = this.Controls.Find("progressBar" + prod.Nom, true).First() as ProgressBar;
            progressbar.Focus();
        }
        private void ActionContinuer(Production prod)
        {
            this.Continuer(prod);
            TabPage tabPage = this.Controls.Find("tabPage" + prod.Nom, true).First() as TabPage;
            this.tabControlOngletsType.SelectedTab = tabPage;
            ProgressBar progressbar = this.Controls.Find("progressBar" + prod.Nom, true).First() as ProgressBar;
            progressbar.Focus();
        }
        #endregion

        #region event click actions
        private void MenuDemarrer_Click(object sender, EventArgs e, Production prod)
        {
            ActionDemarrer(prod);
        }
        private void MenuSuspendre_Click(object sender, EventArgs e, Production prod)
        {
            ActionPause(prod);
        }

        private void MenuContinuer_Click(object sender, EventArgs e, Production prod)
        {
            ActionContinuer(prod);
        }

        private void BoutonDemarrer_Click(object sender, EventArgs e, Production prod)
        {
            ActionDemarrer(prod);
        }

        private void BoutonPause_Click(object sender, EventArgs e, Production prod)
        {
            ActionPause(prod);

        }
        private void BoutonContinuer_Click(object sender, EventArgs e, Production prod)
        {
            ActionContinuer(prod);

        }
        #endregion

        #region Event changement nombre de caisses
        private void Prod_ChangementNbCaisses(Production prodSender, StatutProduction prodStatut)
        {
            this.Invoke(this.miseAjourIHM, new Object[] { prodSender, prodStatut });
        }
        #endregion

        #region Event changement statut de la production

        private void Prod_ChangementStatutProduction(Production prodSender, StatutProduction prodStatut)
        {
            this.NotificationProductionTerminee(prodSender, prodStatut);
            this.Invoke(this.miseAjourIHM, new Object[] { prodSender, prodStatut });
        }

        public void NotificationProductionTerminee(Production prodSender, StatutProduction prodStatut)
        {

            if (prodStatut == StatutProduction.Terminé)
            {
                this.Invoke(this.miseAjourIHM, new Object[] { prodSender, prodStatut });
                MessageBox.Show("Production " + prodSender.Nom + " terminée !");
            }
        }
        #endregion

        #region Mise a jour de l'IHM
        private void MiseAjourIHM(Production prodSender, StatutProduction prodStatut)
        {
            ProgressBar progressbar = this.Controls.Find("progressBar" + prodSender.Nom, true).First() as ProgressBar;
            progressbar.Value = prodSender.CalculAvancementEnPourcentage();

            TextBox textBoxNbCaisseDepuisDemarrage = this.Controls.Find("textBoxNbCaisseDepuisDemarrage" + prodSender.Nom, true).First() as TextBox;
            textBoxNbCaisseDepuisDemarrage.Text = prodSender.NbCaissesDepuisDemarrageTotal.ToString();

            TextBox textBoxTauxDefautHeure = this.Controls.Find("textBoxTauxDefautHeure" + prodSender.Nom, true).First() as TextBox;
            textBoxTauxDefautHeure.Text = prodSender.CalculTauxDefautHeure().ToString();

            TextBox textBoxTauxDefautDepuisDemarrage = this.Controls.Find("textBoxTauxDefautDepuisDemarrage" + prodSender.Nom, true).First() as TextBox;
            textBoxTauxDefautDepuisDemarrage.Text = prodSender.CalculTauxDefautHeure().ToString();

            TextBox textBoxEtatProduction = this.flowLayoutPanelEtat.Controls.Find("textBoxEtat" + prodSender.Nom, true).First() as TextBox;
            textBoxEtatProduction.Text = prodSender.StatutDeLaProduction.ToString();

            Button boutonDemarrer = this.Controls.Find("buttonDemarrer" + prodSender.Nom, true).First() as Button;
            Button boutonPause = this.Controls.Find("buttonPause" + prodSender.Nom, true).First() as Button;
            Button boutonContinuer = this.Controls.Find("buttonContinuer" + prodSender.Nom, true).First() as Button;

            boutonDemarrer.Enabled = this.DemarragePossible(prodSender);
            boutonPause.Enabled = this.PausePossible(prodSender);
            boutonContinuer.Enabled = this.ReprisePossible(prodSender);

            ToolStripMenuItem menuDemarrer = this.démarrerToolStripMenuItem.DropDownItems.Find(prodSender.Nom + "ToolStripMenuItem", true).First() as ToolStripMenuItem;
            ToolStripMenuItem menuPause = this.suspendreToolStripMenuItem.DropDownItems.Find(prodSender.Nom + "ToolStripMenuItem", true).First() as ToolStripMenuItem;
            ToolStripMenuItem menuContinuer = this.continuerToolStripMenuItem.DropDownItems.Find(prodSender.Nom + "ToolStripMenuItem", true).First() as ToolStripMenuItem;
            menuDemarrer.Enabled = this.DemarragePossible(prodSender);
            menuPause.Enabled = this.PausePossible(prodSender);
            menuContinuer.Enabled = this.ReprisePossible(prodSender);

        }
        #endregion

        #region Actions possibles
        private bool DemarragePossible(Production prod)
        {
            if (prod.StatutDeLaProduction == StatutProduction.NonDemarré
                   )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool PausePossible(Production prod)
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
                prod.DemarrerProduction();
            }
        }

        #endregion

        #region Arreter
        private void Suspendre(Production prod)
        {
            if (PausePossible(prod))
            {
                prod.SuspendreProduction();
            }

        }
        #endregion

        #region Continuer
        private void Continuer(Production prod)
        {
            if (ReprisePossible(prod))
            {
                prod.ContinuerProduction();
            }

        }
        #endregion

        #region Timer Heure
        private void timerHeure_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHeure.Text = DateTime.Now.ToString("t");
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

        #region event ajouter production
        private void ajouterUneProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterProductionToutEmbal ajouterProd = new FormAjouterProductionToutEmbal();
            ajouterProd.AjouterProduction += AjouterProd_AjouterProduction;
            ajouterProd.ShowDialog();
        }
        private void AjouterProd_AjouterProduction(string nom, int nbAProduire, int nbAProdParHeure, Form formSender)
        {
            bool ajoutPossible = true;
            foreach (Production production in productions)
            {
                if (string.Equals(production.Nom, nom, StringComparison.OrdinalIgnoreCase))

                {
                    MessageBox.Show("Ajout impossible : une production existante porte déjà ce nom");

                    ajoutPossible = false;
                }
            }

            if (ajoutPossible)
            {
                formSender.Close();
                MessageBox.Show("Production " + nom + " ajoutée avec succès");

                Production prod = new Production(nom, nbAProduire, nbAProdParHeure);
                productions.Add(prod);
                this.AjouterProd(prod);

                this.Invoke(this.miseAjourIHM, new Object[] { prod, prod.StatutDeLaProduction });

            }
        }
        #endregion

    }
}
