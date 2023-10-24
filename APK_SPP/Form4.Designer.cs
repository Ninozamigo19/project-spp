namespace APK_SPP
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button7 = new Button();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            button9 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(452, 24);
            button1.Name = "button1";
            button1.Size = new Size(92, 27);
            button1.TabIndex = 0;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Sign_In;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(252, 240);
            label1.Name = "label1";
            label1.Size = new Size(659, 90);
            label1.TabIndex = 1;
            label1.Text = "Selamat datang di website SPP kami.\r\nSilahkan Sign In atau Sign Up terlebih dahulu";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(194, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 82);
            panel2.TabIndex = 11;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Enabled = false;
            button8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(562, 24);
            button8.Name = "button8";
            button8.Size = new Size(92, 27);
            button8.TabIndex = 1;
            button8.Text = "Sign Up";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Sign_Up;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(670, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button9);
            panel1.Location = new Point(-13, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 573);
            panel1.TabIndex = 10;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(47, 505);
            button7.Name = "button7";
            button7.Size = new Size(119, 46);
            button7.TabIndex = 15;
            button7.Text = "Create Laporan";
            button7.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(60, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(96, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(47, 123);
            button2.Name = "button2";
            button2.Size = new Size(119, 46);
            button2.TabIndex = 9;
            button2.Text = "Riwayat Transaksi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(47, 443);
            button6.Name = "button6";
            button6.Size = new Size(119, 46);
            button6.TabIndex = 14;
            button6.Text = "Transaksi";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(47, 381);
            button5.Name = "button5";
            button5.Size = new Size(119, 46);
            button5.TabIndex = 13;
            button5.Text = "Data SPP";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(47, 185);
            button3.Name = "button3";
            button3.Size = new Size(119, 46);
            button3.TabIndex = 10;
            button3.Text = "Data Siswa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(47, 319);
            button4.Name = "button4";
            button4.Size = new Size(119, 46);
            button4.TabIndex = 12;
            button4.Text = "Data Kelas";
            button4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Location = new Point(47, 250);
            button9.Name = "button9";
            button9.Size = new Size(119, 46);
            button9.TabIndex = 11;
            button9.Text = "Data Petugas";
            button9.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(972, 569);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Panel panel2;
        private Button button8;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button7;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button4;
        private Button button9;
        private PictureBox pictureBox3;
    }
}