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
public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

public static String username;
public static String constring = "Server=localhost;Database=project; User=root;Password=Clarets1;";




private void LoginForm_Load(object sender, EventArgs e)
{
    
}

private void Loginbtn_Click(object sender, EventArgs e)
{
    if (Usernametxt.TextLength > 0 && Passwordtxt.TextLength > 0)
    {
        username = Usernametxt.Text;
        String password = Passwordtxt.Text;

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = constring;
        MySqlDataAdapter dataadapter = new MySqlDataAdapter();
        DataSet dataset = new DataSet();

        MySqlCommand command = con.CreateCommand();
        command.CommandText = "SELECT * FROM staff WHERE staff_username='" + username + "' AND staff_password='" + password + "'";
        con.Open();
        dataadapter.SelectCommand = command;
        dataadapter.Fill(dataset, "staff");

        if (dataset.Tables["staff"].Rows.Count == 1)
        {
            DataRow dr = dataset.Tables["staff"].Rows[0];
            Usernametxt.Text = dr[5].ToString();
            string usernameresult = dr[5].ToString();
            string passresult = dr[6].ToString();

            if ((usernameresult == username) || (passresult == password))
            {
                if (password == "password")
                {
                    FirstTimeLogin FirstTimeLogin = new FirstTimeLogin();
                    FirstTimeLogin.Show();
                    this.Dispose(false);
                }
                else
                {
                    HomeForm HomeForm = new HomeForm();
                    HomeForm.Show();
                    this.Dispose(false);
                    con.Close();
                }
            }
        }

        else
        {
            MessageBox.Show("Incorrect Username/Password Combination");
        }
    }

    else if (Usernametxt.TextLength > 0 && Passwordtxt.TextLength == 0)
    {
        MessageBox.Show("Please Enter Your Password");
    }

    else
    {
        MessageBox.Show("Please Enter Your Username And Password");
    }
}



private void Exitbtn_Click(object sender, EventArgs e)
{
    Application.Exit();      
}

private void Resetpassll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
    PasswordReset PasswordReset = new PasswordReset();
    PasswordReset.Show();
    this.Dispose(false);
}
      
}
}
