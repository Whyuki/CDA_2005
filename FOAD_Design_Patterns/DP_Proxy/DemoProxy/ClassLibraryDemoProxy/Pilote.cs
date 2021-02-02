using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDemoProxyEspace

{
    public class Pilote
    {
        private string nom;

        public Pilote(string nom)
        {
            this.nom = nom;
        }
        public string Nom { get => nom; set => nom = value; }

    }
}
