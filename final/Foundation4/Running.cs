
public class Running : Exercise
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _name = "Running";
        _distance = distance;
    }

    public override double CalDistance()
    {
        return _distance;
    }

    public override double CalSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }

    public override double CalPace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
}