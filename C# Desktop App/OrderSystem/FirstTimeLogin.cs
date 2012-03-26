using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace OrderSystem
{
public partial class FirstTimeLogin : Form
    {
        public FirstTimeLogin()
        {
            InitializeComponent();
        }

private void FirstTimeLogin_Load(object sender, EventArgs e)
{

}

private void Submitbtn_Click(object sender, EventArgs e)
{
    DialogResult UpdateDetails = MessageBox.Show("Are You Sure You Wish To Update Your Details?", "Update Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    if (UpdateDetails == DialogResult.Yes)
    {
        if (Passwordtxt.Text == Password2txt.Text)
        {
            if (Passwordtxt.TextLength > 5)
            {
                if (Answer1txt.TextLength < 1)
                {
                    MessageBox.Show("Please enter your mothers maiden name.");
                }
                else if (Answer2txt.TextLength < 1)
                {
                    MessageBox.Show("Please enter your favourite instrument.");
                }
                else
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = LoginForm.constring;

                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "UPDATE staff SET staff_password='" + Password2txt.Text + "', staff_answer1='" + Answer1txt.Text + "', staff_answer2='" + Answer2txt.Text + "' WHERE staff_username='" + LoginForm.username + "'";
                    con.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Details submitted successfully.");
                    con.Close();

                    HomeForm HomeForm = new HomeForm();
                    HomeForm.Show();
                    this.Dispose(true);
                }
            }
            else
            {
                MessageBox.Show("Password must be 6-12 characters.");
            }
        }
        else if (Passwordtxt.Text != Password2txt.Text)
        {
            MessageBox.Show("Passwords do not match.");
        }

        else if (Answer1txt.TextLength < 0)
        {
            MessageBox.Show("Please enter your mothers maiden name.");
        }

        else if (Password2txt.TextLength < 0)
        {
            MessageBox.Show("Please enter your favourite instrument.");
        }
    }
}

private void Cancelbtn_Click(object sender, EventArgs e)
{
    LoginForm LoginForm = new LoginForm();
    LoginForm.Show();
    this.Dispose(true);
}
}
}
