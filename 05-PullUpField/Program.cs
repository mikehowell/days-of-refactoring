using System;
using After = LosTechies.DaysOfRefactoring.PullUpField.After;
using Before = LosTechies.DaysOfRefactoring.PullUpField.Before;

namespace _05_PullUpField
{
    class Program
    {
        static void Main(string[] args)
        {
            // Both before and after code return the same results with the same code
            // refer to each classes for the refactoring.

            BankAccount_Before();
            BankAccount_After();

            Console.ReadKey();
        }

        private static void BankAccount_Before()
        {
            var checkAccount = new Before.CheckingAccount();
            Console.WriteLine($"Checking account minimum balance = {checkAccount.MinimumBalance}");

            var savingAccount = new Before.SavingsAccount();
            Console.WriteLine($"Savings account minimum balance = {savingAccount.MinimumBalance}");
        }

        private static void BankAccount_After()
        {
            var checkAccount = new After.CheckingAccount();
            Console.WriteLine($"Checking account minimum balance = {checkAccount.MinimumBalance}");

            var savingAccount = new After.SavingsAccount();
            Console.WriteLine($"Savings account minimum balance = {savingAccount.MinimumBalance}");
        }
    }
}
