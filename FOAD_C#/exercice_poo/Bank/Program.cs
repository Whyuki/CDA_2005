using Bank_ex.Models;
using System;

namespace Bank_ex
{
    /// <summary>
    /// Main
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount();
            BankAccount a1 = new BankAccount(1234, "toto", 1000, -500);

            Console.WriteLine(a.ToString());
            Console.WriteLine(a1.ToString());

            BankAccount b = new BankAccount(545454, "Laurent", 2000, 500);
            b.Credit(100);
            Console.WriteLine(b);
            bool ok = b.Debit(10000);
            Console.WriteLine(b.ToString());
            if (ok)
            {
                Console.WriteLine("Succes");
            }
            else
            {
                Console.WriteLine("Fail");
            }


            BankAccount c1 = new BankAccount(12345, "toto", 1000, -500);
            BankAccount c2 = new BankAccount(45657, "titi", 2000, -1000);
            c1.Transfer(3300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            c1.Transfer(1300, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());

            if (c1.Higher(c2))
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");

            }

            Bank bk = new Bank("Credit Mututu", "Mulhouse");
            
            bk.AddAccount(1245, "robert", 2000, 300);
            bk.AddAccount(2568, "denis", 1000, 300);
            
            Console.WriteLine(bk.BankAccounts[0].ToString());
            Console.WriteLine(bk.BankAccounts[1].ToString());
            if (bk.Transfer(1245, 2568, 1000))
            {
                Console.WriteLine("Succes");

            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.WriteLine(bk.BankAccounts[0].ToString());
            Console.WriteLine(bk.BankAccounts[1].ToString());
            bool result = bk.Transfer(1245, 2568, 5000);
            Console.WriteLine(result);
            Console.WriteLine(bk.BankAccounts[0].ToString());
            Console.WriteLine(bk.BankAccounts[1].ToString());

            Console.WriteLine(bk.ToString(1245));

            bk.Display(bk.BankAccounts);

            Console.WriteLine("Highest : "+bk.Highest());

            Console.WriteLine(bk.SearchAccount(1245));
        }
    }
}
