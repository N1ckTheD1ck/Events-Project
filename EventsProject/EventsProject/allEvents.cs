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
using System.IO;


namespace EventsProject
{
	public partial class allEvents : Form
	{
		public allEvents()
		{
			InitializeComponent();
		}

		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{

		}

		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		public static int id;
		int pos = 0;
		public void eventLoad()
		{
			string sql = "SELECT * FROM EventTable";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;
			DataSet ds = new DataSet();
			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
			adapter.Fill(ds);

			con.Open();

			OleDbDataReader dr = cmd.ExecuteReader();
			try
			{

				while (dr.Read())
				{
					id = Convert.ToInt32(dr["ID"]);
					titleTextBox.Text = dr["title"].ToString();
					descriptionTextBox.Text = dr["description"].ToString();
					dateTimePicker1.Text = dr["date"].ToString();
					placeTextBox.Text = dr["place"].ToString();
					streetTextBox.Text = dr["placeAddress"].ToString();
					townTextBox.Text = dr["town"].ToString();
					categoryComboBox.Text = dr["category"].ToString();
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
		

		public void updateEvent(byte[] imgAsBytes)
		{
			string sql = "UPDATE EventTable SET title=@title, description=@description, category=@category, town=@town, place=@city, placeAddress=@address, [date]=@date, [image]=@image  WHERE [ID]="+id+"";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			cmd.Parameters.AddWithValue("@title", this.titleTextBox.Text);
			cmd.Parameters.AddWithValue("@description", this.descriptionTextBox.Text);
			cmd.Parameters.AddWithValue("@category", this.categoryComboBox.Text);
			cmd.Parameters.AddWithValue("@town", this.townTextBox.Text);
			cmd.Parameters.AddWithValue("@city", this.townTextBox.Text);
			cmd.Parameters.AddWithValue("@address", this.streetTextBox.Text);
			cmd.Parameters.AddWithValue("@date", this.dateTimePicker1.Text);
			OleDbParameter par = cmd.Parameters.AddWithValue("@image", SqlDbType.Binary);
			par.Value = imgAsBytes;
			par.Size = imgAsBytes.Length;

			con.Open();

			try
			{
				cmd.ExecuteScalar();
				MessageBox.Show("updated succesfully");
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

		private void deleteEvent()
		{
			string sql = "DELETE FROM EventTable WHERE ID=" + id + "";
			OleDbCommand cmd = new OleDbCommand(sql,con);

			con.Open();
			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("deleted successfully");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void allEvents_Load(object sender, EventArgs e)
		{
			loadEventWithId(pos);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			updateEvent(imageToBytes(pictureBox1.Image));
		}

		private void button3_Click(object sender, EventArgs e)
		{
			deleteEvent();
			eventLoad();
		}

		OleDbDataAdapter adapter;
		DataTable table = new DataTable();
		public void loadEventWithId(int index)
		{
			adapter = new OleDbDataAdapter("SELECT * FROM EventTable", con);
			adapter.Fill(table);
			id = (int)table.Rows[index]["ID"];
			titleTextBox.Text = table.Rows[index]["title"].ToString();
			descriptionTextBox.Text = table.Rows[index]["description"].ToString();
			categoryComboBox.Text = table.Rows[index]["category"].ToString();
			placeTextBox.Text = table.Rows[index]["place"].ToString();
			streetTextBox.Text = table.Rows[index]["placeAddress"].ToString();
			townTextBox.Text = table.Rows[index]["town"].ToString();
			dateTimePicker1.Text = table.Rows[index]["date"].ToString();
			byte[] fetchedImgBytes = (byte[])table.Rows[index]["image"];
			MemoryStream stream = new MemoryStream(fetchedImgBytes);
			Image fetchImg = Image.FromStream(stream);
			pictureBox1.Image = fetchImg;
		}
		
		private void button2_Click(object sender, EventArgs e)
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

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();

			if (open.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = new Bitmap(open.FileName);
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			pos--;
			if (pos >= 0)
			{
				loadEventWithId(pos);
			}
			else
			{
				MessageBox.Show("zeroooo");
			}
		}
	}
}
