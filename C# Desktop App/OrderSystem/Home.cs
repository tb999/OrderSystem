using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderSystem
{
    
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void ManageAccountsbtn_Click(object sender, EventArgs e)
        {
            ManageAccounts ManageAccounts = new ManageAccounts();
            ManageAccounts.Show();
            this.Dispose(false); 
        }

        private void ManageStockbtn_Click(object sender, EventArgs e)
        {
            ManageStock ManageStock = new ManageStock();
            ManageStock.Show();
            this.Dispose(false);
        }

        private void StaffAccountsbtn_Click(object sender, EventArgs e)
        {
            ManageStaffAccounts ManageStaffAccounts = new ManageStaffAccounts();
            ManageStaffAccounts.Show();
            this.Dispose(false);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

            Usernamelbl.Text = LoginForm.username;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Dispose(false);
        }

        private void ManageOrdersbtn_Click(object sender, EventArgs e)
        {
            ManageOrders ManageOrders = new ManageOrders();
            ManageOrders.Show();
            this.Dispose(false);
        }

        private void AddOrderbtn_Click(object sender, EventArgs e)
        {
            AddOrder AddOrder = new AddOrder();
            AddOrder.Show();
            this.Dispose(false);
        }

        private void viewstatsbtn_Click(object sender, EventArgs e)
        {
            Stats Stats = new Stats();
            Stats.Show();
            this.Dispose(false);

        }
    }
}
