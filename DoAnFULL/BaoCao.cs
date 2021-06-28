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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            CrystalReport1 rpt = new CrystalReport1();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.ShowDialog();
        }
    }
}
