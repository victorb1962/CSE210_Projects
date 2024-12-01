using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Address address1 = new Address("14194 S Redwood Rd", "Riverton", "Utah", "USA");
        Customer customer1 = new Customer("Victor Boxall", address1);
        address1.CompleteAddress();
        Order order = new Order(customer1, address1);
        order.AddOrder("Freeze Dried Gummy Bears", 5019001, 4, 8);
        order.AddOrder("Freeze Dried Cookie Dough", 5019002, 2, 7);
        order.PackingLabel();
        order.ShippingLabel();
        order.OverallCost();
        order.TotalCost();

        Address address2 = new Address("269 Belle Vue Ln", "Sugar Grove", "Illinois", "USA");
        Customer customer2 = new Customer("Ruth Johnston", address2);
        address2.CompleteAddress();
        Order order2 = new Order(customer2, address2);
        order2.AddOrder("BBQ Maple Honey Glaze", 123456, 2, 10);
        order2.AddOrder("Steak & Brisket Rub", 123901, 1, 11);
        order2.AddOrder("BBQ Pellets, Hickory, 20lb", 123803, 4, 15);
        order2.PackingLabel();
        order2.ShippingLabel();
        order2.OverallCost();
        order2.TotalCost();

        Address address3 = new Address("547 Mt Albert Rd", "Mt Roskill", "Auckland", "NZ");
        Customer customer3 = new Customer("George Donnelly", address3);
        address3.CompleteAddress();
        Order order3 = new Order(customer3, address3);
        order3.AddOrder("UA Utah Utes Baseball Jersey", 9001001, 1, 63);
        order3.PackingLabel();
        order3.ShippingLabel();
        order3.OverallCost();
        order3.TotalCost();
    }
}