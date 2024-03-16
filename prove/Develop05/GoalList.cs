public class GoalList
{
    private List<Goal> _goals;

    public GoalList()
    {
        _goals = new List<Goal>();
    }

    public void DisplayGoals(GoalList goalList, int totalPoints)
    {

        foreach (var goal in goalList._goals)
        {
            Console.WriteLine($"-{goal.GetName()} - {goal.GetDescription()} - Completed: {goal.GetIsCompleted()}");
        }

        Console.WriteLine($"Total points: {totalPoints}");
    }

    public void SaveGoals(string fileName)
{
    using (StreamWriter writer = new StreamWriter(fileName + ".txt"))
    {
        foreach (var goal in _goals)
        {
            string line;
            if (goal.GetType() == typeof(CheckListGoal))
            {
                CheckListGoal checkListGoal = (CheckListGoal)goal;
                line = $"CheckListGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetIsCompleted()}|{checkListGoal.GetRequiredOccurrences()}|{checkListGoal.GetCurrentOccurrences()}|{checkListGoal.GetBonusPoints()}";
            }
            else
            {
                line = $"{goal.GetType().Name}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetIsCompleted()}";
            }
            writer.WriteLine(line);
        }
        Console.WriteLine("Goals saved to file.");
    }
}

    public void LoadGoals(string fileName)
{
    try
    {
        using (StreamReader reader = new StreamReader(fileName + ".txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isCompleted = bool.Parse(parts[4]);
                int bonusPoints = 0;

                Goal goal;
                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(name, description, points);
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(name, description, points);
                        break;
                    case "CheckListGoal":
                        int requiredOccurrences = int.Parse(parts[5]);
                        int currentOccurrences = int.Parse(parts[6]);
                        bonusPoints = int.Parse(parts[7]);
                        goal = new CheckListGoal(name, description, points, requiredOccurrences, bonusPoints);
                        ((CheckListGoal)goal).SetCurrentOccurrences(currentOccurrences);
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type: {type}. Skipping.");
                        continue;
                }
                goal.SetIsCompleted(isCompleted);
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine($"File {fileName} not found.");
    }
    catch (IOException)
    {
        Console.WriteLine($"Error reading file {fileName}.");
    }
}

public void RemoveGoal(Goal goal, string fileName)
{
    _goals.Remove(goal);

    string oldFile = fileName + ".txt";
    if(File.Exists(oldFile))
    {
        File.Delete(oldFile);
    }
    SaveGoals(fileName);
}

public Goal GetGoalByName(string name)
{
    foreach (var goal in _goals)
        {
            if (goal.GetName() == name)
            {
                return goal;
            }
        }
        return null;
}

public void AddGoal(Goal goal)
{
    _goals.Add(goal);
}
}
