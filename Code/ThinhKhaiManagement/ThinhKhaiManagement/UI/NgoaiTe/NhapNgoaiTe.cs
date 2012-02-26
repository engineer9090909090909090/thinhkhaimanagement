using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThinhKhaiManagement.Common;
using System.Data.SqlClient;
using System.Configuration;
using DatabaseAccesser;

namespace ThinhKhaiManagement.UI.NgoaiTe
{
    public partial class NhapNgoaiTe : Form
    {
        #region Variables and Constants



        #endregion

        #region handle events

        public NhapNgoaiTe()
        {
            InitializeComponent();
        }

        private void NhapNgoaiTe_Load(object sender, EventArgs e)
        {
            // hien thi ngay thang hien tai
            labelNgayNhapNgoaiTe.Text = StaticMethods.ShowDate();

            // do du lieu vao combobox
            DataTable ngoaiTeTable = ShowLoaiNgoaiTe();
            comboBoxLoaiNgoaiTeNhap.DataSource = ngoaiTeTable;
            comboBoxLoaiNgoaiTeNhap.DisplayMember = ngoaiTeTable.Columns[1].ColumnName;
            comboBoxLoaiNgoaiTeNhap.ValueMember = ngoaiTeTable.Columns[0].ColumnName;
        }

        private void buttonXemChiTietNhapNgoaiTe_Click(object sender, EventArgs e)
        {
            ChiTietNhapNgoaiTe chiTietNhapNgoaiTe = new ChiTietNhapNgoaiTe();
            chiTietNhapNgoaiTe.ShowDialog();
        }

        #endregion

        #region private methods

        private DataTable ShowLoaiNgoaiTe()
        {
            SqlConnection sqlconnection = StaticMethods.ShowSqlConnection();
            DataAccess dataaccess = new DataAccess();
            return (DataTable)dataaccess.Access(sqlconnection,
                                                StoreProcedureNames.constNgoaiTeGetAll,
                                                new Dictionary<object,int>(),
                                                (int)ExecuteType.Query);
        }

        #endregion

        private void buttonLamSachNhapNgoaiTe_Click(object sender, EventArgs e)
        {
            comboBoxLoaiNgoaiTeNhap.SelectedIndex = 0;
            comboBoxLoaiNgoaiTeNhap.Focus();
            radSpinEditorDonGiaNhapNgoaiTe.Value = 0;
            radSpinEditorSoLuongNhapNgoaiTe.Value = 0;
            textBoxGhiChuNhapNgoaiTe.Text = string.Empty;
        }


    }
}
