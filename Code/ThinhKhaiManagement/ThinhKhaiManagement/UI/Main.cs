using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThinhKhaiManagement.UI.NgoaiTe;
using ThinhKhaiManagement.UI.TienMat;
using ThinhKhaiManagement.UI.MatHang;

namespace ThinhKhaiManagement.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemNhapNgoaiTe_Click(object sender, EventArgs e)
        {
            NhapNgoaiTe nhapNgoaiTe = new NhapNgoaiTe();
            nhapNgoaiTe.MdiParent = this;
            nhapNgoaiTe.Show();
        }

        private void toolStripMenuItemTonNgoaiTe_Click(object sender, EventArgs e)
        {
            TonNgoaiTe tonNgoaiTe = new TonNgoaiTe();
            tonNgoaiTe.MdiParent = this;
            tonNgoaiTe.Show();
        }

        private void toolStripMenuItemTienMat_Click(object sender, EventArgs e)
        {
            TienMat.TienMat tienMat = new TienMat.TienMat();
            tienMat.MdiParent = this;
            tienMat.Show();
        }

        private void toolStripMenuItemTonMatHang_Click(object sender, EventArgs e)
        {
            TonMatHang tonMatHang = new TonMatHang();
            tonMatHang.MdiParent = this;
            tonMatHang.Show();
        }

        private void toolStripMenuItemNhapMatHang_Click(object sender, EventArgs e)
        {
            NhapMatHang nhapMatHang = new NhapMatHang();
            nhapMatHang.MdiParent=this;
            nhapMatHang.Show();
        }
    }
}
