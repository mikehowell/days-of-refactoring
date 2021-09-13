namespace LosTechies.DaysOfRefactoring.PushDownField.After
{
	public abstract class Task
	{
	}

	public class BugTask : Task
	{
        public string Resolution { get; set; }
    }

	public class FeatureTask : Task
	{
	}
}
