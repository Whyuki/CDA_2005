using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_ex.Models
{
    /// <summary>
    /// Class Bank
    /// </summary>
    class Bank
    {
        private string name;

        private string city;

        private int nbAccounts;

        private List<BankAccount> bankAccounts;


        /// <summary>
        /// constructor
        /// </summary>
        public List<BankAccount> BankAccounts
        {
            get => bankAccounts;
        }


        /// <summary>
        /// constructor params
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_city"></param>
        public Bank(string _name, string _city)
        {
            name = _name;
            city = _city;
            bankAccounts = new List<BankAccount>();
        }

        /// <summary>
        /// add an account (account)
        /// </summary>
        /// <param name="account">BankAccount</param>
        public void AddAccount(BankAccount account)
        {
            bankAccounts.Add(account);
        }

        /// <summary>
        /// add an account (new account)
        /// </summary>
        /// <param name="_number">account number</param>
        /// <param name="_owner">account name owner</param>
        /// <param name="_balance">initial balance</param>
        /// <param name="_allowedOverdraft">amout of overdraft allowed</param>
        public void AddAccount(int _number, string _owner, float _balance, int _allowedOverdraft)
        {
            bankAccounts.Add(new BankAccount(_number, _owner, _balance, _allowedOverdraft));
        }

        /// <summary>
        /// toString
        /// </summary>
        /// <param name="numAccount"></param>
        /// <returns>String properties of account sought</returns>
        public string ToString(int numAccount)
        {
            BankAccount account = BankAccounts.Find(delegate (BankAccount account)
            {
                return account.Number == numAccount;

            });

            return account.ToString();
        }


        /// <summary>
        /// Transfert amount from accountFrom to accountTo
        /// </summary>
        /// <param name="numAccountFrom">account number of from </param>
        /// <param name="numAccountTo">account number of to</param>
        /// <param name="amount">amount to transfer</param>
        /// <returns>bool true if it succeeeds, false if it failed</returns>
        public bool Transfer(int numAccountFrom, int numAccountTo, float amount)
        {
            BankAccount from = BankAccounts.Find(delegate (BankAccount account)
            {
                return account.Number == numAccountFrom;

            });

            BankAccount to = BankAccounts.Find(delegate (BankAccount account)
            {
                return account.Number == numAccountTo;

            });


            if (from.Transfer(amount, to))
            {
                from.Transfer(amount, to);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// write all bank accounts
        /// </summary>
        /// <param name="list"></param>
        public void Display(List<BankAccount> list)
        {
            Console.WriteLine("List of accounts :");
            foreach (BankAccount item in list)
            {
                if (item == null)
                    Console.WriteLine("(null)");
                else
                    Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// comparation method for sort of method Highest
        /// </summary>
        /// <param name="account1"></param>
        /// <param name="account2"></param>
        /// <returns></returns>
        public static int CompareByBalance(BankAccount account1, BankAccount account2)
        {
            return account1.Balance.CompareTo(account2.Balance);
        }

        /// <summary>
        /// Sort bankAccounts by balance (ascending)
        /// </summary>
        /// <returns>the account with the highest balance of the list</returns>
        public BankAccount Highest()
        {
            nbAccounts = bankAccounts.Count;
            bankAccounts.Sort(CompareByBalance);
            return bankAccounts[nbAccounts - 1];
        }


        /// <summary>
        /// search an account with its number
        /// </summary>
        /// <param name="numAccount">number account </param>
        /// <returns>the account sought</returns>
        public BankAccount SearchAccount(int numAccount)
        {

            BankAccount account = BankAccounts.Find(delegate (BankAccount account)
            {
                return account.Number == numAccount;

            });

            return account;
        }

    }
}
