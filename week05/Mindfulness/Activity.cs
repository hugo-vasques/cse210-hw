using System;
using System.Threading;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _description;
    private int _duration;

    public Activity(string startingMessage, string description, string endingMessage)
    {
        _startingMessage = startingMessage;
        _description = description;
        _endingMessage = endingMessage;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine(_startingMessage);
        Console.WriteLine(_description);
        Console.Write("\nEnter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed the {_duration} seconds of the activity.");
        Console.WriteLine(_endingMessage);
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}