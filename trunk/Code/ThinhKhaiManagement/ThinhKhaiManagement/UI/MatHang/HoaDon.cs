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
    public partial class HoaDon : Form
    {
        public ThinhKhaiDataSet ReportDataSet { get; set; }

        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            Reports.HoaDon hd = new Reports.HoaDon();
            hd.SetDataSource(ReportDataSet);
            crystalReportViewerHoaDon.ReportSource = hd;
        }
    }
}
