namespace LosTechies.DaysOfRefactoring.MoveMethod.Before
{
	public class BankAccount
	{
		public BankAccount(int accountAge, int creditScore)
		{
			AccountAge = accountAge;
			CreditScore = creditScore;
		}

		public int AccountAge { get; }
		public int CreditScore { get; }
		public double AccountInterest { get; set; }

		// Refactor Step: This method is referenced in the AccountInterest class multiple times
		// let's move it there!
		public double CalculateInterestRate()
		{
			if (CreditScore > 800)
				return 0.02;

			return AccountAge > 10 ? 0.03 : 0.05;
        }
	}

	public class AccountInterest
	{
		public BankAccount Account { get; }

		public AccountInterest(BankAccount account)
		{
			Account = account;
		}

		public double InterestRate => Account.CalculateInterestRate();

        public bool IntroductoryRate => Account.CalculateInterestRate() < 0.05;
    }
}