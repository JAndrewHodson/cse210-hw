using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Activity
{
    private string _name;
    private int _duration;
    private string _description;
    private DateTime _startTime;
    private DateTime _endTime;


    public Activity(string name, string description, DateTime start)
    {
        _name = name;
        _description = description;
        _startTime = start;

    }

    public void Introduction()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?");

        _duration = Int32.Parse(Console.ReadLine());
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
        

    }

    public void Outro()
    {
        Console.WriteLine("Well Done!");
        Load();
        Console.WriteLine($"You have completed {_duration} seconds of {_name}ing Activity");
        Load();
    }

    static void Load()
    {
        
            
                for (int i = 0; i < 7; i++)
                {
                   Console.Write("+");

                Thread.Sleep(500);

                Console.Write("\b"); // Erase the + character
                Console.Write("x"); // Replace it with the - character 

                Thread.Sleep(500);
                Console.Write("\b");
                }
                Console.WriteLine();
            
    }
    
}