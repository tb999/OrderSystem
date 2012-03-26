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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        public DataSet ProductDataSet = new DataSet();
        public DataSet CustomerDataSet = new DataSet();


        private void AddOrder_Load(object sender, EventArgs e)
        {
            Usernamelbl.Text = LoginForm.username;
            AddDataToProductDataGrid();
            AddDataToCustomerDataGrid();

            
        }

        private void AddDataToCustomerDataGrid()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = LoginForm.constring;
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
            DataSet CustomerDataSet = new DataSet();
            con.Open();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT customer_id, customer_forename, customer_surname, customer_email FROM customer;";

            dataadapter.SelectCommand = command;
            dataadapter.Fill(CustomerDataSet, "customers");
            con.Close();

            this.Customersdg.DataSource = CustomerDataSet.Tables[0];
            Customersdg.Columns[0].HeaderText = "ID";
            Customersdg.Columns[1].HeaderText = "Forename";
            Customersdg.Columns[2].HeaderText = "Surname";
            Customersdg.Columns[3].HeaderText = "Email";
            Customersdg.Columns[0].Width = 50;
            Customersdg.Columns[1].Width = 80;
            Customersdg.Columns[2].Width = 80;
            Customersdg.Columns[3].Width = 225;
            Customersdg.ReadOnly = true;
            Customersdg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            Customersdg.DefaultCellStyle.ForeColor = Color.Black;
        
        }

        private void AddDataToProductDataGrid()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = LoginForm.constring;
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
            DataSet ProductDataSet = new DataSet();
            con.Open();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT product_id, product_name, product_quantity, product_price FROM product;";

            dataadapter.SelectCommand = command;
            dataadapter.Fill(ProductDataSet, "products");
            con.Close();

            this.Productsdg.DataSource = ProductDataSet.Tables[0];
            Productsdg.Columns[0].HeaderText = "ID";
            Productsdg.Columns[1].HeaderText = "Name";
            Productsdg.Columns[2].HeaderText = "Quantity Remaining";
            Productsdg.Columns[3].HeaderText = "Price";
            Productsdg.Columns[0].Width = 80;
            Productsdg.Columns[1].Width = 230;
            Productsdg.Columns[2].Width = 80;
            Productsdg.Columns[3].Width = 70;
            Productsdg.ReadOnly = true;
            Productsdg.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            Productsdg.DefaultCellStyle.ForeColor = Color.Black;
            
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            ProductDataSet.Clear();

            if (ProductSearchtxt.TextLength == 0)
            {
                MessageBox.Show("The Search Field Is Empty");
            }
            else
            {
                if (ProductIDrb.Checked == true)
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = LoginForm.constring;
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter();

                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "SELECT product_id, product_name, product_quantity, product_price FROM product WHERE product_id='" + ProductSearchtxt.Text + "';";
                    con.Open();
                    dataadapter.SelectCommand = command;
                    dataadapter.Fill(ProductDataSet, "searchproductid");
                    con.Close();

                    if (ProductDataSet.Tables["searchproductid"].Rows.Count == 0)
                    {
                        MessageBox.Show("Product Not Found.");
                    }
                    else
                    {

                        this.Productsdg.DataSource = ProductDataSet.Tables["searchproductid"];
                        

                    }
                }

                else if (ProductNamerb.Checked == true)
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = LoginForm.constring;
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter();

                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "SELECT product_id, product_name, product_quantity, product_price FROM product WHERE product_name='" + ProductSearchtxt.Text + "';";
                    con.Open();
                    dataadapter.SelectCommand = command;
                    dataadapter.Fill(ProductDataSet, "searchproductname");
                    con.Close();


                    if (ProductDataSet.Tables["searchproductname"].Rows.Count == 0)
                    {
                        MessageBox.Show("Product Not Found.");
                    }
                    else
                    {

                        this.Productsdg.DataSource = ProductDataSet.Tables["searchproductname"];
                        

                    }
                }
                else
                {
                    MessageBox.Show("Please Select A Search Criteria");
                }
            }
        }

        private void ShowAllbtn_Click(object sender, EventArgs e)
        {
            AddDataToProductDataGrid();
        }

        private void SearchCustomersbtn_Click(object sender, EventArgs e)
        {
            CustomerDataSet.Clear();

            if (SearchCustomerstxt.TextLength == 0)
            {
                MessageBox.Show("The Search Field Is Empty");
            }
            else
            {
                if (CustomerIDrb.Checked == true)
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = LoginForm.constring;
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter();

                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "SELECT customer_id, customer_forename, customer_surname, customer_email FROM customer WHERE customer_id='" + SearchCustomerstxt.Text + "';";
                    con.Open();
                    dataadapter.SelectCommand = command;
                    dataadapter.Fill(CustomerDataSet, "searchcustomerid");
                    con.Close();

                    if (CustomerDataSet.Tables["searchcustomerid"].Rows.Count == 0)
                    {
                        MessageBox.Show("Customer Not Found.");
                    }
                    else
                    {

                        this.Customersdg.DataSource = CustomerDataSet.Tables["searchcustomerid"];


                    }
                }

                else if (Emailrb.Checked == true)
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = LoginForm.constring;
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter();

                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "SELECT customer_id, customer_forename, customer_surname, customer_email FROM customer WHERE customer_email='" + SearchCustomerstxt.Text + "';";
                    con.Open();
                    dataadapter.SelectCommand = command;
                    dataadapter.Fill(CustomerDataSet, "searchcustomeremail");
                    con.Close();


                    if (CustomerDataSet.Tables["searchcustomeremail"].Rows.Count == 0)
                    {
                        MessageBox.Show("Customer Not Found.");
                    }
                    else
                    {

                        this.Customersdg.DataSource = CustomerDataSet.Tables["searchcustomeremail"];


                    }
                }
                else
                {
                    MessageBox.Show("Please Select A Search Criteria");
                }
            }
        }

        private void ShowAllCustomersbtn_Click(object sender, EventArgs e)
        {
            AddDataToCustomerDataGrid();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Dispose(true);
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            HomeForm HomeForm = new HomeForm();
            HomeForm.Show();
            this.Dispose(true);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if ((Productsdg.SelectedRows.Count > 0) && (Customersdg.SelectedRows.Count > 0))
            {

            }
            else
            {
                MessageBox.Show("Please Select BOTH A Product And A Customer.");
            }
        }    
        
    }
}
