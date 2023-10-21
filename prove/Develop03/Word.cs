class Word 
{
    private String _word;
    private Boolean _isHiden = false;
    public Boolean IsHidden
    {
        get { return _isHiden; }
        set { _isHiden = value; }
    }

    public String Words
    {
        get { return _word; }
        set { _word = value; }
    }

    public Word(String word)
    {
        _word = word;
    }
}
