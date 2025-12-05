using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Activity
{
    static Random random = new Random();
    private string _name;
    private int _duration;
    private string _description;
    private DateTime _startTime;
    private DateTime _endTime;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void Introduction()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        _duration = Int32.Parse(Console.ReadLine());
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
        

    }

    public void Outro()
    {
        Console.Write("Well Done! ");
        Load(5);
        Console.Write($"You have completed {_duration} seconds of the {_name} Activity ");
        Load(5);
    }

    public void Load(int time)
    {
        
            
                for (int i = 0; i < time; i++)
                {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b"); // Erase the + character


                Console.Write("x"); // Replace it with the - character 
                Thread.Sleep(500);
                Console.Write("\b");
                }
                Console.Write(" ");
                Console.WriteLine();
            
    }

    public DateTime GetEndTime()
    {
        return _endTime;
    }

        public void Wait(int interval)
    {
        for (int i = interval; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write(" ");
        Console.WriteLine();
    }

        public void PrintPrompt(List<string> prompts)
    {
        int index = random.Next(prompts.Count);
        Console.WriteLine($"---{prompts[index]}---");
    }
    
}