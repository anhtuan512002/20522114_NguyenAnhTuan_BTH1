using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20522114_NguyenAnhTuan_BTH1
{
    public partial class CaNhan : Form
    {
        public CaNhan()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LichSuMuaHang lichsu = new LichSuMuaHang();
            lichsu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }
    }
}
