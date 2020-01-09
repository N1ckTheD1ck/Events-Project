namespace EventsProject
{
	partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.button1 = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(121, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(121, 100);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(157, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(121, 143);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(121, 270);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(157, 20);
            this.cityTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(121, 311);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(157, 20);
            this.addressTextBox.TabIndex = 4;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(28, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(28, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(28, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(28, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(324, 146);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(272, 13);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Ο κωδικός πρέπει να εχει τουλάχιστον 8 χαρακτήρες";
            this.passwordLabel.Visible = false;
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Location = new System.Drawing.Point(121, 184);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(157, 20);
            this.fnameTextBox.TabIndex = 13;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Location = new System.Drawing.Point(121, 228);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(157, 20);
            this.lnameTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(28, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "First name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(28, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Last name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(0, 0);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Visible = false;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(121, 357);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(157, 20);
            this.mailTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(28, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "E-mail";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(322, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.backButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(3, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(41, 27);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox fnameTextBox;
		private System.Windows.Forms.TextBox lnameTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox mailTextBox;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button backButton;
	}
}

