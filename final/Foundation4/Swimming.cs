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
        return Math.Round(_laps * 50.0 / 1000.0, 2); // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / (base.GetMinutes() / 60.0), 2); // Speed in kph
    }

    public override double GetPace()
    {
        return Math.Round(base.GetMinutes() / GetDistance(), 2); // Pace in minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Laps: {_laps}, Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}