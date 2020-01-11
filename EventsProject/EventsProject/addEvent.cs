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
using System.Net;

namespace EventsProject
{
	public partial class addEvent : Form
	{
		public addEvent()
		{
			InitializeComponent();
		}

		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		private void add(/*byte[] imgAsBytes*/)
		{
			string sql = "INSERT INTO Events (PName, PDesc, PCategory, PPlace, PAddress, PTown, PsD, PeD, Pimg) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			con.Open();

			cmd.Parameters.AddWithValue("@PName", titleTextBox.Text);
			cmd.Parameters.AddWithValue("@PDesc", descriptionTextBox.Text);
			cmd.Parameters.AddWithValue("@PCategory", categoryComboBox.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@PPlace", placeTextBox.Text);
			cmd.Parameters.AddWithValue("@PAddress", streetTextBox.Text);
			cmd.Parameters.AddWithValue("@PeD", this.dateTimePicker1.Value);
			cmd.Parameters.AddWithValue("@PsD", this.dateTimePicker2.Value);
			cmd.Parameters.AddWithValue("@PTown", townTextBox.Text);
			cmd.Parameters.AddWithValue("@Pimg", urlTextBox.Text);
			/*OleDbParameter par = cmd.Parameters.AddWithValue("@image", SqlDbType.Binary);
			par.Value = imgAsBytes;
			par.Size = imgAsBytes.Length;*/

			var imgUrl = urlTextBox.Text;
			var request = WebRequest.Create(imgUrl);

			using (var response = request.GetResponse())
			using (var stream = response.GetResponseStream())
			{
				pictureBox1.Image = Bitmap.FromStream(stream);
			}
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

		/*private byte[] imageToBytes(Image input)
		{
			Bitmap bit = new Bitmap(input);

			MemoryStream stream = new MemoryStream();
			bit.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
			byte[] imgAsBytes = stream.ToArray();

			return imgAsBytes;
		}*/

		private void button1_Click(object sender, EventArgs e)
		{
			add(/*imageToBytes(pictureBox1.Image)*/);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			
		}

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
