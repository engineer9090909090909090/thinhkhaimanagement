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
        #region property

        public int MaNhapNgoaiTe { get; set; }

        public DateTime ngay { get; set; }

        #endregion

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
            chiTietNhapNgoaiTe.nhapNgoaiTeObject = this;
            chiTietNhapNgoaiTe.ShowDialog();
        }

        private void buttonLamSachNhapNgoaiTe_Click(object sender, EventArgs e)
        {
            comboBoxLoaiNgoaiTeNhap.SelectedIndex = 0;
            comboBoxLoaiNgoaiTeNhap.Focus();
            radSpinEditorDonGiaNhapNgoaiTe.Value = 0;
            radSpinEditorSoLuongNhapNgoaiTe.Value = 0;
            textBoxGhiChuNhapNgoaiTe.Text = string.Empty;
            labelHeaderNhapNgoaiTe.Text = "Phiếu Nhập Ngoại Tệ";
            buttonLuuNhapNgoaiTe.Text = "Lưu";
            MaNhapNgoaiTe = 0;
        }

        private void buttonLuuNhapNgoaiTe_Click(object sender, EventArgs e)
        {
            if (checkControl())
            {
                if (MaNhapNgoaiTe == 0)
                {
                    if (Save())
                        toolStripStatusLabelNhapNgoaiTe.Text = "Nhập phiếu thành công";
                    else
                        MessageBox.Show("Nhập phiếu thất bại", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(Update())
                        toolStripStatusLabelNhapNgoaiTe.Text = "cập phiếu thành công";
                    else
                        MessageBox.Show("cập nhật phiếu thất bại", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buttonLamSachNhapNgoaiTe_Click(sender, e);
                }
            }
        }

        #endregion

        #region private methods

        private bool checkControl()
        {
            int flag = 0;

            if (radSpinEditorSoLuongNhapNgoaiTe.Value > 0)
            {
                errorProvider_NhapNgoaiTe.SetError(radSpinEditorSoLuongNhapNgoaiTe, string.Empty);
                flag++;
            }
            else
            {
                errorProvider_NhapNgoaiTe.SetError(radSpinEditorSoLuongNhapNgoaiTe, "Dữ liệu không hợp lệ");
                flag = 0;
            }

            if (radSpinEditorDonGiaNhapNgoaiTe.Value > 0)
            {
                errorProvider_NhapNgoaiTe.SetError(radSpinEditorDonGiaNhapNgoaiTe, string.Empty);
                flag++;
            }
            else
            {
                errorProvider_NhapNgoaiTe.SetError(radSpinEditorDonGiaNhapNgoaiTe, "Dữ liệu không hợp lệ");
                flag = 0;
            }

            if (flag == 2)
                return true;
            else
                return false;

        }

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
                                                StoreProcedureNames.constNhapNgoaiTeInsert,
                                                d,
                                                (int)ExecuteType.NonQuery);
        }

        private bool Update()
        {
            Collection<KeyValuePair<object, int>> d = new Collection<KeyValuePair<object, int>>(){
            new KeyValuePair<object,int>(MaNhapNgoaiTe,(int)ParameterType.NonString),
            new KeyValuePair<object,int>(comboBoxLoaiNgoaiTeNhap.SelectedValue, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorSoLuongNhapNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorDonGiaNhapNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(ngay,(int)ParameterType.String),
            new KeyValuePair<object,int>(textBoxGhiChuNhapNgoaiTe.Text, (int)ParameterType.String)
            };

            return (bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                StoreProcedureNames.constNhapNgoaiTe_UpdateByMaNhap,
                                                d,
                                                (int)ExecuteType.NonQuery);
        }

        #endregion
    }
}
