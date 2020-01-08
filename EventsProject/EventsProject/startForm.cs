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
using System.Net;

namespace EventsProject
{
	public partial class startForm : Form
	{
		static login log = new login();
		static int iden = log.identity();
		public startForm()
		{
			InitializeComponent();
		}
		public startForm(string user)
		{
			InitializeComponent();
			usernameLabel.Text = user;
		}

		bool called;
		private void loginButton_Click(object sender, EventArgs e)
		{
			if(loginButton.Text == "Login")
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
				loginButton.Text = "Login";
                adminButton.Visible = false;
				linkLabel1.Visible = false;
            }
			
		}

		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);

		public void eventLoad()
		{
			string sql = "SELECT * FROM EventTable";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			con.Open();

			OleDbDataReader dr = cmd.ExecuteReader();
			try
			{

				if (dr.Read())
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
			loadEventWithId(0);
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
			linkLabel1.Visible = true;
			loginButton.Text = "logout";
			interestButton.Visible = true;
		}
		public void admin()
		{
			adminButton.Visible = true;
		}

		private void adminButton_Click(object sender, EventArgs e)
		{
			adminForm admin = new adminForm();
			admin.Show();
		}
		int pos = 0;
		static string cat;
		OleDbDataAdapter adapter;
		DataTable table = new DataTable();
		private void button6_Click(object sender, EventArgs e)
		{
			if (called == true)
			{
				pos++;
				if (pos < table.Rows.Count)
				{
					loadEventWithcat(pos,cat);
				}
				else
				{
					MessageBox.Show("end");
					pos = table.Rows.Count - 1;
				}
			}
			else
			{
				loadEventWithId(pos);
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
		}

		
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
			/*byte[] fetchedImgBytes = (byte[])table.Rows[index]["image"];
			MemoryStream stream = new MemoryStream(fetchedImgBytes);
			Image fetchImg = Image.FromStream(stream);
			pictureBox1.Image = fetchImg;
			*/

			//To neo kommati kwdika gia tis fwtografies
			var imgUrl = table.Rows[index]["Pimg"].ToString();
			var request = WebRequest.Create(imgUrl);

			using (var response = request.GetResponse())
			using (var stream = response.GetResponseStream())
			{
				pictureBox1.Image = Bitmap.FromStream(stream);
			}
		}

		
		private void button5_Click(object sender, EventArgs e)
		{
			if (called == true)
			{
				pos--;
				pos = 0;
				if (pos >= 0)
				{
					loadEventWithcat(pos,cat);
				}
				else
				{
					MessageBox.Show("zeroooo");
					pos = 0;
				}
			}
			else
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
		}


		public void loadEventWithcat(int index,string categ)
		{
			OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM EventTable WHERE category LIKE '"+categ.ToString()+"'", con);
			DataTable table = new DataTable();
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
			called = true;
		}
		private void button4_Click(object sender, EventArgs e)
		{
			cat = button4.Text;
			loadEventWithcat(pos, cat);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
			cat = button3.Text;
			loadEventWithcat(pos,cat);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cat = button1.Text;
			loadEventWithcat(pos,cat);
		}

		private void searchEvent()
		{
			string sql = "SELECT * FROM EventTable WHERE title LIKE '%"+searchTextBox.Text+"%'";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			con.Open();

			OleDbDataReader dr = cmd.ExecuteReader();

			try
			{
				if (dr.Read())
				{
					title.Text = dr["title"].ToString();
					description.Text = dr["description"].ToString();
					category.Text = dr["category"].ToString();
					town.Text = dr["town"].ToString();
					place.Text = dr["place"].ToString();
					address.Text = dr["address"].ToString();
					date.Text = dr["date"].ToString();
					byte[] fetchedImgBytes = (byte[])dr["image"];
					MemoryStream stream = new MemoryStream(fetchedImgBytes);
					Image fetchImg = Image.FromStream(stream);
					pictureBox1.Image = fetchImg;
				}
				else
				{
					MessageBox.Show("event not found!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			searchEvent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			cat = button2.Text;
			loadEventWithcat(pos, cat);
		}

		
		public void interest(byte[] imgAsBytes)
		{
			con.Open();
			string sql = "INSERT INTO InterestTable (title, town, description, place, placeAddress, [date], [image], category, [user]) VALUES (?,?,?,?,?,?,?,?,?)";
			OleDbCommand cmd = new OleDbCommand(sql, con);

			login log = new login();
			cmd.Parameters.AddWithValue("@title", this.title.Text);
			cmd.Parameters.AddWithValue("@town", town.Text);
			cmd.Parameters.AddWithValue("@description", this.description.Text);
			cmd.Parameters.AddWithValue("@place", this.place.Text);
			cmd.Parameters.AddWithValue("@placeAddress", this.address.Text);
			cmd.Parameters.AddWithValue("@date", this.date.Text);
			OleDbParameter par = cmd.Parameters.AddWithValue("@image", SqlDbType.Binary);
			par.Value = imgAsBytes;
			par.Size = imgAsBytes.Length;
			cmd.Parameters.AddWithValue("@category", this.category.Text);
			cmd.Parameters.AddWithValue("@user", log.identity());
			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("προστεθηκε επιτυχως!");
			}
			catch (Exception ex)
			{
					MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		private byte[] imageToBytes(Image input)
		{
			Bitmap bit = new Bitmap(input);

			MemoryStream stream = new MemoryStream();
			bit.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
			byte[] imgAsBytes = stream.ToArray();

			return imgAsBytes;
		}

		private void interestButton_Click(object sender, EventArgs e)
		{
		
			interest(imageToBytes(pictureBox1.Image));
		}

		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			myEvents my = new myEvents();
			my.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			eventLoad();
		}
	}
}
