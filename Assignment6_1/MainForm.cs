using Assignment5_1;

namespace Assignment6_1;

public partial class MainForm : Form
{
    private readonly OrderService _orderService = new();
    private readonly BindingSource _ordersBindingSource = new();

    public MainForm()
    {
        InitializeComponent();
        InitializeDataBinding();
        LoadOrders();
    }

    private void InitializeDataBinding()
    {
        _ordersBindingSource.DataSource = typeof(Order);
        dataGridViewOrders.DataSource = _ordersBindingSource;
    }

    private void LoadOrders()
    {
        _ordersBindingSource.DataSource = _orderService.GetOrders();
    }

    private void Add_Click(object sender, EventArgs e)
    {
        var orderForm = new OrderForm();
        if (orderForm.ShowDialog() == DialogResult.OK)
        {
            _orderService.AddOrder(orderForm.Details);
            LoadOrders();
        }
    }

    private void Delete_Click(object sender, EventArgs e)
    {
        if (_ordersBindingSource.Current is Order selectedOrder)
        {
            _orderService.DeleteOrder(selectedOrder.SerialNumber);
            LoadOrders();
        }
    }

    private void Modify_Click(object sender, EventArgs e)
    {
        if (_ordersBindingSource.Current is Order selectedOrder)
        {
            var orderForm = new OrderForm(selectedOrder);
            var previousSerial = selectedOrder.SerialNumber;
            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                _orderService.DeleteOrder(previousSerial);
                _orderService.AddOrder(orderForm.Details);
                LoadOrders();
            }
        }
    }

    private void Search_Click(object sender, EventArgs e)
    {
        List<Order> result;
        var text = textBox.Text;
        switch (SearchComboBox.SelectedItem)
        {
            case "Product":
                result = _orderService.SearchOrdersByProduct(text);
                break;
            case "Customer":
                result = _orderService.SearchOrdersByCustomer(text);
                break;
            default:
                throw new ArgumentException("Unrecognized Option");
        }

        _ordersBindingSource.DataSource = result;
    }
}