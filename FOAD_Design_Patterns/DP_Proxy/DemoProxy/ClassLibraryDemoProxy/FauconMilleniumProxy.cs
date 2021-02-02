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
        private FauconMillenium reelFauconMillenium;

        public FauconMilleniumProxy(Pilote pilote)
        {
            this.pilote = pilote;
            this.reelFauconMillenium = new FauconMillenium();
        }

        public void Decoller()
        {
            if (this.VerificationAcces())
            {
                Console.WriteLine($"Bienvenue, {pilote.Nom}.");
                reelFauconMillenium.Decoller();
            }
            else
            {
                Console.WriteLine($"Désolé {pilote.Nom}, seul Han Solo peut piloter le Faucon Millenium !");
            }

        }

        public bool VerificationAcces()
        {
            return pilote.Nom.Equals("Han Solo");
        }
    }
}
