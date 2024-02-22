using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Brady Sanders", "C#");
        MathAssignment mathAssignment = new MathAssignment("Johnathan Smith", "Math", "Section 7.3", "5-25");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "How to make better habits", "Atomic Habits");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}