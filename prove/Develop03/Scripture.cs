class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(string reference, string text)
    {
        this._reference = new Reference(reference);
        // Split the text into words and initialize the list of ScriptureWords
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public void HideRandomWord()
    {
        // Get a list of indices for words that are not already hidden
        List<int> visibleWordIndices = Enumerable.Range(0, _words.Count)
            .Where(i => !_words[i].IsHidden()).ToList();

        if (visibleWordIndices.Count > 0)
        {
            // Randomly select an index from the visible words and hide it
            Random random = new Random();
            int randomIndex = visibleWordIndices[random.Next(visibleWordIndices.Count)];
            _words[randomIndex].Hide();
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{_reference.GetFormattedReference()}:\n");

        foreach (var word in _words)
        {
            Console.Write($"{word.GetDisplayText()} ");
        }

        Console.WriteLine("\n");
    }
}
