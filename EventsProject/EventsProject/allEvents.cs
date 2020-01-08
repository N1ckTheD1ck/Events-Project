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
			string sql = "SELECT * FROM Events";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			con.Open();
			OleDbDataReader dr = cmd.ExecuteReader();
			
			try
			{
				while (dr.Read())
				{
					id = Convert.ToInt32(dr["ID"]);
					titleTextBox.Text = dr["PName"].ToString();
					descriptionTextBox.Text = dr["Desc"].ToString();
					dateTimePicker1.Value = Convert.ToDateTime(dr["PSD"]);
					dateTimePicker2.Value = Convert.ToDateTime(dr["PED"]);
					placeTextBox.Text = dr["Place"].ToString();
					streetTextBox.Text = dr["Addr"].ToString();
					townTextBox.Text = dr["Town"].ToString();
					categoryComboBox.Text = dr["Category"].ToString();
					/*byte[] fetchedImgBytes = (byte[])dr["image"];
					MemoryStream stream = new MemoryStream(fetchedImgBytes);
					Image fetchImg = Image.FromStream(stream);
					pictureBox1.Image = fetchImg;*/
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
			string sql = "UPDATE Events SET PName=@title, Desc=@description, Category=@category, Town=@town, Place=@place, Addr=@address, PSD=@date1, PED=@date2  WHERE [ID]="+id+"";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			cmd.Parameters.AddWithValue("@title", this.titleTextBox.Text);
			cmd.Parameters.AddWithValue("@description", this.descriptionTextBox.Text);
			cmd.Parameters.AddWithValue("@category", this.categoryComboBox.Text);
			cmd.Parameters.AddWithValue("@town", this.townTextBox.Text);
			cmd.Parameters.AddWithValue("@place", this.placeTextBox.Text);
			cmd.Parameters.AddWithValue("@address", this.streetTextBox.Text);
			cmd.Parameters.AddWithValue("@date1", this.dateTimePicker1.Value);
			cmd.Parameters.AddWithValue("@date2", this.dateTimePicker1.Value);
			/*OleDbParameter par = cmd.Parameters.AddWithValue("@image", SqlDbType.Binary);
			par.Value = imgAsBytes;
			par.Size = imgAsBytes.Length;*/

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
			string sql = "DELETE FROM Events WHERE [ID]=" + id + "";
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
			con.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void allEvents_Load(object sender, EventArgs e)
		{
			loadEventWithId(0);
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
			adapter = new OleDbDataAdapter("SELECT * FROM Events", con);
			adapter.Fill(table);
			id = (int)table.Rows[index]["ID"];
			titleTextBox.Text = table.Rows[index]["Pname"].ToString();
			descriptionTextBox.Text = table.Rows[index]["Desc"].ToString();
			categoryComboBox.Text = table.Rows[index]["Category"].ToString();
			placeTextBox.Text = table.Rows[index]["Place"].ToString();
			streetTextBox.Text = table.Rows[index]["Addr"].ToString();
			townTextBox.Text = table.Rows[index]["Town"].ToString();
			dateTimePicker1.Value = Convert.ToDateTime(table.Rows[index]["PSD"]);
			/*byte[] fetchedImgBytes = (byte[])table.Rows[index]["image"];
			MemoryStream stream = new MemoryStream(fetchedImgBytes);
			Image fetchImg = Image.FromStream(stream);
			pictureBox1.Image = fetchImg;*/
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
				pos = 0;
			}
		}
    }
}
