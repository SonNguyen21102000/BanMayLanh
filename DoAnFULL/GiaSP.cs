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
    public partial class GiaSP : Form
    {
        public GiaSP()
        {
            InitializeComponent();
        }
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        public void LoadDataGridView_NHANVIEN()
        {
            string strSQL = "SELECT * FROM GIASANPHAM";
            ada_NhanVien = conn.getDataAdapter(strSQL, "GIASANPHAM");
            dataGridView1.DataSource = conn.DataSet.Tables["GIASANPHAM"];

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = conn.DataSet.Tables["GIASANPHAM"].Columns["MAGIA"];
            conn.DataSet.Tables["GIASANPHAM"].PrimaryKey = primaryKey;
            dataGridView1.ReadOnly = true;
        }
        private void GiaSP_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NHANVIEN();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.ShowDialog();
        }
    }
}
