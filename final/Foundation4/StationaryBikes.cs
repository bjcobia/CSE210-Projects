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
        return Math.Round(_speed, 2);
    }

    public override double GetDistance()
    {
        return Math.Round(base.GetMinutes() / 60.0 * _speed, 2);
    }

    public override double GetPace()
    {
        return Math.Round(60.0 / _speed, 2);
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed} kph, Distance: {GetDistance()} km, Pace: {GetPace()} min/km";
    }
}