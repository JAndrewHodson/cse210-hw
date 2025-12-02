using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment math = new MathAssignment("Dale", "Derivatives", "7.9", "5-10");

        WritingAssignment essay = new WritingAssignment("June","Construction History","Architectural Development Across the Ages");


        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        Console.WriteLine(essay.GetSummary());
        Console.WriteLine(essay.GetWritingInformation());
    }
}