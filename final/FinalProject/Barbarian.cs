using System.Reflection.Metadata.Ecma335;

public class Barbarian : Class
{
    public Barbarian() : base()
    {
        _title = "Barbarian";
        Feature rage = new Feature("Rage", "Your extreme emotions grant you increased physical ability. Twice per day, you can activate this to deal extra damage and gain an advantage on physical checks.");
        _features = [rage]; 
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
        Console.WriteLine($"Class: {_title}");
        Console.WriteLine("Features: ");
        foreach (Feature feature in _features)
        {
            feature.Display();
            Console.WriteLine("");
        }
    }
    public override void LevelUp()
    {
        if (_lvl == 1)
        {
            Console.WriteLine("Your character gained 7 Health.");
            _lvl = _lvl+1;
        }else if (_lvl == 2)
        {
            Console.WriteLine("Your character gained 7 Health");
            Console.WriteLine("Your character gained the feature 'Unarmored Defense'");

            Feature newFeature = new Feature("Unarmored Defense", "Your rage has had a strange affect on your body, increases it's durability. While raging, you now resist bludgeoning, piercing, and slashing damage.");
            _features.Add(newFeature);
            _lvl = _lvl+1;
        }else if (_lvl == 3)
        {
            Console.WriteLine("Your character gained 7 Health");
            _lvl = _lvl+1;
        }else if (_lvl == 4)
        {
            Console.WriteLine("Your character gained 7 Health");
            Console.WriteLine("Your character gained the feature 'Extra Attack'");

            Feature newFeature = new Feature("Extra Attack", "Your martial proficiency has increased significantly. You can now make 1 additional attack when you take the attack action.");
            _features.Add(newFeature);
            _lvl = _lvl+1;
        }else if (_lvl == 5)
        {
            Console.WriteLine("This character can no longer level up. ");
        } else
        {
            Console.WriteLine("Something went wrong.");
        }
    }
}