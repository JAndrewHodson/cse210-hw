public class SimpleGoal : Goal
{
    private bool _completed = false;
    
    public SimpleGoal(string name, string description, double value) : base(name, description, value)
    {
        _name = name;
        _description = description;
        _points = value;
    }

    public SimpleGoal(string name, string description, double value, bool completed) : base(name, description, value)
    {
        _name = name;
        _description = description;
        _points = value;
        _completed = completed;
    }

    public override void Display()
    {
        if (_completed == true)
        {
            Console.WriteLine($"[X] {_name} ({_description})");
        } else
        {
            Console.WriteLine($"[ ] {_name} ({_description})");
        }
    }

    public override double Complete()
    {
        if (_completed == false)
        {
        Console.WriteLine($"You have earned {_points} points.");
        _completed = true;
        return _points;
        } else
        {
            Console.WriteLine("You have already compelted that goal");
            return 0;
        }
    }

    public override string GetStringRepresentation()
    {
        return$"SimpleGoal:{_name}~|~{_description}~|~{_points}~|~{_completed}";
    }
}