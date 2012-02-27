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

namespace ThinhKhaiManagement.UI.NgoaiTe
{
    public partial class ChiTietNhapNgoaiTe : Form
    {
        #region Propertises

        public NhapNgoaiTe nhapNgoaiTeObject{ get; set; }

        #endregion

        #region Variables and constants

        DataAccess dataaccess;

        #endregion

        #region handle event

        public ChiTietNhapNgoaiTe()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void ChiTietNhapNgoaiTe_Load(object sender, EventArgs e)
        {
            dataGridViewChiTietNhapNgoaiTe.DataSource = ShowNhapNgoaiTeByNgay(dateTimePickerNgayNhapNgoaiTe.Value);
        }

        private void dateTimePickerNgayNhapNgoaiTe_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewChiTietNhapNgoaiTe.DataSource = ShowNhapNgoaiTeByNgay(dateTimePickerNgayNhapNgoaiTe.Value);
        }

        private void dataGridViewChiTietNhapNgoaiTe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nhapNgoaiTeObject.comboBoxLoaiNgoaiTeNhap.SelectedValue = dataGridViewChiTietNhapNgoaiTe.Rows[e.RowIndex].Cells[1].Value.ToString();
            nhapNgoaiTeObject.radSpinEditorSoLuongNhapNgoaiTe.Value = (decimal)dataGridViewChiTietNhapNgoaiTe.Rows[e.RowIndex].Cells[3].Value;
            nhapNgoaiTeObject.radSpinEditorDonGiaNhapNgoaiTe.Value = (decimal)dataGridViewChiTietNhapNgoaiTe.Rows[e.RowIndex].Cells[4].Value;
            nhapNgoaiTeObject.SoLuongOld = (decimal)dataGridViewChiTietNhapNgoaiTe.Rows[e.RowIndex].Cells[3].Value;
            nhapNgoaiTeObject.DonGiaOld = (decimal)dataGridViewChiTietNhapNgoaiTe.Rows[e.RowIndex].Cells[4].Value;
            nhapNgoaiTeObject.textBoxGhiChuNhapNgoaiTe.Text = dataGridViewChiTietNhapNgoaiTe.Rows[e.RowIndex].Cells[6].Value.ToString();
            nhapNgoaiTeObject.MaNhapNgoaiTe = Convert.ToInt32( dataGridViewChiTietNhapNgoaiTe.Rows[e.RowIndex].Cells[0].Value);
            nhapNgoaiTeObject.labelHeaderNhapNgoaiTe.Text = "Sửa Phiếu Nhập Ngoại Tệ";
            nhapNgoaiTeObject.buttonLuuNhapNgoaiTe.Text = "Cập nhật";
            nhapNgoaiTeObject.ngay = (DateTime)dataGridViewChiTietNhapNgoaiTe.Rows[e.RowIndex].Cells[5].Value;

            this.Dispose();
        }

            
        #endregion

        #region private methods

        private DataTable ShowNhapNgoaiTeByNgay(DateTime ngayNhap)
        {
            return (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                StoreProcedureNames.constNhapNgoaiTe_ShowByNgay,
                                                new Collection<KeyValuePair<object, int>>(){
                                                    new KeyValuePair<object,int>(ngayNhap,(int)ParameterType.String)
                                                },
                                                (int)ExecuteType.Query);
        }

        #endregion

        #region public methods

        #endregion
    }
}
