public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GenerateFullMessage()
    {
        return $"{base.GenerateStandardMessage()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}
