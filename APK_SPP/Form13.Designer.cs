namespace APK_SPP
{
    partial class Form13
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nama_Petugas = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Level = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox7 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nama_Petugas, Username, Password, Level });
            dataGridView1.Location = new Point(-4, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(821, 265);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.DataPropertyName = "id_petugas";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nama_Petugas
            // 
            Nama_Petugas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama_Petugas.DataPropertyName = "nama_petugas";
            Nama_Petugas.HeaderText = "Nama_Petugas";
            Nama_Petugas.Name = "Nama_Petugas";
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Username.DataPropertyName = "username";
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            // 
            // Level
            // 
            Level.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Level.DataPropertyName = "level";
            Level.HeaderText = "Level";
            Level.Name = "Level";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 12);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Masukan  Nama";
            textBox3.Size = new Size(145, 23);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 52);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Masukan Username";
            textBox4.Size = new Size(145, 23);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(166, 88);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Masukan Password";
            textBox7.Size = new Size(145, 23);
            textBox7.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 14);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 10;
            label2.Text = "Nama Petugas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 52);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 90);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 13;
            label7.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(202, 130);
            button1.Name = "button1";
            button1.Size = new Size(109, 41);
            button1.TabIndex = 14;
            button1.Text = "Tambahkan";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 496);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Name = "Form13";
            Text = " ";
            Load += Form13_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox7;
        private Label label2;
        private Label label3;
        private Label label7;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nama_Petugas;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Level;
        private Button button1;
    }
}