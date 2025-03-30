public class Product
{
    private string _name;
    private int _productID;
    private float _price;
    private int _quantity;
    public Product(string name, int productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public float TotalCost()
    {
        return _price * _quantity;
    }
    public void DisplayP()
    {
        Console.WriteLine($"{_name}\t-\t{_productID}\n");
    }
}