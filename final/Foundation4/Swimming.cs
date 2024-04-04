public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (base._minutes / 60.0); // Speed in kph
    }

    public override double GetPace()
    {
        return base._minutes / GetDistance(); // Pace in minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Laps: {_laps}, Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}