using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using ThinhKhaiManagement.Common;
using DatabaseAccesser;
using System.Globalization;

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class ChiTietNhapMatHang : Form
    {
        DataAccess dataaccess;

        public NhapMatHang nhapMatHang { get; set; }

        public ChiTietNhapMatHang()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void ChiTietNhapMatHang_Load(object sender, EventArgs e)
        {
            dataGridViewChiTietNhapMatHang.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                    StoreProcedureNames.constNhapMatHang_ShowByNgay,
                                                                    new Collection<KeyValuePair<object, int>> { 
                                                                        new KeyValuePair<object,int>(dateTimePickerNgayNhapMatHang.Value,(int)ParameterType.String)
                                                                    },
                                                                    (int)ExecuteType.Query);
            ResetCollummFormat();
        }

        private void ResetCollummFormat()
        {
            dataGridViewChiTietNhapMatHang.Columns[4].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[4].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[5].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[5].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[6].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[6].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[7].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[7].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[8].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[8].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[9].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[9].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[9].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[12].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[12].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[12].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[13].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[13].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[13].DefaultCellStyle.Format = "N2";
        }

        private void dataGridViewChiTietNhapMatHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                nhapMatHang.textBoxMaMatHang.Text = dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                nhapMatHang.comboBoxChatLieu.SelectedValue = dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[1].Value;
                nhapMatHang.comboBoxLoaiMatHang.SelectedValue = dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[2].Value;
                nhapMatHang.textBoxTenMatHang.Text = dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                nhapMatHang.radSpinEditorTrongLuong.Value = (decimal)dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[4].Value;
                nhapMatHang.radSpinEditorTruHot.Value = (decimal)dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[5].Value;
                nhapMatHang.radSpinEditorTienHot.Value = (decimal)dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[6].Value;
                nhapMatHang.radSpinEditorTienHotBan.Value = (decimal)dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[13].Value;
                nhapMatHang.radSpinEditorTienCong.Value = (decimal)dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[7].Value;
                nhapMatHang.radSpinEditorTienCongBan.Value = (decimal)dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[12].Value;
                nhapMatHang.radSpinEditorDonGia.Value = (decimal)dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[8].Value;
                nhapMatHang.radSpinEditorTyGiaUSD.Value = (decimal)dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[9].Value;
                nhapMatHang.Stt = Convert.ToInt32(dataGridViewChiTietNhapMatHang.Rows[e.RowIndex].Cells[11].Value);
                nhapMatHang.calculateThanhTien();
                nhapMatHang.labelHeaderNhapMatHang.Text = "Sửa Phiếu Nhập Mặt Hàng";
                nhapMatHang.buttonLuuNhapMatHang.Text = "Cập Nhật";
                this.Dispose();
            }
        }

        private void dateTimePickerNgayNhapMatHang_ValueChanged(object sender, EventArgs e)
        {
            ChiTietNhapMatHang_Load(sender, e);
        }
    }
}
