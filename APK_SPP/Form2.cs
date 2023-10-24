using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APK_SPP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logout(object sender, EventArgs e)
        {
            var keluar = new Form1();
            keluar.Show();
            Close();
        }

        private void Riwayat(object sender, EventArgs e)
        {

        }

        private void Data_Siswa(object sender, EventArgs e)
        {
          var ds = new Form6();
           ds.Show();
           Close();
        }

        private void Data_Petugas(object sender, EventArgs e)
        {
            var dp = new Form7();
            dp.Show(); 
            Close();
        }

        private void Data_Kelas(object sender, EventArgs e)
        {
            var dk = new Form8();
            dk.Show();
            Close();
        }

        private void Data_SPP(object sender, EventArgs e)
        {
            var sp = new Form9();
            sp.Show();
            Close();
        }

        private void Transaksi(object sender, EventArgs e)
        {
            var tr = new Form10();
            tr.Show();
            Close();
        }

        private void Create_Laporan(object sender, EventArgs e)
        {
            var cl = new Form11();
            cl.Show();
            Close();
        }
    }
}
