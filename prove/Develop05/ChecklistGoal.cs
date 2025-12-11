public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;
    private double _intermediatePoints;


    public ChecklistGoal(string name, string description, double value,int  times, double partialValue) : base(name, description, value)
    {
        _name = name;
        _description = description;
        _points = value;
        _timesToComplete = times;
        _timesCompleted = 0;
        _intermediatePoints = partialValue;
    }

    public ChecklistGoal(string name, string description, double value,int  times, double partialValue, int timesCompleted) : base(name, description, value)
    {
        _name = name;
        _description = description;
        _points = value;
        _timesToComplete = times;
        _timesCompleted = timesCompleted;
        _intermediatePoints = partialValue;
    }

    public override void Display()
    {
        if (_timesCompleted == _timesToComplete)
        {
            Console.WriteLine($"[X] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}");
        } else
        {
            Console.WriteLine($"[ ] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}");
        }
    }


    public override double Complete()
    {
      if (_timesCompleted >= _timesToComplete)
        {
            Console.WriteLine("You have already completed this goal.");
            return 0;
        }
        else
        {
            _timesCompleted = _timesCompleted + 1; 
            if (_timesCompleted == _timesToComplete)
            {
                Console.WriteLine($"Congratulations! You have earned {_intermediatePoints + _points} points!");
                return _intermediatePoints + _points;
            }
            return _intermediatePoints; 
        }

    }

    public override string GetStringRepresentation()
    {
        return$"ChecklistGoal:{_name}~|~{_description}~|~{_intermediatePoints}~|~{_points}~|~{_timesToComplete}~|~{_timesCompleted}";
    }
}