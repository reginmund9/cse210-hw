using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        CryptocurrencyManager manager = new CryptocurrencyManager();
        manager.ReadDataFromFile("cryptocurrency_data.txt");

        int choice;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display all cryptocurrency information");
            Console.WriteLine("2. Display information for a specific type of currency by name");
            Console.WriteLine("3. Display average price of each type of currency");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        manager.DisplayAllCryptocurrenciesInfo();
                        break;
                    case 2:
                        Console.Write("Enter the name of the currency: ");
                        string targetName = Console.ReadLine();
                        manager.DisplayCryptocurrencyInfoByName(targetName);
                        break;
                    case 3:
                        manager.DisplayAveragePriceByCurrency();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        } while (choice != 4);
    }
}