public class Product
{
    public string _name { get; }
    public string _productId { get; }
    public double _pricePerUnit { get; }
    public int _quantity { get; }

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}