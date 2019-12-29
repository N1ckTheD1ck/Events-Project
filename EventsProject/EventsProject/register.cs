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


namespace EventsProject
{
	public partial class register : Form
	{
		public register()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kostas\Source\Repos\N1ckTheD1ck\Events-Project-Team-7\EventsProject\EventsProject\Event.mdf;Integrated Security = True");
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
				SqlCommand cmd = new SqlCommand("addUser",con);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@username", this.usernameTextBox.Text);
				cmd.Parameters.AddWithValue("@password", hash.encrypt(this.passwordTextBox.Text));
				cmd.Parameters.AddWithValue("@lastName", this.lnameTextBox.Text);
				cmd.Parameters.AddWithValue("@firstName", this.fnameTextBox.Text);
				cmd.Parameters.AddWithValue("@city", this.cityTextBox.Text);
				cmd.Parameters.AddWithValue("@address", this.addressTextBox.Text);
				cmd.Parameters.AddWithValue("@email", this.mailTextBox.Text);

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
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
