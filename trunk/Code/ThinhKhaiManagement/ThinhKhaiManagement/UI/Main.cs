using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThinhKhaiManagement.UI.NgoaiTe;

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
    }
}
