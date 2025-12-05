using System.ComponentModel;
using System.Runtime.CompilerServices;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, DateTime start) : base(name, description, start)
    {

    }

    public void Breathe(DateTime end)
    {
        while (DateTime.Compare(end, DateTime.Now) > 0) //looked up how to compare datetimes, found this syntax on a microsoft tutorial page
        {
            Console.Write("Breathe in...");
            Wait(3);
            Console.Write("Hold...");
            Wait(3);
            Console.Write("Breathe out...");
            Wait(3);
            Console.Write("Hold...");
            Wait(3);
            Console.WriteLine();
        }
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
}

