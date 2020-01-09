namespace EventsProject
{
	partial class login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.forgotPass = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.backButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.AccessibleName = "";
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
			this.usernameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.usernameTextBox.Location = new System.Drawing.Point(97, 181);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(249, 20);
			this.usernameTextBox.TabIndex = 0;
			this.usernameTextBox.Text = "Username";
			this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.AccessibleDescription = "";
			this.passwordTextBox.AccessibleName = "";
			this.passwordTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
			this.passwordTextBox.Location = new System.Drawing.Point(97, 233);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(249, 20);
			this.passwordTextBox.TabIndex = 1;
			this.passwordTextBox.Text = "Password";
			this.passwordTextBox.UseSystemPasswordChar = true;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.loginButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.ForeColor = System.Drawing.SystemColors.Window;
			this.loginButton.Location = new System.Drawing.Point(97, 321);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(249, 34);
			this.loginButton.TabIndex = 2;
			this.loginButton.Text = "Login";
			this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.registerButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
			this.registerButton.ForeColor = System.Drawing.SystemColors.Window;
			this.registerButton.Location = new System.Drawing.Point(97, 372);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(249, 32);
			this.registerButton.TabIndex = 5;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = false;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
			// 
			// forgotPass
			// 
			this.forgotPass.AutoSize = true;
			this.forgotPass.LinkColor = System.Drawing.Color.White;
			this.forgotPass.Location = new System.Drawing.Point(235, 279);
			this.forgotPass.Name = "forgotPass";
			this.forgotPass.Size = new System.Drawing.Size(111, 13);
			this.forgotPass.TabIndex = 6;
			this.forgotPass.TabStop = true;
			this.forgotPass.Text = "forgot your password?";
			this.forgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPass_LinkClicked);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(141, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 29);
			this.label3.TabIndex = 7;
			this.label3.Text = "Please Login";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(179, 80);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(77, 81);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.backButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
			this.backButton.Location = new System.Drawing.Point(12, 12);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(41, 27);
			this.backButton.TabIndex = 23;
			this.backButton.Text = "<-";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(440, 450);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.forgotPass);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Name = "login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "login";
			this.Load += new System.EventHandler(this.login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.LinkLabel forgotPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button backButton;
	}
}