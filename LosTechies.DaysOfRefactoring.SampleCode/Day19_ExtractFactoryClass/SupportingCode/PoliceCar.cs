namespace LosTechies.DaysOfRefactoring.SampleCode.Day19_EncapsulateCollection.SupportingCode
{
    public class PoliceCar
    {
        public bool ServiceRequired { get; set; }
        public int Mileage { get; set; }
        public bool ReadyForService { get; internal set; }
    }
}
