using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGestionDeLException
{
    class Program
    {
        static void Main(string[] args)
        {


            System.IO.FileStream file = null;
            //Change the path to something that works on your machine.
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(@"C:\file.txt");

            /*try
            {
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }*/


            try
            {
                file = fileInfo.OpenWrite();
                System.Console.WriteLine("OpenWrite() succeeded");
            }
            catch (DirectoryNotFoundException d)
            {
                System.Console.WriteLine(d.Message);
            }
            catch (IOException)
            {
                System.Console.WriteLine("OpenWrite() failed");
            }
            catch (UnauthorizedAccessException u)
            {
                System.Console.WriteLine(u.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Un pb");
            }
            finally
            {
                // Closing the file allows you to reopen it immediately - otherwise IOException is thrown.
                if (file != null)
                {
                    file.Close();
                }
            }

        }
    }
}
