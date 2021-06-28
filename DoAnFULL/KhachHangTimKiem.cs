using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoAnFULL
{
    public partial class KhachHangTimKiem : Form
    {
        public KhachHangTimKiem()
        {
            InitializeComponent();
        }
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        public void LoadDataGridView_NHANVIEN()
        {
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM KHACH");
            dataGridView1.ReadOnly = true;
        }
        private void KhachHangTimKiem_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NHANVIEN();
        }
        public void KeyWord()
        {
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM KHACH where MAKH = '" + textBox1.Text + "'");
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM KHACH where TENKH like N'%" + textBox1.Text + "%'");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).Rows.Clear();
            KeyWord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).Rows.Clear();
            LoadDataGridView_NHANVIEN();
        }
    }
}
