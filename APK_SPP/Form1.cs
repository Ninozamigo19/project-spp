using MySql.Data.MySqlClient;
namespace APK_SPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            if (Pilih.SelectedIndex == 0 && Pw.Text == "1478")
            {
                var utama = new Form2();
                utama.Show();
                Close();
            }
            else if (Pilih.SelectedIndex == 1 && Pw.Text == "2323")
            {
                var asli = new Form3();
                asli.Show();
                Close();
            }
            else if (Pilih.SelectedIndex == 2 && Pw.Text == "4546")
            {
                var dua = new Form5();
                dua.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Username atau Password anda salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void balik(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}