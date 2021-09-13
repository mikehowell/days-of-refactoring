namespace LosTechies.DaysOfRefactoring.Rename.Before
{
	public class Person
	{
		public string FN { get; set; }

        // code to calculate hourly payrate
		public decimal ClcHrlyPR() => FN == "Bob" ? 50m : 10m;
    }
}
