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
using System.Data.SqlClient;

namespace EventsProject
{
	public partial class forgotPass : Form
	{
		public forgotPass()
		{
			InitializeComponent();
		}

		public static string to;
		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kostas\Source\Repos\N1ckTheD1ck\Events-Project-Team-7\EventsProject\EventsProject\Events.mdf;Integrated Security = True");
		HashCode hash = new HashCode();

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void getPass()
		{
			string sql = "SELECT * FROM UserTable WHERE username = '" + textBox1.Text + "'";
			string password = "";
			string email = "";
			SqlCommand cmd = new SqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds);

			con.Open();

			SqlDataReader dr = cmd.ExecuteReader();
			try
			{
				if (dr.Read())
				{
					password = dr["password"].ToString();
					email = dr["email"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
			string from, pass, message;
			MailMessage mail = new MailMessage();
			to = email;
			from = "kmpatz88@gmail.com";
			pass = "19122014";
			message = "your reset code is:" + hash.decrypt(password);
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

	}

		private void button1_Click(object sender, EventArgs e)
		{
			getPass();
		}	
	}
}
