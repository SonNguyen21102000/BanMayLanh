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
    public partial class NhanVien : Form
    {
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        public NhanVien()
        {
            InitializeComponent();
        }
        public void LoadDataGridView_NHANVIEN()
        {
            string strSQL = "SELECT * FROM NHANVIEN";
            ada_NhanVien = conn.getDataAdapter(strSQL, "NHANVIEN");
            dataGridView1.DataSource = conn.DataSet.Tables["NHANVIEN"];

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = conn.DataSet.Tables["NHANVIEN"].Columns["MANV"];
            conn.DataSet.Tables["NHANVIEN"].PrimaryKey = primaryKey;
            dataGridView1.ReadOnly = true;
        }
        public void dataBindings(DataTable pTable)
        {
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", pTable, "MANV", true, DataSourceUpdateMode.Never);
            textBox2.DataBindings.Add("Text", pTable, "TENNV", true, DataSourceUpdateMode.Never);
            comboBox1.DataBindings.Add("Text",pTable,"GIOITINH",true,DataSourceUpdateMode.Never);
            textBox3.DataBindings.Add("Text", pTable, "DIACHI", true, DataSourceUpdateMode.Never);
            maskedTextBox1.DataBindings.Add("Text", pTable, "DT", true, DataSourceUpdateMode.Never);
            dateTimePicker1.DataBindings.Add("Text", pTable, "NGAYSINH", true, DataSourceUpdateMode.Never);
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string manv = textBox1.Text.Trim();
            string tennv = textBox2.Text.Trim();
            string gt = comboBox1.Text.Trim();
            string dc = textBox3.Text.Trim();
            string dt = maskedTextBox1.Text.Trim();
            string ngsinh = dateTimePicker1.Text.Trim();
            if (manv == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên. Vui lòng nhập !!!");
                textBox1.Focus();
                return;
            }
            else if (tennv == string.Empty)
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
            else if (ngsinh == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh. Vui lòng nhập !!!");
                dateTimePicker1.Focus();
                return;
            }
            try
            {
                if (textBox1.Enabled == true)
                {
                    DataRow existRow = conn.DataSet.Tables["NHANVIEN"].Rows.Find(manv);
                    if (existRow != null)
                    {
                        MessageBox.Show("Mã này đã tồn tại!");
                        textBox1.Clear();
                        textBox1.Focus();
                        return;
                    }
                    DataRow newRow = conn.DataSet.Tables["NHANVIEN"].NewRow();
                    newRow["MANV"] = manv;
                    newRow["TENNV"] = tennv;
                    newRow["GIOITINH"] = comboBox1.Text;
                    newRow["DIACHI"] = dc;
                    newRow["DT"] = dt;
                    newRow["NGAYSINH"] = ngsinh;
                    conn.DataSet.Tables["NHANVIEN"].Rows.Add(newRow);
                }
                else
                {
                    DataRow updateRow = conn.DataSet.Tables["NHANVIEN"].Rows.Find(manv);
                    updateRow["TENNV"] = tennv;                 
                    updateRow["GIOITINH"] = gt;                   
                    updateRow["DIACHI"] = dc;
                    updateRow["DT"] = dt;
                    updateRow["NGAYSINH"] = ngsinh;
                }
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(conn.DataSet, "NHANVIEN");

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
            label6.Enabled = false;
            label7.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            maskedTextBox1.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.ShowDialog();
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
            label6.Enabled = true;
            label7.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
            maskedTextBox1.Enabled = true;
            comboBox1.Enabled = true;
            button4.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            maskedTextBox1.Clear();          
            comboBox1.Text = null;          
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                return;

            //Tiến hành kiểm tra và lưu dữ liệu
            string manv = textBox1.Text.Trim();
            try
            {
                string strSQL = "SELECT count(*) FROM BIENLAI WHERE MANV='" + manv + "'";
                if (conn.checkForExistence(strSQL))
                {
                    MessageBox.Show("Nhân viên này đã tồn tại khóa ngoại trên bảng BIENLAI!");
                    return;
                }
                //Lưu cập nhật
                DataRow deleteRow = conn.DataSet.Tables["NHANVIEN"].Rows.Find(manv);
                deleteRow.Delete();

                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(conn.DataSet, "NHANVIEN");

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
            dateTimePicker1.Text = null;
            maskedTextBox1.Clear();
            comboBox1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
            maskedTextBox1.Enabled = true;
            textBox2.Focus();
            comboBox1.Enabled = true;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NHANVIEN();
            dataBindings(conn.DataSet.Tables["NHANVIEN"]);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            maskedTextBox1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            comboBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = button3.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
