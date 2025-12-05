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
            Console.WriteLine("Select a choice from the menu");

            index = Console.ReadLine();

            if (index == "1")
            {

                BreathingActivity breathe = new BreathingActivity("Breathe", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", DateTime.Now);
                breathe.Introduction();
                breathe.Outro();
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