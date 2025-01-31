using System.Security.Cryptography.X509Certificates;

class Product
{
    private string _name;
    private int _id;
    private int _quantity;
    private double _price;

    public Product(string name, int id, int quantity, double price)
    {
        _name = name;
        _id = id;
        _quantity = quantity;
        _price = price;
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }

    public string GetPackingLabel()
    {
        return $"{_name} Product ID: {_id}";
    }
}