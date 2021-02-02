using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDemoProxyEspace

{
    public class FauconMillenium : IVaisseauSpatial
    {
        public void Decoller()
        {
            Console.WriteLine("   +        .            .                     .\n"
                + "  .                                       +         .         \n"
                + "    Le Faucon Millenium décolle.... fiiiiouuuuu !!\n"
                + "     .         .         .       .                                     .");
        }


    }
}
