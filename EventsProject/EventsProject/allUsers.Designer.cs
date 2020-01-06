namespace EventsProject
{
	partial class allUsers
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.backButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(0, 33);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(715, 407);
			this.listBox1.TabIndex = 0;
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.backButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
			this.backButton.Location = new System.Drawing.Point(0, -1);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(41, 27);
			this.backButton.TabIndex = 23;
			this.backButton.Text = "<-";
			this.backButton.UseVisualStyleBackColor = false;
			// 
			// allUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 440);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.listBox1);
			this.Name = "allUsers";
			this.Text = "allUsers";
			this.Load += new System.EventHandler(this.allUsers_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button backButton;
	}
}