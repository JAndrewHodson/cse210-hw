using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class Program
{
    private static List<string> EntryPrompts = new List<string> {"Who was the most interesting person I interacted with today? What was so interesting about them?","What was the best part of my day? Why?","How did I see the hand of the Lord in my life today? How can I be that hand for someone else tomorrow?","What was the strongest emotion I felt today? How well did I handle it?","If there were one thing I could do over today, what would it be and how would I do it differently this time?"};

    static void Main(string[] args)
    { 
        string index1 = "";
        int index2 = 0;

        Journal journal = new Journal();

        while(index1 != "5")
        {
            //Setting up Menu
            Console.WriteLine("Please Select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do?");
            index1 = Console.ReadLine();
            

            if(index1 == "1")
            {
                //creatin new Entry object
                Entry entry = new Entry();

                //Randomly generating entry prompt for the entry
                Random rnd = new Random();
                int index = rnd.Next(EntryPrompts.Count);
                string entryPrompt = EntryPrompts[index];

                //Retreive DateTime from user device
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                //Encorporating gathered data into an entry
                entry._DateTime = dateText;
                entry._entryPrompt = entryPrompt;
                Console.WriteLine($"{entryPrompt}");
                entry._userResponse = Console.ReadLine();

                //adding entry to journal
                journal._entries.Add(entry);

            } else if (index1 == "2")
            {
                journal.Display();
            } else if (index1 == "3")
            {
                Console.WriteLine("Load");
            } else if (index1 == "4")
            {
                Console.WriteLine("Save");
            } else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}