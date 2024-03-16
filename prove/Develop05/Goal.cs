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

    public string GetName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool GetIsCompleted()
    {
        return _isCompleted;
    }

    public void SetIsCompleted(bool isCompleted)
    {
        _isCompleted = isCompleted;
    }

    public abstract int RecordEvent();

    public abstract bool IsGoalComplete();
}
