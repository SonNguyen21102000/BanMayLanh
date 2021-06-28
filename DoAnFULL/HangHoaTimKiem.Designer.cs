namespace DoAnFULL
{
    partial class HangHoaTimKiem
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
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACHATLIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 76);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(705, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Tìm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(416, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập từ khóa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 100);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::DoAnFULL.Properties.Resources.icons8_go_back_24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(644, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Quay Lại";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Hiễn Thị Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANG,
            this.TENHANG,
            this.MACHATLIEU,
            this.SOLUONG,
            this.DONGIANHAP,
            this.DONGIABAN,
            this.ANH,
            this.GHICHU});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 384);
            this.dataGridView1.TabIndex = 2;
            // 
            // MAHANG
            // 
            this.MAHANG.DataPropertyName = "MAHANG";
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.Name = "MAHANG";
            // 
            // TENHANG
            // 
            this.TENHANG.DataPropertyName = "TENHANG";
            this.TENHANG.HeaderText = "Tên Hàng";
            this.TENHANG.Name = "TENHANG";
            this.TENHANG.Width = 200;
            // 
            // MACHATLIEU
            // 
            this.MACHATLIEU.DataPropertyName = "MACHATLIEU";
            this.MACHATLIEU.HeaderText = "Mã Chất Liệu";
            this.MACHATLIEU.Name = "MACHATLIEU";
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            // 
            // DONGIANHAP
            // 
            this.DONGIANHAP.DataPropertyName = "DONGIANHAP";
            this.DONGIANHAP.HeaderText = "Đơn Giá Nhập";
            this.DONGIANHAP.Name = "DONGIANHAP";
            // 
            // DONGIABAN
            // 
            this.DONGIABAN.DataPropertyName = "DONGIABAN";
            this.DONGIABAN.HeaderText = "Đơn Giá Bán";
            this.DONGIABAN.Name = "DONGIABAN";
            // 
            // ANH
            // 
            this.ANH.DataPropertyName = "ANH";
            this.ANH.HeaderText = "Ảnh";
            this.ANH.Name = "ANH";
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi Chú";
            this.GHICHU.Name = "GHICHU";
            // 
            // HangHoaTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HangHoaTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HangHoaTimKiem";
            this.Load += new System.EventHandler(this.HangHoaTimKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHATLIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
    }
}