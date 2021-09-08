namespace LosTechies.DaysOfRefactoring.SampleCode.Day24_ArrowheadAntipattern.SupportingCode
{
    public interface ISecurityChecker
    {
        bool CheckPermission(User user, Permission permission);
    }
}
