using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (IsValidLogin(username, password))
            {
                // Chuyển đến form chính nếu đăng nhập thành công
                Form6 form6 = new Form6();
                form6.Show();
                this.Hide();
            }
            else
            {
                // Hiển thị thông báo lỗi nếu đăng nhập thất bại
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidLogin(string username, string password)
        {
            // Kiểm tra thông tin đăng nhập (đây chỉ là ví dụ, bạn cần triển khai thực tế)
            return username == "admin" && password == "0000";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }

}
