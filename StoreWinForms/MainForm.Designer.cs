namespace StoreWinForms
{
    partial class MainForm
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
            this.buttonOpenArticleForm = new System.Windows.Forms.Button();
            this.buttonOpenOrderForm = new System.Windows.Forms.Button();
            this.dataGridViewActiveOrders = new System.Windows.Forms.DataGridView();
            this.buttonShowUserForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOrderSent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenArticleForm
            // 
            this.buttonOpenArticleForm.Location = new System.Drawing.Point(12, 26);
            this.buttonOpenArticleForm.Name = "buttonOpenArticleForm";
            this.buttonOpenArticleForm.Size = new System.Drawing.Size(119, 23);
            this.buttonOpenArticleForm.TabIndex = 0;
            this.buttonOpenArticleForm.Text = "Open articleform";
            this.buttonOpenArticleForm.UseVisualStyleBackColor = true;
            this.buttonOpenArticleForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOpenOrderForm
            // 
            this.buttonOpenOrderForm.Location = new System.Drawing.Point(12, 105);
            this.buttonOpenOrderForm.Name = "buttonOpenOrderForm";
            this.buttonOpenOrderForm.Size = new System.Drawing.Size(119, 23);
            this.buttonOpenOrderForm.TabIndex = 1;
            this.buttonOpenOrderForm.Text = "Open new orderform";
            this.buttonOpenOrderForm.UseVisualStyleBackColor = true;
            this.buttonOpenOrderForm.Click += new System.EventHandler(this.buttonOpenOrderForm_Click);
            // 
            // dataGridViewActiveOrders
            // 
            this.dataGridViewActiveOrders.AllowUserToAddRows = false;
            this.dataGridViewActiveOrders.AllowUserToDeleteRows = false;
            this.dataGridViewActiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveOrders.Location = new System.Drawing.Point(304, 26);
            this.dataGridViewActiveOrders.Name = "dataGridViewActiveOrders";
            this.dataGridViewActiveOrders.ReadOnly = true;
            this.dataGridViewActiveOrders.Size = new System.Drawing.Size(754, 444);
            this.dataGridViewActiveOrders.TabIndex = 2;
            // 
            // buttonShowUserForm
            // 
            this.buttonShowUserForm.Location = new System.Drawing.Point(12, 190);
            this.buttonShowUserForm.Name = "buttonShowUserForm";
            this.buttonShowUserForm.Size = new System.Drawing.Size(119, 23);
            this.buttonShowUserForm.TabIndex = 3;
            this.buttonShowUserForm.Text = "Show userform";
            this.buttonShowUserForm.UseVisualStyleBackColor = true;
            this.buttonShowUserForm.Click += new System.EventHandler(this.buttonShowUserForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Active orders";
            // 
            // buttonOrderSent
            // 
            this.buttonOrderSent.Location = new System.Drawing.Point(304, 476);
            this.buttonOrderSent.Name = "buttonOrderSent";
            this.buttonOrderSent.Size = new System.Drawing.Size(75, 23);
            this.buttonOrderSent.TabIndex = 5;
            this.buttonOrderSent.Text = "Order sent";
            this.buttonOrderSent.UseVisualStyleBackColor = true;
            this.buttonOrderSent.Click += new System.EventHandler(this.buttonOrderSent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 611);
            this.Controls.Add(this.buttonOrderSent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowUserForm);
            this.Controls.Add(this.dataGridViewActiveOrders);
            this.Controls.Add(this.buttonOpenOrderForm);
            this.Controls.Add(this.buttonOpenArticleForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenArticleForm;
        private System.Windows.Forms.Button buttonOpenOrderForm;
        private System.Windows.Forms.DataGridView dataGridViewActiveOrders;
        private System.Windows.Forms.Button buttonShowUserForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOrderSent;
    }
}

