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
		
		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kostas\Source\Repos\N1ckTheD1ck\Events-Project-Team-7\EventsProject\EventsProject\Events.mdf;Integrated Security = True");
		
		public void getUser()
		{
			string sql = "SELECT * FROM UserTable WHERE username = '"+usernameTextBox.Text+"'";
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds);

			con.Open();

			SqlDataReader dr = cmd.ExecuteReader();
			try
			{

				while (dr.Read())
				{
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
			SqlCommand cmd = new SqlCommand("updateUser", con);
			cmd.CommandType = CommandType.StoredProcedure;

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
	}
}
