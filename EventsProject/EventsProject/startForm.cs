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


		private void startForm_Load(object sender, EventArgs e)
		{
			
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			myAccount myacc = new myAccount(usernameLabel.Text);
			myacc.Show();
		}

		public void activate()
		{
			welcomeLabel.Visible = true;
			myAccountLabel.Visible = true;
			usernameLabel.Visible = true;
			
		}
	}
}
