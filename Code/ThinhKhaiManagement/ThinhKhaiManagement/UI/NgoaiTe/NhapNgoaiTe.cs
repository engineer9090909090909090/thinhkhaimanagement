using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        DataAccess dataaccess; 

        #endregion

        #region handle events

        public NhapNgoaiTe()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
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

        private void buttonLamSachNhapNgoaiTe_Click(object sender, EventArgs e)
        {
            comboBoxLoaiNgoaiTeNhap.SelectedIndex = 0;
            comboBoxLoaiNgoaiTeNhap.Focus();
            radSpinEditorDonGiaNhapNgoaiTe.Value = 0;
            radSpinEditorSoLuongNhapNgoaiTe.Value = 0;
            textBoxGhiChuNhapNgoaiTe.Text = string.Empty;
        }

        private void buttonLuuNhapNgoaiTe_Click(object sender, EventArgs e)
        {
            if (Save())
                MessageBox.Show("Nhập phiếu thành công");
            else
                MessageBox.Show("Nhập phiếu thất bại");
        }

        #endregion

        #region private methods

        private DataTable ShowLoaiNgoaiTe()
        {   
            return (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                StoreProcedureNames.constNgoaiTeGetAll,
                                                new Collection<KeyValuePair<object,int>>(),
                                                (int)ExecuteType.Query);
        }

        private bool Save()
        {
            Collection<KeyValuePair<object, int>> d = new Collection<KeyValuePair<object, int>>(){
                new KeyValuePair<object,int>(comboBoxLoaiNgoaiTeNhap.SelectedValue, (int)ParameterType.NonString),
                new KeyValuePair<object,int>(radSpinEditorSoLuongNhapNgoaiTe.Value, (int)ParameterType.NonString),
                new KeyValuePair<object,int>(radSpinEditorDonGiaNhapNgoaiTe.Value, (int)ParameterType.NonString),
                new KeyValuePair<object,int>(DateTime.Today.ToShortDateString(),(int)ParameterType.String),
                new KeyValuePair<object,int>(textBoxGhiChuNhapNgoaiTe.Text, (int)ParameterType.String)
            };

            return (bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                StoreProcedureNames.constNgoaiTeInsert,
                                                d,
                                                (int)ExecuteType.NonQuery);

        }

        #endregion

     


    }
}
