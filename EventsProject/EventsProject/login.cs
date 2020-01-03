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

		public int authentication()
		{
			string sql = "SELECT * FROM UserTable WHERE username = '" + usernameTextBox.Text + "' AND [password] = '" + hash.encrypt(passwordTextBox.Text) + "'";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds);
			int is_admin = 0;
			con.Open();

			OleDbDataReader dr = cmd.ExecuteReader();
			try
			{

				if (dr.Read())
				{
					MessageBox.Show("login succesfully!!!");
					is_admin = Convert.ToInt32(dr["is_admin"]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			con.Close();
			return is_admin;
		}
		
		public void loginButton_Click(object sender, EventArgs e)
		{
			string username = usernameTextBox.Text;
			if (usernameTextBox.Text.Length != 0)
			{
				authentication();
			}
			else
			{
				MessageBox.Show("empty fields");
			}
			
			this.Hide();
			startForm start = new startForm(username);
			start.Show();
			start.activate();
			if (authentication() == 1)
			{
				start.admin();
			}
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

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
