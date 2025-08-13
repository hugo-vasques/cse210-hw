using System;
using System.Collections.Generic;
using FitnessApp;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>()
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 12, 5), 45, 20.0),
            new Swimming(new DateTime(2022, 06, 3), 25, 30)
        };

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}