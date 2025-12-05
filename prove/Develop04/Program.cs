using System;

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
                //reflect here
            }else if (index == "3")
            {
                //list here
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