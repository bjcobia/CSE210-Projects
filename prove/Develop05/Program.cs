using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        GoalList goalList = new GoalList();
        int totalPoints = 0;

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("Goal Tracking Menu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Remove Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Goals");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter your choice:");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddGoal(goalList);
                    break;
                case 2:
                    RemoveGoal(goalList);
                    break;
                case 3:
                    totalPoints = RecordEvent(goalList, totalPoints);
                    break;
                case 4:
                    DisplayGoals(goalList, totalPoints);
                    break;
                case 5:
                    SaveGoals(goalList);
                    break;
                case 6:
                    LoadGoals(goalList);
                    break;
                case 7:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                    break;
            }
        }
    }

    static void AddGoal(GoalList goalList)
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points for this goal:");
        int points;
        if (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid points. Please enter a valid integer.");
            return;
        }

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Check List Goal");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
            return;
        }

        Goal goal;
        switch (choice)
        {
            case 1:
                goal = CreateSimpleGoal(name, description, points);
                break;
            case 2:
                goal = CreateEternalGoal(name, description, points);
                break;
            case 3:
                goal = CreateCheckListGoal(name, description, points);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }
        goalList.AddGoal(goal);
        Console.WriteLine("Goal added successfully.");
    }

    static SimpleGoal CreateSimpleGoal(string name, string description, int points)
    {
        return new SimpleGoal(name, description, points);
    }

    static EternalGoal CreateEternalGoal(string name, string description, int points)
    {
        return new EternalGoal(name, description, points);
    }

    static CheckListGoal CreateCheckListGoal(string name, string description, int points)
    {
        Console.WriteLine("Enter required occurrences:");
        int requiredOccurrences;
        if (!int.TryParse(Console.ReadLine(), out requiredOccurrences))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return null;
        }
        Console.WriteLine("Enter bonus points:");
        int bonusPoints;
        if (!int.TryParse(Console.ReadLine(), out bonusPoints))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return null;
        }
        return new CheckListGoal(name, description, points, requiredOccurrences, bonusPoints);
    }

    static void RemoveGoal(GoalList goalList)
    {
        Console.WriteLine("Enter the name of the goal to remove:");
        string name = Console.ReadLine();

        Goal goalToRemove = goalList.GetGoalByName(name);
        if (goalToRemove == null)
        {
            Console.WriteLine("Goal not found.");
            return;
        }
        Console.WriteLine("Enter the file name to save the updated goals: ");
        string fileName = Console.ReadLine();

        goalList.RemoveGoal(goalToRemove, fileName);
        Console.WriteLine("Goal removed successfully.");
    }

    static int RecordEvent(GoalList goalList, int totalPoints)
    {
        Console.WriteLine("Enter the name of the goal to record an event for:");
        string name = Console.ReadLine();

        Goal goal = goalList.GetGoalByName(name);
        if (goal == null)
        {
            Console.WriteLine("Goal not found.");
            return totalPoints = 0;
        }

        int pointsEarned = goal.RecordEvent();
        totalPoints += pointsEarned;
        Console.WriteLine($"Event recorded. Points earned: {pointsEarned}");
        return totalPoints;
    }

        static void DisplayGoals(GoalList goalList, int totalPoints)
    {
        goalList.DisplayGoals(goalList, totalPoints);
    }

    static void SaveGoals(GoalList goalList)
    {
        Console.WriteLine("Enter file name to save goals:");
        string fileName = Console.ReadLine();

        goalList.SaveGoals(fileName);
    }

    static void LoadGoals(GoalList goalList)
    {
        Console.WriteLine("Enter file name to load goals:");
        string fileName = Console.ReadLine();

        goalList.LoadGoals(fileName);
    }
}