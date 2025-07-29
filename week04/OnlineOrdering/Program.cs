using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("138 Block St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("Steve Rogers", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Shield", "S001", 150.0f, 1));
        order1.AddProduct(new Product("Helmet", "H002", 75.0f, 2));

        Address address2 = new Address("Mariscal Cáceres C8", "Cajamarca", "Cajamarca", "Peru");
        Customer customer2 = new Customer("Jorge Luis", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop", "L003", 800.0f, 1));
        order2.AddProduct(new Product("Mouse", "M004", 25.0f, 2));

        ShowOrder(order1);
        Console.WriteLine();
        ShowOrder(order2);
    }

    static void ShowOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order.GetTotalCost()}");
    }
}