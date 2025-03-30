public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products= products;
        _customer = customer;
    }
    public float calculateTotalCost()
    {
        float sum = 0;
        foreach (Product product in _products)
        {
            sum += product.TotalCost();
        }
        if (_customer.AddressInUSA() == true)
        {
            return sum + 5;//lives in USA
        }
        else
        {
            return sum + 35;//Does not live in USA
        }
    }
    public void CreatePackingLabel()
    {
        Console.WriteLine("Displaying packing label");
        Console.WriteLine("List of products:");
        Console.WriteLine("Name:\t-\tProductID:");
        foreach (Product product in _products)
        {
            product.DisplayP();
        }
    }
    public void CreateShippingLabel()
    {
        Console.WriteLine("Displaying shipping label");
        _customer.DisplayName();
    }
}