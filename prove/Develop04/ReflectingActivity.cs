class ReflectingActivity : Activity
{

    static Random random = new Random();

    List<string> _prompts;
    List<string> _questions;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    }

    public void PrintPrompt()
    {
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]}---");
    }

    public void PrintQuestion()
    {
        int index = random.Next(_questions.Count);
        Console.WriteLine($"{_questions[index]}");
    }

    public void Reflect(DateTime end)
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        PrintPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.WriteLine();
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Wait(3);
        Console.Clear();
        while (DateTime.Compare(end, DateTime.Now) > 0)
        {
            PrintQuestion();
            Load(5);
        }
    }
}