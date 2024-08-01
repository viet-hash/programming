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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] row1 = new string[] { "01/07/2024", "10", "25000", "250000", "Paid" };
            string[] row2 = new string[] { "01/08/2024", "12", "25000", "300000", "paid" };
            string[] row3 = new string[] { "01/09/2024", "8", "25000", "200000", "Paid" };
            string[] row4 = new string[] { "01/10/2024", "15", "25000", "375000", "Unpaid" };

            // Thêm hàng vào DataGridView
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
            dataGridView1.Rows.Add(row4);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public string BillDetails { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            double totalAmountDue = 0;
            string billDetails = "Month unpaid:\n\n";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string status = row.Cells[4].Value.ToString();
                    if (status.Equals("Unpaid", StringComparison.OrdinalIgnoreCase))
                    {
                        string date = row.Cells[0].Value.ToString();
                        string amount = row.Cells[3].Value.ToString();

                        billDetails += $"Date: {date}, Total: {amount}\n";

                        if (double.TryParse(amount, out double amountDue))
                        {
                            totalAmountDue += amountDue;
                        }
                    }
                }
            }

            billDetails += $"\nTotal you have to pay: {totalAmountDue}";

           
            Form5 form5 = new Form5();
            form5.BillDetails = billDetails;
            form5.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
