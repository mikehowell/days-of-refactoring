using System;

namespace LosTechies.DaysOfRefactoring.PullUpMethod.After
{
	public abstract class Vehicle
	{
		public void Turn(Direction direction)
		{
            switch (direction)
            {
                case Direction.Right:
                    Console.WriteLine($"{nameof(Vehicle)} - Turning Right");
                    break;
                case Direction.Left:
                    Console.WriteLine($"{nameof(Vehicle)} - Turning Left");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction,
                        $"The direction provided {direction} is not valid! Please choose Left or Right");
            }
		}
	}

	public class Car : Vehicle
	{
	}

	public class Motorcycle : Vehicle
	{
	}

	public enum Direction
	{
		Left,
		Right
	}
}
