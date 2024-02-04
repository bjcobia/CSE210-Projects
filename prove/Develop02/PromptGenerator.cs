using System;
using System.IO;

public class PromptGenerator{
        public List<string> _prompts = new List<string>{
            "Do This",
            "Do That",
            "Do Stuff",
            "Do Something",
            "Do Something Else",
            "Do Something Different"
        };
    public string DisplayPrompt(){
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        return _prompts[number];
    }

}