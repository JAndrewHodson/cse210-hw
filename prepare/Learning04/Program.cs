using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment math = new MathAssignment("Dale", "Derivatives", "7.9", "5-10");
        var (name, topic) = math.GetSummary();
        var (section, problems) = math.GetHomeworkList();

        Console.WriteLine($"{name} - {topic}");
        Console.WriteLine($"Section {section} Problems {problems}");
    }
}