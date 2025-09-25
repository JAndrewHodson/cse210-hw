using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Declaring new list
        List<int> numbers = new List<int>();

        //Setting up variables to save the maximum of the numbers added
        int lastAdded;
        int maximum = 0;
        Console.WriteLine("Enter a list of positive integers, type 0 when finished.");
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
        } while (lastAdded != 0);

        //Calculating sum of numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        //Calculating the mean of the numbers in the list
        float avg = (sum / (((float)numbers.Count)-1));

        //Displaying information about the list to the user
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {maximum}");

    }
}