using System;
using System.Linq;
using System.Windows.Forms;
using OrderApp;

namespace OrderForm
{
    public partial class FormDetailEdit : Form
    {
        public OrderDetail Detail { get; set; }

        public FormDetailEdit()
        {
            InitializeComponent();
        }

        public FormDetailEdit(OrderDetail detail) : this()
        {
            Detail = detail;
            bdsDetail.DataSource = detail;
            using (var ctx = new OrderContext())
            {
                bdsGoods.DataSource = ctx.Goods.ToList();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
        }
    }
}