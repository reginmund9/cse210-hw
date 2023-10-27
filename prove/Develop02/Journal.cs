class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date.ToShortDateString()}: {entry._prompt}: {entry._response}");
            }
        }
    }

    public List<Entry> LoadFromFile(string filename)
    {
        List<Entry> loadedEntries = new List<Entry>();
    
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            string[] columns = line.Split(':');
            
            if (columns.Length == 3)
            {
                Entry newEntry = new Entry(columns[1].Trim(), columns[2].Trim());
    
                // Correct the date parsing
                if (DateTime.TryParse(columns[0].Trim(), out DateTime date))
                {
                    newEntry._date = date;
                }
                else
                {
                    Console.WriteLine($"{columns[0]}");
                    continue; // Skip this entry if date parsing fails
                }
    
                loadedEntries.Add(newEntry);
            }
            else
            {
                Console.WriteLine($"{line}");
            }
        }
        return loadedEntries;
    }


    public void EditEntry(int index, string newPrompt, string newResponse)
    {
        if (index >= 0 && index < _entries.Count)
        {
            _entries[index]._prompt = newPrompt;
            _entries[index]._response = newResponse;
        }
        else
        {
            Console.WriteLine("Invalid entry index.");
        }
    }

}
