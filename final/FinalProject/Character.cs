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
        
    }

    public string List()
    {
        return($"{_name}, {_class.List}");
    }

    public void ShortRest()
    {
        
    }

    public void LongRest()
    {
        
    }

    public void Damage()
    {
        
    }
}