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
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace ThinhKhaiManagement.UI.NgoaiTe
{
    public partial class XuatNgoaiTe : Form
    {
        #region properties

        public TonNgoaiTe TonNgoaiTe { get; set; }

        public int RowsIndexSelect { get; set; }

        public int MaXuatNgoaiTe { get; set; }

        public decimal SoLuongOld { get; set; }

        public DateTime Ngay { get; set; }

        #endregion

        #region Variables and constants

        DataAccess dataaccess; 

        #endregion

        #region handle event

        public XuatNgoaiTe()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void XuatNgoaiTe_Load(object sender, EventArgs e)
        {
            // hien thi ngay thang hien tai
            labelNgayXuatNgoaiTe.Text = StaticMethods.ShowDate();

            // do du lieu vao phieu tu ton kho
            GetDataFromTon();
        }

        private void XuatNgoaiTe_FormClosed(object sender, FormClosedEventArgs e)
        {
            TonNgoaiTe.UpdateTonNgoaiTe();
        }

        private void buttonLuuXuatNgoaiTe_Click(object sender, EventArgs e)
        {
            if (checkControl())
            {
                if (MaXuatNgoaiTe == 0)
                {
                    if (Save())
                    {
                        if (MessageBox.Show("Xuất phiếu thành công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                        MessageBox.Show("Xuất phiếu thất bại", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Update())
                    {
                        if (MessageBox.Show("cập nhật phiếu thành công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                        MessageBox.Show("cập nhật phiếu thất bại", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    labelHeaderXuatNgoaiTe.Text = "Phiếu Xuất Ngoại Tệ";
                    buttonLuuXuatNgoaiTe.Text = "Lưu";
                    MaXuatNgoaiTe = 0;
                }
            }
        }

        private void buttonXemChiTietXuatNgoaiTe_Click(object sender, EventArgs e)
        {
            ChiTietXuatNgoaiTe chiTietXuatNgoaiTe = new ChiTietXuatNgoaiTe();
            chiTietXuatNgoaiTe.xuatNgoaiTe = this;
            chiTietXuatNgoaiTe.ShowDialog();
        }

        #endregion

        #region private methods

        private void GetDataFromTon()
        { 
            textBoxMaLoaiNgoaiTeXuat.Text = TonNgoaiTe.dataGridViewTonNgoaiTe.Rows[RowsIndexSelect].Cells[1].Value.ToString();
            textBoxTenLoaiNgoaiTeXuat.Text = TonNgoaiTe.dataGridViewTonNgoaiTe.Rows[RowsIndexSelect].Cells[2].Value.ToString();
            radSpinEditorSoLuongXuatNgoaiTe.Maximum = (decimal)TonNgoaiTe.dataGridViewTonNgoaiTe.Rows[RowsIndexSelect].Cells[3].Value;
        }

        private bool checkControl()
        {
            int flag = 0;

            if (radSpinEditorSoLuongXuatNgoaiTe.Value > 0)
            {
                errorProviderXuatNgoaiTe.SetError(radSpinEditorSoLuongXuatNgoaiTe, string.Empty);
                flag++;
            }
            else
            {
                errorProviderXuatNgoaiTe.SetError(radSpinEditorSoLuongXuatNgoaiTe, "Dữ liệu không hợp lệ");
                flag = 0;
            }

            if (radSpinEditorDonGiaXuatNgoaiTe.Value > 0)
            {
                errorProviderXuatNgoaiTe.SetError(radSpinEditorDonGiaXuatNgoaiTe, string.Empty);
                flag++;
            }
            else
            {
                errorProviderXuatNgoaiTe.SetError(radSpinEditorDonGiaXuatNgoaiTe, "Dữ liệu không hợp lệ");
                flag = 0;
            }

            if (flag == 2)
                return true;
            else
                return false;

        }

        private bool Save()
        {

            SqlConnection sqlConnection = StaticMethods.ShowSqlConnection();
            SqlTransaction sqlTransaction = null;

            try
            {
                Collection<KeyValuePair<object, int>> c1 = new Collection<KeyValuePair<object, int>>(){
            new KeyValuePair<object,int>(textBoxMaLoaiNgoaiTeXuat.Text, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorSoLuongXuatNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorDonGiaXuatNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(DateTime.Today.ToShortDateString(),(int)ParameterType.String),
            new KeyValuePair<object,int>(textBoxGhiChuXuatNgoaiTe.Text, (int)ParameterType.String)
            };

                bool i = (bool)dataaccess.Access(ref sqlConnection,
                                                    StoreProcedureNames.constXuatNgoaiTe_Insert,
                                                    c1,
                                                    (int)ExecuteType.NonQuery,
                                                    (int)TransactionType.StartTrans,
                                                    ref sqlTransaction
                                                    );

                Collection<KeyValuePair<object, int>> c2 = new Collection<KeyValuePair<object, int>>(){
            new KeyValuePair<object,int>(textBoxMaLoaiNgoaiTeXuat.Text, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorSoLuongXuatNgoaiTe.Value, (int)ParameterType.NonString)
            };

                bool k = (bool)dataaccess.Access(ref sqlConnection,
                                                    StoreProcedureNames.constTonNgoaiTe_UpdateFromXuatInsert,
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
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}", ex.Message, ex.StackTrace),
                                    "Lỗi hệ thống",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                sqlTransaction.Rollback();
                dataaccess.DongKetNoi(sqlConnection);
                return false;
            }
        }

        private bool Update()
        {
            SqlConnection sqlConnection = StaticMethods.ShowSqlConnection();
            SqlTransaction sqlTransaction = null;

            try
            {
                Collection<KeyValuePair<object, int>> c1 = new Collection<KeyValuePair<object, int>>(){
            new KeyValuePair<object,int>(MaXuatNgoaiTe,(int)ParameterType.NonString),
            new KeyValuePair<object,int>(textBoxMaLoaiNgoaiTeXuat.Text, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorSoLuongXuatNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorDonGiaXuatNgoaiTe.Value, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(Ngay,(int)ParameterType.String),
            new KeyValuePair<object,int>(textBoxGhiChuXuatNgoaiTe.Text, (int)ParameterType.String)
            };

                bool i = (bool)dataaccess.Access(ref sqlConnection,
                                                    StoreProcedureNames.constXuatNgoaiTe_UpdateByMaXuat,
                                                    c1,
                                                    (int)ExecuteType.NonQuery,
                                                    (int)TransactionType.StartTrans,
                                                    ref sqlTransaction);

                Collection<KeyValuePair<object, int>> c2 = new Collection<KeyValuePair<object, int>>(){
            new KeyValuePair<object,int>(textBoxMaLoaiNgoaiTeXuat.Text, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(SoLuongOld, (int)ParameterType.NonString),
            new KeyValuePair<object,int>(radSpinEditorSoLuongXuatNgoaiTe.Value, (int)ParameterType.NonString)

            };

                bool k = (bool)dataaccess.Access(ref sqlConnection,
                                                    StoreProcedureNames.constTonNgoaiTe_UpdateFromXuatUpdate,
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
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}", ex.Message, ex.StackTrace),
                                    "Lỗi hệ thống",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                sqlTransaction.Rollback();
                dataaccess.DongKetNoi(sqlConnection);
                return false;
            }
        }

        #endregion
    }
}
