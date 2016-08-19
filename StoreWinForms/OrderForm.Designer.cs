namespace StoreWinForms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.dataGridViewPendingArticlesForOrder = new System.Windows.Forms.DataGridView();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonAddToPendingOrder = new System.Windows.Forms.Button();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.textBoxOrdedby = new System.Windows.Forms.TextBox();
            this.textBoxDeliveryType = new System.Windows.Forms.TextBox();
            this.textBoxPaymentOption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewActiveOrders = new System.Windows.Forms.DataGridView();
            this.buttonRemoveArticleFromPendingOrder = new System.Windows.Forms.Button();
            this.buttonEditOrder = new System.Windows.Forms.Button();
            this.buttonUpdateActiveOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingArticlesForOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.AllowUserToAddRows = false;
            this.dataGridViewArticles.AllowUserToDeleteRows = false;
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Location = new System.Drawing.Point(936, 12);
            this.dataGridViewArticles.MultiSelect = false;
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.ReadOnly = true;
            this.dataGridViewArticles.Size = new System.Drawing.Size(685, 343);
            this.dataGridViewArticles.TabIndex = 18;
            // 
            // dataGridViewPendingArticlesForOrder
            // 
            this.dataGridViewPendingArticlesForOrder.AllowUserToAddRows = false;
            this.dataGridViewPendingArticlesForOrder.AllowUserToDeleteRows = false;
            this.dataGridViewPendingArticlesForOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendingArticlesForOrder.Location = new System.Drawing.Point(308, 12);
            this.dataGridViewPendingArticlesForOrder.MultiSelect = false;
            this.dataGridViewPendingArticlesForOrder.Name = "dataGridViewPendingArticlesForOrder";
            this.dataGridViewPendingArticlesForOrder.ReadOnly = true;
            this.dataGridViewPendingArticlesForOrder.Size = new System.Drawing.Size(528, 343);
            this.dataGridViewPendingArticlesForOrder.TabIndex = 19;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(227, 335);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(75, 20);
            this.buttonAddOrder.TabIndex = 20;
            this.buttonAddOrder.Text = "Add order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonAddToPendingOrder
            // 
            this.buttonAddToPendingOrder.Location = new System.Drawing.Point(842, 12);
            this.buttonAddToPendingOrder.Name = "buttonAddToPendingOrder";
            this.buttonAddToPendingOrder.Size = new System.Drawing.Size(75, 20);
            this.buttonAddToPendingOrder.TabIndex = 21;
            this.buttonAddToPendingOrder.Text = "Add article";
            this.buttonAddToPendingOrder.UseVisualStyleBackColor = true;
            this.buttonAddToPendingOrder.Click += new System.EventHandler(this.buttonAddToPendingOrder_Click);
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(202, 12);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderId.TabIndex = 22;
            // 
            // textBoxOrdedby
            // 
            this.textBoxOrdedby.Location = new System.Drawing.Point(202, 38);
            this.textBoxOrdedby.Name = "textBoxOrdedby";
            this.textBoxOrdedby.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrdedby.TabIndex = 23;
            // 
            // textBoxDeliveryType
            // 
            this.textBoxDeliveryType.Location = new System.Drawing.Point(202, 64);
            this.textBoxDeliveryType.Name = "textBoxDeliveryType";
            this.textBoxDeliveryType.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeliveryType.TabIndex = 24;
            // 
            // textBoxPaymentOption
            // 
            this.textBoxPaymentOption.Location = new System.Drawing.Point(202, 90);
            this.textBoxPaymentOption.Name = "textBoxPaymentOption";
            this.textBoxPaymentOption.Size = new System.Drawing.Size(100, 20);
            this.textBoxPaymentOption.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Order id leave blank if new";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Orded by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Delivery type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Payment Option";
            // 
            // dataGridViewActiveOrders
            // 
            this.dataGridViewActiveOrders.AllowUserToAddRows = false;
            this.dataGridViewActiveOrders.AllowUserToDeleteRows = false;
            this.dataGridViewActiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveOrders.Location = new System.Drawing.Point(936, 381);
            this.dataGridViewActiveOrders.MultiSelect = false;
            this.dataGridViewActiveOrders.Name = "dataGridViewActiveOrders";
            this.dataGridViewActiveOrders.ReadOnly = true;
            this.dataGridViewActiveOrders.Size = new System.Drawing.Size(685, 373);
            this.dataGridViewActiveOrders.TabIndex = 30;
            // 
            // buttonRemoveArticleFromPendingOrder
            // 
            this.buttonRemoveArticleFromPendingOrder.Location = new System.Drawing.Point(842, 334);
            this.buttonRemoveArticleFromPendingOrder.Name = "buttonRemoveArticleFromPendingOrder";
            this.buttonRemoveArticleFromPendingOrder.Size = new System.Drawing.Size(88, 23);
            this.buttonRemoveArticleFromPendingOrder.TabIndex = 31;
            this.buttonRemoveArticleFromPendingOrder.Text = "Remove article";
            this.buttonRemoveArticleFromPendingOrder.UseVisualStyleBackColor = true;
            this.buttonRemoveArticleFromPendingOrder.Click += new System.EventHandler(this.buttonRemoveArticleFromPendingOrder_Click);
            // 
            // buttonEditOrder
            // 
            this.buttonEditOrder.Location = new System.Drawing.Point(855, 731);
            this.buttonEditOrder.Name = "buttonEditOrder";
            this.buttonEditOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonEditOrder.TabIndex = 32;
            this.buttonEditOrder.Text = "Edit Order";
            this.buttonEditOrder.UseVisualStyleBackColor = true;
            this.buttonEditOrder.Click += new System.EventHandler(this.buttonEditOrder_Click);
            // 
            // buttonUpdateActiveOrders
            // 
            this.buttonUpdateActiveOrders.Location = new System.Drawing.Point(808, 509);
            this.buttonUpdateActiveOrders.Name = "buttonUpdateActiveOrders";
            this.buttonUpdateActiveOrders.Size = new System.Drawing.Size(122, 23);
            this.buttonUpdateActiveOrders.TabIndex = 33;
            this.buttonUpdateActiveOrders.Text = "Update active orders";
            this.buttonUpdateActiveOrders.UseVisualStyleBackColor = true;
            this.buttonUpdateActiveOrders.Click += new System.EventHandler(this.buttonUpdateActiveOrders_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 775);
            this.Controls.Add(this.buttonUpdateActiveOrders);
            this.Controls.Add(this.buttonEditOrder);
            this.Controls.Add(this.buttonRemoveArticleFromPendingOrder);
            this.Controls.Add(this.dataGridViewActiveOrders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPaymentOption);
            this.Controls.Add(this.textBoxDeliveryType);
            this.Controls.Add(this.textBoxOrdedby);
            this.Controls.Add(this.textBoxOrderId);
            this.Controls.Add(this.buttonAddToPendingOrder);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.dataGridViewPendingArticlesForOrder);
            this.Controls.Add(this.dataGridViewArticles);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendingArticlesForOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArticles;
        private System.Windows.Forms.DataGridView dataGridViewPendingArticlesForOrder;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonAddToPendingOrder;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.TextBox textBoxOrdedby;
        private System.Windows.Forms.TextBox textBoxDeliveryType;
        private System.Windows.Forms.TextBox textBoxPaymentOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewActiveOrders;
        private System.Windows.Forms.Button buttonRemoveArticleFromPendingOrder;
        private System.Windows.Forms.Button buttonEditOrder;
        private System.Windows.Forms.Button buttonUpdateActiveOrders;
    }
}