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
    public partial class HangHoaTimKiem : Form
    {
        public HangHoaTimKiem()
        {
            InitializeComponent();
        }
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        public void LoadDataGridView_NHANVIEN()
        {
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM HANG");
            dataGridView1.ReadOnly = true;
        }
        public void KeyWord()
        {
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM HANG where MAHANG = '" + textBox1.Text + "'");
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM HANG where TENHANG like N'%" + textBox1.Text + "%'");
            dataGridView1.DataSource = conn.getDataTable("SELECT * FROM HANG where MACHATLIEU = '" + textBox1.Text + "'");
        }
        private void HangHoaTimKiem_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NHANVIEN();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).Rows.Clear();
            KeyWord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).Rows.Clear();
            LoadDataGridView_NHANVIEN();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangHoa hh = new HangHoa();
            hh.ShowDialog();
        }
    }
}
