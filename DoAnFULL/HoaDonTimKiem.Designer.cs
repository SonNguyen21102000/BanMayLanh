namespace DoAnFULL
{
    partial class HoaDonTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 87);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(931, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập từ khóa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 100);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::DoAnFULL.Properties.Resources.icons8_go_back_24;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(900, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "&Quay Lại";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(509, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "&Hiễn Thị Danh Sách";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.NGAYBAN,
            this.MANV,
            this.TENNV,
            this.MAKH,
            this.TENKH,
            this.DIACHI,
            this.DT,
            this.MAHANG,
            this.TENHANG,
            this.SOLUONG,
            this.DONGIA,
            this.GIAMGIA,
            this.THANHTIEN});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1362, 389);
            this.dataGridView1.TabIndex = 2;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã Hóa Đơn";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            // 
            // NGAYBAN
            // 
            this.NGAYBAN.DataPropertyName = "NGAYBAN";
            this.NGAYBAN.HeaderText = "Ngày Bán";
            this.NGAYBAN.Name = "NGAYBAN";
            this.NGAYBAN.ReadOnly = true;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên Nhân Viên";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã Khách";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên Khách";
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa Chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // DT
            // 
            this.DT.DataPropertyName = "DT";
            this.DT.HeaderText = "Điện Thoại";
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            // 
            // MAHANG
            // 
            this.MAHANG.DataPropertyName = "MAHANG";
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.Name = "MAHANG";
            this.MAHANG.ReadOnly = true;
            // 
            // TENHANG
            // 
            this.TENHANG.DataPropertyName = "TENHANG";
            this.TENHANG.HeaderText = "Tên Hàng";
            this.TENHANG.Name = "TENHANG";
            this.TENHANG.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn Giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.DataPropertyName = "GIAMGIA";
            this.GIAMGIA.HeaderText = "Giảm Giá(%)";
            this.GIAMGIA.Name = "GIAMGIA";
            this.GIAMGIA.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // HoaDonTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDonTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonTimKiem";
            this.Load += new System.EventHandler(this.HoaDonTimKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}