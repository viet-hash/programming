namespace WinFormsApp1
{
    partial class Form5
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Water_Bill_Online;
            pictureBox1.Location = new Point(222, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 205);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 272);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(647, 331);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}