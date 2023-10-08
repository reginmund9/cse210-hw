using System;
using System.Collections.Generic;
using System.IO;



class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry._date.ToShortDateString()}: {entry._prompt}\n{entry._response}\n");
            }
        }
    }

    public List<Entry> LoadFromFile(string filename)
    {
        List<Entry> loadedEntries = new List<Entry>();
        
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine($"File Information:\n{content}");

            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return loadedEntries;

       
    }
    public void EditEntry(int index, Entry editedEntry)
        {
            if (index >= 0 && index < entries.Count)
            {
                entries[index] = editedEntry;
            }
            else
            {
                Console.WriteLine("Invalid entry index.");
            }
        }

}
