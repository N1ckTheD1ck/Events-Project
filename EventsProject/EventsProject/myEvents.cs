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
using System.Net;

namespace EventsProject
{
	public partial class myEvents : Form
	{
		public myEvents()
		{
			InitializeComponent();
		}
		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		static int pos = 0;
		OleDbDataAdapter adapter;
		DataTable table = new DataTable();
		private void showData(int index)
		{
			login log = new login();
			int id = log.identity();
			string sql = "SELECT * FROM InterestTable WHERE [user]="+id+"";
			OleDbCommand cmd = new OleDbCommand(sql, con);

			adapter = new OleDbDataAdapter(cmd);
			adapter.Fill(table);

			con.Open();
			try
			{
				title.Text = table.Rows[index]["title"].ToString();
				richTextBox1.Text = table.Rows[index]["description"].ToString();
				cat.Text = table.Rows[index]["category"].ToString();
				placeLabel.Text = table.Rows[index]["place"].ToString();
				addressLabel.Text = table.Rows[index]["placeAddress"].ToString();
				townLabel.Text = table.Rows[index]["town"].ToString();
				date1.Text = table.Rows[index]["sDate"].ToString();
				date2.Text = table.Rows[index]["eDate"].ToString();
				/*byte[] fetchedImgBytes = (byte[])table.Rows[index]["image"];
				MemoryStream stream = new MemoryStream(fetchedImgBytes);
				Image fetchImg = Image.FromStream(stream);
				pictureBox1.Image = fetchImg;*/

				//To neo kommati kwdika gia tis fwtografies
				var imgUrl = table.Rows[index]["image"].ToString();
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
		private void myEvents_Load(object sender, EventArgs e)
		{
			showData(0);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			pos++;
			if (pos < table.Rows.Count)
			{
				showData(pos);
			}
			else
			{
				MessageBox.Show("end");
				pos = table.Rows.Count - 1;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			pos--;
			if (pos >= 0)
			{

				showData(pos);
			}
			else
			{
				MessageBox.Show("zeroooo");
				pos = 0;
			}
		}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            startForm startF = new startForm();
            this.Hide();
            startF.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
