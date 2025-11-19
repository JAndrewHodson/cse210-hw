public class Entry
{
    private string entryPrompt = "";

    private string DateTime = "";

    private string userResponse = "";

    public void Display()
    {
        Console.WriteLine($"Date: {DateTime} - Prompt: {entryPrompt}");
        Console.WriteLine($"{userResponse}");
        Console.WriteLine("");
    }
}