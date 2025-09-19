using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in the class? ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade;
        bool pass;
        string modifier;

        if (grade >= 90)
        {
            letterGrade = "A";
            pass = true;
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            pass = true;
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            pass = true;
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            pass = false;
        }
        else
        {
            letterGrade = "F";
            pass = false;
        }

        if ((grade % 10) >= 7 && (letterGrade != "A") && (letterGrade != "F")) 
        {
            modifier = "+";
        }
        else if ((grade % 10) <= 3 && (letterGrade != "F") && (grade != 100))
        {
            modifier = "-";
        }
        else
        {
            modifier = "";
        }

        if (pass)
        {
            Console.WriteLine($"Congratulations! You got a {letterGrade}{modifier} and passed!");
        }
        else
        {
            Console.WriteLine($"Better luck next time! You got a {letterGrade}{modifier} and failed.");
        }
    }
}