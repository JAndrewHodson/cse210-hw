using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int lastAdded = 0;
        Console.WriteLine("Enter a list of positive integers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            lastAdded = int.Parse(Console.ReadLine());
        } while (lastAdded != 0);
    }
}