using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;

namespace EventsProject
{
	public partial class forgotPass : Form
	{
		public forgotPass()
		{
			InitializeComponent();
		}

		public static string to;
		public static string email;
		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		HashCode hash = new HashCode();
		string randomCode;

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		public void getPass()
		{
			string sql = "SELECT * FROM UserTable WHERE username = '" + textBox1.Text + "'";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds);

			con.Open();

			OleDbDataReader dr = cmd.ExecuteReader();
			try
			{
				if (dr.Read())
				{
					email = dr["email"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();

	}

		private void button1_Click(object sender, EventArgs e)
		{
			getPass();
			
			string from, pass, message;
			Random rand = new Random();
			randomCode = (rand.Next(999999)).ToString();
			MailMessage mail = new MailMessage();
			to = email;
			from = "eventsteamadopse@gmail.com";
			pass = "eventsTeam7!";
			message = "your reset code is:" + " " + randomCode; ;
			mail.To.Add(to);
			mail.From = new MailAddress(from);
			mail.Body = message;
			mail.Subject = "password reset code";
			SmtpClient smtp = new SmtpClient("smtp.gmail.com");
			smtp.EnableSsl = true;
			smtp.Port = 587;
			smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtp.Credentials = new NetworkCredential(from, pass);
			try
			{
				smtp.Send(mail);
				MessageBox.Show("password send successfully");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			verifyButton.Visible = true;
			verifyText.Visible = true;
			label2.Visible = true;
		}

		public string getMail()
		{
			return to;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void verifyButton_Click(object sender, EventArgs e)
		{
			if(randomCode == (verifyText.Text).ToString())
			{
				resetPass rp = new resetPass();
				this.Hide();
				rp.Show();
			}
			else
			{
				MessageBox.Show("wrong verification code!");
			}
		}

        private void forgotPass_Load(object sender, EventArgs e)
        {

        }

        private void verifyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

		private void backButton_Click(object sender, EventArgs e)
		{
			login log = new login();
			this.Hide();
			log.Show();
		}
	}
}
