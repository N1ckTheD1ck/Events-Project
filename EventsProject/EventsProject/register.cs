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
			}
		}
		HashCode hash = new HashCode();
		private void insertData()
		{
			string username = usernameTextBox.Text;
			string password = hash.encrypt(passwordTextBox.Text);
			string fname = fnameTextBox.Text;
			string lname = lnameTextBox.Text;
			string email = mailTextBox.Text;
			string sql = "INSERT INTO UserTable(username,password,firstName,lastName,email) VALUES('"+username+ "','" + password + "','" + fname + "','" + lname + "','" + email + "')";
				OleDbCommand cmd = new OleDbCommand(sql,con);
				cmd.CommandType = CommandType.Text;


				con.Open();
			try {
				cmd.ExecuteScalar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}
		private void showData()
		{

			string sql = "SELECT * FROM UserTable";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
			DataSet ds = new DataSet();
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

			dataGridView1.DataSource = ds.Tables[0];
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
