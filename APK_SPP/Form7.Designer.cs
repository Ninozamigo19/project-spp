namespace APK_SPP
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            panel2 = new Panel();
            label1 = new Label();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            USERNAME = new DataGridViewTextBoxColumn();
            PASSWORD = new DataGridViewTextBoxColumn();
            NAMA = new DataGridViewTextBoxColumn();
            LEVEL = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 82);
            panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 2;
            label1.Text = "DATA PETUGAS";
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(765, 23);
            button8.Name = "button8";
            button8.Size = new Size(92, 27);
            button8.TabIndex = 1;
            button8.Text = "BACK";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Keluar;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(878, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, USERNAME, PASSWORD, NAMA, LEVEL });
            dataGridView1.Location = new Point(2, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(971, 324);
            dataGridView1.TabIndex = 14;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.DataPropertyName = "id_petugas";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // USERNAME
            // 
            USERNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            USERNAME.DataPropertyName = "username";
            USERNAME.HeaderText = "USERNAME";
            USERNAME.Name = "USERNAME";
            // 
            // PASSWORD
            // 
            PASSWORD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PASSWORD.DataPropertyName = "password";
            PASSWORD.HeaderText = "PASSWORD";
            PASSWORD.Name = "PASSWORD";
            // 
            // NAMA
            // 
            NAMA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NAMA.DataPropertyName = "nama_petugas";
            NAMA.HeaderText = "NAMA";
            NAMA.Name = "NAMA";
            // 
            // LEVEL
            // 
            LEVEL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LEVEL.DataPropertyName = "level";
            LEVEL.HeaderText = "LEVEL";
            LEVEL.Name = "LEVEL";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(972, 569);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "Form7";
            Text = "Form7";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Button button8;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn USERNAME;
        private DataGridViewTextBoxColumn PASSWORD;
        private DataGridViewTextBoxColumn NAMA;
        private DataGridViewTextBoxColumn LEVEL;
    }
}