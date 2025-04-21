using System;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class FormParent : Form
    {
        private readonly FormMain _formMain = new FormMain();

        public FormParent()
        {
            InitializeComponent();
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            _formMain.ShowEditForm += ShowEditForm;
            ShowOrderForm();
        }


        private void ShowOrderForm()
        {
            orderMainLink.Enabled = false;
            orderEditLink.Visible = false;
            seperatorLabel.Visible = false;
            ShowFormInPanel(_formMain);
            _formMain.QueryAll();
        }

        private void ShowEditForm(FormEdit formEdit)
        {
            orderMainLink.Enabled = true;
            orderEditLink.Visible = true;
            seperatorLabel.Visible = true;
            orderEditLink.Text = formEdit.EditModel ? "Modify order" : "Add order";
            formEdit.CloseEditFrom += form => ShowOrderForm();
            ShowFormInPanel(formEdit);
        }

        private void ShowFormInPanel(Form form)
        {
            contentPanel.SuspendLayout();
            contentPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;
            contentPanel.Controls.Add(form);
            contentPanel.ResumeLayout();
        }

        private void orderMainLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowOrderForm();
        }
    }
}