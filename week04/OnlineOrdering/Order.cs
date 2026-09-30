using System;
public class Order
{
    public Customer _customer { get; set; }
    public List<Product> _products { get; set; }

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalPrice();
        }
        
        if (_customer.IsInUSA())   //if costumer is in USA, cost is $5, otherwise it is $35
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        
        return totalCost;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("");
        Console.WriteLine(" < Packing Label > ");
        foreach (var product in _products)
        {
            Console.WriteLine($"Product: {product._name}, Product ID: {product._productId}");
        }
    }  

    public void GetShippingLabel()
    {
        Console.WriteLine("");
        Console.WriteLine(" < Shipping Label > ");
        _customer.DisplayCustomerInfo();

    }


    public void DisplayOrderDetails()
    {
        Console.WriteLine(" « Order Details » ");
        GetPackingLabel();
        GetShippingLabel();
        if (_customer.IsInUSA())
        {
            Console.WriteLine("Shipping Cost: $5");
        }
        else
        {
            Console.WriteLine("Shipping Cost: $35");
        }
        Console.WriteLine($"Total Cost: ${GetTotalCost()}");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("");
    }
}