public class Lectures : Event
{
    private string _speakerName;
    private int _capacity;

    public Lectures(string title, string description, string date, TimeSpan time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Lecture\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {base.GetTitle()}\nDate: {base.GetDate()}";
    }
}