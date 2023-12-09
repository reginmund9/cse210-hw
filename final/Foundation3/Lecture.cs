
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public string ReturnEventType()
    {
        return "Lecture";
    }

    public string DetailedLecture()
    {
        string detailed = GetStandard() + "\n";

        detailed += "Speaker: " + _speaker + "\n";
        detailed += "Capacity: " + _capacity +  " max";
        return detailed;
    }

    public string ShortLecture()
    {
        string briefLecture = "";
        string eventType = ReturnEventType();

        briefLecture += "Event Type: " + eventType + "\n";
        briefLecture += GetShort();
        return briefLecture;
    }
    
}