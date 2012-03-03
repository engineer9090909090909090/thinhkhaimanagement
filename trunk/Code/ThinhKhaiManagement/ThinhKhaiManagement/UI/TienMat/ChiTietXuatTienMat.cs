using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThinhKhaiManagement.Common;
using DatabaseAccesser;
using System.Globalization;

namespace ThinhKhaiManagement.UI.TienMat
{
    public partial class ChiTietXuatTienMat : Form
    {
        DataAccess dataaccess;

        public TienMat tienMat { get; set; }

        public ChiTietXuatTienMat()
        {
            InitializeComponent();
            dataaccess = new DataAccess();

        }

        private void dateTimePickerNgayXuatTienMat_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewChiTietXuatTienMat.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                   StoreProcedureNames.constXuatTienMat_ShowByNgay,
                                                                   new Collection<KeyValuePair<object, int>>{
                                                                        new KeyValuePair<object,int> (dateTimePickerNgayXuatTienMat.Value,(int)ParameterType.String)
                                                                    },
                                                                   (int)ExecuteType.Query);
            dataGridViewChiTietXuatTienMat.Columns[2].ValueType = typeof(Decimal);
            dataGridViewChiTietXuatTienMat.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietXuatTienMat.Columns[2].DefaultCellStyle.Format = "N2";
        }

        private void ChiTietXuatTienMat_Load(object sender, EventArgs e)
        {
            dataGridViewChiTietXuatTienMat.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                   StoreProcedureNames.constXuatTienMat_ShowByNgay,
                                                                   new Collection<KeyValuePair<object, int>>{
                                                                        new KeyValuePair<object,int> (dateTimePickerNgayXuatTienMat.Value,(int)ParameterType.String)
                                                                    },
                                                                   (int)ExecuteType.Query);
            dataGridViewChiTietXuatTienMat.Columns[2].ValueType = typeof(Decimal);
            dataGridViewChiTietXuatTienMat.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietXuatTienMat.Columns[2].DefaultCellStyle.Format = "N2";
        }

        private void dataGridViewChiTietXuatTienMat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tienMat.MaTemp = Convert.ToInt32(dataGridViewChiTietXuatTienMat.Rows[e.RowIndex].Cells[0].Value);
            tienMat.Ngay = (DateTime)dataGridViewChiTietXuatTienMat.Rows[e.RowIndex].Cells[1].Value;
            tienMat.radSpinEditorTienMat.Value = (decimal)dataGridViewChiTietXuatTienMat.Rows[e.RowIndex].Cells[2].Value;
            tienMat.textBoxLyDo.Text = dataGridViewChiTietXuatTienMat.Rows[e.RowIndex].Cells[3].Value.ToString();
            tienMat.labelHeaderThongTinTienMat.Text = "Sửa Thông Tin Tiền Mặt";
            tienMat.buttonLuu.Text = "Cập Nhật";

            this.Dispose();
        }

    }
}
