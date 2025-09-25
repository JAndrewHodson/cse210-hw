using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool play = true;
        string keepPlaying;
        int guesses = 0;
        do
        {


            int number = randomGenerator.Next(1, 100);
            int response;
            do
            {
                Console.Write("What is your guess? ");
                response = int.Parse(Console.ReadLine());
                guesses = guesses + 1;
                if (response == number)
                {
                    Console.WriteLine($"You guessed it in {guesses} tries!");
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
            guesses = 0;
            Console.WriteLine("Would you like to play again? ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying != "yes")
            {
                play = false;
            }
        } while (play == true);
    }
}