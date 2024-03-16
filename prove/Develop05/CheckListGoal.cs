public class CheckListGoal : Goal
{
    private int _requiredOccurrences;
    private int _currentOccurrences;
    private int _bonusPoints;

    public CheckListGoal(string goalName, string description, int points, int requiredOccurrences, int bonusPoints) : base(goalName, description, points)
    {
        _requiredOccurrences = requiredOccurrences;
        _bonusPoints = bonusPoints;
    }

    public int GetRequiredOccurrences()
    {
        return _requiredOccurrences;
    }

    public void SetCurrentOccurrences(int currentOccurrences)
    {
        _currentOccurrences = currentOccurrences;
    }

    public int GetCurrentOccurrences()
    {
        return _currentOccurrences;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public override int RecordEvent()
    {
        _currentOccurrences++;
        if (_currentOccurrences >= _requiredOccurrences)
        {
            SetIsCompleted(true);
            return GetPoints() + _bonusPoints;
        }
        return GetPoints();
    }

    public override bool IsGoalComplete()
    {
        return GetIsCompleted();
    }
}