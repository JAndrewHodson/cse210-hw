using System.Reflection.Metadata.Ecma335;

public class Wizard : Class
{
    public override double CalculateMaxHealth()
    {
        return 6+(4*(_lvl-1));
    }

    public override List<int> CalculateSpellSlots()
    {
        return []; //figure out wizard spell slot progression and enter it here.
    }

    public override void Display()
    {
        
    }
    public override void LevelUp()
    {
        
    }
}