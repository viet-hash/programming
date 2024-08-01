using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public static List<UserAccount> UserAccounts = new List<UserAccount>();

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;

            // Check registration conditions
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password confirmation does not match.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username already exists
            if (UserAccounts.Exists(u => u.Username == username))
            {
                MessageBox.Show("Account already exists.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new account to the list
            UserAccounts.Add(new UserAccount { Username = username, Password = password });

            // Success notification
            MessageBox.Show("Registration successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Pass new account info to Form1
            Form1.NewUserAccount = new UserAccount { Username = username, Password = password };

            // Go back to Form1 for login
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }

    public class UserAccount
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
