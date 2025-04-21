using System;
using System.Linq;
using System.Windows.Forms;
using OrderApp;

namespace OrderForm
{
    public partial class FormEdit : Form
    {
        private readonly OrderService _orderService;
        public bool EditModel { get; set; }

        public Order CurrentOrder { get; set; }
        public event Action<FormEdit> CloseEditFrom;

        public FormEdit(Order order, bool model, OrderService orderService)
        {
            InitializeComponent();
            using (var ctx = new OrderContext())
            {
                bdsCustomers.DataSource = ctx.Customers.ToList();
            }

            _orderService = orderService;
            EditModel = model;

            CurrentOrder = order;
            bdsOrders.DataSource = CurrentOrder;

            txtOrderId.Enabled = !model;
            if (!model)
            {
                CurrentOrder.Customer = (Customer)bdsCustomers.Current;
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            var formItemEdit = new FormDetailEdit(new OrderDetail());
            try
            {
                if (formItemEdit.ShowDialog() == DialogResult.OK)
                {
                    var index = 0;
                    if (CurrentOrder.Details.Count != 0)
                    {
                        index = CurrentOrder.Details.Max(i => i.Index) + 1;
                    }

                    formItemEdit.Detail.Index = index;
                    CurrentOrder.AddDetail(formItemEdit.Detail);
                    bdsDetails.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditModel)
                {
                    _orderService.UpdateOrder(CurrentOrder);
                }
                else
                {
                    _orderService.AddOrder(CurrentOrder);
                }

                CloseEditFrom?.Invoke(this);
            }
            catch (Exception e3)
            {
                if (e3.InnerException != null) MessageBox.Show(e3.InnerException.Message);
            }
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            EditDetail();
        }

        private void dgvItems_DoubleClick(object sender, EventArgs e)
        {
            EditDetail();
        }

        private void EditDetail()
        {
            if (!(bdsDetails.Current is OrderDetail detail))
            {
                MessageBox.Show(@"Please choose an order detail to modify");
                return;
            }

            var formDetailEdit = new FormDetailEdit(detail);
            if (formDetailEdit.ShowDialog() == DialogResult.OK)
            {
                bdsDetails.ResetBindings(false);
            }
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (!(bdsDetails.Current is OrderDetail detail))
            {
                MessageBox.Show(@"Please choose an order detail to delete");
                return;
            }

            CurrentOrder.RemoveDetail(detail);
            bdsDetails.ResetBindings(false);
        }
    }
}