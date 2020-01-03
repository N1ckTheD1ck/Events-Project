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
	public partial class myEvents : Form
	{
		public myEvents()
		{
			InitializeComponent();
		}
		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		private void showData()
		{
			login log = new login();
			int id = log.identity();
			string sql = "SELECT * FROM InterestTable WHERE [user]="+id+"";
			OleDbCommand cmd = new OleDbCommand(sql, con);
			cmd.CommandType = CommandType.Text;

			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
			DataTable ds = new DataTable();
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

			dataGridView1.DataSource = ds;
		}
		private void myEvents_Load(object sender, EventArgs e)
		{
			showData();
		}
	}
}
