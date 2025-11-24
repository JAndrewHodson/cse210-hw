using System.IO;

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
        Console.WriteLine($"What would you like to name the file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._DateTime}~|~{e._entryPrompt}~|~{e._userResponse}");
            }
        }
    }

    public void Load()
    {
        ;
    }
}