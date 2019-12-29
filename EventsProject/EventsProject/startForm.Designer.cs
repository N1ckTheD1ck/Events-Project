namespace EventsProject
{
	partial class startForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.loginButton = new System.Windows.Forms.Button();
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.address = new System.Windows.Forms.Label();
			this.place = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.Label();
			this.description = new System.Windows.Forms.Label();
			this.title = new System.Windows.Forms.Label();
			this.myAccountLabel = new System.Windows.Forms.LinkLabel();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.eventsDataSet = new EventsProject.EventsDataSet();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eventsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(12, 241);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 0;
			this.loginButton.Text = "login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.AutoSize = true;
			this.welcomeLabel.Location = new System.Drawing.Point(662, 24);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Size = new System.Drawing.Size(55, 13);
			this.welcomeLabel.TabIndex = 2;
			this.welcomeLabel.Text = "Welcome:";
			this.welcomeLabel.Visible = false;
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(723, 24);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(0, 13);
			this.usernameLabel.TabIndex = 3;
			this.usernameLabel.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 188);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Μπουζουκια";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 136);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Live";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 82);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Cinema";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 24);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Θεατρο";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.address);
			this.panel1.Controls.Add(this.place);
			this.panel1.Controls.Add(this.date);
			this.panel1.Controls.Add(this.description);
			this.panel1.Controls.Add(this.title);
			this.panel1.Location = new System.Drawing.Point(182, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(457, 398);
			this.panel1.TabIndex = 8;
			// 
			// address
			// 
			this.address.AutoSize = true;
			this.address.Location = new System.Drawing.Point(3, 336);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(44, 13);
			this.address.TabIndex = 4;
			this.address.Text = "address";
			// 
			// place
			// 
			this.place.AutoSize = true;
			this.place.Location = new System.Drawing.Point(3, 299);
			this.place.Name = "place";
			this.place.Size = new System.Drawing.Size(33, 13);
			this.place.TabIndex = 3;
			this.place.Text = "place";
			// 
			// date
			// 
			this.date.AutoSize = true;
			this.date.Location = new System.Drawing.Point(3, 370);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(28, 13);
			this.date.TabIndex = 2;
			this.date.Text = "date";
			// 
			// description
			// 
			this.description.AutoSize = true;
			this.description.Location = new System.Drawing.Point(65, 240);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(58, 13);
			this.description.TabIndex = 1;
			this.description.Text = "description";
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Location = new System.Drawing.Point(202, 206);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(27, 13);
			this.title.TabIndex = 0;
			this.title.Text = "Title";
			// 
			// myAccountLabel
			// 
			this.myAccountLabel.AutoSize = true;
			this.myAccountLabel.Location = new System.Drawing.Point(684, 57);
			this.myAccountLabel.Name = "myAccountLabel";
			this.myAccountLabel.Size = new System.Drawing.Size(64, 13);
			this.myAccountLabel.TabIndex = 9;
			this.myAccountLabel.TabStop = true;
			this.myAccountLabel.Text = "My Account";
			this.myAccountLabel.Visible = false;
			this.myAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(182, 405);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 10;
			this.button5.Text = "< previous";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(564, 405);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 11;
			this.button6.Text = "next >";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.eventsDataSet;
			this.bindingSource1.Position = 0;
			// 
			// eventsDataSet
			// 
			this.eventsDataSet.DataSetName = "EventsDataSet";
			this.eventsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(457, 185);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// startForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 449);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.myAccountLabel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.welcomeLabel);
			this.Controls.Add(this.loginButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "startForm";
			this.Text = "startForm";
			this.Load += new System.EventHandler(this.startForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eventsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.LinkLabel myAccountLabel;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.BindingSource bindingSource1;
		private EventsDataSet eventsDataSet;
		private System.Windows.Forms.Label place;
		private System.Windows.Forms.Label date;
		private System.Windows.Forms.Label description;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label address;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}