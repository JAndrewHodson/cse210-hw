using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video("Skyrunners", "Unknown", 90);
        video1.AddComment(new Comment("jtuck", "it was great"));
    }
}