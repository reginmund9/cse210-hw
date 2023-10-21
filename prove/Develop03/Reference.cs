
class Reference 
{
    private String _author;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(String author, int chapter, int startVerse)
    {
        _author = author;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    public Reference(String author, int chapter, int startVerse, int endVerse)
    {
        _author = author;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public String GetReference() 
    {
        if (_endVerse == 0) {
            return $"{_author} {_chapter}:{_startVerse}";

        }
            return $"{_author} {_chapter}:{_startVerse}-{_endVerse}";
    }
}
