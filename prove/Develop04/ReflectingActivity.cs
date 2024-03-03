using System;
using System.Threading;

public class ReflectingActivity : Activity
{
    private Random _random;
    private string[] _prompts;
    private string[] _questions;

    public int GenerateRandomNumber(int min, int max)
    {
        return _random.Next(min, max);
    }

    public string SelectRandomPrompt()
    {
        int number = GenerateRandomNumber(0, _prompts.Length);
        return _prompts[number];
    }
    public string SelectRandomQuestion()
    {
        int number = GenerateRandomNumber(0, _questions.Length);
        return _questions[number];
    }

    public void RunActivity()
    {
        PausingWhileShowingSpinner();
        DisplayingStartMessage();

        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(GetDuration());
        DateTime endTime = startTime + duration;

        while (DateTime.Now < endTime)
        {
            string prompt = SelectRandomPrompt();
            Console.WriteLine($"{prompt}");
            Thread.Sleep(6000);

            string question = SelectRandomQuestion();
            Console.WriteLine($"{question}");
            Thread.Sleep(6000);
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue when ready.");
            Console.ReadLine();
        }
        DisplayingEndMessage();
    }

    public ReflectingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        _random = new Random();
        _prompts = new string[]{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you learned something new.",
            "Think of a time when you changed something.",
            "Think of a time when you were happy."
        };
        _questions = new string[]{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "Who made this experience meaningful to you?",
            "Was this a good or a bad experience? What made it good or bad?"
        };
    }



}