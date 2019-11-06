using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Events
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.userConnectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Size oldSize = new Size(159,433);
            Size newSize = new Size(45, 433);

            if (panel1.Size.Width == 159) {

                panel1.Size = newSize;

                button1.Width = 60;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;

                
            }else {
                panel1.Size = oldSize;

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Size oldSize = new Size(159, 433);
            Size newSize = new Size(47, 433);

            if (panel1.Size.Width == 159)
            {

                panel1.Size = newSize;

                
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }
            else
            {
                panel1.Size = oldSize;

                button1.Text = "Μπουζούκια";
                button2.Text = "Cinema";
                button3.Text = "Θέατρο";
                button4.Text = "Συναυλίες";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
        }
       
        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Visible = false;
            login.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
