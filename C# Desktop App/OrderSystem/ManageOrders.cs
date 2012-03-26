using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrderSystem
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();

        }

        public DataSet OrderDataSet = new DataSet();
        public DataSet OrderItemsDataSet = new DataSet();


        private void SetupOrderDataGridProperties()
        {
            Ordersdg.Width = 547;
            Ordersdg.Columns[0].HeaderText = "Order ID";
            Ordersdg.Columns[1].HeaderText = "Customer ID";
            Ordersdg.Columns[2].HeaderText = "Order Date";
            Ordersdg.Columns[3].HeaderText = "Order Complete Date";
            Ordersdg.Columns[0].Width = 125;
            Ordersdg.Columns[1].Width = 115;
            Ordersdg.Columns[2].Width = 110;
            Ordersdg.Columns[3].Width = 154;
            Ordersdg.ReadOnly = true;
            Ordersdg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            Ordersdg.DefaultCellStyle.ForeColor = Color.Black;
            Ordersdg.MultiSelect = false;


        }

        private void SetupOrderItemDataGridProperties()
        {
            OrderItemsdg.Width = 547;
            OrderItemsdg.Columns[0].HeaderText = "Order ID";
            OrderItemsdg.Columns[1].HeaderText = "Product ID";
            OrderItemsdg.Columns[2].HeaderText = "Status";
            OrderItemsdg.Columns[3].HeaderText = "Delivery Date";
            OrderItemsdg.Columns[4].HeaderText = "Quantity";
            OrderItemsdg.Columns[0].Width = 130;
            OrderItemsdg.Columns[1].Width = 128;
            OrderItemsdg.Columns[2].Width = 50;
            OrderItemsdg.Columns[3].Width = 121;
            OrderItemsdg.Columns[4].Width = 75;
            OrderItemsdg.ReadOnly = true;
            OrderItemsdg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            OrderItemsdg.DefaultCellStyle.ForeColor = Color.Black;
            OrderItemsdg.MultiSelect = false;

        }

        private void AwaitingDeliveryrb_CheckedChanged(object sender, EventArgs e)
        {
            ViewOrderItemsbtn.Enabled = true;
            if (AwaitingDeliveryrb.Checked == true)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                DataSet OrderDataSet = new DataSet();
                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "SELECT Order_id, customer_id, order_date, order_complete_date FROM customer_order WHERE status_id='AD';";

                dataadapter.SelectCommand = command;
                dataadapter.Fill(OrderDataSet, "orders");
                con.Close();

                this.Ordersdg.DataSource = OrderDataSet.Tables[0];
                SetupOrderDataGridProperties();

            }

        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {

        }

        private void CompletedOrdersrb_CheckedChanged(object sender, EventArgs e)
        {
            ViewOrderItemsbtn.Enabled = true;
            if (CompletedOrdersrb.Checked == true)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                DataSet OrderCompletedDataSet = new DataSet();
                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "SELECT Order_id, customer_id, order_date, order_complete_date FROM customer_order WHERE status_id='CM';";

                dataadapter.SelectCommand = command;
                dataadapter.Fill(OrderCompletedDataSet, "orderscomplete");
                con.Close();

                this.Ordersdg.DataSource = OrderCompletedDataSet.Tables[0];
                SetupOrderDataGridProperties();
            }
        }

        private void ViewOrderItemsbtn_Click(object sender, EventArgs e)
        {
            SentAllbtn.Enabled = true;
            if (Ordersdg.SelectedRows.Count > 0)
            {

                LoadOrderItemsdg();
                SetupOrderItemDataGridProperties();
            }
            else
            {
                MessageBox.Show("Please Select An Order.");
            }    
        }

        private void LoadOrderItemsdg()
        {
            if (OrderItemsdg.Rows.Count > 0)
            {
                OrderItemsDataSet.Clear();
            }

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = LoginForm.constring;
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
            DataSet OrderItemsDataSett = new DataSet();
            con.Open();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT Order_id, product_id, status_id, item_complete_date, item_quantity FROM order_item WHERE order_id='" + Ordersdg.SelectedCells[0].Value.ToString() + "';";
            dataadapter.SelectCommand = command;
            dataadapter.Fill(OrderItemsDataSet, "orderscomplete");
            con.Close();

            this.OrderItemsdg.DataSource = OrderItemsDataSet.Tables[0];
        }

        private void SentItembtn_Click(object sender, EventArgs e)
        {
            if (OrderItemsdg.SelectedRows.Count > 0)
            {
                DialogResult SentItem = MessageBox.Show("Are You Sure You Wish To Mark The Selected Product As Sent?", "Send Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SentItem == DialogResult.Yes)
                {
                    if (OrderItemsdg.SelectedCells[2].Value.ToString() == "CM")
                    {
                        MessageBox.Show("The Selected Product Has Already Been Sent.");
                    }
                    else
                    {
                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = LoginForm.constring;
                        MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                        con.Open();

                        MySqlCommand command = con.CreateCommand();
                        command.CommandText = "UPDATE order_item SET status_id='CM' WHERE order_id=" + OrderItemsdg.SelectedCells[0].Value.ToString() + " AND product_id=" + OrderItemsdg.SelectedCells[1].Value.ToString() + ";";
                        command.ExecuteNonQuery();
                        MessageBox.Show("Status Successfully Updated To 'Sent'.");
                        LoadOrderItemsdg();
                        checkOrderComplete();
                    }

                }
                
            }
            else
            {
                MessageBox.Show("No Product Selected.");
            }
        }

        private void SentAllbtn_Click(object sender, EventArgs e)
        {
                DialogResult SentAll = MessageBox.Show("Are You Sure You Wish To Mark ALL Products As Sent?", "Send Products", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SentAll == DialogResult.Yes)
                {
                    int ItemsCount = OrderItemsdg.RowCount;
                    for (int i = 0; i <= ItemsCount; i++)
                    {
                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = LoginForm.constring;
                        MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                        con.Open();

                        MySqlCommand command = con.CreateCommand();
                        command.CommandText = "UPDATE order_item SET status_id='CM' WHERE order_id=" + OrderItemsdg.Rows[0].Cells[0].FormattedValue.ToString() + ";";
                        command.ExecuteNonQuery();
                        LoadOrderItemsdg();
                        checkOrderComplete();

                    }

                    MessageBox.Show("Status Successfully Updated To 'Sent' For All Products.");
                }
                
            }


        private void RemoveItembtn_Click(object sender, EventArgs e)
        {
            if (OrderItemsdg.SelectedRows.Count > 0)
            {
                DialogResult DeleteProduct = MessageBox.Show("Are You Sure You Wish To DELETE This Product From The Order?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DeleteProduct == DialogResult.Yes)
                {
                    if (OrderItemsdg.SelectedRows.Count > 0)
                    {
                        if (OrderItemsdg.SelectedCells[2].Value.ToString() == "CM")
                        {
                            MessageBox.Show("The Selected Product Has Already Been Sent.");
                        }
                        else
                        {
                            MySqlConnection con = new MySqlConnection();
                            con.ConnectionString = LoginForm.constring;
                            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                            con.Open();

                            MySqlCommand command = con.CreateCommand();
                            command.CommandText = "DELETE FROM order_item WHERE order_id=" + OrderItemsdg.SelectedCells[0].Value.ToString() + " AND product_id=" + OrderItemsdg.SelectedCells[1].Value.ToString() + ";";
                            command.ExecuteNonQuery();
                            MessageBox.Show("Product Successfully Removed.");
                            LoadOrderItemsdg();
                            checkOrderComplete();
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("No Product Selected.");
            }
        }

        public void checkOrderComplete()
        { 
            int ItemsCount = OrderItemsdg.RowCount;
            for (int i = 0; i <= ItemsCount-1; i++)
            {
                if (OrderItemsdg.Rows[i].Cells[2].Value.ToString() == "AD")
                {
                    MessageBox.Show("Still Products To Send.");
                    return;
                }
            }
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = LoginForm.constring;
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                    con.Open();

                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "UPDATE customer_order SET status_id='CM' WHERE order_id=" + OrderItemsdg.Rows[0].Cells[0].Value.ToString() + ";";
                    command.ExecuteNonQuery();
                    MessageBox.Show("The Order Is Now Fully Complete");
                    Ordersdg.Refresh();
                    
                }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            HomeForm HomeForm = new HomeForm();
            HomeForm.Show();
            this.Dispose(true);
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Dispose(true);
        }

            }

        }
    


