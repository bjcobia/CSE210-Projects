using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "1";
        
        Journal _journal = new Journal();
        PromptGenerator _promptGenerator = new PromptGenerator();

        while (userChoice != "5") {

        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write\n2. Display\n3. Save\n4. Load\n5. Delete Files\n6. Start New File\n7. Quit");

        userChoice = Console.ReadLine();
        Journal journal = new Journal();
            switch (userChoice)
            {
                case "1":
                    string _randomPrompt = _promptGenerator.DisplayPrompt();
                    Console.WriteLine(_randomPrompt);
                    Console.WriteLine("Response: ");
                    String _response = Console.ReadLine();
                    Entry _newEntry = new Entry(_randomPrompt, _response, DateTime.Now.ToString());
                    _journal.AddingAnEntry(_newEntry);
                    Console.WriteLine("Entry saved!\n");
                    break;
                case "2":
                    Console.WriteLine("Journal Entries\n");
                    _journal.DisplayAllEntries();
                    break;
                case "3":
                    Console.WriteLine("Enter filename: ");
                    string _saveFileName = Console.ReadLine();
                    _journal.SavingToAFile(_saveFileName);
                    Console.WriteLine("Journal saved!\n");
                    break;
                case "4":
                    Console.Write("Enter filename: ");
                    string _loadFileName = Console.ReadLine();
                    _journal.LoadingFromFile(_loadFileName);
                    _journal.DisplayAllEntries();
                    Console.WriteLine("Journal loaded!\n");
                    break;
                case "5":
                    Console.WriteLine("Enter filename: ");
                    string _deleteFileName = Console.ReadLine();
                    _journal.DeleteFile(_deleteFileName);
                    break;
                case "6":
                    _journal.StartNewFile();
                break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                    break;
            }
        }
    }
}