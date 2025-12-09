using System.ComponentModel.DataAnnotations;

public abstract class Goal
{
    protected string _description;
    protected double _points;

    public Goal(string description, double value)
    {
        _description = description;
        _points = value;
    }

    public abstract void Display();

    public abstract void Complete();
}