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


		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kostas\Source\Repos\N1ckTheD1ck\Events-Project-Team-7\EventsProject\EventsProject\Event.mdf;Integrated Security = True");
		public void eventLoad()
		{
			string sql = "SELECT * FROM EventTable";
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
					title.Text = dr["name"].ToString();
					description.Text = dr["description"].ToString();
					date.Text = dr["date"].ToString();
					place.Text = dr["place"].ToString();
					address.Text = dr["placeAddress"].ToString();
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
			eventLoad();
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
	}
}
