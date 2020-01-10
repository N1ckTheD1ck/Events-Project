using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using System.Net;
using System.Threading.Tasks;

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

		private void startForm_Load(object sender, EventArgs e)
		{
			loadEventWithId(0);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
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
			adapter = new OleDbDataAdapter("SELECT * FROM Events", con);
			adapter.Fill(table);

			con.Open();
			try
			{
				title.Text = table.Rows[index]["PName"].ToString();
				description.Text = table.Rows[index]["PDesc"].ToString();
				category.Text = table.Rows[index]["PCategory"].ToString();
				place.Text = table.Rows[index]["PPlace"].ToString();
				address.Text = table.Rows[index]["PAddress"].ToString();
				town.Text = table.Rows[index]["PTown"].ToString();
				date.Text = table.Rows[index]["PsD"].ToString();
				date2.Text = table.Rows[index]["PeD"].ToString();
				/*byte[] fetchedImgBytes = (byte[])table.Rows[index]["image"];
				MemoryStream stream = new MemoryStream(fetchedImgBytes);
				Image fetchImg = Image.FromStream(stream);
				pictureBox1.Image = fetchImg;*/

				//To neo kommati kwdika gia tis fwtografies
				var imgUrl = table.Rows[index]["Pimg"].ToString();
				var request = WebRequest.Create(imgUrl);

				using (var response = request.GetResponse())
				using (var stream = response.GetResponseStream())
				{
					pictureBox1.Image = Bitmap.FromStream(stream);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();

			
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
			OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Events WHERE PCategory LIKE '"+categ.ToString()+"'", con);
			DataTable table = new DataTable();
			adapter.Fill(table);
			con.Open();
			try
			{
				title.Text = table.Rows[index]["PName"].ToString();
				description.Text = table.Rows[index]["PDesc"].ToString();
				category.Text = table.Rows[index]["PCategory"].ToString();
				place.Text = table.Rows[index]["PPlace"].ToString();
				address.Text = table.Rows[index]["PAddress"].ToString();
				town.Text = table.Rows[index]["PTown"].ToString();
				date.Text = table.Rows[index]["PsD"].ToString();
				date2.Text = table.Rows[index]["PeD"].ToString();
				/*byte[] fetchedImgBytes = (byte[])table.Rows[index]["image"];
				MemoryStream stream = new MemoryStream(fetchedImgBytes);
				Image fetchImg = Image.FromStream(stream);
				pictureBox1.Image = fetchImg;*/

				//To neo kommati kwdika gia tis fwtografies
				var imgUrl = table.Rows[index]["Pimg"].ToString();
				var request = WebRequest.Create(imgUrl);

				using (var response = request.GetResponse())
				using (var stream = response.GetResponseStream())
				{
					pictureBox1.Image = Bitmap.FromStream(stream);
				}
				called = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			cat = "θεατρο";
			loadEventWithcat(pos, cat);
		}

		private void button3_Click(object sender, EventArgs e)
		{

			cat = "εκδηλωσεις";
			loadEventWithcat(pos,cat);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cat = "παιδικες";
			loadEventWithcat(pos,cat);
		}

		private void searchEvent()
		{
			string sql = "SELECT * FROM Events WHERE title LIKE '%"+searchTextBox.Text+"%'";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			con.Open();

			OleDbDataReader dr = cmd.ExecuteReader();

			try
			{
				if (dr.Read())
				{
					title.Text = dr["PName"].ToString();
					description.Text = dr["Desc"].ToString();
					category.Text = dr["Category"].ToString();
					place.Text = dr["Place"].ToString();
					address.Text = dr["Addr"].ToString();
					town.Text = dr["Town"].ToString();
					date.Text = dr["PSD"].ToString();
					date2.Text = dr["PED"].ToString();
					/* byte[] fetchedImgBytes = (byte[])dr["image"];
					MemoryStream stream = new MemoryStream(fetchedImgBytes);
					Image fetchImg = Image.FromStream(stream);
					pictureBox1.Image = fetchImg; */
					var imgUrl = dr["Pimg"].ToString();
					var request = WebRequest.Create(imgUrl);

					using (var response = request.GetResponse())
					using (var stream = response.GetResponseStream())
					{
						pictureBox1.Image = Bitmap.FromStream(stream);
					}
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
			cat = "συναυλιες";
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
			loadEventWithId(0);
		}

        private void description_Click(object sender, EventArgs e)
        {

        }
    }
}
