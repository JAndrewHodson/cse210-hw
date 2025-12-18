public class Character
{
    private string _name;
    private Class _class;
    private double _health;
    private double _maxHealth;

    public Character(string name, Class characterClass)
    {
        _name = name;
        _class = characterClass;
        _maxHealth = characterClass.CalculateMaxHealth();
        _health = _maxHealth;
    }

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Health: {_health}");
        _class.Display();
    }

    public string List()
    {
        return $"{_name}, {_class.List()}";
    }

    public void LevelUp()
    {
        _class.LevelUp();
    }


}