public class InfiniteGoal : Goal
{
    private int _timesCompleted;

    public InfiniteGoal(string name, string description, double value) : base(name, description, value)
    {
        _name = name;
        _description = description;
        _points = value;
        _timesCompleted = 0;
    }

    public InfiniteGoal(string name, string description, double value, int timesCompleted) : base(name, description, value)
    {
        _name = name;
        _description = description;
        _points = value;
        _timesCompleted = timesCompleted;
    }

    public override void Display()
    {
        if (_timesCompleted > 0)
        {
            Console.WriteLine($"[{_timesCompleted}] {_name} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }

    public override double Complete()
    {
        Console.WriteLine($"You have earned {_points} points.");
        _timesCompleted = _timesCompleted + 1;
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return$"InfiniteGoal:{_name}~|~{_description}~|~{_points}~|~{_timesCompleted}";
    }
}