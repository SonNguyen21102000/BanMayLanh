using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace DoAnFULL
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
            
        }
        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatLieu chatlieu = new ChatLieu();
            chatlieu.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangHoa hh = new HangHoa();
            hh.ShowDialog();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonBan hdb = new HoaDonBan();
            hdb.ShowDialog();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangHoaTimKiem hh = new HangHoaTimKiem();
            hh.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHangTimKiem kh = new KhachHangTimKiem();
            kh.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonTimKiem hd = new HoaDonTimKiem();
            hd.ShowDialog();
        }
        private void trợGiúpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\DELL\\Desktop\\huongdan.txt");
        }
        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCao bc = new BaoCao();
            bc.ShowDialog();
        }

        private void giáHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaSP sp = new GiaSP();
            sp.ShowDialog();
        }
    }
}
