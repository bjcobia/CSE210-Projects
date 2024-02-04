using System;
using System.IO;
using System.Security.Cryptography;


public class Journal{

    public List<Entry> _entries = new List<Entry>();

    public void AddingAnEntry(Entry entry){
        _entries.Add(entry);
    }

    public void DisplayAllEntries(){
        foreach (var entry in _entries){
            Console.WriteLine(entry);
        }
    }

    public void SavingToAFile(string filename)
    {
        filename = $"{filename}.csv";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            }
        }
    }

    public void LoadingFromFile(string filename){
        _entries.Clear();
        filename = $"{filename}.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach(string line in lines){
            string[] parts = line.Split(",");
            _entries.Add(new Entry(parts[1].Trim(), parts[2].Trim(), parts[0].Trim()));
        }
    }

    public void DeleteFile(string filename){
        filename = $"{filename}.csv";
        Console.WriteLine($"Are you sure you want to delete {filename} [y/n]?");
        string userChoice = Console.ReadLine();
        userChoice = userChoice.ToUpper();
        if (userChoice == "Y"){
        try{
            File.Delete(filename);
            Console.WriteLine($"{filename} has been deleted!");
            return;
        }
        catch (Exception er){
            Console.WriteLine($"Error deleting file: {er.Message}");
        }
        }
        else{
            return;
        }
    }

    public void StartNewFile(){
        Console.WriteLine($"Are you sure you want to start a new file you won't be able to go back to this file [y/n]?");
        string userChoice = Console.ReadLine();
        userChoice = userChoice.ToUpper();
        if (userChoice == "Y"){
        _entries.Clear();
        Console.WriteLine("Feel free to start a new file by selecting option 1.");
        }
        else{
            return;
        }
    }
}