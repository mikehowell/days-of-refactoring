namespace LosTechies.DaysOfRefactoring.Rename.After
{
	// Changed the class name to Employee
	public class Employee
	{
		public string FirstName { get; set; }

		public decimal CalculateHourlyPay() => FirstName == "Bob" ? 50m : 10m;
    }
}
