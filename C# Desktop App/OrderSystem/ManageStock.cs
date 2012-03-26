using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

namespace OrderSystem
{

    public partial class ManageStock : Form
    {

        public ManageStock()
        {
            InitializeComponent();
        }

        public int counter = 0;
        public int noOfProducts;
        public DataSet dataset = new DataSet();

        public void ManageStock_Load(object sender, EventArgs e)
        {
            int noOfCategories;
            Usernamelbl.Text = LoginForm.username;

            Categorycb.DropDownStyle = ComboBoxStyle.DropDownList;
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = LoginForm.constring;
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
            con.Open();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM product;";
            dataadapter.SelectCommand = command;
            dataadapter.Fill(dataset, "product");

            noOfProducts = dataset.Tables["product"].Rows.Count;

            MySqlDataAdapter dataadapter2 = new MySqlDataAdapter();
            DataSet dataset2 = new DataSet();


            MySqlCommand command2 = con.CreateCommand();
            command2.CommandText = "SELECT * FROM category;";
            dataadapter2.SelectCommand = command2;
            dataadapter2.Fill(dataset2, "categories");

            noOfCategories = dataset2.Tables["categories"].Rows.Count;

            for (int i = 0; i < noOfCategories; i++)
            {
                DataRow dr2 = dataset2.Tables["categories"].Rows[i];
                Categorycb.Items.Add(dr2[0].ToString());
            }

            con.Close();
            NavigateRecords();
        }


        private void NavigateRecords()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = LoginForm.constring;
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();

            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM product;";
            con.Open();

            dataadapter.SelectCommand = command;
            dataadapter.Fill(dataset, "product");


            DataRow dr = dataset.Tables["product"].Rows[counter];

            ProductIDtxt.Text = dr[0].ToString();
            Categorycb.SelectedItem = dr[1].ToString();
            ProductNametxt.Text = dr[2].ToString();
            ProductDescriptiontxt.Text = dr[3].ToString();
            ProductPricetxt.Text = dr[5].ToString();
            ProductQuantitytxt.Text = dr[4].ToString();
            RecordNumber();
            con.Close();
        }

        private void RecordNumber()
        {
            RecordNolbl.Show();
            RecordNolbl.Text = ("Record No: " + (counter + 1) + " of " + noOfProducts);
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
            ProductIDtxt.Text = "Auto Number";
            ProductIDtxt.Enabled = false;
            ProductNametxt.Clear();
            ProductPricetxt.Clear();
            ProductDescriptiontxt.Clear();
            ProductQuantitytxt.Clear();
            Imagepb = null;
            Savebtn.Enabled = true;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            DialogResult SaveProduct = MessageBox.Show("Are You Sure You Wish To ADD This Product?", "Add Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveProduct == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO product (category_id, product_name, product_price, product_description, product_quantity) VALUES" + "('" + Categorycb.SelectedItem.ToString() + "','" + ProductNametxt.Text + "'," + ProductPricetxt.Text + ",'" + ProductDescriptiontxt.Text + "'," + ProductQuantitytxt.Text + ");";

                command.ExecuteNonQuery();

                MessageBox.Show("The Product Has Been Added Successfully.");

                ManageStock ManageStock = new ManageStock();
                ManageStock.Show();
                this.Close();
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            DialogResult UpdateProduct = MessageBox.Show("Are You Sure You Wish To UPDATE This Product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (UpdateProduct == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "UPDATE product SET category_id='" + Categorycb.Text.ToString() + "', product_name='" + ProductNametxt.Text + "', product_description='" + ProductDescriptiontxt.Text + "', product_quantity=" + ProductQuantitytxt.Text + ", product_price=" + ProductPricetxt.Text + " WHERE product_id=" + ProductIDtxt.Text + ";";
                command.ExecuteNonQuery();
                MessageBox.Show("The Product Details Have Been Updated.");
                con.Close();

                ManageStock ManageStock = new ManageStock();
                ManageStock.Show();
                this.Close();
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult DeleteProduct = MessageBox.Show("Are You Sure You Wish To DELETE This Product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DeleteProduct == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "DELETE FROM product WHERE product_id='" + ProductIDtxt.Text + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("The Product Deleted Successfully.");
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
                if (ProductIDrb.Checked == true)
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = LoginForm.constring;
                    MySqlDataAdapter dataadapter = new MySqlDataAdapter();

                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "SELECT * FROM product WHERE product_id=" + Searchtxt.Text + ";";
                    con.Open();
                    dataadapter.SelectCommand = command;
                    dataadapter.Fill(dataset, "searchproductid");

                    if (dataset.Tables["searchproductid"].Rows.Count == 0)
                    {
                        MessageBox.Show("Product Not Found.");
                    }
                    else
                    {
                        DataRow dr = dataset.Tables["searchproductid"].Rows[0];

                        ProductIDtxt.Text = dr[0].ToString();
                        ProductNametxt.Text = dr[2].ToString();
                        ProductDescriptiontxt.Text = dr[4].ToString();
                        ProductPricetxt.Text = dr[6].ToString();
                        ProductQuantitytxt.Text = dr[5].ToString();
                        con.Close();

                        RecordNolbl.Hide();
                        MessageBox.Show("Product Found.");
                        dataset.Clear();
                    }
                }
                else if (Namerb.Checked == true)
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = LoginForm.constring;
                    MySqlDataAdapter dataadapter2 = new MySqlDataAdapter();

                    MySqlCommand command2 = con.CreateCommand();
                    command2.CommandText = "SELECT * FROM product WHERE product_name='" + Searchtxt.Text + "';";
                    con.Open();

                    dataadapter2.SelectCommand = command2;
                    dataadapter2.Fill(dataset, "searchproductname");

                    if (dataset.Tables["searchproductname"].Rows.Count == 0)
                    {
                        MessageBox.Show("Product Not Found.");
                    }
                    else
                    {
                        DataRow dr = dataset.Tables["searchproductname"].Rows[0];
                        ProductIDtxt.Text = dr[0].ToString();
                        ProductNametxt.Text = dr[2].ToString();
                        ProductDescriptiontxt.Text = dr[4].ToString();
                        ProductPricetxt.Text = dr[6].ToString();
                        ProductQuantitytxt.Text = dr[5].ToString();
                        con.Close();

                        RecordNolbl.Hide();
                        MessageBox.Show("Product Found.");
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

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Dispose(true);
        }
    }
}
 