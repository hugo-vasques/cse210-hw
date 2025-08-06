using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.", 
               "You did a great job with your breathing. Keep it up!") 
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);
            elapsed += 4;

            if (elapsed >= duration) break;

            Console.Write("Breathe out... ");
            ShowCountDown(6);
            elapsed += 6;
        }

        DisplayEndingMessage();
    }
}