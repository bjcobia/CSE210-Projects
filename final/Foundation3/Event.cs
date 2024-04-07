public class Event
{
    private string _title{get;}
    private string _description{get;}
    private string _date{get;}
    private TimeSpan _time{get;}
    private Address _address{get;}

    public Event(string title, string description, string date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time.ToString()}\nAddress: {_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {_date}";
    }
}