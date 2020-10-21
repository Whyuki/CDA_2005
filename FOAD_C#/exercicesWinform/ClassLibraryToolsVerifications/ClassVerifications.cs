using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryToolsVerifications
{
    public static class ClassVerifications
    {
        private const string regexNom = @"^[A-Za-z]+-?[A-Za-z]+$";
        private const string regexCp = @"^(?:[0-8]\d|9[0-8])\d{3}$";


        /// <summary>
        /// Indique si la date existe, oui : true / non : false
        /// </summary>
        /// <returns></returns>
        public static bool ValidDate(string _date)
        {
            return DateTime.TryParse(_date, out DateTime result);

        }
        /// <summary>
        /// Indique si le nom est valide : uniquement des lettres (possibilité de tiret pour noms composés)
        /// </summary>
        /// <param name="_nom"></param>
        /// <returns></returns>
        public static bool ValidNom(string _nom)
        {
            return Regex.IsMatch(_nom, regexNom) & _nom.Length >1;

        }
        /// <summary>
        /// check montant float
        /// </summary>
        /// <param name="_montant"></param>
        /// <returns></returns>
        public static bool ValidMontant(string _montant)
        {
                        
            if (float.TryParse(_montant, out float result))
            {
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        ///  check postal code
        /// </summary>
        /// <param name="_cp"></param>
        /// <returns></returns>
        public static bool ValidCP(string _cp)
        {
            return Regex.IsMatch(_cp, regexCp);

        }

    }

}