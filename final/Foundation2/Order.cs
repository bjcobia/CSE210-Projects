public class Order
{
    private List<Product> _products;
    public Customer _customer { get; }

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
            packingLabel += $"Product: {product._name}, ID: {product._productId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        var customerAddress = _customer._address;
        return $"Name: {_customer._name}\n{customerAddress.GetFullAddress()}";
    }
}