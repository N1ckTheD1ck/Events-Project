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
		public startForm(string user)
		{
			InitializeComponent();
			usernameLabel.Text = user;
		}
		
		private void loginButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			login login = new login();
			login.Show();
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			register reg = new register();
			reg.Show();
		}

		private void startForm_Load(object sender, EventArgs e)
		{

		}
	}
}
