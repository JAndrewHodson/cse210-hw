using System.Net;

class ListingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _responses = [""];
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    }

    public void Listing(DateTime end)
    {

        Console.WriteLine("List as many responses as you can to the followign prompt:");
        PrintPrompt(_prompts);
        Console.Write("You may begin in: ");
        Wait(5);
        string response;

        while (DateTime.Compare(end, DateTime.Now) > 0)
        {
            response = Console.ReadLine();
            _responses.Add(response);
        }

        int count = _responses.Count - 1;
        Console.WriteLine($"You listed {count} items!");
    }
}