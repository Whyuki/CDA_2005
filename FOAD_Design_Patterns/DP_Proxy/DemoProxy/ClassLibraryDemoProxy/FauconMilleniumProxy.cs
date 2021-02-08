using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDemoProxyEspace

{
    public class FauconMilleniumProxy : IVaisseauSpatial
    {

        private Pilote pilote;
        private FauconMillenium fauconMillenium;

        public FauconMilleniumProxy(Pilote pilote)
        {
            this.pilote = pilote;
            this.fauconMillenium = new FauconMillenium();
        }

        private bool VerifierNomPilote()
        {
            return this.pilote.Nom.Equals("Han Solo");
        }

        public void Decoller()
        {
            if (this.VerifierNomPilote())
            {
                Console.WriteLine($"Bienvenue, {pilote.Nom}.");
                fauconMillenium.Decoller();
            }
            else
            {
                Console.WriteLine($"Désolé {pilote.Nom}, seul Han Solo peut faire décoller le Faucon Millenium !");
            }
        }
    }
}
