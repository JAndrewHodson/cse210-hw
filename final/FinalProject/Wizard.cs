using System.Reflection.Metadata.Ecma335;

public class Wizard : Class
{

    protected List<Spell> _spells;

    protected List<int> _spellSlots;

    public Wizard() : base()
    {
        _title = "Wizard";
        _features = [];
        _spells = [new Spell("Fire Bolt","You shoot a bolt of flames from your hand, dealing 1d8 damage on a hit.",0), new Spell("Magic Missile","You shoot a swarm of 3 magical projectiles. Each deals 1d4 force damage and can be directed to separate targets if so desired.",1)]; //add wizard spells here
    }
    public override double CalculateMaxHealth()
    {
        return 6+(4*(_lvl-1));
    }

    public override void CalculateSpellSlots()
    {
        if (_lvl == 1)
        {
            _spellSlots = [2,0,0];
        }else if (_lvl == 2)
        {
            _spellSlots = [3,0,0];
        }else if (_lvl == 3)
        {
            _spellSlots = [3,2,0];
        }else if (_lvl == 4)
        {
            _spellSlots = [4,3,0];
        }else if (_lvl == 5)
        {
            _spellSlots = [4,3,2];
        }
    }

    public override void Display()
    {
        CalculateSpellSlots();
        Console.WriteLine($"Class: {_title}");
        Console.WriteLine("Spell Slots: ");
        Console.WriteLine($"1st Level: {_spellSlots[0]}");
        Console.WriteLine($"2nd Level: {_spellSlots[1]}");
        Console.WriteLine($"3rd Level: {_spellSlots[2]}");

        foreach(Spell spell in _spells)
        {
            spell.Display();
            Console.WriteLine("");
        }
    }
    public override void LevelUp()
    {
        if (_lvl == 1)
        {
            Console.WriteLine("Your character gained 4 Health.");
            _lvl = _lvl+1;
        }else if (_lvl == 2)
        {
            Console.WriteLine("Your character gained 4 Health");
            Console.WriteLine("Your character leanred the spell 'Misty Step'");

            Spell newSpell = new Spell("Misty Step", "By tapping into the etherial plane, you can teleport to a point you can see within range instantaneously.", 2);
            _spells.Add(newSpell);
            _lvl = _lvl+1;
        }else if (_lvl == 3)
        {
            Console.WriteLine("Your character gained 4 Health");
            _lvl = _lvl+1;
        }else if (_lvl == 4)
        {
            Console.WriteLine("Your character gained 4 Health");
            Console.WriteLine("Your character learned the spell 'Fireball'");

            Spell newSpell = new Spell("Fireball", "You know what this spell does", 3);
            _spells.Add(newSpell);
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