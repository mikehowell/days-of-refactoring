using System;

namespace LosTechies.DaysOfRefactoring.PushDownMethod.After
{
	public abstract class Animal
	{
	}

	public class Dog : Animal
	{
		public void Bark()
		{
            Console.WriteLine($"{GetType().Name} goes Woof, woof!");
        }
	}

	public class Cat : Animal
	{
	}
}
