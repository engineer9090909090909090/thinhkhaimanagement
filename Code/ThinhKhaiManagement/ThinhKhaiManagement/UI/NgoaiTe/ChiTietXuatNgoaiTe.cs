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
    public partial class ChiTietXuatNgoaiTe : Form
    {
        #region properties

        public XuatNgoaiTe xuatNgoaiTe { get; set; }

        #endregion

        #region variables and constants

        DataAccess dataaccess;

        #endregion

        #region handle events

        public ChiTietXuatNgoaiTe()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void dataGridViewChiTietXuatNgoaiTe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xuatNgoaiTe.radSpinEditorSoLuongXuatNgoaiTe.Maximum = xuatNgoaiTe.radSpinEditorSoLuongXuatNgoaiTe.Maximum + (decimal)dataGridViewChiTietXuatNgoaiTe.Rows[e.RowIndex].Cells[3].Value;

            xuatNgoaiTe.textBoxMaLoaiNgoaiTeXuat.Text = dataGridViewChiTietXuatNgoaiTe.Rows[e.RowIndex].Cells[1].Value.ToString();
            xuatNgoaiTe.textBoxTenLoaiNgoaiTeXuat.Text = dataGridViewChiTietXuatNgoaiTe.Rows[e.RowIndex].Cells[2].Value.ToString();
            xuatNgoaiTe.radSpinEditorSoLuongXuatNgoaiTe.Value = (decimal)dataGridViewChiTietXuatNgoaiTe.Rows[e.RowIndex].Cells[3].Value;
            xuatNgoaiTe.SoLuongOld = (decimal)dataGridViewChiTietXuatNgoaiTe.Rows[e.RowIndex].Cells[3].Value;
            xuatNgoaiTe.radSpinEditorDonGiaXuatNgoaiTe.Value = (decimal)dataGridViewChiTietXuatNgoaiTe.Rows[e.RowIndex].Cells[4].Value;
            xuatNgoaiTe.textBoxGhiChuXuatNgoaiTe.Text = dataGridViewChiTietXuatNgoaiTe.Rows[e.RowIndex].Cells[6].Value.ToString();
            xuatNgoaiTe.Ngay = (DateTime)dataGridViewChiTietXuatNgoaiTe.Rows[e.RowIndex].Cells[5].Value;
            xuatNgoaiTe.labelHeaderXuatNgoaiTe.Text = "Sửa Phiếu Xuất Ngoại Tệ";
            xuatNgoaiTe.buttonLuuXuatNgoaiTe.Text = "Cập nhật";
            xuatNgoaiTe.MaXuatNgoaiTe = Convert.ToInt32(dataGridViewChiTietXuatNgoaiTe.Rows[e.RowIndex].Cells[0].Value);
            

            this.Dispose();
        }

        private void ChiTietXuatNgoaiTe_Load(object sender, EventArgs e)
        {
            dataGridViewChiTietXuatNgoaiTe.DataSource = ShowXuatNgoaiTeByNgayAndMaNT(dateTimePickerNgayXuatNgoaiTe.Value,Int32.Parse(xuatNgoaiTe.textBoxMaLoaiNgoaiTeXuat.Text));
        }

        private void dateTimePickerNgayXuatNgoaiTe_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewChiTietXuatNgoaiTe.DataSource = ShowXuatNgoaiTeByNgayAndMaNT(dateTimePickerNgayXuatNgoaiTe.Value, Int32.Parse(xuatNgoaiTe.textBoxMaLoaiNgoaiTeXuat.Text));
        }

        #endregion

        #region private methods

        private DataTable ShowXuatNgoaiTeByNgayAndMaNT(DateTime ngayNhap, int maLoaiNT)
        {
            return (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                StoreProcedureNames.constXuatNgoaiTe_ShowByNgayAndMaNT,
                                                new Collection<KeyValuePair<object, int>>(){
                                                    new KeyValuePair<object,int>(ngayNhap,(int)ParameterType.String),
                                                    new KeyValuePair<object,int>(maLoaiNT,(int)ParameterType.NonString)
                                                },
                                                (int)ExecuteType.Query);
        }

        #endregion

       
    }
}