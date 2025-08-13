using System;

namespace FitnessApp
{
    abstract class Activity
    {
        public DateTime Date { get; }
        public int Minutes { get; }

        public Activity(DateTime date, int minutes)
        {
            Date = date;
            Minutes = minutes;
        }

        public abstract double GetSpeed();
        public abstract double GetDistance();
        public abstract double GetPace();
        public virtual string GetSummary()
        {
            return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min) - " +
                   $"Distance: {GetDistance():F1} km, " +
                   $"Speed: {GetSpeed():F1} kph, " +
                   $"Pace: {GetPace():F1} min per km";
        }
    }
}