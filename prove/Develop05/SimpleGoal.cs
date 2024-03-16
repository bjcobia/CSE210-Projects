public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        SetIsCompleted(true);
        return GetPoints();
    }

    public override bool IsGoalComplete()
    {
        return GetIsCompleted();
    }
}