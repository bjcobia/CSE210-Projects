using System;
using System.IO;
public class Entry{
    public string _prompt;
    public string _date;
    public string _response;

    public Entry(string prompt, string response, string date){
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public override string ToString(){
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }

}