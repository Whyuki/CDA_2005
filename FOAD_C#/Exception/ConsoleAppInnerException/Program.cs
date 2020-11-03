using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInnerException
{
    //https://docs.microsoft.com/fr-fr/dotnet/standard/exceptions/best-practices-for-exceptions

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] mesEntiers = new int[] { 12, 58, 1023 };
                GetInt(mesEntiers, 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", ex.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", ex.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", ex.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", ex.TargetSite);
            }
        }

        static int GetInt(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException e)
            {
                throw new System.ArgumentOutOfRangeException("Parameter index is out of range.",
                    e);
            }
        }
    }
}
