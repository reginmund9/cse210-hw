using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Edit an entry");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = GetRandomPrompt();
                    Console.WriteLine($"{prompt}\nYour response: ");
                    string response = Console.ReadLine();
                    Entry entry = new Entry(prompt, response);
                    journal.AddEntry(entry);
                    //Entry entry = GetRandomPrompt();
                    //Console.WriteLine($"{entry._prompt}\nYour response: ");
                    //entry._response = Console.ReadLine();
                    //journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter the filename to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "4":
                    Console.Write("Enter the filename to load the journal: ");
                    string loadFileName = Console.ReadLine();
                    List<Entry> loadedEntries = journal.LoadFromFile(loadFileName);
                    foreach (var loadedEntry in loadedEntries)
                    {
                        Console.WriteLine(loadedEntry);
                    }
                    break;

                case "5":
                    Console.Write("Enter the index of the entry to edit: ");
                    if (int.TryParse(Console.ReadLine(), out int editIndex))
                    {
                        Console.WriteLine("Enter the new prompt: ");
                        string newPrompt = Console.ReadLine();
                        Console.WriteLine("Enter the new response: ");
                        string newResponse = Console.ReadLine();

                        journal.EditEntry(editIndex - 1, newPrompt, newResponse);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index input.");
                    }
                    break;
                
                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What scripture did I read?",
            "What was the strongest emotion I felt today?",
            "What challanges did I have?",
            "How did I face a challenge?",
            "What goals do I have today?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    /*static Entry GetRandomPrompt()
    {
        List<Entry> prompts = new List<Entry>
        {
            new Entry("Who was the most interesting person I interacted with today?", ""),
            new Entry("What was the best part of my day?", ""),
            new Entry("What scripture did I read?", ""),
            new Entry("What was the strongest emotion I felt today?", ""),
            new Entry("What challenges did I have?", ""),
            new Entry("How did I face a challenge?", ""),
            new Entry("What goals do I have today?", "")
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }*/

}







