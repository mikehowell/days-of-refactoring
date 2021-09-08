namespace LosTechies.DaysOfRefactoring.SampleCode.Day18_ReplaceException.SupportingCode
{
    internal interface IMicrowaveMotor
    {
        bool IsInUse { get; set; }
        void Cook(object food);
    }
}
