public class Entry
{
    public string _entryPrompt = "";

    public string _DateTime = "";

    public string _userResponse = "";

    public void Display()
    {
        Console.WriteLine($"Date: {_DateTime} - Prompt: {_entryPrompt}");
        Console.WriteLine($"{_userResponse}");
        Console.WriteLine("");
    }
}