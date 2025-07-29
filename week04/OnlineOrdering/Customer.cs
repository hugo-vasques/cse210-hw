public class Customer
{
    public string Name { get; set; }
    private Address _address;

    public Customer(string name, Address address)
    {
        Name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetShippingAddress()
    {
        return _address.GetFullAddress();
    }
}