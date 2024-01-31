using System;
using System.IO;

public class PromptGenerator{
        public List<string> _prompts = new List<string>{
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"
        };
    public string DisplayPrompt(){
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        return _prompts[number];
    }

}