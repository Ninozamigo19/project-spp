namespace APK_SPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            Nama = new TextBox();
            Pilih = new ComboBox();
            Pw = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Nama
            // 
            Nama.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Nama.Location = new Point(163, 39);
            Nama.Multiline = true;
            Nama.Name = "Nama";
            Nama.PlaceholderText = "Masukan Nama";
            Nama.Size = new Size(274, 28);
            Nama.TabIndex = 2;
            // 
            // Pilih
            // 
            Pilih.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Pilih.FormattingEnabled = true;
            Pilih.Items.AddRange(new object[] { "Administrator", "Petugas", "Murid" });
            Pilih.Location = new Point(163, 186);
            Pilih.Name = "Pilih";
            Pilih.Size = new Size(237, 28);
            Pilih.TabIndex = 6;
            // 
            // Pw
            // 
            Pw.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Pw.Location = new Point(163, 109);
            Pw.Multiline = true;
            Pw.Name = "Pw";
            Pw.PasswordChar = '*';
            Pw.PlaceholderText = "Masukan Sandi";
            Pw.Size = new Size(274, 33);
            Pw.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(446, 255);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 8;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Login;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(163, 162);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 7;
            label4.Text = "login sebagai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(163, 15);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 4;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(163, 85);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Nama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Pw);
            panel1.Controls.Add(Pilih);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2);
            panel1.Size = new Size(614, 316);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(301, 255);
            button2.Name = "button2";
            button2.Size = new Size(125, 47);
            button2.TabIndex = 9;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += balik;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(615, 316);
            Controls.Add(panel1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox Nama;
        private ComboBox Pilih;
        private TextBox Pw;
        private Button button1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button button2;
    }
}