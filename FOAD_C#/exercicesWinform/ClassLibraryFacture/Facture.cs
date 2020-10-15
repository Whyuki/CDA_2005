using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFacture
{
    public class Facture
    {

        private string nom;
        private DateTime date;
        private float montant;
        private string codePostal;

        /// <summary>
        /// facture constructor inputs controlesSaisie
        /// </summary>
        /// <param name="_nom"></param>
        /// <param name="_date"></param>
        /// <param name="_montant"></param>
        /// <param name="_codePostal"></param>
        public Facture(string _nom, DateTime _date, float _montant, string _codePostal)
        {
            this.nom = _nom;
            this.date = _date;
            this.montant = _montant;
            this.codePostal = _codePostal;

        }
    }
}
