namespace Assignment5_1;

internal static class Program
{
    private static readonly OrderService Service = new();

    public static void Main()
    {
        AddOrder("Apple", "Allen", 10);
        AddOrder("Orange", "Fred", 20);
        AddOrder("Banana", "Tom", 15);
        AddOrder("Apple", "Allen", 10);
        AddOrder("Orange", "Alice", 30);

        var list = Service.SearchOrders(x => x.Details.Amount >= 15);
        Console.WriteLine("Orders with amount >= 15:");
        foreach (var order in list)
        {
            Console.WriteLine(order);
        }

        DeleteOrderByProduct("Orange");
        DeleteOrderByCustomer("Tom");
        Console.WriteLine("All the orders present:");
        foreach (var order in Service)
        {
            Console.WriteLine(order);
        }

        AddOrder("Pear", "Bob", 30);
        AddOrder("Grape", "Fred", 25);
        Console.WriteLine("Sorting orders by amount...");
        Service.SortOrders((x, y) => x.Details.Amount - y.Details.Amount);
        Console.WriteLine("All the orders present:");
        foreach (var order in Service)
        {
            Console.WriteLine(order);
        }

        Console.WriteLine("Sorting orders by serial number...");
        Service.SortOrders();
        Console.WriteLine("All the orders present:");
        foreach (var order in Service)
        {
            Console.WriteLine(order);
        }
    }

    private static void AddOrder(string product, string customer, int amount)
    {
        var state = Service.AddOrder(product, customer, amount);
        switch (state)
        {
            case OrderService.OperationSuccessful:
                Console.WriteLine("Add order successful");
                break;
            case OrderService.OperationFailed:
                Console.WriteLine("The order already exists");
                break;
        }
    }

    private static void DeleteOrderByProduct(string product)
    {
        var number = Service.DeleteOrderByProduct(product);
        Console.WriteLine($"Deleted {number} orders");
    }

    private static void DeleteOrderByCustomer(string customer)
    {
        var number = Service.DeleteOrderByCustomer(customer);
        Console.WriteLine($"Deleted {number} orders");
    }
}