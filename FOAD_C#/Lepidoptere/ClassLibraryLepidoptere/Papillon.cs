using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Papillon : StadeDEvolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole");
            return true;
        }

        public override StadeDEvolution prochainStade()
        {
            return new Papillon();
        }
    }
}