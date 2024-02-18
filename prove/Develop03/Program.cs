using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi", 4, 34);
        
        Scripture scripture = new Scripture(reference, "O Lord, I have atrusted in thee, and I will btrust in thee forever. I will not put my ctrust in the arm of flesh; for I know that cursed is he that putteth his dtrust in the arm of flesh. Yea, cursed is he that putteth his trust in man or maketh flesh his arm.");

        scripture.GetRenderedText();

        Console.WriteLine("All words are hidden. Press enter to exit.");
        Console.ReadLine();

    }
}