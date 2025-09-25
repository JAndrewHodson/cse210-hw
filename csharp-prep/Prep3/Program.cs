using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());
        int response;
        do
        {
            Console.Write("What is your guess? ");
            response = int.Parse(Console.ReadLine());
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
        } while (response != number);
    }
}