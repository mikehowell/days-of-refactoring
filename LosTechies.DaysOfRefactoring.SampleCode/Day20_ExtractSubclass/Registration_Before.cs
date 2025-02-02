﻿using System;
using LosTechies.DaysOfRefactoring.SampleCode.Day20_ExtractSubclass.SupportingCode;

namespace LosTechies.DaysOfRefactoring.SampleCode.ExtractSubclass.Before
{
	public class Registration
	{
		public NonRegistrationAction Action { get; set; }
		public decimal RegistrationTotal { get; set; }
		public string Notes { get; set; }
		public string Description { get; set; }
		public DateTime RegistrationDate { get; set; }
	}
}
