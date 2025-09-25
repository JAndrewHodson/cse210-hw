using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int response = int.Parse(Console.ReadLine());
        if (response == number)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (response > number)
        {
            Console.WriteLine("Lower");
        }
        else if (response < number)
        {
            Console.WriteLine("Higher");
        }
    }
}