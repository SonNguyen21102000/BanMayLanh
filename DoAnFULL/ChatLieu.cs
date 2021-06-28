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
    public partial class ChatLieu : Form
    {
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_ChatLieu = new SqlDataAdapter();
        public ChatLieu()
        {
            InitializeComponent();
        }
        public void LoadDataGridView_CHATLIEU()
        {
            string strSQL = "SELECT * FROM CHATLIEU";
            ada_ChatLieu = conn.getDataAdapter(strSQL, "CHATLIEU");
            dataGridView1.DataSource = conn.DataSet.Tables["CHATLIEU"];

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = conn.DataSet.Tables["CHATLIEU"].Columns["MACHATLIEU"];
            conn.DataSet.Tables["CHATLIEU"].PrimaryKey = primaryKey;
            dataGridView1.ReadOnly = true;
        }
        public void dataBindings(DataTable pTable)
        {
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", pTable, "MACHATLIEU", true, DataSourceUpdateMode.Never);
            textBox2.DataBindings.Add("Text", pTable, "TENCHATLIEU", true, DataSourceUpdateMode.Never);
        }
        private void ChatLieu_Load(object sender, EventArgs e)
        {
            LoadDataGridView_CHATLIEU();
            dataBindings(conn.DataSet.Tables["CHATLIEU"]);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button4.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn xóa chất liệu này không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.No)
                return;

            //Tiến hành kiểm tra và lưu dữ liệu
            string machatlieu = textBox1.Text.Trim();
            try
            {
                //Kiểm tra khóa ngoại
                string strSQL = "SELECT count(*) FROM HANG WHERE MACHATLIEU='" + machatlieu + "'";
                if (conn.checkForExistence(strSQL))
                {
                    MessageBox.Show("Chất liệu này đã tồn tại khóa ngoại trên bảng HANG!");
                    return;
                }
                //Lưu cập nhật
                DataRow deleteRow = conn.DataSet.Tables["CHATLIEU"].Rows.Find(machatlieu);
                deleteRow.Delete();

                //Cập nhật dữ liệu xuống CSDL
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_ChatLieu);
                ada_ChatLieu.Update(conn.DataSet, "CHATLIEU");

                button4.Enabled = false;
                textBox1.Enabled = textBox2.Enabled = false;

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
            textBox2.Enabled = true;
            textBox2.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đóng màn hình này không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string machatlieu = textBox1.Text.Trim();
            string tenchatlieu = textBox2.Text.Trim();
            if (machatlieu == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã chất liệu. Vui lòng nhập !!!");
                textBox1.Focus();
                return;
            }
            else if (tenchatlieu == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu. Vui lòng nhập !!!");
                textBox2.Focus();
                return;
            }
            try
            {
                if (textBox1.Enabled == true)
                {
                    DataRow existRow = conn.DataSet.Tables["CHATLIEU"].Rows.Find(machatlieu);
                    if (existRow != null)
                    {
                        MessageBox.Show("Mã này đã tồn tại!");
                        textBox1.Clear();
                        textBox1.Focus();
                        return;
                    }
                    DataRow newRow = conn.DataSet.Tables["CHATLIEU"].NewRow();
                    newRow["MACHATLIEU"] = machatlieu;
                    newRow["TENCHATLIEU"] = tenchatlieu;
                    conn.DataSet.Tables["CHATLIEU"].Rows.Add(newRow);
                }
                else
                {
                    DataRow updateRow = conn.DataSet.Tables["CHATLIEU"].Rows.Find(machatlieu);
                    updateRow["TENCHATLIEU"] = tenchatlieu;
                }
                SqlCommandBuilder cb = new SqlCommandBuilder(ada_ChatLieu);
                ada_ChatLieu.Update(conn.DataSet, "CHATLIEU");

                button4.Enabled = false;
                textBox1.Enabled = textBox2.Enabled = false;

                MessageBox.Show("Lưu thành công!");
            }
            catch
            {
                MessageBox.Show("Lưu không thành công!");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
        }
    }
}
