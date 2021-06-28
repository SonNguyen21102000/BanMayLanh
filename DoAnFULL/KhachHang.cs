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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoadDataGridView_NHANVIEN()
        {
            string strSQL = "SELECT * FROM KHACH";
            ada_NhanVien = conn.getDataAdapter(strSQL, "KHACH");
            dataGridView1.DataSource = conn.DataSet.Tables["KHACH"];

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = conn.DataSet.Tables["KHACH"].Columns["MAKH"];
            conn.DataSet.Tables["KHACH"].PrimaryKey = primaryKey;
            dataGridView1.ReadOnly = true;
        }
        public void dataBindings(DataTable pTable)
        {
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", pTable, "MAKH", true, DataSourceUpdateMode.Never);
            textBox2.DataBindings.Add("Text", pTable, "TENKH", true, DataSourceUpdateMode.Never);         
            textBox3.DataBindings.Add("Text", pTable, "DIACHI", true, DataSourceUpdateMode.Never);
            maskedTextBox1.DataBindings.Add("Text", pTable, "DT", true, DataSourceUpdateMode.Never);        
        }
        private void button6_Click(object sender, EventArgs e)
        {
           DialogResult res = MessageBox.Show("Bạn muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            maskedTextBox1.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            button4.Enabled = true;
            maskedTextBox1.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NHANVIEN();
            dataBindings(conn.DataSet.Tables["KHACH"]);
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            maskedTextBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn xóa khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo,
             MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                return;

            //Tiến hành kiểm tra và lưu dữ liệu
            string manv = textBox1.Text.Trim();
            try
            {
                //Kiểm tra khóa ngoại
                string strSQL = "SELECT count(*) FROM BIENLAI WHERE MAKH='" + manv + "'";
                if (conn.checkForExistence(strSQL))
                {
                    MessageBox.Show("Mã này đã tồn tại khóa ngoại trên bảng BIENLAI!");
                    return;
                }
                //Lưu cập nhật
                DataRow deleteRow = conn.DataSet.Tables["KHACH"].Rows.Find(manv);
                deleteRow.Delete();

                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(conn.DataSet, "KHACH");

                button4.Enabled = false;
                textBox1.Enabled = textBox2.Enabled = false;

                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();           
            maskedTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            maskedTextBox1.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string makh = textBox1.Text.Trim();
            string tenkh = textBox2.Text.Trim();
            string dc = textBox3.Text.Trim();
            string dt = maskedTextBox1.Text.Trim();
            if (makh == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên. Vui lòng nhập !!!");
                textBox1.Focus();
                return;
            }
            else if (tenkh == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên. Vui lòng nhập !!!");
                textBox2.Focus();
                return;
            }
            else if (dc == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ. Vui lòng nhập !!!");
                textBox3.Focus();
                return;
            }
            else if (dt == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại. Vui lòng nhập !!!");
                maskedTextBox1.Focus();
                return;
            }
            try
            {
                if (textBox1.Enabled == true)
                {
                    DataRow existRow = conn.DataSet.Tables["KHACH"].Rows.Find(makh);
                    if (existRow != null)
                    {
                        MessageBox.Show("Mã này đã tồn tại!");
                        textBox1.Clear();
                        textBox1.Focus();
                        return;
                    }
                    DataRow newRow = conn.DataSet.Tables["KHACH"].NewRow();
                    newRow["MAKH"] = makh;
                    newRow["TENKH"] = tenkh;
                    newRow["DIACHI"] = dc;
                    newRow["DT"] = dt;
                    conn.DataSet.Tables["KHACH"].Rows.Add(newRow);
                }
                else
                {
                    DataRow updateRow = conn.DataSet.Tables["KHACH"].Rows.Find(makh);
                    updateRow["TENKH"] = tenkh;
                    updateRow["DIACHI"] = dc;
                    updateRow["DT"] = dt;
                }
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(conn.DataSet, "KHACH");

                button4.Enabled = false;
                textBox1.Enabled = textBox2.Enabled = false;

                MessageBox.Show("Lưu thành công!");
            }
            catch
            {
                MessageBox.Show("Lưu không thành công!");
            }
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;            
            maskedTextBox1.Enabled = false;         
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = button3.Enabled = true;
        }
    }
}
