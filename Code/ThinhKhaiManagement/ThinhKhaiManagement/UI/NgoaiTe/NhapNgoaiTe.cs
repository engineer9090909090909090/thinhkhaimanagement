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

        public decimal SoLuongOld { get; set; }

        public decimal DonGiaOld { get; set; }

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
            toolStripStatusLabelNhapNgoaiTe.Text = string.Empty;
        }

        private void buttonLuuNhapNgoaiTe_Click(object sender, EventArgs e)
        {
            try
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
                        if (Update())
                            toolStripStatusLabelNhapNgoaiTe.Text = "cập phiếu thành công";
                        else
                            MessageBox.Show("cập nhật phiếu thất bại", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                        labelHeaderNhapNgoaiTe.Text = "Phiếu Nhập Ngoại Tệ";
                        buttonLuuNhapNgoaiTe.Text = "Lưu";
                        MaNhapNgoaiTe = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}",ex.Message,ex.StackTrace),
                                "Lỗi hệ thống",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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
                                                StoreProcedureNames.constNgoaiTe_GetAll,
                                                new Collection<KeyValuePair<object,int>>(),
                                                (int)ExecuteType.Query);
        }

        private bool Save()
        {

            SqlConnection sqlConnection = StaticMethods.ShowSqlConnection();
            SqlTransaction sqlTransaction=null;

            Collection<KeyValuePair<object, int>> c1 = new Collection<KeyValuePair<object, int>>(){
            new KeyValuePair<object,int>(comboBoxLoaiNgoaiTeNhap.SelectedValue, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorSoLuongNhapNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorDonGiaNhapNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(DateTime.Today.ToShortDateString(),(int)ParameterType.String),
            new KeyValuePair<object,int>(textBoxGhiChuNhapNgoaiTe.Text, (int)ParameterType.String)
            };

            bool i = (bool)dataaccess.Access(ref sqlConnection,
                                                StoreProcedureNames.constNhapNgoaiTe_Insert,
                                                c1,
                                                (int)ExecuteType.NonQuery,
                                                (int)TransactionType.StartTrans,
                                                ref sqlTransaction
                                                );

            Collection<KeyValuePair<object, int>> c2 = new Collection<KeyValuePair<object, int>>(){
            new KeyValuePair<object,int>(comboBoxLoaiNgoaiTeNhap.SelectedValue, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorSoLuongNhapNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorDonGiaNhapNgoaiTe.Value, (int)ParameterType.NonString)
            };

            bool k = (bool)dataaccess.Access(ref sqlConnection,
                                                StoreProcedureNames.constTonNgoaiTe_UpdateFromNhapInsert,
                                                c2,
                                                (int)ExecuteType.NonQuery,
                                                (int)TransactionType.DurringTrans,
                                                ref sqlTransaction
                                                );

            if (i & k)
            {
                sqlTransaction.Commit();
                dataaccess.DongKetNoi(sqlConnection);
                return true;
            }
            else
            {
                sqlTransaction.Rollback();
                dataaccess.DongKetNoi(sqlConnection);
                return false;
            }

        }

        private bool Update()
        {
            SqlConnection sqlConnection = StaticMethods.ShowSqlConnection();
            SqlTransaction sqlTransaction = null;

            Collection<KeyValuePair<object, int>> c1 = new Collection<KeyValuePair<object, int>>(){
            new KeyValuePair<object,int>(MaNhapNgoaiTe,(int)ParameterType.NonString),
            new KeyValuePair<object,int>(comboBoxLoaiNgoaiTeNhap.SelectedValue, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorSoLuongNhapNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorDonGiaNhapNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(ngay,(int)ParameterType.String),
            new KeyValuePair<object,int>(textBoxGhiChuNhapNgoaiTe.Text, (int)ParameterType.String)
            };

            bool i = (bool)dataaccess.Access(ref sqlConnection,
                                                StoreProcedureNames.constNhapNgoaiTe_UpdateByMaNhap,
                                                c1,
                                                (int)ExecuteType.NonQuery,
                                                (int)TransactionType.StartTrans,
                                                ref sqlTransaction);

            Collection<KeyValuePair<object, int>> c2 = new Collection<KeyValuePair<object, int>>(){
            new KeyValuePair<object,int>(comboBoxLoaiNgoaiTeNhap.SelectedValue, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(SoLuongOld, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(DonGiaOld, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorSoLuongNhapNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorDonGiaNhapNgoaiTe.Value, (int)ParameterType.NonString),
            };

            bool k = (bool)dataaccess.Access(ref sqlConnection,
                                                StoreProcedureNames.constTonNgoaiTe_UpdateFromNhapUpdate,
                                                c2,
                                                (int)ExecuteType.NonQuery,
                                                (int)TransactionType.DurringTrans,
                                                ref sqlTransaction);
            if (i & k)
            {
                sqlTransaction.Commit();
                dataaccess.DongKetNoi(sqlConnection);
                return true;
            }
            else
            {
                sqlTransaction.Rollback();
                dataaccess.DongKetNoi(sqlConnection);
                return false;
            }
        }

        #endregion
    }
}
