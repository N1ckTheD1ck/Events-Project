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
			string sql = "SELECT username,firstName,lastName,city,address,email FROM UserTable";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
			DataSet ds = new DataSet();
			adapter.Fill(ds);

			con.Open();
			try
			{
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();

			dataGridView1.DataSource = ds.Tables[0];
		}
		private void allUsers_Load(object sender, EventArgs e)
		{
			showUsers();
		}
	}
}
