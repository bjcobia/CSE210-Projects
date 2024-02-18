using System;
using System.Formats.Asn1;
using System.Net.Quic;
using System.Runtime.CompilerServices;

public class Scripture{

private List<Word> _words = new List<Word>();
private Reference _reference;

public void HideWords()
{
    foreach(Word word in _words){
        word.Hide();
    }  
}

public void GetRenderedText()
{
    Console.WriteLine($"Reference: {_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetVerse()}");
    
    int hiddenCount = 0;
    while (hiddenCount < _words.Count){
        Console.WriteLine(GenerateRenderedText(hiddenCount));
        string answer = Console.ReadLine();
        if (answer == "Quit" || answer == "quit"){
            break;
        }
        else{
            answer = "";
        }
        Console.Clear();
        hiddenCount++;
    }
}

public string GenerateRenderedText(int hiddenCount)
{
    string renderedText = "";
    for(int i = 0; i < _words.Count; i++)
    {
        if (i < hiddenCount || _words[i].IsHidden())
        {
            renderedText += "___";
        }
        else
        {
            renderedText += _words[i].GetRenderedText();
        }

        if (i != _words.Count - 1)
        {
            renderedText += " ";
        }
    }
    return renderedText;
}

public bool IsCompletelyHidden()
{
    return _words.All(word => word.IsHidden());
}

public Scripture(Reference reference, string text)
{
    _reference = reference;
    _words = text.Split(' ').Select(word => new Word(word, false)).ToList();
}

}