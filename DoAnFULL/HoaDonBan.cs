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
    public partial class HoaDonBan : Form
    {
        public HoaDonBan()
        {
            InitializeComponent();
        }
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        private void HoaDonBan_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NHANVIEN();
            dataBindings(conn.DataSet.Tables["BIENLAI"]);
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            dataGridView1.Enabled = true;
        }
        public void LoadDataGridView_NHANVIEN()
        {
            string strSQL = "SELECT * FROM BIENLAI";
            ada_NhanVien = conn.getDataAdapter(strSQL, "BIENLAI");
            dataGridView1.DataSource = conn.DataSet.Tables["BIENLAI"];

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = conn.DataSet.Tables["BIENLAI"].Columns["MAHD"];
            conn.DataSet.Tables["BIENLAI"].PrimaryKey = primaryKey;
            dataGridView1.ReadOnly = true;
        }
        public void dataBindings(DataTable pTable)
        {
            textBox1.DataBindings.Add("Text", pTable, "MAHD", true, DataSourceUpdateMode.Never);
            dateTimePicker1.DataBindings.Add("Text", pTable, "NGAYBAN", true, DataSourceUpdateMode.Never);
            comboBox1.DataBindings.Add("Text", pTable, "MANV", true, DataSourceUpdateMode.Never);
            textBox2.DataBindings.Add("Text", pTable, "SOLUONG", true, DataSourceUpdateMode.Never);
            textBox3.DataBindings.Add("Text", pTable, "TENNV", true, DataSourceUpdateMode.Never);
            textBox4.DataBindings.Add("Text", pTable, "TENKH", true, DataSourceUpdateMode.Never);
            textBox5.DataBindings.Add("Text", pTable, "DIACHI", true, DataSourceUpdateMode.Never);
            textBox6.DataBindings.Add("Text", pTable, "DT", true, DataSourceUpdateMode.Never);
            comboBox2.DataBindings.Add("Text", pTable, "MAKH", true, DataSourceUpdateMode.Never);
            comboBox3.DataBindings.Add("Text", pTable, "MAHANG", true, DataSourceUpdateMode.Never);
            textBox9.DataBindings.Add("Text", pTable, "DONGIA", true, DataSourceUpdateMode.Never);
            textBox8.DataBindings.Add("Text", pTable, "GIAMGIA", true, DataSourceUpdateMode.Never);
            textBox7.DataBindings.Add("Text", pTable, "TENHANG", true, DataSourceUpdateMode.Never);
            textBox10.DataBindings.Add("Text", pTable, "THANHTIEN", true, DataSourceUpdateMode.Never);
           
        }
        //public void loadCombobox1()
        //{
        //    string tb = "select MANV from NHANVIEN";
        //    ada_NhanVien = conn.getDataAdapter(tb, "NHANVIEN");
        //    DataTable dt = new DataTable();
        //    ada_NhanVien.Fill(dt);
        //    comboBox1.DisplayMember = "MANV";
        //    comboBox1.DataSource = dt;
        //}
        //public void loadCombobox2()
        //{
        //    string tb = "select MAKH from KHACH";
        //    ada_NhanVien = conn.getDataAdapter(tb, "KHACH");
        //    DataTable dt = new DataTable();
        //    ada_NhanVien.Fill(dt);
        //    comboBox2.DisplayMember = "MAKH";
        //    comboBox2.DataSource = dt;
        //}
        //public void loadCombobox3()
        //{
        //    string tb = "select MAHANG from HANG";
        //    ada_NhanVien = conn.getDataAdapter(tb, "HANG");
        //    DataTable dt = new DataTable();
        //    ada_NhanVien.Fill(dt);
        //    comboBox3.DisplayMember = "MAHANG";
        //    comboBox3.DataSource = dt;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = groupBox2.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            button4.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mahd = textBox1.Text.Trim();
            string ngayban = dateTimePicker1.Text.Trim();
            string manv = comboBox1.Text.Trim();
            string tennv = textBox3.Text.Trim();
            string makh = comboBox2.Text.Trim();
            string tenkh = textBox4.Text.Trim();
            string diachi = textBox5.Text.Trim();
            string dt = textBox6.Text.Trim();
            string mahang = comboBox3.Text.Trim();
            string tenhang = textBox7.Text.Trim();
            string soluong = textBox2.Text.Trim();
            string dongia = textBox9.Text.Trim();
            string giamgia = textBox8.Text.Trim();
            string thanhtien = textBox10.Text.Trim();
            if (mahd == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn. Vui lòng nhập !!!");
                textBox1.Focus();
                return;
            }
            else if (soluong == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số lượng. Vui lòng nhập !!!");
                textBox2.Focus();
                return;
            }
            else if (manv == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên. Vui lòng nhập !!!");
                comboBox1.Focus();
                return;
            }
            else if (makh == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng. Vui lòng nhập !!!");
                comboBox2.Focus();
                return;
            }
            else if (mahang == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa. Vui lòng nhập !!!");
                comboBox3.Focus();
                return;
            }
            else if (tennv == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên. Vui lòng nhập !!!");
                textBox3.Focus();
                return;
            }
            else if (tenkh == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng. Vui lòng nhập !!!");
                textBox4.Focus();
                return;
            }
            else if (diachi == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng. Vui lòng nhập !!!");
                textBox5.Focus();
                return;
            }
            else if (dt == string.Empty)
            {
                MessageBox.Show("Thiếu số điện thoại. Vui lòng bổ sung !!!");
                textBox6.Focus();
                return;
            }
            else if (tenhang == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên hàng. Vui lòng bổ sung !!!");
                textBox7.Focus();
                return;
            }
            try
            {
                if (textBox1.Enabled == true)
                {
                    DataRow existRow = conn.DataSet.Tables["BIENLAI"].Rows.Find(mahd);
                    if (existRow != null)
                    {
                        MessageBox.Show("Mã này đã tồn tại!");
                        textBox1.Clear();
                        textBox1.Focus();
                        return;
                    }
                    DataRow newRow = conn.DataSet.Tables["BIENLAI"].NewRow();
                    newRow["MAHD"] = mahd;
                    newRow["NGAYBAN"] = ngayban;
                    newRow["MANV"] = manv;
                    newRow["TENNV"] = tennv;
                    newRow["MAKH"] = makh;
                    newRow["TENKH"] = tenkh;
                    newRow["DIACHI"] = diachi;
                    newRow["DT"] = dt;
                    newRow["MAHANG"] = mahang;
                    newRow["TENHANG"] = tenhang;
                    newRow["SOLUONG"] = soluong;
                    newRow["DONGIA"] = dongia;
                    newRow["GIAMGIA"] = giamgia;
                    newRow["THANHTIEN"] = thanhtien;
                    conn.DataSet.Tables["BIENLAI"].Rows.Add(newRow);
                }
                else
                {
                    DataRow updateRow = conn.DataSet.Tables["BIENLAI"].Rows.Find(mahd);
                    updateRow["NGAYBAN"] = ngayban;
                    updateRow["TENNV"] = tennv;
                    updateRow["TENKH"] = tenkh;
                    updateRow["DIACHI"] = diachi;
                    updateRow["DT"] = dt;
                    updateRow["TENHANG"] = tenhang;
                    updateRow["SOLUONG"] = soluong;
                    updateRow["DONGIA"] = dongia;
                    updateRow["GIAMGIA"] = giamgia;
                    updateRow["THANHTIEN"] = thanhtien;
                }
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(conn.DataSet, "BIENLAI");
                MessageBox.Show("Lưu thành công!");
            }
            catch
            {
                MessageBox.Show("Lưu không thành công!");
            }
            groupBox1.Enabled = groupBox2.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult res = MessageBox.Show("Bạn muốn hủy đơn hàng này không?", "Thông báo", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                return;

            //Tiến hành kiểm tra và lưu dữ liệu
            string mahd = textBox1.Text.Trim();
            try
            {
                //Lưu cập nhật
                DataRow deleteRow = conn.DataSet.Tables["BIENLAI"].Rows.Find(mahd);
                deleteRow.Delete();

                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(conn.DataSet, "BIENLAI");
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            groupBox2.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Focus();
            comboBox1.Enabled = comboBox2.Enabled = comboBox3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonTimKiem hd = new HoaDonTimKiem();
            hd.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double sl = double.Parse(textBox2.Text);
            double giamgia = double.Parse(textBox8.Text);
            double dongia = double.Parse(textBox9.Text);
            double thanhtien = sl * dongia - (sl * dongia * (giamgia/100));
            textBox10.Text = thanhtien.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GiaSP sp = new GiaSP();
            sp.ShowDialog();
        }
    }
}
