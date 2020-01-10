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

namespace EventsProject
{
	public partial class allUsers : Form
	{
		public allUsers()
		{
			InitializeComponent();
		}
		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		private void showUsers()
		{
			string sql = "SELECT * FROM UserTable";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;
			con.Open();
			OleDbDataReader dr = cmd.ExecuteReader();
			
			try
			{
				while (dr.Read())
				{
					listBox1.Items.Add(string.Format("{0} | {1} | {2} | {3} ", dr["username"], dr["firstName"], dr["lastName"], dr["email"]));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();

			
		}
		private void allUsers_Load(object sender, EventArgs e)
		{
			showUsers();
		}

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
