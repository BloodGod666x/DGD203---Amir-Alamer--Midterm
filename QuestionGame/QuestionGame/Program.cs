using System;

class AdventureGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Adventure Game!");
        Console.Write("What is your name? ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"\nWelcome, {playerName}! Let's begin your adventure...\n");

        int choiceA = 0, choiceB = 0, choiceC = 0;

        Console.WriteLine("Question 1: If you had to choose, would you rather:");
        Console.WriteLine("A) Explore a deep, mysterious cave.");
        Console.WriteLine("B) Sail across an endless ocean on a small boat.");
        Console.WriteLine("C) Venture into a dense, enchanted forest.");
        char answer1 = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (answer1 == 'A' || answer1 == 'a') choiceA++;
        else if (answer1 == 'B' || answer1 == 'b') choiceB++;
        else if (answer1 == 'C' || answer1 == 'c') choiceC++;

        Console.WriteLine("\nQuestion 2: In times of danger, do you prefer to:");
        Console.WriteLine("A) Stand and fight with everything you've got.");
        Console.WriteLine("B) Think carefully and plan your next move.");
        Console.WriteLine("C) Find a way to escape as quickly as possible.");
        char answer2 = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (answer2 == 'A' || answer2 == 'a') choiceA++;
        else if (answer2 == 'B' || answer2 == 'b') choiceB++;
        else if (answer2 == 'C' || answer2 == 'c') choiceC++;

        Console.WriteLine("\nQuestion 3: If you had the ability to transform into an animal, what would it be?");
        Console.WriteLine("A) A majestic eagle, soaring high above.");
        Console.WriteLine("B) A swift cheetah, quick on my feet.");
        Console.WriteLine("C) A clever fox, able to outwit my enemies.");
        char answer3 = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (answer3 == 'A' || answer3 == 'a') choiceA++;
        else if (answer3 == 'B' || answer3 == 'b') choiceB++;
        else if (answer3 == 'C' || answer3 == 'c') choiceC++;

        Console.WriteLine("\nQuestion 4: What would you prefer to have with you on an unknown adventure?");
        Console.WriteLine("A) A sword to defend yourself and fight foes.");
        Console.WriteLine("B) A magical map that shows hidden paths and secrets.");
        Console.WriteLine("C) A backpack filled with supplies for survival.");
        char answer4 = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (answer4 == 'A' || answer4 == 'a') choiceA++;
        else if (answer4 == 'B' || answer4 == 'b') choiceB++;
        else if (answer4 == 'C' || answer4 == 'c') choiceC++;

        Console.WriteLine("\n\nResults:");

        if (choiceA > choiceB && choiceA > choiceC)
        {
            Console.WriteLine($"{playerName}, you are a fearless adventurer! You embrace danger head-on and face challenges without hesitation.");
        }
        else if (choiceB > choiceA && choiceB > choiceC)
        {
            Console.WriteLine($"{playerName}, you are a strategist! You think things through and prefer using your intelligence to navigate tough situations.");
        }
        else if (choiceC > choiceA && choiceC > choiceB)
        {
            Console.WriteLine($"{playerName}, you are a survivor! You know how to adapt to any situation and always find your way out of trouble.");
        }
        else
        {
            Console.WriteLine($"{playerName}, you are a mix of boldness, strategy, and survival! Every adventure you face will have a unique approach.");
        }

        Console.WriteLine("\nYour adventure is just beginning, and the world is waiting for you. What will you do next?");
    }
}
