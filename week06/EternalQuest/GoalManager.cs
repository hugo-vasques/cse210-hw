using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuestProgram
{
    class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;
        private const string SAVE_FILE = "goals.txt";

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Eternal Quest ---");
                Console.WriteLine($"You have {_score} points\n");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("\nSelect one option from the menu: ");

                string opt = Console.ReadLine();
                Console.WriteLine();
                switch (opt)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoalDetails(); break;
                    case "3": SaveGoals(); break;
                    case "4": LoadGoals(); break;
                    case "5": RecordEvent(); break;
                    case "6": running = false; break;
                    default: Console.WriteLine("Invalid option"); break;
                }
            }
            Console.WriteLine("Exiting program...");
        }

        public void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string t = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine();

            int points = ReadInt("What is the amount of points associated with this goal? ");

            if (t == "1")
                _goals.Add(new SimpleGoal(name, desc, points));
            else if (t == "2")
                _goals.Add(new EternalGoal(name, desc, points));
            else if (t == "3")
            {
                int target = ReadInt("How many times does this goal need to be accomplished for a bonus? ");
                int bonus = ReadInt("What is the bonus for accomplishing it that many times? ");
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
            }
        }

        public void ListGoalDetails()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created.");
                return;
            }
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record.");
                return;
            }

            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
                Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");

            int choice = ReadInt($"Which goal did you accomplish? ", 1, _goals.Count);
            var goal = _goals[choice - 1];
            int earned = goal.RecordEvent();
            _score += earned;
            Console.WriteLine($"Congratulations! You have earned {earned} points!");
            Console.WriteLine($"You now have {_score} points.");
        }

        public void SaveGoals()
        {
            Console.Write("What is the name of this file goal?: ");
            string fileName = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("Invalid file name, using the default one: 'goals.txt'.");
                fileName = "goals";
            }

            string fullPath = fileName.EndsWith(".txt") ? fileName : fileName + ".txt";

            try
            {
                var lines = new List<string>();
                lines.Add(_score.ToString());
                foreach (var g in _goals)
                {
                    lines.Add(g.GetStringRepresentation());
                }

                File.WriteAllLines(fullPath, lines);
                Console.WriteLine("File saved succesfully :D");
            }
            catch
            {
                Console.WriteLine("Error while saving");
            }
        }

        public void LoadGoals()
        {
            Console.Write("Please enter the name of the file goal: ");
            string fileName = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(fileName))
            {
                Console.WriteLine("Invalid name");
                return;
            }

            string fullPath = fileName.EndsWith(".txt") ? fileName : fileName + ".txt";

            if (!File.Exists(fullPath))
            {
                Console.WriteLine($"The file '{fullPath}' doesn't exist");
                return;
            }

            try
            {
                var lines = File.ReadAllLines(fullPath);
                _goals.Clear();

                _score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    var goal = GoalFactory.CreateGoalFromString(lines[i]);
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }

                Console.WriteLine("File loaded succesfully :D");
            }
            catch
            {
                Console.WriteLine("An error ocurred while loading");
            }
        }

        private int ReadInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int val) && val >= min && val <= max)
                    return val;
                Console.WriteLine("Invalid number.");
            }
        }
    }
}