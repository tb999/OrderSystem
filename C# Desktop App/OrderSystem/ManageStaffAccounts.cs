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
    public partial class ManageStaffAccounts : Form
    {
        public ManageStaffAccounts()
        {
            InitializeComponent();
        }

        private void ManageAdminAccounts_Load(object sender, EventArgs e)
        {
            int noOfStaff;
            Usernamelbl.Text = LoginForm.username;
            Rolecb.DropDownStyle = ComboBoxStyle.DropDownList;
 
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = LoginForm.constring;
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
            DataSet dataset = new DataSet();

            List<String> staff = new List<String>();

            con.Open();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM staff;";

            dataadapter.SelectCommand = command;
            dataadapter.Fill(dataset, "staff");
            noOfStaff = dataset.Tables["staff"].Rows.Count;


            for (int i = 0; i < noOfStaff; i++)
            {
                DataRow dr = dataset.Tables["staff"].Rows[i];
                staff.Add(dr[4].ToString());
            }

            Stafflb.DataSource = staff;
            

            int noOfRoles;

            MySqlDataAdapter dataadapter2 = new MySqlDataAdapter();
            DataSet dataset2 = new DataSet();

            
            MySqlCommand command2 = con.CreateCommand();
            command2.CommandText = "SELECT * FROM job;";

            dataadapter2.SelectCommand = command2;
            dataadapter2.Fill(dataset2, "roles");
            noOfRoles = dataset2.Tables["roles"].Rows.Count;

            for (int i = 0; i < noOfRoles; i++)
            {
                DataRow dr2 = dataset2.Tables["roles"].Rows[i];
                Rolecb.Items.Add(dr2[1].ToString());
            }

            con.Close();
        }


        private void AddStaffbtn_Click_1(object sender, EventArgs e)
        {
            DialogResult AddStaff = MessageBox.Show("Are You Sure You Wish To ADD This Staff Member?", "Add Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (AddStaff == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO staff (job_id, staff_forename, staff_surname, staff_username, staff_phone, staff_password) VALUES " + "(" + Rolecb.SelectedIndex + ",'" + Forenametxt.Text + "','" + Surnametxt.Text + "','" + Usernametxt.Text + "'," + Phonetxt.Text + ",'" + "password" + "');";
                command.ExecuteNonQuery();
                MessageBox.Show("The Staff Member Has Been Added Successfully.");
                con.Close();

                ManageStaffAccounts ManageStaffAccounts = new ManageStaffAccounts();
                ManageStaffAccounts.Show();
                this.Close();
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            DialogResult RemoveStaff = MessageBox.Show("Are You Sure You Wish To DELETE This Staff Member?", "Delete Staff Member", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RemoveStaff == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = LoginForm.constring;
                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "DELETE FROM staff WHERE staff_username='" + Stafflb.SelectedItem.ToString() + "';";

                command.ExecuteNonQuery();
                MessageBox.Show("The Staff Member Has Been Removed Successfully.");
                con.Close();

                ManageStaffAccounts ManageStaffAccounts = new ManageStaffAccounts();
                ManageStaffAccounts.Show();
                this.Close();

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
