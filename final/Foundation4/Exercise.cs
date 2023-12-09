
public class Exercise
{
    protected string _date;
    protected int _minutes;
    protected string _name;

    public Exercise(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double CalDistance()
    {
        return 0;
    }

    public virtual double CalSpeed()
    {
        return 0;
    }

    public virtual double CalPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        string summary = $"{_date} {_name} ({_minutes} min)- Distance {CalDistance()} km, Speed: {CalSpeed()} kph, Pace: {CalPace()} min per km";
        return summary;
    }
}