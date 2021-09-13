using System;

namespace LosTechies.DaysOfRefactoring.PullUpField.Before
{
    // Assuming that at least $5 is required to open an account
    // When we check the minimum balance after creating the account
    // the result should be 5.  This is returned for both checking and savings accounts
    // in this example both CheckingAccount and SavingsAccount classes have a Minimum Balance
    // this field can be pulled up into the abstract Account Class.

	public abstract class Account
	{
	}

	public class CheckingAccount : Account
	{
        public decimal MinimumBalance
        {
            get => 5m;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        public CheckingAccount()
        {
        }

        public CheckingAccount(decimal openingBalance)
        {
            MinimumBalance = openingBalance;
        }
    }

	public class SavingsAccount : Account
	{
        public decimal MinimumBalance
        {
            get => 5m;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        public SavingsAccount()
        {
        }

        public SavingsAccount(decimal openingBalance)
        {
            MinimumBalance = openingBalance;
        }
	}
}
