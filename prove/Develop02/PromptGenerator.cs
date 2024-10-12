using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // list of prompts
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced today and how you overcame it.",
        "What made you smile today?",
        "What did you learn today?"
    };

    // random prompts
    private Random _random = new Random();

    // Getting a Random prompt
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
