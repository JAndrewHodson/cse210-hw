class Activity
{
    private string _name;
    private int _duration;
    private string _description;
    private int _startTime;
    private int _endTime;

    public Activity(string name, int duration, string description, int start, int end)
    {
        _name = name;
        _duration = duration;
        _description = description;
        _startTime = start;
        _endTime = end;
    }
}