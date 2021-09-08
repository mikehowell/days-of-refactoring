using System.Collections.Generic;
using LosTechies.DaysOfRefactoring.SampleCode.Day23_ParameterObject.SupportingCode;

namespace LosTechies.DaysOfRefactoring.SampleCode.ParameterObject.Before
{
	public class Registration
	{
		public void Create(decimal amount, Student student, IEnumerable<Course> courses, decimal credits)
		{
			// do work
		}
	}
}
