namespace Events
{
    partial class loginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.registerButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.passwdTextBox = new System.Windows.Forms.TextBox();
			this.unameTextBox = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(619, 38);
			this.panel1.TabIndex = 1;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// button8
			// 
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
			this.button8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button8.Location = new System.Drawing.Point(506, 0);
			this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(46, 34);
			this.button8.TabIndex = 10;
			this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button6
			// 
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.Location = new System.Drawing.Point(558, 0);
			this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(40, 34);
			this.button6.TabIndex = 8;
			this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
			this.label3.ForeColor = System.Drawing.Color.GhostWhite;
			this.label3.Location = new System.Drawing.Point(189, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(283, 58);
			this.label3.TabIndex = 15;
			this.label3.Text = "New user?\r\nregister now Motherfucker!";
			// 
			// registerButton
			// 
			this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.registerButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.registerButton.ForeColor = System.Drawing.Color.White;
			this.registerButton.Location = new System.Drawing.Point(254, 294);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(101, 34);
			this.registerButton.TabIndex = 14;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = false;
			this.registerButton.Click += new System.EventHandler(this.button9_Click);
			this.registerButton.MouseEnter += new System.EventHandler(this.button9_MouseEnter);
			this.registerButton.MouseLeave += new System.EventHandler(this.button9_MouseLeave);
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.loginButton.ForeColor = System.Drawing.Color.White;
			this.loginButton.Location = new System.Drawing.Point(254, 159);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(101, 34);
			this.loginButton.TabIndex = 13;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
			this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(102, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 29);
			this.label2.TabIndex = 12;
			this.label2.Text = "Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(102, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 29);
			this.label1.TabIndex = 11;
			this.label1.Text = "Username:";
			// 
			// passwdTextBox
			// 
			this.passwdTextBox.Location = new System.Drawing.Point(232, 116);
			this.passwdTextBox.Name = "passwdTextBox";
			this.passwdTextBox.Size = new System.Drawing.Size(153, 20);
			this.passwdTextBox.TabIndex = 10;
			// 
			// unameTextBox
			// 
			this.unameTextBox.Location = new System.Drawing.Point(232, 70);
			this.unameTextBox.Name = "unameTextBox";
			this.unameTextBox.Size = new System.Drawing.Size(153, 20);
			this.unameTextBox.TabIndex = 9;
			// 
			// loginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(619, 368);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwdTextBox);
			this.Controls.Add(this.unameTextBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "loginForm";
			this.Text = "loginForm";
			this.Load += new System.EventHandler(this.loginForm_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.TextBox unameTextBox;
    }
}