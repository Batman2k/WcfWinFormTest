namespace StoreWinForms
{
    partial class ArticleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxArticleId = new System.Windows.Forms.TextBox();
            this.textBoxArticleName = new System.Windows.Forms.TextBox();
            this.textBoxArticlePrice = new System.Windows.Forms.TextBox();
            this.textBoxArticleModel = new System.Windows.Forms.TextBox();
            this.textBoxArticleBrand = new System.Windows.Forms.TextBox();
            this.textBoxArticleInformation = new System.Windows.Forms.TextBox();
            this.buttonArticleAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonShowAllArticles = new System.Windows.Forms.Button();
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.buttonEditArticle = new System.Windows.Forms.Button();
            this.buttonRemoveArticle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Brand :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Information";
            // 
            // textBoxArticleId
            // 
            this.textBoxArticleId.Location = new System.Drawing.Point(92, 68);
            this.textBoxArticleId.Name = "textBoxArticleId";
            this.textBoxArticleId.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticleId.TabIndex = 6;
            // 
            // textBoxArticleName
            // 
            this.textBoxArticleName.Location = new System.Drawing.Point(92, 105);
            this.textBoxArticleName.Name = "textBoxArticleName";
            this.textBoxArticleName.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticleName.TabIndex = 7;
            // 
            // textBoxArticlePrice
            // 
            this.textBoxArticlePrice.Location = new System.Drawing.Point(92, 147);
            this.textBoxArticlePrice.Name = "textBoxArticlePrice";
            this.textBoxArticlePrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticlePrice.TabIndex = 8;
            // 
            // textBoxArticleModel
            // 
            this.textBoxArticleModel.Location = new System.Drawing.Point(92, 184);
            this.textBoxArticleModel.Name = "textBoxArticleModel";
            this.textBoxArticleModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticleModel.TabIndex = 9;
            // 
            // textBoxArticleBrand
            // 
            this.textBoxArticleBrand.Location = new System.Drawing.Point(92, 223);
            this.textBoxArticleBrand.Name = "textBoxArticleBrand";
            this.textBoxArticleBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticleBrand.TabIndex = 10;
            // 
            // textBoxArticleInformation
            // 
            this.textBoxArticleInformation.Location = new System.Drawing.Point(92, 255);
            this.textBoxArticleInformation.Name = "textBoxArticleInformation";
            this.textBoxArticleInformation.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticleInformation.TabIndex = 11;
            // 
            // buttonArticleAdd
            // 
            this.buttonArticleAdd.Location = new System.Drawing.Point(11, 321);
            this.buttonArticleAdd.Name = "buttonArticleAdd";
            this.buttonArticleAdd.Size = new System.Drawing.Size(102, 23);
            this.buttonArticleAdd.TabIndex = 12;
            this.buttonArticleAdd.Text = "Add/Save Article";
            this.buttonArticleAdd.UseVisualStyleBackColor = true;
            this.buttonArticleAdd.Click += new System.EventHandler(this.buttonArticleAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Leave id blank if new article";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Articles";
            // 
            // buttonShowAllArticles
            // 
            this.buttonShowAllArticles.Location = new System.Drawing.Point(426, 469);
            this.buttonShowAllArticles.Name = "buttonShowAllArticles";
            this.buttonShowAllArticles.Size = new System.Drawing.Size(108, 23);
            this.buttonShowAllArticles.TabIndex = 16;
            this.buttonShowAllArticles.Text = "Show All Articles";
            this.buttonShowAllArticles.UseVisualStyleBackColor = true;
            this.buttonShowAllArticles.Click += new System.EventHandler(this.buttonShowAllArticles_Click);
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.AllowUserToAddRows = false;
            this.dataGridViewArticles.AllowUserToDeleteRows = false;
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Location = new System.Drawing.Point(426, 68);
            this.dataGridViewArticles.MultiSelect = false;
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.ReadOnly = true;
            this.dataGridViewArticles.Size = new System.Drawing.Size(644, 395);
            this.dataGridViewArticles.TabIndex = 17;
            // 
            // buttonEditArticle
            // 
            this.buttonEditArticle.Location = new System.Drawing.Point(995, 469);
            this.buttonEditArticle.Name = "buttonEditArticle";
            this.buttonEditArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonEditArticle.TabIndex = 18;
            this.buttonEditArticle.Text = "Edit article";
            this.buttonEditArticle.UseVisualStyleBackColor = true;
            this.buttonEditArticle.Click += new System.EventHandler(this.buttonEditArticle_Click);
            // 
            // buttonRemoveArticle
            // 
            this.buttonRemoveArticle.Location = new System.Drawing.Point(705, 468);
            this.buttonRemoveArticle.Name = "buttonRemoveArticle";
            this.buttonRemoveArticle.Size = new System.Drawing.Size(103, 23);
            this.buttonRemoveArticle.TabIndex = 19;
            this.buttonRemoveArticle.Text = "Remove article";
            this.buttonRemoveArticle.UseVisualStyleBackColor = true;
            this.buttonRemoveArticle.Click += new System.EventHandler(this.buttonRemoveArticle_Click);
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 517);
            this.Controls.Add(this.buttonRemoveArticle);
            this.Controls.Add(this.buttonEditArticle);
            this.Controls.Add(this.dataGridViewArticles);
            this.Controls.Add(this.buttonShowAllArticles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonArticleAdd);
            this.Controls.Add(this.textBoxArticleInformation);
            this.Controls.Add(this.textBoxArticleBrand);
            this.Controls.Add(this.textBoxArticleModel);
            this.Controls.Add(this.textBoxArticlePrice);
            this.Controls.Add(this.textBoxArticleName);
            this.Controls.Add(this.textBoxArticleId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArticleForm";
            this.Text = "ArticleForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxArticleId;
        private System.Windows.Forms.TextBox textBoxArticleName;
        private System.Windows.Forms.TextBox textBoxArticlePrice;
        private System.Windows.Forms.TextBox textBoxArticleModel;
        private System.Windows.Forms.TextBox textBoxArticleBrand;
        private System.Windows.Forms.TextBox textBoxArticleInformation;
        private System.Windows.Forms.Button buttonArticleAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonShowAllArticles;
        private System.Windows.Forms.DataGridView dataGridViewArticles;
        private System.Windows.Forms.Button buttonEditArticle;
        private System.Windows.Forms.Button buttonRemoveArticle;
    }
}