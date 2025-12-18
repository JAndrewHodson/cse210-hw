using System.Reflection.Metadata.Ecma335;

public class Barbarian : Class
{
    public Barbarian() : base()
    {
        _title = "Barbarian";
        _spells = [];
        _features = []; //create and add rage here.
    }
    public override double CalculateMaxHealth()
    {
        return 12+(7*(_lvl-1));
    }

    public override void CalculateSpellSlots()
    {
        
    }

    public override void Display()
    {
        
    }
    public override void LevelUp()
    {
        
    }
}