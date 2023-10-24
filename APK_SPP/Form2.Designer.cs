namespace APK_SPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            button7 = new Button();
            panel2 = new Panel();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 11);
            label1.Name = "label1";
            label1.Size = new Size(105, 39);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(38, 125);
            button1.Name = "button1";
            button1.Size = new Size(119, 46);
            button1.TabIndex = 1;
            button1.Text = "Riwayat Transaksi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Riwayat;
            // 
            // button2
            // 
            button2.Location = new Point(38, 187);
            button2.Name = "button2";
            button2.Size = new Size(119, 46);
            button2.TabIndex = 2;
            button2.Text = "Data Siswa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Data_Siswa;
            // 
            // button3
            // 
            button3.Location = new Point(38, 252);
            button3.Name = "button3";
            button3.Size = new Size(119, 46);
            button3.TabIndex = 3;
            button3.Text = "Data Petugas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Data_Petugas;
            // 
            // button4
            // 
            button4.Location = new Point(38, 321);
            button4.Name = "button4";
            button4.Size = new Size(119, 46);
            button4.TabIndex = 4;
            button4.Text = "Data Kelas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Data_Kelas;
            // 
            // button5
            // 
            button5.Location = new Point(38, 383);
            button5.Name = "button5";
            button5.Size = new Size(119, 46);
            button5.TabIndex = 5;
            button5.Text = "Data SPP";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Data_SPP;
            // 
            // button6
            // 
            button6.Location = new Point(38, 445);
            button6.Name = "button6";
            button6.Size = new Size(119, 46);
            button6.TabIndex = 6;
            button6.Text = "Transaksi";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Transaksi;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 573);
            panel1.TabIndex = 7;
            // 
            // button7
            // 
            button7.Location = new Point(38, 507);
            button7.Name = "button7";
            button7.Size = new Size(119, 46);
            button7.TabIndex = 8;
            button7.Text = "Create Laporan";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Create_Laporan;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(206, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 82);
            panel2.TabIndex = 9;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(562, 24);
            button8.Name = "button8";
            button8.Size = new Size(92, 27);
            button8.TabIndex = 1;
            button8.Text = "Logout";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Logout;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(972, 569);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Button button7;
        private Panel panel2;
        private Button button8;
        private PictureBox pictureBox1;
    }
}