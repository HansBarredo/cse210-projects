using System.Dynamic;

class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order (Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
        
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total+= product.GetTotalCost();
        }
        total += _customer.InUSA() ? 5 : 35;
        return total;
    }

     public string DisplayPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }
        return label;
    }

    public string DisplayShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingLabel();
    }

}