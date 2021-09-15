namespace LosTechies.DaysOfRefactoring.ReplaceInheritance.After
{
	public class CleaningRoutine
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

	public class Child
    {
        private readonly CleaningRoutine _cleaningRoutine;

        // Refactoring:
        // Here the CleaningRoutine is passed in to the Child constructor
        // The Child now HAS A CleaningRoutine
        // This takes more code to set up
        public Child(CleaningRoutine cleaningRoutine)
        {
            _cleaningRoutine = cleaningRoutine;
        }

		public string WashHands()
		{
			return _cleaningRoutine.WashHands();
		}
	}
}
