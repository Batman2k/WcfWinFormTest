namespace StoreWinForms
{
    partial class UserForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonUpdateUserList = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserFirstName = new System.Windows.Forms.TextBox();
            this.textBoxUserLastName = new System.Windows.Forms.TextBox();
            this.textBoxUserAdress = new System.Windows.Forms.TextBox();
            this.textBoxUserNationalIdentificationNumber = new System.Windows.Forms.TextBox();
            this.textBoxUserPhoneCell = new System.Windows.Forms.TextBox();
            this.textBoxUserPhoneHome = new System.Windows.Forms.TextBox();
            this.textBoxUserZipCode = new System.Windows.Forms.TextBox();
            this.textBoxUserCity = new System.Windows.Forms.TextBox();
            this.textBoxUserCounty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(484, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(210, 12);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(92, 23);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonUpdateUserList
            // 
            this.buttonUpdateUserList.Location = new System.Drawing.Point(484, 445);
            this.buttonUpdateUserList.Name = "buttonUpdateUserList";
            this.buttonUpdateUserList.Size = new System.Drawing.Size(89, 23);
            this.buttonUpdateUserList.TabIndex = 2;
            this.buttonUpdateUserList.Text = "Update userlist";
            this.buttonUpdateUserList.UseVisualStyleBackColor = true;
            this.buttonUpdateUserList.Click += new System.EventHandler(this.buttonUpdateUserList_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(615, 445);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(75, 23);
            this.buttonEditUser.TabIndex = 3;
            this.buttonEditUser.Text = "Edit user";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Location = new System.Drawing.Point(752, 445);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveUser.TabIndex = 4;
            this.buttonRemoveUser.Text = "Remove user";
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(13, 69);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserId.TabIndex = 5;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(12, 95);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 6;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(13, 121);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserPassword.TabIndex = 7;
            // 
            // textBoxUserFirstName
            // 
            this.textBoxUserFirstName.Location = new System.Drawing.Point(12, 147);
            this.textBoxUserFirstName.Name = "textBoxUserFirstName";
            this.textBoxUserFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserFirstName.TabIndex = 8;
            // 
            // textBoxUserLastName
            // 
            this.textBoxUserLastName.Location = new System.Drawing.Point(12, 173);
            this.textBoxUserLastName.Name = "textBoxUserLastName";
            this.textBoxUserLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserLastName.TabIndex = 9;
            // 
            // textBoxUserAdress
            // 
            this.textBoxUserAdress.Location = new System.Drawing.Point(13, 199);
            this.textBoxUserAdress.Name = "textBoxUserAdress";
            this.textBoxUserAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserAdress.TabIndex = 10;
            // 
            // textBoxUserNationalIdentificationNumber
            // 
            this.textBoxUserNationalIdentificationNumber.Location = new System.Drawing.Point(13, 355);
            this.textBoxUserNationalIdentificationNumber.Name = "textBoxUserNationalIdentificationNumber";
            this.textBoxUserNationalIdentificationNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserNationalIdentificationNumber.TabIndex = 16;
            // 
            // textBoxUserPhoneCell
            // 
            this.textBoxUserPhoneCell.Location = new System.Drawing.Point(12, 329);
            this.textBoxUserPhoneCell.Name = "textBoxUserPhoneCell";
            this.textBoxUserPhoneCell.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserPhoneCell.TabIndex = 15;
            // 
            // textBoxUserPhoneHome
            // 
            this.textBoxUserPhoneHome.Location = new System.Drawing.Point(12, 303);
            this.textBoxUserPhoneHome.Name = "textBoxUserPhoneHome";
            this.textBoxUserPhoneHome.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserPhoneHome.TabIndex = 14;
            // 
            // textBoxUserZipCode
            // 
            this.textBoxUserZipCode.Location = new System.Drawing.Point(13, 277);
            this.textBoxUserZipCode.Name = "textBoxUserZipCode";
            this.textBoxUserZipCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserZipCode.TabIndex = 13;
            // 
            // textBoxUserCity
            // 
            this.textBoxUserCity.Location = new System.Drawing.Point(12, 251);
            this.textBoxUserCity.Name = "textBoxUserCity";
            this.textBoxUserCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserCity.TabIndex = 12;
            // 
            // textBoxUserCounty
            // 
            this.textBoxUserCounty.Location = new System.Drawing.Point(13, 225);
            this.textBoxUserCounty.Name = "textBoxUserCounty";
            this.textBoxUserCounty.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserCounty.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id leave blank if new";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "First name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "County";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Adress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Last name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Person id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Phone cell";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Phone home";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Zip code";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 556);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserNationalIdentificationNumber);
            this.Controls.Add(this.textBoxUserPhoneCell);
            this.Controls.Add(this.textBoxUserPhoneHome);
            this.Controls.Add(this.textBoxUserZipCode);
            this.Controls.Add(this.textBoxUserCity);
            this.Controls.Add(this.textBoxUserCounty);
            this.Controls.Add(this.textBoxUserAdress);
            this.Controls.Add(this.textBoxUserLastName);
            this.Controls.Add(this.textBoxUserFirstName);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.buttonRemoveUser);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonUpdateUserList);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonUpdateUserList;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonRemoveUser;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUserFirstName;
        private System.Windows.Forms.TextBox textBoxUserLastName;
        private System.Windows.Forms.TextBox textBoxUserAdress;
        private System.Windows.Forms.TextBox textBoxUserNationalIdentificationNumber;
        private System.Windows.Forms.TextBox textBoxUserPhoneCell;
        private System.Windows.Forms.TextBox textBoxUserPhoneHome;
        private System.Windows.Forms.TextBox textBoxUserZipCode;
        private System.Windows.Forms.TextBox textBoxUserCity;
        private System.Windows.Forms.TextBox textBoxUserCounty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}