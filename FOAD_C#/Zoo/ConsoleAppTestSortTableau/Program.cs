using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestSortTableau
{
    class Program
    {
        static void Main(string[] args)
        {
           // String

            Personne georges = new Personne(55);
            Personne patrick = new Personne(40);
            int resu = georges.CompareTo(patrick);

            List<Personne> c = new List<Personne>();
            c.Add(new Personne(13));
            c.Add(new Personne(1));
            c.Add(new Personne(50));

            c.Sort();

            //try
            //{
            //    ArrayList aa = new ArrayList();
            //    aa.Add(new Personne(13));
            //    aa.Add(1);
            //    aa.Add(new Personne(50));

            //    aa.Sort();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    int resu2 = georges.CompareTo(1);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

        }
    }
}
