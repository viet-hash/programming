using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Thuộc tính để lưu thông tin tài khoản mới từ Form2
        public static UserAccount? NewUserAccount { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nếu có thông tin tài khoản mới, hiển thị nó
            if (NewUserAccount != null)
            {
                textBox1.Text = NewUserAccount.Username;
                textBox2.Text = NewUserAccount.Password;
                NewUserAccount = null; // Đặt lại thông tin tài khoản mới sau khi sử dụng
            }
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

            // Kiểm tra thông tin đăng nhập với danh sách tài khoản từ Form2
            if (IsValidLogin(username, password))
            {
                // Chuyển đến Form3 nếu đăng nhập thành công
                Form3 form3 = new Form3();
                form3.Show();
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
            // Kiểm tra thông tin đăng nhập với danh sách tài khoản từ Form2
            bool isValidFromForm2 = Form2.UserAccounts.Any(u => u.Username == username && u.Password == password);

            // Kiểm tra tài khoản cố định
            bool isValidFixedAccount = (username == "vietanh" && password == "0000");

            // Tài khoản hợp lệ nếu một trong hai điều kiện đúng
            return isValidFromForm2 || isValidFixedAccount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Chuyển đến Form2 để đăng ký tài khoản mới
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Chuyển đến Form4 cho hành động khác
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
