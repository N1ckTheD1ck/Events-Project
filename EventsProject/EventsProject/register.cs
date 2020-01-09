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
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;


namespace EventsProject
{
	public partial class register : Form
	{
		public register()
		{
			InitializeComponent();
		}
		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		private void passwordText_Leave(object sender, EventArgs e)
		{
			if(passwordTextBox.Text.Length < 8)
			{
				passwordLabel.Visible = true;
				button1.Enabled = false;
				
			}
			else
			{
				passwordLabel.Visible = false;
				button1.Enabled = true;
			}
		}
		HashCode hash = new HashCode();
		private void insertData()
		{
			string check = "SELECT * FROM UserTable WHERE username = @username";
			OleDbCommand checkcmd = new OleDbCommand(check, con);
			checkcmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
			
			con.Open();

			OleDbDataReader dr = checkcmd.ExecuteReader();

			if (dr.Read())
			{
				MessageBox.Show("το username χρησιμοποιειται ηδη,παρακαλω επιλεξτε διαφορετικο username");
			}
			else
			{
				const string V = "INSERT INTO UserTable (username, [password], firstName, lastName, city, address, email, is_admin) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
				var sql = V;
				OleDbCommand cmd = new OleDbCommand(sql, con);
				cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
				cmd.Parameters.AddWithValue("@password", hash.encrypt(passwordTextBox.Text));
				cmd.Parameters.AddWithValue("@firstName", fnameTextBox.Text);
				cmd.Parameters.AddWithValue("@lastName", lnameTextBox.Text);
				cmd.Parameters.AddWithValue("@city", cityTextBox.Text);
				cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
				cmd.Parameters.AddWithValue("@email", mailTextBox.Text);
				cmd.Parameters.AddWithValue("@is_admin", 0);

				try
				{
					cmd.ExecuteNonQuery();
					MessageBox.Show("Succesfully Registered.Please Login");
					login log = new login();
					this.Hide();
					log.Show();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			
			con.Close();
		}
		/*
		private void showData()
		{

			string sql = "SELECT * FROM UserTable";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
			DataTable ds = new DataTable();
			adapter.Fill(ds);

			con.Open();
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();

			dataGridView1.DataSource = ds;
		}
		*/
		private void button1_Click(object sender, EventArgs e)
		{
			insertData();
			//showData();
		}

		private void register_Load(object sender, EventArgs e)
		{
			//showData();
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

		private void backButton_Click(object sender, EventArgs e)
		{
			login login = new login();
			this.Hide();
			login.Show();
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
