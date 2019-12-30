namespace EventsProject
{
	partial class addEvent
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
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.placeTextBox = new System.Windows.Forms.TextBox();
			this.streetTextBox = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.categoryComboBox = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.townTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// titleTextBox
			// 
			this.titleTextBox.Location = new System.Drawing.Point(134, 12);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(251, 20);
			this.titleTextBox.TabIndex = 0;
			// 
			// placeTextBox
			// 
			this.placeTextBox.Location = new System.Drawing.Point(134, 278);
			this.placeTextBox.Name = "placeTextBox";
			this.placeTextBox.Size = new System.Drawing.Size(251, 20);
			this.placeTextBox.TabIndex = 3;
			// 
			// streetTextBox
			// 
			this.streetTextBox.Location = new System.Drawing.Point(134, 323);
			this.streetTextBox.Name = "streetTextBox";
			this.streetTextBox.Size = new System.Drawing.Size(251, 20);
			this.streetTextBox.TabIndex = 4;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(134, 383);
			this.dateTimePicker1.MinDate = new System.DateTime(2019, 12, 30, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(251, 20);
			this.dateTimePicker1.TabIndex = 5;
			this.dateTimePicker1.Value = new System.DateTime(2019, 12, 30, 0, 0, 0, 0);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(169, 453);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(533, 253);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Τιτλος";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Περιγραφη";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(58, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "κατηγορια";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(58, 285);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "μαγαζι";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(58, 330);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "οδος";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(58, 389);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "ημερομηνια";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(45, 497);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "φωτογραφια event";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(134, 63);
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(319, 96);
			this.descriptionTextBox.TabIndex = 14;
			this.descriptionTextBox.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(501, 383);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "επιβεβαιωση";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// categoryComboBox
			// 
			this.categoryComboBox.FormattingEnabled = true;
			this.categoryComboBox.Items.AddRange(new object[] {
            "Μπουζούκια",
            "Θέατρο",
            "Cinema",
            "Συναυλίες"});
			this.categoryComboBox.Location = new System.Drawing.Point(134, 190);
			this.categoryComboBox.Name = "categoryComboBox";
			this.categoryComboBox.Size = new System.Drawing.Size(251, 21);
			this.categoryComboBox.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(58, 247);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "πολη";
			// 
			// townTextBox
			// 
			this.townTextBox.Location = new System.Drawing.Point(134, 240);
			this.townTextBox.Name = "townTextBox";
			this.townTextBox.Size = new System.Drawing.Size(251, 20);
			this.townTextBox.TabIndex = 17;
			// 
			// addEvent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 749);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.townTextBox);
			this.Controls.Add(this.categoryComboBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.streetTextBox);
			this.Controls.Add(this.placeTextBox);
			this.Controls.Add(this.titleTextBox);
			this.Name = "addEvent";
			this.Text = "addEvent";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.TextBox placeTextBox;
		private System.Windows.Forms.TextBox streetTextBox;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox descriptionTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox categoryComboBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox townTextBox;
	}
}