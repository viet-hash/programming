namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Register new user";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 210);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 4;
            label2.Text = "New User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 240);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 5;
            label3.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 273);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 6;
            label4.Text = "Re-enter Password ";
            // 
            // button1
            // 
            button1.Location = new Point(521, 231);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(521, 273);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Return Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(375, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(375, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 13;
            textBox2.UseSystemPasswordChar = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_07_29_224135;
            ClientSize = new Size(643, 345);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}