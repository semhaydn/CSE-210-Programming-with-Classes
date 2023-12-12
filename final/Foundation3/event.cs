public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GenerateStandardMessage()
    {
        return $"Standard Details:\nTitle: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string GenerateFullMessage()
    {
        return GenerateStandardMessage();
    }

    public string GenerateShortDescription()
    {
        return $"Short Description:\nType: {_title}\nTitle: {_title}\nDate: {_date}";
    }
}
