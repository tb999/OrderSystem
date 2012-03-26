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
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();
        }

        public int counter = 0;
        public int noOfProducts;
        public string addressid;
        public DataSet dataset = new DataSet();


        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            Usernamelbl.Text = LoginForm.username;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = LoginForm.constring;
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM customer;";

            dataadapter.SelectCommand = command;
            dataadapter.Fill(dataset, "customers");
            noOfProducts = dataset.Tables["customers"].Rows.Count;
            con.Close();
            NavigateRecords();
        }

        private void NavigateRecords()
        {
            string customeraddressid;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = LoginForm.constring;
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM customer;";
            con.Open();
            dataadapter.SelectCommand = command;
            dataadapter.Fill(dataset, "customers");

            DataRow dr = dataset.Tables["customers"].Rows[counter];

            CustomerIDtxt.Text = dr[0].ToString();
            Forenametxt.Text = dr[2].ToString();
            Surnametxt.Text = dr[3].ToString();
            Emailtxt.Text = dr[4].ToString();
            Phonetxt.Text = dr[5].ToString();
            customeraddressid = dr[1].ToString();

            
            MySqlCommand commandaddress = con.CreateCommand();
            commandaddress.CommandText = "SELECT * FROM address WHERE address_id='"+ dr[1].ToString()+"'";
            dataadapter.SelectCommand = commandaddress;
            dataadapter.Fill(dataset, "address");
            DataRow dradd = dataset.Tables["address"].Rows[counter];

            Addl1txt.Text = dradd[1].ToString();
            Addl2txt.Text = dradd[2].ToString();
            Towntxt.Text = dradd[3].ToString();
            Countytxt.Text = dradd[4].ToString();
            Postcodetxt.Text = dradd[5].ToString();

            RecordNumber();
            con.Close();
            

        }

        private void RecordNumber()
        {
            Recordnolbl.Show();
            Recordnolbl.Text = ("Record No: " + (counter + 1) + " of " + noOfProducts);
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            if (counter < noOfProducts - 1)
            {
                counter++;
                NavigateRecords();
                RecordNumber();
            }
            else
            {
                MessageBox.Show("End Of Records.");
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                NavigateRecords();
                RecordNumber();

            }
            else
            {
                MessageBox.Show("You Are Viewing The First Record");
            }
        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            CustomerIDtxt.Text = "Auto Number";
            CustomerIDtxt.Enabled = false;
            Forenametxt.Clear();
            Surnametxt.Clear();
            Emailtxt.Clear();
            Phonetxt.Clear();
            Postcodetxt.Clear();
            Addl1txt.Clear();
            Addl2txt.Clear();
            Towntxt.Clear();
            Countytxt.Clear();
            Savebtn.Enabled = true;
            Updatebtn.Enabled = false;
            Deletebtn.Enabled = false;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            DialogResult AddCustomer = MessageBox.Show("Are You Sure You Wish To ADD This Customer?", "Add Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (AddCustomer == DialogResult.Yes)
            {
            dataset.Clear();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = LoginForm.constring;
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
            con.Open();

            MySqlCommand command = con.CreateCommand();
            MySqlCommand commandaddress = con.CreateCommand();
            commandaddress.CommandText = "INSERT INTO address (address_line1, address_line2, address_city, address_county, address_postcode) VALUES "+"('"+Addl1txt.Text+"','"+Addl2txt.Text+"','"+Towntxt.Text+"','"+Countytxt.Text+"','"+Postcodetxt.Text+"');";
            commandaddress.ExecuteNonQuery();


            MySqlCommand commandfindaddid = con.CreateCommand();
            command.CommandText = "SELECT * FROM address WHERE address_line1='"+Addl1txt.Text+"' AND address_postcode='" + Postcodetxt.Text + "'";
            dataadapter.SelectCommand = command;
            dataadapter.Fill(dataset, "address");
            DataRow dr = dataset.Tables["address"].Rows[0];

            command.CommandText = "INSERT INTO customer (address_id, customer_forename, customer_surname, customer_email, customer_phone) VALUES" + "(" + dr[0].ToString()+ ",'" + Forenametxt.Text + "','" + Surnametxt.Text + "','" + Emailtxt.Text + "'," + Phonetxt.Text + ");";
            command.ExecuteNonQuery();
            MessageBox.Show("The Customer Has Been Added Successfully.");
            con.Close();
            dataset.Clear();

            ManageAccounts ManageAccounts = new ManageAccounts();
            ManageAccounts.Show();
            this.Close();
            
        }}

        private void Exitbtn_Click_1(object sender, EventArgs e)
        { Application.Exit(); }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            DialogResult UpdateCustomer = MessageBox.Show("Are You Sure You Wish To EDIT This Customer?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateCustomer == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "UPDATE customer SET customer_forename='" + Forenametxt.Text + "', customer_surname='" + Surnametxt.Text + "', customer_email='" + Emailtxt.Text + "', customer_phone='" + Phonetxt.Text + "'WHERE product_id='" + CustomerIDtxt.Text + "'";
                command.ExecuteNonQuery();

                MySqlCommand commandaddress = con.CreateCommand();
                commandaddress.CommandText = "UPDATE address SET address_line1='" + Addl1txt.Text + "', address_line2='" + Addl2txt.Text + "', address_city='" + Countytxt.Text + "', address_postcode='" + Postcodetxt.Text + "'WHERE address_id='" + addressid + "'";
                commandaddress.ExecuteNonQuery();

                MessageBox.Show("The Customer Details Have Been Updated.");
                con.Close();

                ManageStock ManageStock = new ManageStock();
                ManageStock.Show();
                this.Close();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult DeleteCustomer = MessageBox.Show("Are You Sure You Wish To DELETE This Customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteCustomer == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "DELETE FROM customer WHERE customer_id='" + CustomerIDtxt.Text + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("The Customer Deleted Successfully.");
                con.Close();

                ManageStock ManageStock = new ManageStock();
                ManageStock.Show();
                this.Close();
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (Searchtxt.TextLength == 0)
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
                    command.CommandText = "SELECT * FROM customer WHERE customer_id='" + Searchtxt.Text + "';";
                    con.Open();
                    dataadapter.SelectCommand = command;
                    dataadapter.Fill(dataset, "searchcustomerid");

                    if (dataset.Tables["searchcustomerid"].Rows.Count == 0)
                    {
                        MessageBox.Show("Customer Not Found.");
                    }
                    else
                    {

                        DataRow dr = dataset.Tables["searchcustomerid"].Rows[0];

                        CustomerIDtxt.Text = dr[0].ToString();
                        Forenametxt.Text = dr[2].ToString();
                        Surnametxt.Text = dr[3].ToString();
                        Emailtxt.Text = dr[4].ToString();
                        Phonetxt.Text = dr[5].ToString();
                        

                        MySqlCommand commandaddress = con.CreateCommand();
                        commandaddress.CommandText = "SELECT * FROM address WHERE address_id='" + dr[1].ToString() + "'";
                        dataadapter.SelectCommand = commandaddress;
                        dataadapter.Fill(dataset, "addresssearch");
                        DataRow dradd = dataset.Tables["addresssearch"].Rows[0];
                        con.Close();

                        Addl1txt.Text = dradd[1].ToString();
                        Addl2txt.Text = dradd[2].ToString();
                        Towntxt.Text = dradd[3].ToString();
                        Countytxt.Text = dradd[4].ToString();
                        Postcodetxt.Text = dradd[5].ToString();

                        Recordnolbl.Hide();
                        Nextbtn.Hide();
                        Backbtn.Hide();
                        dataset.Clear();

                    }
                }

                else if (Emailrb.Checked == true)
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = LoginForm.constring;
                    MySqlDataAdapter dataadapter2 = new MySqlDataAdapter();

                    MySqlCommand command2 = con.CreateCommand();
                    command2.CommandText = "SELECT * FROM customer WHERE customer_email='" + Searchtxt.Text + "';";
                    con.Open();
                    dataadapter2.SelectCommand = command2;
                    dataadapter2.Fill(dataset, "searchcustomeremail");

                    if (dataset.Tables["searchcustomeremail"].Rows.Count == 0)
                    {
                        MessageBox.Show("Customer Not Found.");
                    }
                    else
                    {

                        DataRow dr = dataset.Tables["searchcustomeremail"].Rows[0];

                        CustomerIDtxt.Text = dr[0].ToString();
                        Forenametxt.Text = dr[2].ToString();
                        Surnametxt.Text = dr[3].ToString();
                        Emailtxt.Text = dr[4].ToString();
                        Phonetxt.Text = dr[5].ToString();
                        

                        MySqlCommand commandaddress = con.CreateCommand();
                        commandaddress.CommandText = "SELECT * FROM address WHERE address_id='" + dr[1].ToString() + "'";
                        dataadapter2.SelectCommand = commandaddress;
                        dataadapter2.Fill(dataset, "address2");
                        DataRow dradd = dataset.Tables["address2"].Rows[0];

                        Addl1txt.Text = dradd[1].ToString();
                        Addl2txt.Text = dradd[2].ToString();
                        Towntxt.Text = dradd[3].ToString();
                        Countytxt.Text = dradd[4].ToString();
                        Postcodetxt.Text = dradd[5].ToString();

                        Recordnolbl.Hide();
                        Nextbtn.Hide();
                        Backbtn.Hide();
                        dataset.Clear();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Please Select A Search Criteria");
                }
            }
        }
        

        private void Homebtn_Click(object sender, EventArgs e)
        {
            HomeForm HomeForm = new HomeForm();
            HomeForm.Show();
            this.Dispose(true);
        }



        private void Logoutbtn_Click_1(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Dispose(true);
        }
    }
}




