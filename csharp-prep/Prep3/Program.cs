using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string Answer = Console.ReadLine();
        // int magicNumber = int.Parse(Answer);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int guess = 0;

        while (guess != magicNumber){
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber){
                Console.WriteLine("You guessed it! ");
            }
            else if (guess < magicNumber){
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber){
                Console.WriteLine("Lower");
            }
        }
        
    }
}