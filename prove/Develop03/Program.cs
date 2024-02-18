using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string[] scriptureTexts = {
            "And he shall be called Jesus Christ, the Son of God, the Father of heaven and earth, the Creator of all things from the beginning; and his fmother shall be called Mary.",
            "And by the power of the Holy Ghost ye may aknow the truth of all things.",
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        };

        Reference[] scriptureReferences = {
            new Reference("Mosiah", 3, 8),
            new Reference("Moroni", 10, 5),
            new Reference("1 Nephi", 3, 7)
        };


        Console.WriteLine("Choose a scripture (enter 1, 2, or 3):");
        for (int i = 0; i < scriptureTexts.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptureTexts[i]}");
        }


        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid input. Please enter 1, 2, or 3:");
        }


        Reference reference = new Reference("2 Nephi", 4, 34);

        Scripture scripture = new Scripture(reference, scriptureTexts[choice - 1]);
        
        scripture.GetRenderedText();

        Console.WriteLine("Press enter to exit.");
        Console.ReadLine();

    }
}