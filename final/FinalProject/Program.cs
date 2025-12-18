using System;

class Program
{
    static void Main(string[] args)
    {
        bool active = true;
        bool creating = true;
        bool characterActive = false;

        Binder userBinder = new Binder();

        int index1 = 0;

        Character activeCharacter;

        while(active)
        {
            //main menu
            Console.WriteLine("");
            Console.WriteLine("Welcome to your binder!");
            Console.WriteLine("   1. Create Character");
            Console.WriteLine("   2. View Character");
            Console.WriteLine("   3. Use Character");
            Console.WriteLine("   4. Quit");
                Console.Write("Please select an option from the menu. ");
            int index = int.Parse(Console.ReadLine());
            if (index == 1)
            {
                //create
                while (creating)
                {
                    Console.WriteLine("");
                    Console.WriteLine("What is the character's name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("The Class Options Are: ");
                    Console.WriteLine("1. Barbarian");
                    Console.WriteLine("2. Rogue");
                    Console.WriteLine("3. Paladin");
                    Console.WriteLine("4. Wizard");
                    Console.WriteLine("5. Quit");
                    Console.Write("Please select your character's class: ");
                    index1 = int.Parse(Console.ReadLine());
                    if (index1 == 1)
                    {
                        //create barbarian class
                        Class newClass = new Barbarian();
                        Character newCharacter = new Character(name, newClass);
                    } else if (index1 == 2)
                    {
                        //create rogue class
                        Class newClass = new Rogue();
                        Character newCharacter = new Character(name, newClass);
                    } else if (index1 == 3)
                    {
                        //create paladin class
                        Class newClass = new Paladin();
                        Character newCharacter = new Character(name, newClass);
                    } else if (index1 == 4)
                    {
                        //create wizard class
                        Class newClass = new Wizard();
                        Character newCharacter = new Character(name, newClass);
                    } else if (index == 5)
                    {
                        creating = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input.");
                    }

                }

            }else if (index == 2)
            {
                //look at a character

                //list all characters
                userBinder.List();
                Console.WriteLine("");

                //pick a specific character to look at
                Console.WriteLine("");
                Console.WriteLine("Which character would you like to look at?");
                Console.Write("(please enter the number to the left of the character): ");
                index1 = int.Parse(Console.ReadLine());

                userBinder.GetCharacter(index1).Display();
                Console.WriteLine("Press Enter to return to main menu");
                Console.ReadLine();

            }else if (index == 3)
            {
                //display of characters to choose from the make active
                userBinder.List();
                Console.WriteLine("");
                activeCharacter = userBinder.GetCharacter(index1);
                characterActive = true;

                //sub-menu of things to do with active character
                while (characterActive)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"");
                    Console.WriteLine("   1. Leveled Up");
                    Console.WriteLine("   2. Short Rest");
                    Console.WriteLine("   3. Long Rest");
                    Console.WriteLine("   4. Took Damage");
                    index1 = int.Parse(Console.ReadLine());
                }
            }else if (index == 4)
            {
                active = false;
            }else
            {
                Console.WriteLine("Please enter a valid input from the menu");
            }
        }


    }
}