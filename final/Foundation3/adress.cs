public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        // Assuming USA if country is "USA"
        return _country.ToUpper() == "USA";
    }

    public override string ToString()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
