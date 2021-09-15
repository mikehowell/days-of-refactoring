namespace LosTechies.DaysOfRefactoring.ReplaceInheritance.Before
{
	public class CleaningRouting
	{
		public string WashHands()
		{
			return "Hands Washed!";
		}

        public string BrushTeeth()
        {
            return "Teeth Brushed!";
        }

        public string TakeABath()
        {
            return "Took a Bubble Bath";
        }
	}

	// Refactoring:
	// It doesn't make much that a Child IS A CleaningRouting
	// although it programatically achieves the result
	public class Child : CleaningRouting
	{
	}
}
