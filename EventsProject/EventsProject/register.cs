using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace EventsProject
{
	public partial class register : Form
	{
		public register()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(Properties.Settings.Default.EventsConnectionString);
		private void passwordText_Leave(object sender, EventArgs e)
		{
			if(passwordTextBox.Text.Length < 8)
			{
				passwordLabel.Visible = true;
			}
		}
		private void insertData()
		{
			string fname = fnameTextBox.Text;
			string lname = lnameTextBox.Text;
			string city = cityTextBox.Text;
			string address = addressTextBox.Text;
			string username = usernameTextBox.Text;
			string passwd = passwordTextBox.Text;

			string sql = "INSERT INTO [user] (username,password,city,address,firstName,lastName)" +
							"VALUES ('" + username + "','" + passwd + "','" + city + "','" + address + "','" + fname + "','" + lname + "')";
			
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Select id from [user] where username= @Username", con);
				cmd.Parameters.AddWithValue("@Username", this.usernameTextBox.Text);

				var nId = cmd.ExecuteScalar();

				if (nId != null)
				{
					MessageBox.Show("username exists");
				}
				else
				{
					SqlCommand cmd2 = con.CreateCommand();
					cmd2.CommandType = CommandType.Text;
					cmd2.CommandText = sql;
					cmd2.ExecuteNonQuery();
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void showData()
		{

			string sql = "SELECT * FROM [user]";
			try
			{
				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = sql;
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			insertData();
			showData();
		}

		private void register_Load(object sender, EventArgs e)
		{
			showData();
		}
	}
}
