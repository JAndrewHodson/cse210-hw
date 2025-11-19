public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Entry.Display()
        }
    }

    public void Save()
    {

    }

    public void Load()
    {

    }
}