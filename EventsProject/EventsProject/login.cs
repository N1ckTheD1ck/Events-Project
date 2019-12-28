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
using System.Security.Cryptography;

namespace EventsProject
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kostas\Source\Repos\N1ckTheD1ck\Events-Project-Team-7\EventsProject\EventsProject\Events.mdf;Integrated Security = True");
		HashCode hash = new HashCode();

		private void authentication()
		{
			string sql = "SELECT * FROM UserTable WHERE username = '" + usernameTextBox.Text + "' AND password = '" + hash.encrypt(passwordTextBox.Text) + "'";
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds);

			con.Open();

			SqlDataReader dr = cmd.ExecuteReader();
			try
			{
				
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
			string username = usernameTextBox.Text;
			authentication();
			this.Hide();
			startForm start = new startForm(username);
			start.Show();
			start.activate();
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			register reg = new register();
			reg.Show();
		}

		private void forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			forgotPass forgot = new forgotPass();
			forgot.Show();
		}
	}
}
