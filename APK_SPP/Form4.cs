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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sign_Up(object sender, EventArgs e)
        {

        }

        private void Sign_In(object sender, EventArgs e)
        {
            var masuk = new Form1();
            masuk.Show();
        }
    }
}
