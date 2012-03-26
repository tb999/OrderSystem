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
    public partial class PasswordReset : Form
    {
        public PasswordReset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Close();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            DialogResult PasswordRest = MessageBox.Show("Are You Sure You Wish To Reset Your Password?", "Rest Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (PasswordRest == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                DataSet dataset = new DataSet();
                con.Open();
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "SELECT * FROM staff WHERE staff_username='" + Usernametxt.Text + "';";

                dataadapter.SelectCommand = command;
                dataadapter.Fill(dataset, "staff");

                if (dataset.Tables["staff"].Rows.Count == 0)
                {
                    MessageBox.Show("Inncorrect Email Address.");
                }

                else
                {
                    DataRow dr = dataset.Tables["staff"].Rows[0];

                    if (Answer1txt.Text != dr[7].ToString())
                    {
                        MessageBox.Show("Mother's Maiden Name Is Incorrect.");
                    }

                    else if (Answer2txt.Text != dr[8].ToString())
                    {
                        MessageBox.Show("Favourite Instrument Is Incorrect.");
                    }
                    else
                    {

                        command.CommandText = "UPDATE staff SET staff_password='password' WHERE staff_username='" + Usernametxt.Text + "'";
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Your Password Has Been Reset To The Default Password Which Is 'password'.");

                        LoginForm loginform = new LoginForm();
                        loginform.Show();
                        this.Dispose(true);
                    }
                }
            }
        }

        private void PasswordReset_Load(object sender, EventArgs e)
        {

        }
    }
}
