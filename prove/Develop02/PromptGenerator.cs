using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>;
    {
        "What was the best part of your day?",
        "What are you gratefull for today?",
        "Describe a challenge you faced today and how you overcame it?",
        "What made you smile today",
        "What did you learn today"
    };

    // Gettin a Random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}