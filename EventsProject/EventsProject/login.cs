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
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(Properties.Settings.Default.EventsConnectionString);

		private void authentication()
		{
			string sql = "SELECT * FROM [user] WHERE username = '" + usernameTextBox.Text + "' AND password = '" + passwordTextBox.Text + "'";
			try
			{
				con.Open();
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = sql;
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					MessageBox.Show("login succesfully!!!");
				}
				else
				{
					MessageBox.Show("wrong username or password");
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void loginButton_Click(object sender, EventArgs e)
		{
			authentication();
		}
	}
}
