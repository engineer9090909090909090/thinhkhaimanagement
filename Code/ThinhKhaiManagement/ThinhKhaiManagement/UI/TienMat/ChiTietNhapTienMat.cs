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
            dataGridViewChiTietNhapTienMat.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                    StoreProcedureNames.constNhapTienMat_ShowByNgay,
                                                                    new Collection<KeyValuePair<object, int>>{
                                                                        new KeyValuePair<object,int> (dateTimePickerNgayNhapTienMat.Value,(int)ParameterType.String)
                                                                    },
                                                                    (int)ExecuteType.Query);
        }

        private void dateTimePickerNgayNhapTienMat_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewChiTietNhapTienMat.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                    StoreProcedureNames.constNhapTienMat_ShowByNgay,
                                                                    new Collection<KeyValuePair<object, int>>{
                                                                        new KeyValuePair<object,int> (dateTimePickerNgayNhapTienMat.Value,(int)ParameterType.String)
                                                                    },
                                                                    (int)ExecuteType.Query);
        }

        private void dataGridViewChiTietNhapTienMat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
}
