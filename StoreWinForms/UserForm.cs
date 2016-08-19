using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreWinForms.StoreService;

namespace StoreWinForms
{
    public partial class UserForm : Form
    {
        private readonly StoreServiceClient _storeService = new StoreServiceClient();
        public UserForm()
        {
            InitializeComponent();
        }

        private void buttonUpdateUserList_Click(object sender, EventArgs e)
        {
            UpdateUserList();
        }

        private async void buttonAddUser_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                UserName = textBoxUserName.Text,
                Password = textBoxUserPassword.Text,
                Adress = textBoxUserAdress.Text,
                City = textBoxUserCity.Text,
                County = textBoxUserCounty.Text,
                ZipCode = textBoxUserZipCode.Text,
                FirstName = textBoxUserFirstName.Text,
                LastName = textBoxUserLastName.Text,
                NationalIdentificationNumber = textBoxUserNationalIdentificationNumber.Text,
                PhoneHome = textBoxUserPhoneHome.Text,
                PhoneCell = textBoxUserPhoneCell.Text
                
            };
            var parsedId = 0;
            int.TryParse(textBoxUserId.Text, out parsedId);
            user.Id = parsedId;
            await _storeService.AddOrUpdateUserAsync(user);

        }

        private void UpdateUserList()
        {
            dataGridView1.DataSource = _storeService.ReturnAllUsers();
        }

    }
}
