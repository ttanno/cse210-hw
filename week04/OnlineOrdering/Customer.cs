public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public void DisplayName()
    {
        Console.WriteLine($"Customer: {_name}\nFrom:");
        _address.DisplayAddress();
    }
    public bool AddressInUSA()
    {
        bool USACustomer = _address.inUSA();
        return USACustomer;
    }
}