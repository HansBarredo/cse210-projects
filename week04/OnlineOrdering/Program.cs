using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();


        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1, 1000));
        order1.AddProduct(new Product("Mouse", 102, 2, 25));
        orders.Add(order1);

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", 103, 1, 50));
        order2.AddProduct(new Product("Monitor", 104, 1, 200));
        orders.Add(order2);

        foreach (var order in orders)
        {
            Console.WriteLine(order.DisplayPackingLabel());
            Console.WriteLine(order.DisplayShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
            Console.WriteLine(new string('-', 40));
        }
    }
}