namespace EternalQuestProgram
{
    class ChecklistGoal : Goal
    {
        private int _targetCount;
        private int _currentCount;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _bonus = bonus;
            _currentCount = 0;
        }

        public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount)
            : base(name, description, points)
        {
            _targetCount = targetCount;
            _bonus = bonus;
            _currentCount = currentCount;
        }

        public override int RecordEvent()
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                return _points + _bonus;
            }
            return _points;
        }

        public override bool IsComplete() => _currentCount >= _targetCount;

        public override string GetDetailsString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {_shortName} ({_description}) -- Completed {_currentCount}/{_targetCount}";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_targetCount}|{_bonus}|{_currentCount}";
        }
    }
}