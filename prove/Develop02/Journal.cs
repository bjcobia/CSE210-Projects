using System;
using System.IO;


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
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._response}");
            }
        }
    }

    public void LoadingFromFile(){
        string filename = "myFile.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach(string line in lines){
            string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}