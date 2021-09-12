using System;
using After = LosTechies.DaysOfRefactoring.MoveMethod.After;
using Before = LosTechies.DaysOfRefactoring.MoveMethod.Before;

namespace _02_MoveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount_Before();
            BankAccount_After();

            Console.ReadKey();
        }

        private static void BankAccount_Before()
        {
            var myBankAccountBefore = new Before.BankAccount(6, 500);
            var accountInterestBefore = new Before.AccountInterest(myBankAccountBefore);
            myBankAccountBefore.AccountInterest = accountInterestBefore.InterestRate;

            Console.WriteLine($"Account InterestRate for {myBankAccountBefore}: {myBankAccountBefore.AccountInterest}");
        }

        private static void BankAccount_After()
        {
            var myBankAccountAfter = new After.BankAccount(6, 500);
            var accountInterestAfter = new After.AccountInterest(myBankAccountAfter);
            myBankAccountAfter.AccountInterest = accountInterestAfter.InterestRate;

            Console.WriteLine($"Account InterestRate for {myBankAccountAfter}: {myBankAccountAfter.AccountInterest}");
        }
    }
}
