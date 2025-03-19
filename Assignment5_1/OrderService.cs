using System.Collections;

namespace Assignment5_1;

public class OrderService : IEnumerable<Order>
{
    private readonly List<Order> _orders = [];
    public const int OperationSuccessful = 0;
    public const int OperationFailed = 1;

    public List<Order> GetOrders()
    {
        return _orders;
    }

    public int AddOrder(OrderDetails detail)
    {
        if (_orders.Any(order => order.Details.Equals(detail)))
        {
            return OperationFailed;
        }

        _orders.Add(new Order(detail));
        return OperationSuccessful;
    }

    public int AddOrder(string product, string customer, int amount)
    {
        var orderDetail = new OrderDetails(product, customer, amount);
        if (_orders.Any(order => order.Details.Equals(orderDetail)))
        {
            return OperationFailed;
        }

        _orders.Add(new Order(orderDetail));
        return OperationSuccessful;
    }

    public int DeleteOrder(int serial)
    {
        foreach (var order in _orders.Where(order => order.SerialNumber == serial))
        {
            _orders.Remove(order);
            return OperationSuccessful;
        }

        return OperationFailed;
    }

    public int DeleteOrderByProduct(string product)
    {
        var deleteNumber = 0;
        foreach (var order in _orders.Where(order => order.Details.ProductName == product).ToList())
        {
            deleteNumber++;
            _orders.Remove(order);
        }

        return deleteNumber;
    }

    public int DeleteOrderByCustomer(string customer)
    {
        var deleteNumber = 0;
        foreach (var order in _orders.Where(order => order.Details.Customer == customer).ToList())
        {
            deleteNumber++;
            _orders.Remove(order);
        }

        return deleteNumber;
    }

    public List<Order> SearchOrders(Func<Order, bool> func)
    {
        var orders = _orders.Where(func).ToList();
        orders.Sort((x, y) => x.Details.Amount - y.Details.Amount);
        return orders;
    }

    public List<Order> SearchOrdersByProduct(string product)
    {
        return _orders.Where(order => order.Details.ProductName == product).ToList();
    }

    public List<Order> SearchOrdersByCustomer(string customer)
    {
        return _orders.Where(order => order.Details.Customer == customer).ToList();
    }

    public void SortOrders()
    {
        SortOrders((x, y) => x.SerialNumber - y.SerialNumber);
    }

    public void SortOrders(Func<Order, Order, int> func)
    {
        _orders.Sort((x, y) => func(x, y));
    }

    public IEnumerator<Order> GetEnumerator()
    {
        return ((IEnumerable<Order>)_orders).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}