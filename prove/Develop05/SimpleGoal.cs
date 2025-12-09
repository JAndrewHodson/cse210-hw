public class SimpleGoal : Goal
{
    public SimpleGoal(string description, double value) : base(description, value)
    {
        _description = description;
        _points = value;
    }

    public override void Display()
    {
        
    }

    public override void Complete()
    {
        
    }
}