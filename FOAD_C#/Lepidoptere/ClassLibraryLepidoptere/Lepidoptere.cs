using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        private StadeDEvolution monStadeCourant;
        private DateTime dateDeNaissance;

        public Lepidoptere(DateTime _dateDeNaissance)
        {
            monStadeCourant = new Oeuf();
            dateDeNaissance = _dateDeNaissance;
        }

        public StadeDEvolution MonStadeCourant { get => monStadeCourant; 
        //    set => monStadeCourant = value; 
        }
        public DateTime DateDeNaissance { get => dateDeNaissance;
            //set => dateDeNaissance = value;
        }

        public bool SeDeplacer()
        {
            return monStadeCourant.SeDeplacer();
            
        }

        public void SeMetamorphoser()
        {
            monStadeCourant = monStadeCourant.prochainStade();
            Console.WriteLine(monStadeCourant);
        }
    }
}
