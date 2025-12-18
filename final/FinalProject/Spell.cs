public class Spell
{
    private string _name;
    private string _description;
    private int _spellLevel;
    public Spell(string name, string description, int level)
    {
        _name = name;
        _description = description;
        _spellLevel = level;
    }

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_name}");
        Console.WriteLine($"A {_spellLevel} level spell.");
        Console.WriteLine($"{_description}");
    }
}