
public class Swimming : Exercise
{
    private double _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "Swimming";
        _laps = laps;
    }

    public override double CalDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double CalSpeed()
    {
        double speed = CalDistance() / _minutes * 60;
        return speed;
    }

    public override double CalPace()
    {
        double pace = _minutes / CalDistance();
        return pace;
    }
}