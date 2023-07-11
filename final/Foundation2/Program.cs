using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("IDC Area", "Ibadan", "Oyo", "Nigeria", 213342);
        Customer customer1 = new Customer("John Carter", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Belt", 121442, 9.99f, 2),
            new Product("Pants", 121556, 11.99f, 3),
            new Product("Nike Shoes", 124221, 49.99f, 1)
        };
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("Eheneden", "Benin", "Edo", "NG", 310010);
        Customer customer2 = new Customer("Josh Groovie", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Snickers", 214777, 74.99f, 1),
            new Product("Dress", 317698, 19.49f, 1),
            new Product("Shoes", 439010, 40.00f, 2)
        };
        Order order2 = new Order(customer2, products2);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine("");
            order.CreatePackingSlip();
            Console.WriteLine("");
            Console.WriteLine($"Your shipping is: ${order.CalculateShipping()}.00");
            Console.WriteLine(
                $"Your total is: ${Math.Round(order.CalculateTotalPrice(), 2)}"
            );
            Console.WriteLine("");
            order.CreateShippingSlip();
            Console.WriteLine("");
        }
    }
}
