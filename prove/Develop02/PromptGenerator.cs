using System;
using System.IO;

public class PromptGenerator{
        public List<string> _prompts = new List<string>{
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the best food or worst I ate today?",
            "Was this a good or a bad day? Why?"
        };
    public string DisplayPrompt(){
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        return _prompts[number];
    }

}