using System.Reflection.Metadata.Ecma335;

public class Rogue : Class
{
    public Rogue() : base()
    {
        _title = "Rogue";
        _features = [new Feature("Sneak Attack","You skulk around in the shadows, waiting for the perfect time to strike. WHen making attacks while 'hidden', deal an extra 2d6 damage.")]; 

    }
    public override double CalculateMaxHealth()
    {
        return 8+(5*(_lvl-1));
    }

    public override void CalculateSpellSlots()
    {
        
    }

    public override void Display()
    {
        Console.WriteLine($"Class: {_title}");
        Console.WriteLine($"Features: ");
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
            Console.WriteLine("Your character gained 5 Health.");
            _lvl = _lvl+1;
        }else if (_lvl == 2)
        {
            Console.WriteLine("Your character gained 5 Health");
            Console.WriteLine("Your character gained the feature 'Cunning Strike'");

            Feature newFeature = new Feature("Cunning Strike", "Your training in stealth and mobility have yielded incredible acrobatic ability. You can take the Hide, Dash, and Disengage actions as bonus actions.");
            _features.Add(newFeature);
            _lvl = _lvl+1;
        }else if (_lvl == 3)
        {
            Console.WriteLine("Your character gained 5 Health");
            _lvl = _lvl+1;
        }else if (_lvl == 4)
        {
            Console.WriteLine("Your character gained 5 Health");
            Console.WriteLine("Your character gained the feature 'Uncanny Dodge'");

            Feature newFeature = new Feature("Uncanny Dodge", "Your experience in split moment decision making has refined your reaction time to a sliver compared to most. When you are attacked by a foe you can see, you can use your reaction to take only half damage.");
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