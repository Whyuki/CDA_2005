using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomainePersistance
{
    public struct sFournisseur
    {
        public int id;
        public string nom;
        public string adresse;
        public string cp;
        public string ville;
        public string contact;
        public byte satisfaction;

        public sFournisseur(int id, string nom, string adresse, string cp, string ville, string contact, byte satisfaction)
        {
            this.id = id;
            this.nom = nom;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.contact = contact;
            this.satisfaction = satisfaction;
        }
    }
}
