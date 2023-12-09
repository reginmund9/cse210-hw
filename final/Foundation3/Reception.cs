

public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string ReturnEventType()
    {
        return "Reception";
    }

    public string DetailedReception()
    {
        string detailed = GetStandard() + "\n";
        detailed += "RSVP: " + _email;
        return detailed;
    }
    public string ShortReception()
    {
        string briefReception = "";
        string eventType = ReturnEventType();
        briefReception += "Event Type: " + eventType + "\n";
        briefReception += GetShort();
        return briefReception;
    }
}
