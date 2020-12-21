using ClassLibraryDomainePersistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMetierFournisseur
{
    public class Fournisseur
    {
        #region Champs
        static IPersistanceFournisseur maPersistanceFournisseur;
        public static IPersistanceFournisseur MaPersistanceFournisseur { get => maPersistanceFournisseur; set => maPersistanceFournisseur = value; }

        int id;
        string nom;
        string adresse;
        string cp;
        string ville;
        string contact;
        byte satisfaction;

        #endregion

        #region Constructeurs
        public Fournisseur(int id, string nom, string adresse, string cp, string ville, string contact, byte satisfaction)
        {
            this.id = id;
            this.nom = nom;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.contact = contact;
            this.satisfaction = satisfaction;
        }

        public Fournisseur(string nom, string adresse, string cp, string ville, string contact, byte satisfaction)
        {
            this.id = -1;
            this.nom = nom;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.contact = contact;
            this.satisfaction = satisfaction;
        }

        public Fournisseur(sFournisseur sFournisseur) : this(sFournisseur.id, sFournisseur.nom, sFournisseur.adresse, sFournisseur.cp, sFournisseur.ville, sFournisseur.contact, sFournisseur.satisfaction)
        {
        }
        #endregion

        #region getters/setters
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Contact { get => contact; set => contact = value; }
        public byte Satisfaction { get => satisfaction; set => satisfaction = value; }
        #endregion

        public sFournisseur GetStruct()
        {
            sFournisseur structFournisseur = new sFournisseur(this.id, this.nom, this.adresse, this.cp, this.ville, this.contact, this.satisfaction);

            return structFournisseur;
        }

        public bool Save()
        {
            if (this.id == -1)
            {
                this.id = maPersistanceFournisseur.InsertFournisseur(this.GetStruct());
                return true;
            }
            else
            {
                return maPersistanceFournisseur.UpdateFournisseur(this.GetStruct());
            }
        }

        public bool Delete()
        {
            return maPersistanceFournisseur.DeleteFournisseur(this.GetStruct());
        }

        public static Fournisseur Load(int id)
        {
            sFournisseur structFournisseur = maPersistanceFournisseur.GetFournisseur(id);
            Fournisseur fournisseur = new Fournisseur(structFournisseur);
            return fournisseur;
        }

        public static Dictionary<int, string> LoadAll()
        {
            return maPersistanceFournisseur.GetListFournisseurs();
        }
    }
}
