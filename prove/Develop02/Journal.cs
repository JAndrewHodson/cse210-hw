public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry Entry in _entries)
        {
            Entry.Display();
        }
    }

    public void Save()
    {
        ;
    }

    public void Load()
    {
        ;
    }
}