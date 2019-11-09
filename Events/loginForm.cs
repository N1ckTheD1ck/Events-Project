using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Events
{
    public partial class loginForm : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.userConnectionString);
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            authentication();
        }
        private void authentication()
        {
            string sql = "SELECT * FROM [user] WHERE Username = '" + unameTextBox.Text + "' AND Password = '" + passwdTextBox.Text + "'";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("login succesfully!!!");
                }
                else
                {
                    MessageBox.Show("wrong username or password");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.MidnightBlue;
            loginButton.ForeColor = Color.White;
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.White;
            loginButton.ForeColor = Color.MidnightBlue;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            registerForm reg = new registerForm();
            this.Visible = false;
            reg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.White;
            registerButton.ForeColor = Color.MidnightBlue;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.MidnightBlue;
            registerButton.ForeColor = Color.White;
        }
    }
}
