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
using System.Security.Cryptography;

namespace EventsProject
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		HashCode hash = new HashCode();

		public string authentication()
		{
			string sql = "SELECT * FROM UserTable WHERE username = '" + usernameTextBox.Text + "' AND [password] = '" + hash.encrypt(passwordTextBox.Text) + "'";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			string user = null;
			con.Open();

			OleDbDataReader dr = cmd.ExecuteReader();
			try
			{

				while (dr.Read())
				{
					MessageBox.Show("login succesfully!!!");
					user = dr["username"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			con.Close();
			return user;
		}
		
		public void loginButton_Click(object sender, EventArgs e)
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
