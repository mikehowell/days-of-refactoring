namespace LosTechies.DaysOfRefactoring.MoveMethod.After
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
	}

    public class AccountInterest
    {
        public BankAccount Account { get; }

        public AccountInterest(BankAccount account)
        {
            Account = account;
        }

        public double InterestRate => CalculateInterestRate();

        public bool IntroductoryRate => CalculateInterestRate() < 0.05;

        // Refactor Step: This method has been moved from the Bank Account class
        // this class references so should own it.
        // This method can now be made private exposed via the InterestRate property above.
        private double CalculateInterestRate()
        {
            if (Account.CreditScore > 800)
                return 0.02;

            return Account.AccountAge > 10 ? 0.03 : 0.05;
        }
    }

}