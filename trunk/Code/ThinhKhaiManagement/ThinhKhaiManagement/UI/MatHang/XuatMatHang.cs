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

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class XuatMatHang : Form
    {
        DataAccess dataaccess;

        public XuatMatHang()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void XuatMatHang_Load(object sender, EventArgs e)
        {
            labelNgayXuatMatHang.Text = StaticMethods.ShowDate();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            FillDataToBill();
        }

        private void FillDataToBill()
        {
            try
            {
                DataTable tb = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                               StoreProcedureNames.constXuatMatHang_ShowByMaMH,
                                                                               new Collection<KeyValuePair<object, int>> { 
                                                                            new KeyValuePair<object,int>(textBoxMaMH.Text,(int)ParameterType.String)
                                                                       },
                                                                               (int)ExecuteType.Query);
                if (tb.Rows.Count > 0)
                {
                    textBoxTenMatHang.Text = tb.Rows[0][4].ToString();
                    radSpinEditorTrongLuong.Value = (decimal)tb.Rows[0][5];
                    radSpinEditorTruHot.Value = (decimal)tb.Rows[0][6];
                    radSpinEditorTienHot.Value = (decimal)tb.Rows[0][7];
                    radSpinEditorTienCong.Value = (decimal)tb.Rows[0][8];
                    radSpinEditorDonGia.Value = (decimal)tb.Rows[0][9];
                    radSpinEditorTyGiaUSD.Value = (decimal)tb.Rows[0][10];
                }
                else
                    MessageBox.Show("Mặt hàng này không tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}", ex.Message, ex.StackTrace),
               "Lỗi hệ thống",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void textBoxMaMH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FillDataToBill();
        }
    }
}
