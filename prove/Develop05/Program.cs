using System;
using System.Runtime.CompilerServices;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        bool active = true;
        string index;

        Profile userProfile = new Profile();

        while(active == true)
        {
            Console.WriteLine("");
            Console.WriteLine($"You have {userProfile.getScore()} points");
            Console.WriteLine("");
            Console.WriteLine($"Menu Options");
            Console.WriteLine($"  1. Create New Goal");
            Console.WriteLine($"  2. List Goals");
            Console.WriteLine($"  3. Save Goals");
            Console.WriteLine($"  4. Load Goals");
            Console.WriteLine($"  5. Record Event");
            Console.WriteLine($"  6. Quit");
            Console.Write($"Select a choice from the menu: ");
            index = Console.ReadLine();

            if (index == "1")
            {
                string index1;
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                index1 = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                double points = double.Parse(Console.ReadLine());

                if (index1 == "1")
                {
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    userProfile.AddGoal(goal);
                } else if (index1 == "2")
                {
                    InfiniteGoal goal = new InfiniteGoal(name, description, points);
                    userProfile.AddGoal(goal);
                } else if (index1 == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int howMany = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    double bonus = double.Parse(Console.ReadLine());

                    ChecklistGoal goal = new ChecklistGoal(name, description, bonus, howMany, points);
                    userProfile.AddGoal(goal);
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }

            } else if (index == "2")
            {
                userProfile.DisplayGoals();
            } else if (index == "3")
            {
                userProfile.Save();
            } else if (index == "4")
            {
                userProfile.Load();
            } else if (index == "5")
            {
                userProfile.Event();
                Console.Write("Which goal did you accomplish? ");
                int index2 = int.Parse(Console.ReadLine());
                userProfile.CompleteGoal(index2);

            } else if (index == "6")
            {
                active = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
            }
        }
    }
}