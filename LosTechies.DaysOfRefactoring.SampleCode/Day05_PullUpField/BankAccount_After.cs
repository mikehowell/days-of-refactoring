using System;

namespace LosTechies.DaysOfRefactoring.PullUpField.After
{
    // Assuming that at least $5 is required to open an account
    // When we check the minimum balance after creating the account
    // the result should be 5.  This is returned for both checking and savings accounts
    // in this example only the abstract Account Class has a Minimum Balance.

    public abstract class Account
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

        protected Account()
        {
        }

        protected Account(decimal openingBalance)
        {
            MinimumBalance = openingBalance;
        }
	}

	public class CheckingAccount : Account
	{
	}

	public class SavingsAccount : Account
	{
	}
}
