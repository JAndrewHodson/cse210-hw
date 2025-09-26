using System;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

class Program
{
    //Function to welcome user to the program
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //Funtion to prompt user for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    //Function to prompt user for user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    //Function to prompt user for their birth year
    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        return int.Parse(Console.ReadLine());
    }

    //Function to square user's favorite number
    static int SquareNumber(int number)
    {
        number = number * number;
        return number;
    }

    //functino to display results
    static void DisplayResults(string name, int square, int age)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you have turned or will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int year = PromptUserBirthYear();
        int age = 2025 - year;
        int square = SquareNumber(userNumber);

        DisplayResults(name, square, age);

    }
}