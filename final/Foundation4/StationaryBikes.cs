public class StationaryBikes : Activity
{
    private double _speed;

    public StationaryBikes(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return base._minutes / 60.0 * _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed} kph, Distance: {GetDistance()} km, Pace: {GetPace()} min/km";
    }
}