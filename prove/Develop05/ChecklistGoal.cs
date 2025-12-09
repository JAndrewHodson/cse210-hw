public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _timesCompleted;
    private double _intermediatePoints;

    public ChecklistGoal(string description, double value,int  times, double partialValue) : base(description, value)
    {
        _description = description;
        _points = value;
        _timesToComplete = times;
        _timesCompleted = 0;
        _intermediatePoints = partialValue;
    }

    public override void Display()
    {
        
    }

    public override void Complete()
    {
        
    }
}