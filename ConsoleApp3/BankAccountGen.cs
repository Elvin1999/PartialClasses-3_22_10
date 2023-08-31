using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public partial class BankAccount
    {
        public BankAccount(int id, string? accountName)
        {
            Id = id;
            AccountName = accountName;
        }

        public BankAccount()
        {
            Console.WriteLine($"Id : {Id} - Your account {AccountName} opened");
        }

        public void Start()
        {
            Console.WriteLine("Started Program");
            Console.WriteLine($"Id : {Id} - Your account {AccountName} opened");
        }

        partial void ShowAccount()
        {
            Console.WriteLine(Id);
            Console.WriteLine(AccountName);
        }

        public void ShowAccountCall()
        {
            ShowAccount();
        }

        partial void UpdateAccount()
        {
            Console.WriteLine("Some update happened");
        }

        public void UpdateAccountCall()
        {
            UpdateAccount();
        }

    }
}
