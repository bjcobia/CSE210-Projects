public class OutdoorGatherings : Event
{
    private string _weatherForecast;

    public OutdoorGatherings(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {base.GetTitle()}\nDate: {base.GetDate().ToShortDateString()}";
    }
}