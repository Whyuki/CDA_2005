using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNonCls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class library written in C++/CLI.
            var myClass = new ThrowNonCLS.Class1();

            try
            {
                // throws gcnew System::String(  
                // "I do not derive from System.Exception!");  
                myClass.TestThrow();
            }
            catch (RuntimeWrappedException e)
            {
                String s = e.WrappedException as String;
                if (s != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
