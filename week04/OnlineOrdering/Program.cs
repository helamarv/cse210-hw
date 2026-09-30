using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        // Create an address for the customer
        Address customerAddress = new Address("123 Main St", "Anytown", "CA", "USA");

        // Create a customer with the address
        Customer customer = new Customer("John Doe", customerAddress);

        // Create an order for the customer
        Order order = new Order(customer);


        // Create some products
        Product product1 = new Product("Widget", "W123", 19.99, 2);
        Product product2 = new Product("Gadget", "G456", 29.99, 1);

        // Add products to the order
        order.AddProduct(product1);         
        order.AddProduct(product2); 

        // Display order details
        order.DisplayOrderDetails();


        //Second order for a customer outside the USA
        Address customerAddress2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", customerAddress2);  
        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);
        order2.DisplayOrderDetails();

    }
}