using System;

namespace EternalQuestProgram
{
    abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name.Replace("|", "/");
            _description = description.Replace("|", "/");
            _points = points;
        }

        public string ShortName => _shortName;
        public string Description => _description;
        public int Points => _points;

        public abstract int RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetDetailsString();
        public abstract string GetStringRepresentation();
    }
}