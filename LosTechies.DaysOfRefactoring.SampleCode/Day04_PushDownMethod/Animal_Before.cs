using System;

namespace LosTechies.DaysOfRefactoring.PushDownMethod.Before
{
	public abstract class Animal
	{
		public void Bark()
        {
            Console.WriteLine($"{GetType().Name} goes Woof, woof!");
        }
	}

	public class Dog : Animal
	{
	}

	public class Cat : Animal
	{
	}
}
