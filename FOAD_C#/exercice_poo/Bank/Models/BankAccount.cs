using System;

namespace Bank_ex.Models
{
    /// <summary>
    /// class BankAccount
    /// </summary>
    class BankAccount
    {
        private int number;

        private string owner;

        private float balance;

        private int allowedOverdraft;

        /// <summary>
        /// get/set number
        /// </summary>
        public int Number { get => number; set => number = value; }

        /// <summary>
        /// get/set balance
        /// </summary>
        public float Balance { get => balance; set => balance = value; }

        /// <summary>
        /// constructor
        /// </summary>
        public BankAccount()
        {
        }

        /// <summary>
        /// constructor params
        /// </summary>
        /// <param name="_number">account number</param>
        /// <param name="_owner">account name owner</param>
        /// <param name="_balance">initial balance</param>
        /// <param name="_allowedOverdraft">amount of overdraft allowed</param>
        public BankAccount(int _number, string _owner, float _balance, int _allowedOverdraft)
        {
            number = _number;
            owner = _owner;
            balance = _balance;
            allowedOverdraft = _allowedOverdraft;
        }

        /// <summary>
        /// toString
        /// </summary>
        /// <returns>String properties</returns>
        public override string ToString()
        {
            return "number : " + number + " name : " + owner + " balance : " + balance + " overdraft allowed : " + allowedOverdraft;
        }

        /// <summary>
        /// credit amount to this account
        /// </summary>
        /// <param name="amount">amount to credit</param>
        public void Credit(float amount)
        {
            balance = balance + amount;
        }

        /// <summary>
        /// debit amount to this account
        /// </summary>
        /// <param name="amount">amount to debit</param>
        /// <returns>bool : true if it succeeeds, false if it failed</returns>
        public bool Debit(float amount)
        {
            if ((balance - amount) < allowedOverdraft)
            {
                return false;
            }
            else
            {
                balance = balance - amount;
                return true;
            }
        }

        /// <summary>
        /// transfert amount to another account
        /// </summary>
        /// <param name="amount">amount to transfert</param>
        /// <param name="account">receiver account</param>
        /// <returns>bool : true if it succeeeds, false if it failed</returns>
        public bool Transfer(float amount, BankAccount account)
        {
            if ((balance - amount) < allowedOverdraft)
            {
                return false;
            }
            else
            {
                account.balance = account.balance + amount;
                balance = balance - amount;

                return true;
            }
        }

        /// <summary>
        /// compare balance between two accounts (this and an another one)
        /// ask if this account balance is higher than the another
        /// </summary>
        /// <param name="account">account to compare with</param>
        /// <returns>bool : true if this account is hight than the another, else : false </returns>
        public bool Higher(BankAccount account)
        {
            if (this.balance > account.balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}