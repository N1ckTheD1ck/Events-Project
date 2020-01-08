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
using System.Data.SqlClient;
using System.IO;

namespace EventsProject
{
	public partial class addEvent : Form
	{
		public addEvent()
		{
			InitializeComponent();
		}

		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		private void add(byte[] imgAsBytes)
		{
			string sql = "INSERT INTO EventTable (PName, Desc, Category, Place, Addr, Town, PSD, PED) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			con.Open();

			cmd.Parameters.AddWithValue("@PName", titleTextBox.Text);
			cmd.Parameters.AddWithValue("@Desc", descriptionTextBox.Text);
			cmd.Parameters.AddWithValue("@Category", categoryComboBox.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@Place", placeTextBox.Text);
			cmd.Parameters.AddWithValue("@Addr", streetTextBox.Text);
			cmd.Parameters.AddWithValue("@PED", this.dateTimePicker1);
			cmd.Parameters.AddWithValue("@PSD", this.dateTimePicker2);
			cmd.Parameters.AddWithValue("@Town", townTextBox.Text);
			/*OleDbParameter par = cmd.Parameters.AddWithValue("@image", SqlDbType.Binary);
			par.Value = imgAsBytes;
			par.Size = imgAsBytes.Length;*/
			try
			{
				cmd.ExecuteNonQuery();
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

		private void button1_Click(object sender, EventArgs e)
		{
			add(imageToBytes(pictureBox1.Image));
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			
			if(open.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = new Bitmap(open.FileName);
			}
		}
	}
}
