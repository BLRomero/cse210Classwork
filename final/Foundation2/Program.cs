using System;

class Program
{
    static void Main(string[] args)
    {
        // Your program logic goes here

        // Example: Creating an instance of Order and performing operations
        Address address = new Address("123 Hwy 90 East", "Castroville", "Tx", "USA");
        Customer customer = new Customer("M Haby", address);

        Product product1 = new Product("Freshie", 1, 9.99f, 5);
        Product product2 = new Product("Air Freshener", 2, 4.99f, 3);

        Order order = new Order(customer);
        order.addProduct(product1);
        order.addProduct(product2);

        Console.WriteLine(order.getPackingLabel());
        Console.WriteLine(order.getShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order.calculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine();

    }
}



