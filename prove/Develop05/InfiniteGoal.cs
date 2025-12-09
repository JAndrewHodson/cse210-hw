public class InfiniteGoal : Goal
{
    private int _timesCompleted;

    public InfiniteGoal(string description, double value) : base(description, value)
    {
        _description = description;
        _points = value;
        _timesCompleted = 0;
    }

    public override void Display()
    {
        
    }

    public override void Complete()
    {
        
    }
}