// Class to represent a word in the scripture
class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        this._word = word;
        _isHidden = false;
    }

    public string GetWord()
    {
        return _word;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        return IsHidden() ? new string('_', GetWord().Length) : GetWord();
    }
}

