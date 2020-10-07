using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Chrysalide : StadeDEvolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je ne peux pas bouger");
            return false;
        }

        public override StadeDEvolution prochainStade()
        {
            return new Papillon();
        }
    }
}