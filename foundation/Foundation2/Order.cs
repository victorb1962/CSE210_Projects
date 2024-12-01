public class Order
{
    public Order(Customer name, Address address)
    {
        _name = name;
        _address = address;
    }

    Customer _name;
    Address _address;

    public List<Product> orderList = new List<Product>();
    int _totalOrderCost = 0;
    
    public void AddOrder(string name, int id, int quantity, int price)
    {
        orderList.Add(new Product(name, id, quantity, price));
    }

    public void PackingLabel()
    {
        Console.WriteLine("\nNew Order\n=========\nPacking Label:");
        foreach (Product order in orderList)
        {
            order.DisplayOrders();
        }
    }

    public void ShippingLabel()
    {
        // Customer name and address
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine($" {_name.GetName()}\n" + $" { _address.CompleteAddress()}");
    }

    public int OverallCost()
    {
        foreach(Product product in orderList)
        {
            _totalOrderCost +=  product.GetProductCost();
        }
        
        if (_address.IsInternational())
        {
            _totalOrderCost += 35;
        }
        else
        {
            _totalOrderCost += 5;
        }
        return _totalOrderCost;
    }

    public void TotalCost()
    {
        Console.WriteLine($"\nTotal Cost: ${_totalOrderCost}");
    }
}