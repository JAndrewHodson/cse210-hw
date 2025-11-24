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

        Console.WriteLine("Writing to file...");

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
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        List<Entry> _loadedEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            Entry entry = new Entry();

            entry._DateTime = parts[0];
            entry._entryPrompt = parts[1];
            entry._userResponse = parts[2];

            _loadedEntries.Add(entry);
        }
        _entries = _loadedEntries;
    }
}