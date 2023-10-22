// Class to represent the reference (e.g., "Proverbs 3:5-6")
class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string reference)
    {
        // Parse the reference and initialize the properties
        string[] parts = reference.Split(' ');
        string[] chapterVerse = parts[1].Split(':');
        string[] verses = chapterVerse[1].Split('-');

        this._book = parts[0];
        this._chapter = int.Parse(chapterVerse[0]);
        this._startVerse = int.Parse(verses[0]);
        this._endVerse = verses.Length > 1 ? int.Parse(verses[1]) : this._startVerse;
    }

    public string GetFormattedReference()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}


