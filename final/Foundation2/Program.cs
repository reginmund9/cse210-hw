using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("Caracollo St", "El Alto", "La Paz", "Bolivia");
        Customer customer1 = new Customer("Marlene Ramirez", address1);
        List<Product> productsList1 = new List<Product>();

        Product p001 = new Product("Headphones", "H100", 3.99, 4);
        Product p002 = new Product("Keyboard", "K110", 5.50, 2);
        Product p003 = new Product("Computer speaker", "CS120", 6.99, 2);

        productsList1.Add(p001);
        productsList1.Add(p002);
        productsList1.Add(p003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order 1");
        order1.DisplayResult();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("1712 Romines Mill Road", "Dallas", "TX 75207", "USA");
        Customer customer2 = new Customer("Bruce Williams", address2);
        List<Product> productsList2 = new List<Product>();

        Product p010 = new Product("Wireless Car Charger", "WCC200", 29, 1);
        Product p011 = new Product("wireless CarPlay Screen", "WCS210", 105, 1);
        Product p012 = new Product("Smart Dash Cam", "SDC220", 39, 1);

        productsList2.Add(p010);
        productsList2.Add(p011);
        productsList2.Add(p012);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order 2");
        order2.DisplayResult();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("2269 Dogwood Lane", "Tucson", "AZ 85701", "USA");
        Customer customer3 = new Customer("Elizabeth Clayson", address3);
        List<Product> productsList3 = new List<Product>();

        Product p020 = new Product("Wallet", "W300", 5.99, 2);
        Product p021 = new Product("Necklance", "N310", 8.99, 2);

        productsList3.Add(p020);
        productsList3.Add(p021);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order 3");
        order3.DisplayResult();
        Console.WriteLine();
    }
}

