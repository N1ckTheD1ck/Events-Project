namespace EventsProject
{
	partial class allEvents
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
			this.label8 = new System.Windows.Forms.Label();
			this.townTextBox = new System.Windows.Forms.TextBox();
			this.categoryComboBox = new System.Windows.Forms.ComboBox();
			this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.streetTextBox = new System.Windows.Forms.TextBox();
			this.placeTextBox = new System.Windows.Forms.TextBox();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.eventsdbDataSet = new EventsProject.EventsdbDataSet();
			this.eventTableTableAdapter1 = new EventsProject.EventsdbDataSetTableAdapters.EventTableTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eventsdbDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(21, 247);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 30;
			this.label8.Text = "πολη";
			// 
			// townTextBox
			// 
			this.townTextBox.Location = new System.Drawing.Point(97, 240);
			this.townTextBox.Name = "townTextBox";
			this.townTextBox.Size = new System.Drawing.Size(251, 20);
			this.townTextBox.TabIndex = 29;
			// 
			// categoryComboBox
			// 
			this.categoryComboBox.FormattingEnabled = true;
			this.categoryComboBox.Items.AddRange(new object[] {
            "Μπουζούκια",
            "Θέατρο",
            "Cinema",
            "Συναυλίες"});
			this.categoryComboBox.Location = new System.Drawing.Point(97, 190);
			this.categoryComboBox.Name = "categoryComboBox";
			this.categoryComboBox.Size = new System.Drawing.Size(251, 21);
			this.categoryComboBox.TabIndex = 28;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(97, 63);
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(319, 96);
			this.descriptionTextBox.TabIndex = 27;
			this.descriptionTextBox.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 330);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "οδος";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 285);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "μαγαζι";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 24;
			this.label3.Text = "κατηγορια";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Περιγραφη";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "Τιτλος";
			// 
			// streetTextBox
			// 
			this.streetTextBox.Location = new System.Drawing.Point(97, 323);
			this.streetTextBox.Name = "streetTextBox";
			this.streetTextBox.Size = new System.Drawing.Size(251, 20);
			this.streetTextBox.TabIndex = 21;
			// 
			// placeTextBox
			// 
			this.placeTextBox.Location = new System.Drawing.Point(97, 278);
			this.placeTextBox.Name = "placeTextBox";
			this.placeTextBox.Size = new System.Drawing.Size(251, 20);
			this.placeTextBox.TabIndex = 20;
			// 
			// titleTextBox
			// 
			this.titleTextBox.Location = new System.Drawing.Point(97, 12);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(251, 20);
			this.titleTextBox.TabIndex = 19;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(465, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(388, 291);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(465, 320);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 32;
			this.button1.Text = "< previous";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(778, 320);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 33;
			this.button2.Text = "next >";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(110, 432);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 34;
			this.button3.Text = "διαγραφη";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(263, 432);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 35;
			this.button4.Text = "ενημερωση";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 377);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 13);
			this.label6.TabIndex = 37;
			this.label6.Text = "ημερομηνια";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(97, 374);
			this.dateTimePicker1.MinDate = new System.DateTime(2019, 12, 30, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(298, 20);
			this.dateTimePicker1.TabIndex = 36;
			this.dateTimePicker1.Value = new System.DateTime(2019, 12, 30, 0, 0, 0, 0);
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = this.eventsdbDataSet;
			this.bindingSource1.Position = 0;
			// 
			// eventsdbDataSet
			// 
			this.eventsdbDataSet.DataSetName = "EventsdbDataSet";
			this.eventsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// eventTableTableAdapter1
			// 
			this.eventTableTableAdapter1.ClearBeforeFill = true;
			// 
			// allEvents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(890, 486);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.townTextBox);
			this.Controls.Add(this.categoryComboBox);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.streetTextBox);
			this.Controls.Add(this.placeTextBox);
			this.Controls.Add(this.titleTextBox);
			this.Name = "allEvents";
			this.Text = "allEvents";
			this.Load += new System.EventHandler(this.allEvents_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eventsdbDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox townTextBox;
		private System.Windows.Forms.ComboBox categoryComboBox;
		private System.Windows.Forms.RichTextBox descriptionTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox streetTextBox;
		private System.Windows.Forms.TextBox placeTextBox;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private EventsdbDataSet eventsdbDataSet;
		private EventsdbDataSetTableAdapters.EventTableTableAdapter eventTableTableAdapter1;
	}
}