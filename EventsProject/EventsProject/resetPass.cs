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
using System.Security.Cryptography;
using System.Data.OleDb;

namespace EventsProject
{
	public partial class resetPass : Form
	{
		public resetPass()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}


		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		HashCode hash = new HashCode();
		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text == textBox2.Text)
			{
				forgotPass fp = new forgotPass();
				string mail = fp.getMail();
				string sql = "UPDATE UserTable SET [password] = '" + hash.encrypt(textBox1.Text) + "' WHERE email = '" + mail + "'";
				OleDbCommand cmd = new OleDbCommand(sql, con);
				cmd.CommandType = CommandType.Text;
				con.Open();
				try
				{
					cmd.ExecuteNonQuery();
					MessageBox.Show("password reset succesfully");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				con.Close();
				
			}
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			if(textBox1.Text.Length < 8)
			{
				label3.Visible = true;
				button1.Enabled = false;
			}
			else
			{
				label3.Visible = false;
				button1.Enabled = true;
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
