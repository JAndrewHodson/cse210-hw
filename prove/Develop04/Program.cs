using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        bool proceed = true;
        string index;

        while (proceed)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            index = Console.ReadLine();

            if (index == "1")
            {
                
                Console.Clear();

                BreathingActivity breathe = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathe.Introduction();

                Console.Clear();

                breathe.Breathe(breathe.GetEndTime());

                Console.Clear();

                breathe.Outro();

                Console.Clear();

            }else if (index == "2")
            {
                Console.Clear();

                ReflectingActivity reflection = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflection.Introduction();

                Console.Clear();

                reflection.Reflect(reflection.GetEndTime());

                Console.Clear();

                reflection.Outro();

                Console.Clear();

            }else if (index == "3")
            {
                Console.Clear();
                
                ListingActivity list = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                list.Introduction();

                Console.Clear();

                list.Listing(list.GetEndTime());

                Console.WriteLine();

                list.Outro();

                Console.Clear();

            }else if (index == "4")
            {
                proceed = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid option from the menu");
            }

            
        }

        

        
    }

}