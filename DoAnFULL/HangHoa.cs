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
using System.IO;
namespace DoAnFULL
{
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }
        OpenFileDialog open;
        Image file;
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_NhanVien = new SqlDataAdapter();
        private void HangHoa_Load(object sender, EventArgs e)
        {
            LoadDataGridView_NHANVIEN();
            dataBindings(conn.DataSet.Tables["HANG"]);
            label2.Enabled = label3.Enabled = label4.Enabled = label5.Enabled = label6.Enabled = label7.Enabled = label8.Enabled = label9.Enabled = false;
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = textBox7.Enabled = false;
            comboBox1.Enabled = false;
            button4.Enabled = button9.Enabled = false ;
            comboBox1.Text = null;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            //comboBox1.Items.Clear();
            //loadCombobox1();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        public void LoadDataGridView_NHANVIEN()
        {
            string strSQL = "SELECT * FROM HANG";
            ada_NhanVien = conn.getDataAdapter(strSQL, "HANG");
            dataGridView1.DataSource = conn.DataSet.Tables["HANG"];

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = conn.DataSet.Tables["HANG"].Columns["MAHANG"];
            conn.DataSet.Tables["HANG"].PrimaryKey = primaryKey;
            dataGridView1.ReadOnly = true;
        }

        public void dataBindings(DataTable pTable)
        {
            textBox1.DataBindings.Add("Text", pTable, "MAHANG", true, DataSourceUpdateMode.Never);
            textBox2.DataBindings.Add("Text", pTable, "TENHANG", true, DataSourceUpdateMode.Never);
            comboBox1.DataBindings.Add("Text", pTable, "MACHATLIEU", true, DataSourceUpdateMode.Never);
            textBox3.DataBindings.Add("Text", pTable, "SOLUONG", true, DataSourceUpdateMode.Never);
            textBox4.DataBindings.Add("Text", pTable, "DONGIANHAP", true, DataSourceUpdateMode.Never);
            textBox5.DataBindings.Add("Text", pTable, "DONGIABAN", true, DataSourceUpdateMode.Never);
            textBox6.DataBindings.Add("Text", pTable, "ANH", true, DataSourceUpdateMode.Never);
            textBox7.DataBindings.Add("Text", pTable, "GHICHU", true, DataSourceUpdateMode.Never);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\DoAnFULL\\DoAnFULL\\Resources\\3a74ab4b8c97fc1a826af48bbe05574e (1).jpg");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            open = new OpenFileDialog();
            open.Filter = "JPG(*.JPG)|*.jpg";
            if(open.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = open.FileName;
                file = Image.FromFile(open.FileName);
                pictureBox1.Image = file;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           DialogResult res = MessageBox.Show("Bạn muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo,
           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Enabled = label3.Enabled = label4.Enabled = label5.Enabled = label6.Enabled = label7.Enabled = label8.Enabled = label9.Enabled = true;
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = textBox7.Enabled = true;
            comboBox1.Enabled = true;
            button4.Enabled = button9.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            pictureBox1.Image = null;
            comboBox1.Text = null;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                return;

            //Tiến hành kiểm tra và lưu dữ liệu
            string manv = textBox1.Text.Trim();
            try
            {
                //Kiểm tra khóa ngoại
                string strSQL = "SELECT count(*) FROM BIENLAI WHERE MAHANG='" + manv + "'";
                if (conn.checkForExistence(strSQL))
                {
                    MessageBox.Show("Mã hàng này đã tồn tại khóa ngoại trên bảng BIENLAI!");
                    return;
                }
                //Lưu cập nhật
                DataRow deleteRow = conn.DataSet.Tables["HANG"].Rows.Find(manv);
                deleteRow.Delete();

                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(conn.DataSet, "HANG");

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
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = null;
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            label3.Enabled = label4.Enabled = label5.Enabled = label6.Enabled = label7.Enabled = label8.Enabled = label9.Enabled = true;
            textBox2.Enabled = textBox3.Enabled = comboBox1.Enabled = true;
            textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = textBox7.Enabled = true;
            textBox2.Focus();
            comboBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mahang = textBox1.Text.Trim();
            string tenhang = textBox2.Text.Trim();
            string mcl = comboBox1.Text.Trim();
            string sl = textBox3.Text.Trim();
            string dgn = textBox4.Text.Trim();
            string dgb = textBox5.Text.Trim();
            string anh = textBox6.Text.Trim();
            string gc = textBox7.Text.Trim();
            if (mahang == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã hàng. Vui lòng nhập !!!");
                textBox1.Focus();
                return;
            }
            else if (tenhang == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên hàng. Vui lòng nhập !!!");
                textBox2.Focus();
                return;
            }
            else if (mcl == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã chất liệu. Vui lòng nhập !!!");
                comboBox1.Focus();
                return;
            }
            else if (sl == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập số lượng. Vui lòng nhập !!!");
                textBox3.Focus();
                return;
            }
            else if (dgn == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập giá nhập. Vui lòng nhập !!!");
                textBox4.Focus();
                return;
            }
            else if (dgb == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập giá bán. Vui lòng nhập !!!");
                textBox5.Focus();
                return;
            }
            else if (anh == string.Empty)
            {
                MessageBox.Show("Thiếu link ảnh. Vui lòng bổ sung !!!");
                textBox6.Focus();
                return;
            }
            else if (gc == string.Empty)
            {
                MessageBox.Show("Chưa ghi chú. Vui lòng bổ sung !!!");
                textBox7.Focus();
                return;
            }
            try
            {
                if (textBox1.Enabled == true)
                {
                    DataRow existRow = conn.DataSet.Tables["HANG"].Rows.Find(mahang);
                    if (existRow != null)
                    {
                        MessageBox.Show("Mã này đã tồn tại!");
                        textBox1.Clear();
                        textBox1.Focus();
                        return;
                    }
                    DataRow newRow = conn.DataSet.Tables["HANG"].NewRow();
                    newRow["MAHANG"] = mahang;
                    newRow["TENHANG"] = tenhang;
                    newRow["MACHATLIEU"] = comboBox1.Text;
                    newRow["SOLUONG"] = sl;
                    newRow["DONGIANHAP"] = dgn;
                    newRow["DONGIABAN"] = dgb;
                    newRow["ANH"] = anh;
                    newRow["GHICHU"] = gc;
                    conn.DataSet.Tables["HANG"].Rows.Add(newRow);
                }
                else
                {
                    DataRow updateRow = conn.DataSet.Tables["HANG"].Rows.Find(mahang);
                    updateRow["TENHANG"] = tenhang;
                    updateRow["MACHATLIEU"] = mcl;
                    updateRow["SOLUONG"] = sl;
                    updateRow["DONGIANHAP"] = dgn;
                    updateRow["DONGIABAN"] = dgb;
                    updateRow["ANH"] = anh;
                    updateRow["GHICHU"] = gc;
                }
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_NhanVien);
                ada_NhanVien.Update(conn.DataSet, "HANG");

                button4.Enabled = false;
                textBox1.Enabled = textBox2.Enabled = false;
                textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = textBox7.Enabled = false;
                MessageBox.Show("Lưu thành công!");
            }
            catch
            {
                MessageBox.Show("Lưu không thành công!");
            }
            label2.Enabled = label3.Enabled = label4.Enabled = label5.Enabled = label6.Enabled = label7.Enabled = label8.Enabled = label9.Enabled = false;
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = comboBox1.Enabled = false;
            button9.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string anh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ANH"].FormattedValue);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2ILVFNR\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True");
            conn.Open();
            SqlCommand cm = new SqlCommand("select ANH from HANG where ANH = '"+anh+"'",conn);
            string img = cm.ExecuteScalar().ToString();
            pictureBox1.Image = Image.FromFile(img);
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangHoaTimKiem tk = new HangHoaTimKiem();
            tk.ShowDialog();
        }
        SqlConnection con;
        SqlCommand cm;
        DataSet ds;
        
        public void loadCombobox1()
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        } 
    }
}
