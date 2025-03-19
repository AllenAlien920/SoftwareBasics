namespace Assignment5_1;

public class Order
{
    private static int _totalOrderNumber;
    public int SerialNumber { get; }
    public OrderDetails Details { get; }

    public Order(OrderDetails details)
    {
        SerialNumber = _totalOrderNumber++;
        Details = details;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Order order)
        {
            return SerialNumber == order.SerialNumber && Details.Equals(order.Details);
        }

        return false;
    }

    public override int GetHashCode()
    {
        return (SerialNumber.GetHashCode() << 16) ^ Details.GetHashCode();
    }

    public override string ToString()
    {
        return $"Order No.{SerialNumber}: {Details}";
    }
}

public class OrderDetails(string productName, string customer, int amount)
{
    public string ProductName { get; } = productName;
    public string Customer { get; } = customer;
    public int Amount { get; } = amount;

    public override bool Equals(object? obj)
    {
        if (obj is OrderDetails details)
        {
            return ProductName == details.ProductName && Customer == details.Customer && Amount == details.Amount;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return (ProductName.GetHashCode() << 16) ^ (Customer.GetHashCode() << 8) ^ Amount.GetHashCode();
    }

    public override string ToString()
    {
        return $"Product Name: {ProductName}, Customer: {Customer}, Amount: {Amount}";
    }
}