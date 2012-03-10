using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThinhKhaiManagement.Reports;

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class InPhieuTonMathang : Form
    {
        public ThinhKhaiDataSet ReportDataSet { get; set; }
  
        public InPhieuTonMathang()
        {
            InitializeComponent();
        }

        private void InPhieuTonMathang_Load(object sender, EventArgs e)
        {
            Reports.TonMatHang tmh = new Reports.TonMatHang();
            tmh.SetDataSource(ReportDataSet);
            crystalReportViewerTonMatHang.ReportSource = tmh;
        }
    }
}
