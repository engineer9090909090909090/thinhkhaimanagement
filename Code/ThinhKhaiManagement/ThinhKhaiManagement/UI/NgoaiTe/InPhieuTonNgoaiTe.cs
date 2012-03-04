using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThinhKhaiManagement.Common;
using DatabaseAccesser;
using System.Collections.ObjectModel;

namespace ThinhKhaiManagement.UI.NgoaiTe
{
    public partial class InPhieuTonNgoaiTe : Form
    {
        DataAccess dataaccess;

        public InPhieuTonNgoaiTe()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void InPhieuTonNgoaiTe_Load(object sender, EventArgs e)
        {
            RPTonNgoaiTe rp = new RPTonNgoaiTe();
            crystalReportViewer.ReportSource = rp;
        }
    }
}
