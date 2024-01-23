using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int newNumber = -1;

        while (newNumber != 0){
            Console.Write("Enter Number (Enter 0 to quit): ");
            newNumber = int.Parse(Console.ReadLine());
            
            if (newNumber != 0){
            numbers.Add(newNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers){
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum)/ numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int Maximum = numbers[0];

        foreach(int number in numbers){
            if(number > Maximum){
                Maximum = number;
            }
        }
        Console.WriteLine($"The max is: {Maximum}");
    }
}