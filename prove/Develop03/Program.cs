using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture
        Scripture myScripture = new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Display the original scripture
        myScripture.Display();

        // Continue prompting the user until all words are hidden
        while (!myScripture.AllWordsHidden())
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            // Hide random words and display the updated scripture
            myScripture.HideRandomWord();
            myScripture.Display();
        }

        Console.WriteLine("Program ended.");
    }
}

