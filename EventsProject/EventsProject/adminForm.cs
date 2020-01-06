﻿using System;
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
	public partial class adminForm : Form
	{
		public adminForm()
		{
			InitializeComponent();
		}

		OleDbConnection con = new OleDbConnection(Properties.Settings.Default.EventsConnectionString);
		
		private void button1_Click(object sender, EventArgs e)
		{
			addEvent add = new addEvent();
			add.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			allEvents events = new allEvents();
			events.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			allUsers users = new allUsers();
			users.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			startForm start = new startForm();
			start.Show();
		}
	}
}
