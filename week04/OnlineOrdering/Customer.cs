class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }

    public string GetShippingLabel()
    {
        return $"Name: {_name} \nAddress: {_address.ToString()}";
    }
}