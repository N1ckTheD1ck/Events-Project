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
    public partial class registerForm : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.userConnectionString);
        public registerForm()
        {
            InitializeComponent();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            showData();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            insertData();
            showData();
            
        }
        private void insertData()
        {
            string fname = fnameTextBox.Text;
            string lname = lnameTextBox.Text;
            string city = cityTextBox.Text;
            string address = addresstextBox.Text;
            string username = unametextBox.Text;
            string passwd = PasswordtextBox.Text;
            string interests="";
            if (checkBox1.Checked) {
                interests = checkBox1.Text;
            }
            if (checkBox1.Checked)
            {
                interests = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                interests = checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                interests = checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                interests = checkBox4.Text;
            }
            
            string sql = "INSERT INTO [user] (FirstName,LastName,City,Address,Interests,Username,Password)"+
                            "VALUES ('" + fname + "','" + lname + "','" + city + "','" + address + "','" + interests + "','" + username + "','" + passwd + "')";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showData() {
            
            string sql = "SELECT * FROM [user]";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void detele() { 
              
            string sql = "DELETE FROM [user] WHERE";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.White;
            registerButton.ForeColor = Color.MidnightBlue;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.MidnightBlue;
            registerButton.ForeColor = Color.White;
        }
        
    }
}
