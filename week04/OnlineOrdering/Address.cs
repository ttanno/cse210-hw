public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state_Or_province;
    private string _country;
    public Address(string streetAddress, string city, string state_Or_province, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state_Or_province = state_Or_province;
        _country = country;
    }
    public bool inUSA()
    {
        string countryM = _country.ToUpper();
        if (countryM == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void DisplayAddress()
    {
        Console.WriteLine($"Country: {_country} - State/Province: {_state_Or_province} - City: {_city} - Street Address: {_streetAddress}");
    }
}