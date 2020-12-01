using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibraryProduction
{
    public class Production
    {
        #region Champs
        public delegate void DelegateProduction(Production prodSender, StatutProduction prodStatut);
        public event DelegateProduction ChangementStatutProduction;
        public event DelegateProduction ChangementNbCaisses;

        string nom;
        DateTime dateTimeDemarrageProduction;
        StatutProduction statutDeLaProduction;
        int nbCaissesAProduire;
        int nbCaissesAProduireParHeure;
        int nbCaissesDepuisDemarrageTotal;
        int nbCaissesDepuisDemarrageAvecDefaut;
        #endregion

        #region Accesseurs
        public DateTime DateTimeDemarrageProduction
        {
            get => dateTimeDemarrageProduction; //set => dateTimeDemarrageProduction = value; 
        }
        public StatutProduction StatutDeLaProduction
        {
            get => statutDeLaProduction; //set => statutDeLaProduction = value; 
        }
        public int NbCaissesAProduire
        {
            get => nbCaissesAProduire; //set => nbCaissesAProduire = value; 
        }
        public int NbCaissesAProduireParHeure
        {
            get => nbCaissesAProduireParHeure; //set => nbCaissesAProduireParHeure = value; 
        }
        public int NbCaissesDepuisDemarrageTotal
        {
            get => nbCaissesDepuisDemarrageTotal; //set => nbCaissesDepuisDemarrageTotal = value; 
        }

        public int NbCaissesDepuisDemarrageAvecDefaut
        {
            get => nbCaissesDepuisDemarrageAvecDefaut; //set => nbCaissesDepuisDemarrageAvecDefaut = value; 
        }
        public string Nom
        {
            get => nom; //set => nom = value; 
        }
        #endregion

        #region Constructeur
        public Production(string _nom, int _nbCaissesAProduire, int _nbCaissesAProduireParHeure)
        {
            this.nom = _nom;
            this.nbCaissesAProduire = _nbCaissesAProduire;
            this.nbCaissesAProduireParHeure = _nbCaissesAProduireParHeure;
            this.statutDeLaProduction = StatutProduction.NonDemarré;
            this.Reinitialisation();

        }
        #endregion

        #region init/reinit champs
        public void Reinitialisation()
        {
            this.nbCaissesDepuisDemarrageTotal = 0;
            this.nbCaissesDepuisDemarrageAvecDefaut = 0;
            this.dateTimeDemarrageProduction = new DateTime();
        }
        #endregion

        #region Changement etat production
        public bool DemarrerProduction()
        {
            if (statutDeLaProduction == StatutProduction.NonDemarré
                || statutDeLaProduction == StatutProduction.Suspendu
                || statutDeLaProduction == StatutProduction.Terminé)
            {
                this.statutDeLaProduction = StatutProduction.Demarré;
                this.Reinitialisation();
                this.dateTimeDemarrageProduction = DateTime.Now;
                ChangementStatutProduction(this, this.statutDeLaProduction);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ArreterProduction()
        {
            if (statutDeLaProduction == StatutProduction.Demarré
                || statutDeLaProduction == StatutProduction.Redemarré)
            {
                this.statutDeLaProduction = StatutProduction.Suspendu;
                ChangementStatutProduction(this, this.statutDeLaProduction);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ContinuerProduction()
        {
            if (statutDeLaProduction == StatutProduction.Suspendu)
            {
                this.statutDeLaProduction = StatutProduction.Redemarré;
                ChangementStatutProduction(this, this.statutDeLaProduction);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Produire
        public void ProduireUneCaisse()
        {
            Random rdm = new Random();
            int random = rdm.Next(2);
            if (!this.IsTermine())
            {
                nbCaissesDepuisDemarrageTotal++;
                nbCaissesDepuisDemarrageAvecDefaut += random;
                ChangementNbCaisses(this, this.statutDeLaProduction);
            }
        }
        #endregion

        #region Production terminée
        public bool IsTermine()
        {
            if (this.nbCaissesDepuisDemarrageTotal == this.NbCaissesAProduire)
            {
                this.statutDeLaProduction = StatutProduction.Terminé;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Calculs taux defaut
        public double CalculTauxDefautHeure()
        {
            // methode a revoir
            TimeSpan tempsEcouleDepuisDemarrage = DateTime.Now - dateTimeDemarrageProduction;
            double nbHeuredepuisDemarrage = tempsEcouleDepuisDemarrage.TotalHours;
            if (nbCaissesDepuisDemarrageTotal > 0 && nbHeuredepuisDemarrage > 0)
            {
                return Math.Round(((double)nbCaissesDepuisDemarrageAvecDefaut / nbHeuredepuisDemarrage) / ((double)nbCaissesAProduireParHeure), 4);
            }
            else
            {
                return 0;
            }
        }
        public double CalculTauxDefautDepuisDemarrage()
        {
            if (nbCaissesDepuisDemarrageTotal > 0)
            {
                return Math.Round((double)nbCaissesDepuisDemarrageAvecDefaut / (double)nbCaissesDepuisDemarrageTotal, 4);
            }
            else
            {
                return 0;
            }
        }


        #endregion

        #region Calcul pourcentage d'avancement
        public int CalculAvancementEnPourcentage()
        {
            return Convert.ToInt32(((double)nbCaissesDepuisDemarrageTotal / (double)nbCaissesAProduire) * 100);
        }
        #endregion


    }
}
