using System;
using LosTechies.DaysOfRefactoring.SampleCode.Day18_ReplaceException.SupportingCode;

namespace LosTechies.DaysOfRefactoring.ReplaceException.Before
{
	public class Microwave
	{
		private IMicrowaveMotor Motor { get; set;}

		public bool Start(object food)
		{
			bool foodCooked = false;
			try
			{
				Motor.Cook(food);
				foodCooked = true;
			}
			catch(InUseException)
			{
				foodCooked = false;
			}

			return foodCooked;
		}
	}

    public class InUseException : Exception
    {
    }
}
