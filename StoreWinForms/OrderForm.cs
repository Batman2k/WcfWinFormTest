using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StoreWinForms.StoreService;

namespace StoreWinForms
{
    public partial class OrderForm : Form
    {
        private readonly StoreServiceClient _storeService = new StoreServiceClient();
        private List<OrderItem> _orderItems = new List<OrderItem>();

        public OrderForm()
        {
            InitializeComponent();
            UpdateDataGridArticles();
        }

        private async void UpdateDataGridArticles()
        {
            dataGridViewArticles.DataSource = await _storeService.ReturnAllArticlesAsync();
        }

        private void UpdateDataGridPending()
        {
            dataGridViewPendingArticlesForOrder.DataSource = _orderItems.ToList();
        }
        
        private void buttonAddToPendingOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewArticles.CurrentRow != null)
            {
                var article = (Article) dataGridViewArticles.CurrentRow.DataBoundItem;
                var orderitem = new OrderItem
                {
                    Price = article.Price,
                    ArticleId = article.Articleid
                };

                _orderItems.Add(orderitem);
            }
            UpdateDataGridPending();
        }

        private void UpdateActiveOrderList()
        {
        }

        private async void buttonAddOrder_Click(object sender, EventArgs e)
        {
            var parsedId = 0;
            var order = new Order
            {
                OrdedBy = textBoxOrdedby.Text,
                DeliveryType = textBoxDeliveryType.Text,
                PaymentOption = textBoxPaymentOption.Text,
                OrderDate = DateTime.Now,
                TotalPrice = _orderItems.Sum(o => o.Price)
            };
            int.TryParse(textBoxOrderId.Text, out parsedId);
            order.OrderId = parsedId;

            await _storeService.AddOrUpdateOrderAsync(order, _orderItems);
            _orderItems = new List<OrderItem>();
            UpdateDataGridPending();

            textBoxOrdedby.Text = "";
            textBoxDeliveryType.Text = "";
            textBoxPaymentOption.Text = "";
        }

        private async void buttonUpdateActiveOrders_Click(object sender, EventArgs e)
        {
            dataGridViewActiveOrders.DataSource = await _storeService.ReturnAllActiveOrdersAsync();
        }

        private async void buttonEditOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewActiveOrders.CurrentRow != null)
            {
                var order = (Order)dataGridViewActiveOrders.CurrentRow.DataBoundItem;
                _orderItems = await _storeService.ReturnAllOrderItemsByfkKeyAsync(order.OrderId);
                UpdateDataGridPending();
                textBoxOrderId.Text = order.OrderId.ToString();
                textBoxOrdedby.Text = order.OrdedBy;
                textBoxDeliveryType.Text = order.DeliveryType;
                textBoxPaymentOption.Text = order.PaymentOption;
            }
        }
        private void buttonRemoveArticleFromPendingOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewPendingArticlesForOrder.CurrentRow != null)
                _orderItems.Remove((OrderItem) dataGridViewPendingArticlesForOrder.CurrentRow.DataBoundItem);

            UpdateDataGridPending();
        }
    }
}