using System.Reflection.Metadata.Ecma335;

public abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _points;
    private bool _isCompleted; 

    public Goal(string goalName, string description, int points)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public abstract int RecordEvent();

    public abstract bool IsGoalComplete();
}