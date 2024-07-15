using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Hwy 90 East", "Castroville", "Tx", "USA");
        Customer customer = new Customer("Mr. Michael Haby", address);

        Product product1 = new Product("Freshie", 1, 9.99f, 5);
        Product product2 = new Product("Air Freshener", 2, 4.99f, 3);

        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine();

        Address address2 = new Address("2 Selby Ave", "Région de Beauce", "QC", "Canada");
        Customer customer2 = new Customer("Prince Gilbert", address2);

        Product product3 = new Product("Aspirin", 3, 2.99f, 2);
        Product product4 = new Product("Excedrin", 4, 5.99f, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine();
    }
}



