using System;
using System.Threading;

public class ReflectingActivity : Activity
{
    private Random _random;

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public int GenerateRandomNumber(int min, int max)
    {
        return _random.Next(min, max);
    }

    public void RunActivity()
    {
        DisplayingStartMessage();
        PausingWhileShowingSpinner();
        for(int i =0; i < GetDuration(); i++)
        {
            Console.WriteLine($"Reflecting on the {_prompts[GenerateRandomNumber(0, 3)]}");
            Thread.Sleep(3000);
            Console.WriteLine($"{_questions[GenerateRandomNumber(0, 8)]}");
            Thread.Sleep(3000);
        }
        DisplayingEndMessage();
    }

    public ReflectingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
    }



}