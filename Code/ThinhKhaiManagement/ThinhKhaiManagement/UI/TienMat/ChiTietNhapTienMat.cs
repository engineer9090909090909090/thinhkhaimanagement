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
    public partial class ChiTietNhapTienMat : Form
    {
        DataAccess dataaccess;

        public TienMat tienMat { get; set; }

        public ChiTietNhapTienMat()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void ChiTietNhapTienMat_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridViewChiTietNhapTienMat.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                    StoreProcedureNames.constNhapTienMat_ShowByNgay,
                                                                    new Collection<KeyValuePair<object, int>>{
                                                                        new KeyValuePair<object,int> (dateTimePickerNgayNhapTienMat.Value,(int)ParameterType.String)
                                                                    },
                                                                    (int)ExecuteType.Query);
            dataGridViewChiTietNhapTienMat.Columns[2].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapTienMat.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapTienMat.Columns[2].DefaultCellStyle.Format = "N2";
            labelTT.Text = String.Format("{0:0,0.00}", CalculateTotal());
        }

        private void dateTimePickerNgayNhapTienMat_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewChiTietNhapTienMat.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                    StoreProcedureNames.constNhapTienMat_ShowByNgay,
                                                                    new Collection<KeyValuePair<object, int>>{
                                                                        new KeyValuePair<object,int> (dateTimePickerNgayNhapTienMat.Value,(int)ParameterType.String)
                                                                    },
                                                                    (int)ExecuteType.Query);
            dataGridViewChiTietNhapTienMat.Columns[2].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapTienMat.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapTienMat.Columns[2].DefaultCellStyle.Format = "N2";
            labelTT.Text = String.Format("{0:0,0.00}", CalculateTotal());
        }

        private void dataGridViewChiTietNhapTienMat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tienMat.MaTemp = Convert.ToInt32(dataGridViewChiTietNhapTienMat.Rows[e.RowIndex].Cells[0].Value);
                tienMat.Ngay = (DateTime)dataGridViewChiTietNhapTienMat.Rows[e.RowIndex].Cells[1].Value;
                tienMat.radSpinEditorTienMat.Value = (decimal)dataGridViewChiTietNhapTienMat.Rows[e.RowIndex].Cells[2].Value;
                tienMat.textBoxLyDo.Text = dataGridViewChiTietNhapTienMat.Rows[e.RowIndex].Cells[3].Value.ToString();
                tienMat.labelHeaderThongTinTienMat.Text = "Sửa Thông Tin Tiền Mặt";
                tienMat.buttonLuu.Text = "Cập Nhật";
                this.Dispose();
            }
        }

        private decimal CalculateTotal()
        {
            decimal k = 0;
            for (int i = 0; i < dataGridViewChiTietNhapTienMat.Rows.Count; i++)
            {
                k += (decimal)dataGridViewChiTietNhapTienMat.Rows[i].Cells[2].Value;
            }
            return k;
        }
    }
}
