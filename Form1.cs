namespace _20522114_NguyenAnhTuan_BTH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dangky_Click(object sender, EventArgs e)
        {
            DangKy dangky = new DangKy();
            dangky.Show();
        }

        private void Dangnhap_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CaNhan canhan = new CaNhan();
            canhan.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GioHang cart = new GioHang();
            cart.Show();
        }
    }
}