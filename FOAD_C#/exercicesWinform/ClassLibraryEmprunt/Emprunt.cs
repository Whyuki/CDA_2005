using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryEmprunt
{
    public class Emprunt
    {
        private string nomClient;
        private float capitalEmprunte;
        private int dureeRemboursementEnMois;
        private Periodicite periodicite;
        private double tauxEnPourcentage;

        public Emprunt()
        {
            this.capitalEmprunte = 0;
            this.dureeRemboursementEnMois = 1;
            this.periodicite = Periodicite.Mensuellement;
            this.tauxEnPourcentage = 7;
            this.nomClient = "";
        }

        public Emprunt(float _capitalEmprunte, int _dureeRemboursementEnMois, Periodicite _periodicite, double _tauxEnPourcentage, string _nomClientFacultatif = "")
        {
            this.capitalEmprunte = _capitalEmprunte;
            this.dureeRemboursementEnMois = _dureeRemboursementEnMois;
            this.periodicite = _periodicite;
            this.tauxEnPourcentage = _tauxEnPourcentage;
            this.nomClient = _nomClientFacultatif;
        }

        public string NomClient { get => nomClient; set => nomClient = value; }
        public float CapitalEmprunte { get => capitalEmprunte; set => capitalEmprunte = value; }
        public int DureeRemboursementEnMois { get => dureeRemboursementEnMois; set => dureeRemboursementEnMois = value; }
        public Periodicite Periodicite { get => periodicite; set => periodicite = value; }
        public double TauxEnPourcentage { get => tauxEnPourcentage; set => tauxEnPourcentage = value; }


        public int CalculNombreDeRemboursement()
        {

            return this.dureeRemboursementEnMois / Convert.ToInt32(this.periodicite);

        }
        public double CalculMontantEcheance()
        {

            int nbRemboursement = this.CalculNombreDeRemboursement();
            double tauxApplique = this.tauxEnPourcentage / (12 / Convert.ToInt32(this.periodicite)) / 100;
            return this.capitalEmprunte * (tauxApplique / (1 - Math.Pow(1 + tauxApplique, -nbRemboursement)));

        }

    }
}
