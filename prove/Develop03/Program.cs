using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<string> default1 = [""];
        List<string> john = ["For","God","so","loved","the","world,","that","he","gave","his","only","begotten","Son,","that","whosoever","believeth","in","him","should","not","perish,","but","have","everlasting","life."];
        List<string> proverbs = ["Trust","in","the","Lord","with","all","thine","heart;","and","lean","not","unto","thine","own","understanding.","In","all","thy","ways","acknowledge","him,","and","he","shall","direct","thy","paths."];
        string reference;

        Scripture s1 = new Scripture(default1);

        Random rnd = new Random();
        if (rnd.Next(0,2)==1)
        {
            s1 = new Scripture(john);
            Reference r1 = new Reference();
            reference = r1.GetReference("John",3,16);
        }
        else
        {
            s1 = new Scripture(proverbs);
            Reference r1 = new Reference();
            reference = r1.GetReference("Proverbs",3,5,6);
        }


        string userInput = "";
        while (userInput != "Quit")
        {
            Console.Clear();

            Console.Write($"{reference} ");
            s1.Display(); 
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'Quit' to exit");
            userInput = Console.ReadLine();
            s1.Hide();
        
            
        }
        
        

        

    }
}