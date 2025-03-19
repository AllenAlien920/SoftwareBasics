using Assignment5_1;

namespace Assignment6_1;

public partial class OrderForm : Form
{
    public readonly OrderDetails Details;
    private readonly BindingSource _orderDetailsBindingSource = new();

    public OrderForm()
    {
        InitializeComponent();
        InitializeDataBinding();
        Details = new OrderDetails("", "", 0);
    }

    public OrderForm(Order order) : this()
    {
        Details = order.Details;
    }

    private void InitializeDataBinding()
    {
        _orderDetailsBindingSource.DataSource = typeof(OrderDetails);
        dataGridViewOrderDetails.DataSource = _orderDetailsBindingSource;
    }

    private void Save_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Close();
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}