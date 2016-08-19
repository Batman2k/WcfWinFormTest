using System;
using System.Windows.Forms;
using StoreWinForms.StoreService;

namespace StoreWinForms
{
    public partial class MainForm : Form
    {
        private readonly StoreServiceClient _storeService = new StoreServiceClient();

        public MainForm()
        {
            InitializeComponent();
            UpdateActiveOrderList();


        }

        private async void UpdateActiveOrderList()
        {
            dataGridViewActiveOrders.DataSource = await _storeService.ReturnAllActiveOrdersAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var arcticleForm = new ArticleForm();
            Enabled = false;
            arcticleForm.ShowDialog();
            Enabled = true;
        }

        private void buttonOpenOrderForm_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm();
            Enabled = false;
            orderForm.ShowDialog();
            Enabled = true;
        }
        
        private async void buttonOrderSent_Click(object sender, EventArgs e)
        {
            if (dataGridViewActiveOrders.CurrentRow != null)
            {
                var sendOrder = (Order) dataGridViewActiveOrders.CurrentRow.DataBoundItem;
                await _storeService.UpdateOrderToSentAsync(sendOrder);
            }
            UpdateActiveOrderList();
        }

        private void buttonShowUserForm_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            Enabled = false;
            userForm.ShowDialog();
            Enabled = true;
        }
    }
}