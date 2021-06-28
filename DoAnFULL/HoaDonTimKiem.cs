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
    public partial class HoaDonTimKiem : Form
    {
        public HoaDonTimKiem()
        {
            InitializeComponent();
        }
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        public void LoadDataGridView_NHANVIEN()
        {
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM BIENLAI");
            dataGridView1.ReadOnly = true;
        }
        public void KeyWord()
        {
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM BIENLAI where MAHD = '" + textBox1.Text + "'");
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM BIENLAI where MAKH = '" + textBox1.Text + "'");
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM BIENLAI where TENKH like N'%" + textBox1.Text + "%'");
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM BIENLAI where MANV = '" + textBox1.Text + "'");
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM BIENLAI where TENNV like N'%" + textBox1.Text + "%'");
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM BIENLAI where MAHANG = '" + textBox1.Text + "'");
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM BIENLAI where TENHANG like N'%" + textBox1.Text + "%'");
        }
        private void HoaDonTimKiem_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NHANVIEN();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonBan hdb = new HoaDonBan();
            hdb.ShowDialog();
        }
    }
}
