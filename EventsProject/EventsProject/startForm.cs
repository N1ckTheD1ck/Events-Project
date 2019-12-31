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
using System.Data.OleDb;
using System.IO;

namespace EventsProject
{
	public partial class startForm : Form
	{
		public startForm()
		{
			InitializeComponent();
		}
		public startForm(string user)
		{
			InitializeComponent();
			usernameLabel.Text = user;
		}
		

		private void loginButton_Click(object sender, EventArgs e)
		{
			if(loginButton.Text == "login")
			{
				this.Hide();
				login login = new login();
				login.Show();
			}
			else
			{
				usernameLabel.Text = " ";
				myAccount acc = new myAccount();
				acc.logout();
				myAccountLabel.Visible = false;
				loginButton.Text = "login";
			}
			
		}

		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);

		public void eventLoad()
		{
			string sql = "SELECT * FROM EventTable";
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
					title.Text = dr["title"].ToString();
					description.Text = dr["description"].ToString();
					date.Text = dr["date"].ToString();
					place.Text = dr["place"].ToString();
					address.Text = dr["placeAddress"].ToString();
					byte[] fetchedImgBytes = (byte[])dr["image"];
					MemoryStream stream = new MemoryStream(fetchedImgBytes);
					Image fetchImg = Image.FromStream(stream);
					pictureBox1.Image = fetchImg;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			con.Close();
		}
		private void startForm_Load(object sender, EventArgs e)
		{
			loadEventWithId(pos);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			myAccount myacc = new myAccount(usernameLabel.Text);
			myacc.Show();
		}

		public void activate()
		{
			welcomeLabel.Visible = true;
			myAccountLabel.Visible = true;
			usernameLabel.Visible = true;
			loginButton.Text = "logout";
		}
		public void admin()
		{
			adminButton.Visible = true;
		}

		private void adminButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			adminForm admin = new adminForm();
			admin.Show();
		}
		int pos = 0;
		private void button6_Click(object sender, EventArgs e)
		{
			pos++;
			if (pos < table.Rows.Count)
			{
				loadEventWithId(pos);
			}
			else
			{
				MessageBox.Show("end");
				pos = table.Rows.Count - 1;
			}
		}

		OleDbDataAdapter adapter;
		DataTable table = new DataTable();
		public void loadEventWithId(int index)
		{
			adapter = new OleDbDataAdapter("SELECT * FROM EventTable", con);
			adapter.Fill(table);
			title.Text = table.Rows[index]["title"].ToString();
			description.Text = table.Rows[index]["description"].ToString();
			category.Text = table.Rows[index]["category"].ToString();
			place.Text = table.Rows[index]["place"].ToString();
			address.Text = table.Rows[index]["placeAddress"].ToString();
			town.Text = table.Rows[index]["town"].ToString();
			date.Text = table.Rows[index]["date"].ToString();
			byte[] fetchedImgBytes = (byte[])table.Rows[index]["image"];
			MemoryStream stream = new MemoryStream(fetchedImgBytes);
			Image fetchImg = Image.FromStream(stream);
			pictureBox1.Image = fetchImg;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			pos--;
			if (pos >= 0)
			{
				loadEventWithId(pos);
			}
			else
			{
				MessageBox.Show("zeroooo");
				pos = 0;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
