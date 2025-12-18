public class Feature
{
    private string _name;
    private string _description;

    public Feature(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"||{_name}||");
        Console.WriteLine($"   {_description}");
    }
}