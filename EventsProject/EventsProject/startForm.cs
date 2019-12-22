using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsProject
{
	public partial class startForm : Form
	{
		public startForm()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			login login = new login();
			login.Show();
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			register reg = new register();
			reg.Show();
		}
	}
}
