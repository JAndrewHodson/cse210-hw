using System;

class Program
{
    private static List<string> EntryPrompts = new List<string> {"Who was the most interesting person I interacted with today? What was so interesting about them?","What was the best part of my day? Why?","How did I see the hand of the Lord in my life today? How can I be that hand for someone else tomorrow?","What was the strongest emotion I felt today? How well did I handle it?","If there were one thing I could do over today, what would it be and how would I do it differently this time?"};

    static void Main(string[] args)
    { 
        string index = "";

        while(index != "5")
        {
            Console.WriteLine("Please Select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do?");
            index = Console.ReadLine();

            if(index == "1")
            {
                Console.WriteLine("Write");
            } else if (index == "2")
            {
                Console.WriteLine("Display");
            } else if (index == "3")
            {
                Console.WriteLine("Load");
            } else if (index == "4")
            {
                Console.WriteLine("Save");
            } else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}