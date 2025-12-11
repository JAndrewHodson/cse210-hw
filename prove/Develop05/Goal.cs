using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected double _points;

    public Goal(string name, string description, double value)
    {
        _name = name;
        _description = description;
        _points = value;
    }

    public abstract void Display();

    public abstract double Complete();

    public abstract string GetStringRepresentation();

    public void EventList()
    {
        Console.WriteLine(_name);
    }
}