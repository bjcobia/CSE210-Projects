public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.CalculateTotalCost();
        }
        totalCost += _customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in _products)
        {
            packingLabel += $"Product: {product.GetName()}, ID: {product.GetProductId()}\n"; 
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        var customerAddress = _customer.GetAddress();
        return $"Name: {_customer.GetName()}\n{customerAddress.GetFullAddress()}";
    }
}
