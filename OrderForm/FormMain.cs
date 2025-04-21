using System;
using System.Windows.Forms;
using OrderApp;

namespace OrderForm
{
    public partial class FormMain : Form
    {
        private readonly OrderService _orderService;
        public event Action<FormEdit> ShowEditForm;
        public string Keyword { get; set; }

        public FormMain()
        {
            InitializeComponent();
            _orderService = new OrderService();
            bdsOrders.DataSource = _orderService.Orders;
            cbxField.SelectedIndex = 0;
            txtKeyword.DataBindings.Add("Text", this, "Keyword");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var formEdit = new FormEdit(new Order(), false, _orderService);
            ShowEditForm?.Invoke(formEdit);
        }

        public void QueryAll()
        {
            bdsOrders.DataSource = _orderService.Orders;
            bdsOrders.ResetBindings(false);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            EditOrder();
        }

        private void dbvOrders_DoubleClick(object sender, EventArgs e)
        {
            EditOrder();
        }

        private void EditOrder()
        {
            if (!(bdsOrders.Current is Order order))
            {
                MessageBox.Show(@"Please choose an order to modify");
                return;
            }

            var form2 = new FormEdit(order, true, _orderService);
            ShowEditForm?.Invoke(form2);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var order = bdsOrders.Current as Order;
            if (order == null)
            {
                MessageBox.Show(@"Please choose an order to delete");
                return;
            }

            _orderService.RemoveOrder(order.OrderId);
            QueryAll();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                var fileName = saveFileDialog1.FileName;
                _orderService.Export(fileName);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                var fileName = openFileDialog1.FileName;
                _orderService.Import(fileName);
                QueryAll();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cbxField.SelectedIndex)
            {
                case 0: //所有订单
                    bdsOrders.DataSource = _orderService.Orders;
                    break;
                case 1: //根据ID查询
                    bdsOrders.DataSource = _orderService.GetOrder(Keyword);
                    break;
                case 2: //根据客户查询
                    bdsOrders.DataSource = _orderService.QueryOrdersByCustomerName(Keyword);
                    break;
                case 3: //根据货物查询
                    bdsOrders.DataSource = _orderService.QueryOrdersByProductName(Keyword);
                    break;
                case 4: //根据总价格查询（大于某个总价）
                    float.TryParse(Keyword, out var totalPrice);
                    bdsOrders.DataSource =
                        _orderService.QueryByTotalPrice(totalPrice);
                    break;
            }

            bdsOrders.ResetBindings(false);
        }
    }
}