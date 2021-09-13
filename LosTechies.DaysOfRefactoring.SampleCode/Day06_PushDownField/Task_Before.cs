namespace LosTechies.DaysOfRefactoring.PushDownField.Before
{
	public abstract class Task
	{
        public string Resolution { get; set; }
    }

	public class BugTask : Task
	{
	}

	public class FeatureTask : Task
	{
	}
}
