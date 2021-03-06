﻿using System;
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

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Emprunt() : this(0, 1, Periodicite.Mensuellement, 7, "")
        {
        }

        /// <summary>
        /// Constructeur par defaut et avec parametres
        /// </summary>
        /// <param name="_capitalEmprunte"></param>
        /// <param name="_dureeRemboursementEnMois"></param>
        /// <param name="_periodicite"></param>
        /// <param name="_tauxEnPourcentage"></param>
        /// <param name="_nomClientFacultatif"></param>
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

        /// <summary>
        /// Calcul le nombre de remboursmeent en fonciton de la durée et de la périodicité
        /// </summary>
        /// <returns></returns>
        public int CalculNombreDeRemboursement()
        {
            return this.dureeRemboursementEnMois / Convert.ToInt32(this.periodicite);
        }

        /// <summary>
        /// Calcul le montant de l'écheance
        /// </summary>
        /// <returns></returns>
        public double CalculMontantEcheance()
        {
            int nbRemboursement = this.CalculNombreDeRemboursement();
            double tauxApplique = this.tauxEnPourcentage / (12 / Convert.ToInt32(this.periodicite)) / 100;
            return this.capitalEmprunte * (tauxApplique / (1 - Math.Pow(1 + tauxApplique, -nbRemboursement)));

        }

    }
}
