using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "If you had the chance to repeat something that you made today, what could it be?",
        "Do you assist constantly to the church? And if not, what would be the reason?",
        "Wich kind of weather do you prefer?",
        "Who is the most interesting person that you met today?",
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}