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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Keluar(object sender, EventArgs e)
        {
            var ba = new Form2();
            ba.Show();
            Close();
        }

        private void Kirim(object sender, EventArgs e)
        {
            MessageBox.Show("Laporan anda berhasil di kirim", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
