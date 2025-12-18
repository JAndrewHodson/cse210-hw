using System.Reflection.Metadata.Ecma335;

public class Paladin : Class
{
    protected List<Spell> _spells;

    protected List<int> _spellSlots;

    public Paladin() : base()
    {
        _title = "Paladin";
        _features = [new Feature("Lay on Hands","Your blessed touch can heal wounds. When you touch a creature, you may restore an amount of health up to 5 times your level.")];
        _spells = [new Spell("Divine Smite","Your faith can be channeled into pure, offensive energy. When making an attack, you may cast this spell to increase the damage by 2d8.", 1)]; //add 1st level paladin spells
    }
    public override double CalculateMaxHealth()
    {
        return 10+(6*(_lvl-1));
    }

    public override void CalculateSpellSlots()
    {
        if (_lvl == 1)
        {
            _spellSlots = [2,0];
        }else if (_lvl == 2)
        {
            _spellSlots = [2,0];
        }else if (_lvl == 3)
        {
            _spellSlots = [3,0];
        }else if (_lvl == 4)
        {
            _spellSlots = [3,0];
        }else if (_lvl == 5)
        {
            _spellSlots = [4, 2];
        }
    }

    public override void Display()
    {
        CalculateSpellSlots();
        Console.WriteLine($"Class: {_title}");
        Console.WriteLine("Spell Slots: ");
        Console.WriteLine($"1st Level: {_spellSlots[0]}");
        Console.WriteLine($"2nd Level: {_spellSlots[1]}");

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
            Console.WriteLine("Your character gained 6 Health.");
            _lvl = _lvl+1;
        }else if (_lvl == 2)
        {
            Console.WriteLine("Your character gained 6 Health");
            Console.WriteLine("Your character learned the spell 'Compelled Duel'");

            Spell newSpell = new Spell("Compelled Duel", "When you cast this spell you point your blade at a foe. For the duration of the spell you may not attack any creature other than the one you have targetted and they have disadvantage when attacking anyone other than you. ", 2);
            _spells.Add(newSpell);
            _lvl = _lvl+1;
        }else if (_lvl == 3)
        {
            Console.WriteLine("Your character gained 6 Health");
            _lvl = _lvl+1;
        }else if (_lvl == 4)
        {
            Console.WriteLine("Your character gained 6 Health");
            Console.WriteLine("Your character gained the feature 'Aura of Protection'");

            Feature newFeature = new Feature("Aura of Protection", "Allies within 10 feet of you gain a bonus to their saving throws equal to your charisma modifier.");
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