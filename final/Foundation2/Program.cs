using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.SetName("Libby Dodson");
        order1.SetAddress("9th Street", "Ogden", "Utah", "USA");

        Product product1 = new Product("Cake", "001", 9.50, 5);
        Product product2 = new Product("Bagged chesse", "002", 4.85, 3);
        Product product3 = new Product("Garbage bags", "003", 7.89, 1);

        order1.AddList(product1);
        order1.AddList(product2);
        order1.AddList(product3);

        Order order2 = new Order();
        order2.SetName("Rone Dodson");
        order2.SetAddress("Wheatland court", "Cininati", "Ohio", "USA");

        Product product4 = new Product("Ipad", "009", 1000.00, 1);
        Product product5 = new Product("Samsung TV", "015", 846.74, 1);
        Product product6 = new Product("Headphone", "007", 59.08, 1);

        order2.AddList(product4);
        order2.AddList(product5);
        order2.AddList(product6);

        Console.WriteLine("Order 1:");

        Console.WriteLine($"Packing Label\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order1.GetTotal()}");

        Console.WriteLine("Order 2:");

        Console.WriteLine($"Packing Label\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order2.GetTotal()}");


    }
}