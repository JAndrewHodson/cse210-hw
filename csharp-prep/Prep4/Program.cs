using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Declaring new list
        List<int> numbers = new List<int>();

        //Setting up variables to save the maximum of the numbers added as well as the lowest positive number
        int lastAdded;
        int maximum = 0;
        int minPositive = 99999999;

        //Ask user for numbers to add to list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //establishing loop of user inputs
        do
        {
            //Asking user for input
            Console.Write("Enter number: ");
            lastAdded = int.Parse(Console.ReadLine());
            numbers.Add(lastAdded);

            //Updating maximum number added to list
            if (lastAdded > maximum)
            {
                maximum = lastAdded;
            }

            //Updating minimum positive integer added to list
            if ((lastAdded > 0) && (lastAdded < minPositive))
            {
                minPositive = lastAdded;
            }

        } while (lastAdded != 0);

        //Calculating sum of numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        //Calculating the mean of the numbers in the list
        float avg = (sum / (((float)numbers.Count) - 1));

        //sorting list
        numbers.Sort();

        //Displaying information about the list to the user
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {maximum}");
        Console.WriteLine($"The smallest positive number is: {minPositive}");
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }

    }
}