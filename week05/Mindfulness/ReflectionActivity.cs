using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something truly selfless.",
        "Recall a moment when you stood up for someone.",
        "Think of a time when you overcame a big challenge.",
        "Remember a time when you helped someone in need."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "What could you learn from this experience?"
    };

    public ReflectionActivity()
    {
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        SetStartingMessage("Reflection Activity");
        SetEndingMessage("You have completed the Reflection Activity. Good job!");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        DisplayDescription();
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);

        string prompt = SelectRandomPrompt();
        Console.WriteLine($"\nConsider the following prompt:\n>> {prompt}");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowCountDown(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string question = SelectRandomQuestion();
            Console.Write($"> {question} ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    private string SelectRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private string SelectRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
}