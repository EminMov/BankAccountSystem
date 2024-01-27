using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    internal class BankAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public string AccountOwner { get; set; }


        public BankAccount(string firstname, string lastname, decimal balance)
        {
            FirstName = firstname;
            LastName = lastname;
            Balance = balance;
            AccountOwner = $"{firstname} {lastname}";
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
