namespace EventsProject
{
	partial class myAccount
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.fnameTextBox = new System.Windows.Forms.TextBox();
			this.lnameTextBox = new System.Windows.Forms.TextBox();
			this.mailTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(118, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "first name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(118, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "last name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(118, 202);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "email";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(118, 255);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "city";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(118, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "address";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Location = new System.Drawing.Point(241, 26);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(171, 20);
			this.usernameTextBox.TabIndex = 6;
			// 
			// fnameTextBox
			// 
			this.fnameTextBox.Location = new System.Drawing.Point(241, 87);
			this.fnameTextBox.Name = "fnameTextBox";
			this.fnameTextBox.Size = new System.Drawing.Size(171, 20);
			this.fnameTextBox.TabIndex = 7;
			// 
			// lnameTextBox
			// 
			this.lnameTextBox.Location = new System.Drawing.Point(241, 147);
			this.lnameTextBox.Name = "lnameTextBox";
			this.lnameTextBox.Size = new System.Drawing.Size(171, 20);
			this.lnameTextBox.TabIndex = 8;
			// 
			// mailTextBox
			// 
			this.mailTextBox.Location = new System.Drawing.Point(241, 199);
			this.mailTextBox.Name = "mailTextBox";
			this.mailTextBox.Size = new System.Drawing.Size(171, 20);
			this.mailTextBox.TabIndex = 9;
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(241, 252);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(171, 20);
			this.cityTextBox.TabIndex = 10;
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(241, 301);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(171, 20);
			this.addressTextBox.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(269, 376);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "confirm";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// myAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 461);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.mailTextBox);
			this.Controls.Add(this.lnameTextBox);
			this.Controls.Add(this.fnameTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "myAccount";
			this.Text = "myAccount";
			this.Load += new System.EventHandler(this.myAccount_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.TextBox fnameTextBox;
		private System.Windows.Forms.TextBox lnameTextBox;
		private System.Windows.Forms.TextBox mailTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Button button1;
	}
}