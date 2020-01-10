using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EventsProject
{
	public partial class myAccount : Form
	{
		public myAccount()
		{
			InitializeComponent();
		}

		public myAccount(string user)
		{
			InitializeComponent();
			usernameTextBox.Text = user.ToString();
			
		}

		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		private static int id;
		public void getUser()
		{
			string sql = "SELECT * FROM UserTable WHERE username = '"+usernameTextBox.Text+"'";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds);

			con.Open();

			OleDbDataReader dr = cmd.ExecuteReader();
			try
			{

				while (dr.Read())
				{
					id = Convert.ToInt32(dr["ID"]);
					usernameTextBox.Text.Equals(dr["username"].ToString());
					fnameTextBox.Text = dr["firstName"].ToString();
					lnameTextBox.Text = dr["lastName"].ToString();
					mailTextBox.Text = dr["email"].ToString();
					cityTextBox.Text = dr["city"].ToString();
					addressTextBox.Text = dr["address"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public void updateUser()
		{
			string sql = "UPDATE UserTable SET username = @username, lastName=@lastName, firstName=@firstName,email=@email,city=@city,address=@address  WHERE username=" + id + "";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			cmd.Parameters.AddWithValue("@username", this.usernameTextBox.Text);
			cmd.Parameters.AddWithValue("@lastName", this.lnameTextBox.Text);
			cmd.Parameters.AddWithValue("@firstName", this.fnameTextBox.Text);
			cmd.Parameters.AddWithValue("@email", this.mailTextBox.Text);
			cmd.Parameters.AddWithValue("@city", this.cityTextBox.Text);
			cmd.Parameters.AddWithValue("@address", this.addressTextBox.Text);

			con.Open();

			try
			{
				cmd.ExecuteScalar();
				MessageBox.Show("updated succesfully");
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			con.Close();
		}

		private void myAccount_Load(object sender, EventArgs e)
		{
			getUser();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			updateUser();
		}

		public void logout()
		{
			usernameTextBox.Text = " ";
			fnameTextBox.Text = " ";
			lnameTextBox.Text = " ";
			mailTextBox.Text = " ";
			cityTextBox.Text = " ";
			addressTextBox.Text = " ";
		}

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            startForm startF = new startForm();
            this.Hide();
            startF.Show();
        }
    }
}
