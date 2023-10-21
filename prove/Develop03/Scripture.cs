using System.Diagnostics.Contracts;
 
class Scripture 
{
    private Reference _referance;
    private List<Word> _words {get; set;}

    public List<Word> Words
    {
        get { return _words; }
        set { _words = value; }
    }

    public Scripture(Reference referance, List<Word> words)
    {
        _referance = referance;
        _words = words;
    }

    public String GetStringScripture()
    {
        return $"{_referance.GetReference()} \"{ConcatinateWords()}\"";

    }

    private String ConcatinateWords()
    {
       return String.Join(" ", _words.Select(it => it.Words).ToList());
    }
}
