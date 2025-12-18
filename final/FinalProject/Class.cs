using System.IO.Compression;

public abstract class Class
{
    protected string _title;
    protected int _lvl;
    protected List<Feature> _features;

    public Class()
    {
        _lvl = 1;
    }

    public abstract double CalculateMaxHealth();
    public abstract void CalculateSpellSlots();
    public abstract void Display();
    public abstract void LevelUp();

    public string List()
    {
        return $"{_title}({_lvl})";
    }

    public int GetLevel()
    {
        return _lvl;
    }
}