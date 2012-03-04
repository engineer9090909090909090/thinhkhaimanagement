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
using System.Data.SqlClient;

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class NhapMatHang : Form
    {
        #region properties

        public int Stt { get; set; }

        #endregion

        #region Variables and constants

        DataAccess dataaccess;

        #endregion

        #region handle event

        public NhapMatHang()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void NhapMatHang_Load(object sender, EventArgs e)
        {
            labelNgayNhapNgoaiTe.Text = StaticMethods.ShowDate();
            DataTable tb1 = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constChatLieu_GetAll,
                new Collection<KeyValuePair<object, int>>(),
                (int)ExecuteType.Query);
            comboBoxChatLieu.DataSource = tb1;
            comboBoxChatLieu.DisplayMember = tb1.Columns[1].ColumnName;
            comboBoxChatLieu.ValueMember = tb1.Columns[0].ColumnName;

            DataTable tb2 = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constLoaiMatHang_GetAll,
                new Collection<KeyValuePair<object, int>>(),
                (int)ExecuteType.Query);
            comboBoxLoaiMatHang.DataSource = tb2;
            comboBoxLoaiMatHang.DisplayMember = tb2.Columns[1].ColumnName;
            comboBoxLoaiMatHang.ValueMember = tb2.Columns[0].ColumnName;
        }

        private void buttonLamSachNhapMatHang_Click(object sender, EventArgs e)
        {
            textBoxMaMatHang.Text = string.Empty;
            comboBoxChatLieu.SelectedIndex = 0;
            comboBoxLoaiMatHang.SelectedIndex = 0;
            textBoxTenMatHang.Text = string.Empty;
            radSpinEditorTrongLuong.Value = 0;
            radSpinEditorTruHot.Value = 0;
            radSpinEditorTienHot.Value = 0;
            radSpinEditorTienCong.Value = 0;
            radSpinEditorTienHotBan.Value = 0;
            radSpinEditorTienCongBan.Value = 0;
            radSpinEditorDonGia.Value = 0;
            radSpinEditorTyGiaUSD.Value = 1;
            radSpinEditorThanhTien.Value = 0;
            labelHeaderNhapMatHang.Text = "Phiếu Nhập Mặt Hàng";
            buttonLuuNhapMatHang.Text = "Lưu";
            Stt = 0;
            textBoxMaMatHang.Focus();
        }

        private void buttonXemChiTietNhapMatHang_Click(object sender, EventArgs e)
        {
            ChiTietNhapMatHang chiTietNhapMatHang = new ChiTietNhapMatHang();
            chiTietNhapMatHang.nhapMatHang = this;
            chiTietNhapMatHang.ShowDialog();
        }

        private void buttonLuuNhapMatHang_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                if (Stt ==0)
                {
                    if (Save())
                        MessageBox.Show(string.Format("- Nhập mặt hàng thành công. \n- Đây là Mã Mặt Hàng: {0}", textBoxMaMatHang.Text),
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    else
                        MessageBox.Show("- Nhập mặt hàng thất bại",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                }
                else
                {
                    if (Update())
                        MessageBox.Show(string.Format("- Cập nhật mặt hàng thành công. \n- Đây là Mã Mặt Hàng Sau Khi cập nhật: {0}", textBoxMaMatHang.Text),
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        
                    else
                        MessageBox.Show("- Cập nhật mặt hàng thất bại",
                                    "Thông báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                buttonLamSachNhapMatHang_Click(sender, e);
            }
        }

        #endregion

        #region private methods

        private bool CheckControl()
        {
            int flag = 0;

            //1
            if (!string.IsNullOrEmpty(textBoxTenMatHang.Text))
            {
                errorProvider_NhapMatHang.SetError(textBoxTenMatHang, string.Empty);
                flag++;
            }
            else
            {
                errorProvider_NhapMatHang.SetError(textBoxTenMatHang, "Dữ liệu không hợp lệ");
                flag = 0;

            }

            //2
            if (radSpinEditorTrongLuong.Value > 0)
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTrongLuong, string.Empty);
                flag++;
            }
            else
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTrongLuong, "Dữ liệu không hợp lệ");
                flag = 0;
            }

            //3
            if (radSpinEditorDonGia.Value > 0)
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorDonGia, string.Empty);
                flag++;
            }
            else
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorDonGia, "Dữ liệu không hợp lệ");
                flag = 0;
            }

            //4
            if (radSpinEditorTruHot.Value < radSpinEditorTrongLuong.Value)
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTruHot, string.Empty);
                flag++;
            }
            else
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTruHot, "Trọng lượng không thể lớn hơn trọng lượng mặt hàng");
                flag = 0;
            }

            //5
            if (radSpinEditorTienCongBan.Value <= radSpinEditorTienCong.Value && radSpinEditorTienCong.Value > 0)
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTienCongBan, "Tiền công bán không hợp lệ");
                flag = 0;
            }
            else if (radSpinEditorTienCongBan.Value > radSpinEditorTienCong.Value && radSpinEditorTienCong.Value == 0)
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTienCongBan, "Tiền công bán không hợp lệ");
                flag = 0;
            }
            else
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTienCongBan, string.Empty);
                flag++;
            }

            //6
            if (radSpinEditorTienHotBan.Value <= radSpinEditorTienHot.Value && radSpinEditorTienHot.Value > 0)
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTienHotBan, "Tiền hột bán không hợp lệ");
                flag = 0;
            }
            else if (radSpinEditorTienHotBan.Value > radSpinEditorTienHot.Value && radSpinEditorTienHot.Value == 0)
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTienHotBan, "Tiền công bán không hợp lệ");
                flag = 0;
            }
            else
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTienHotBan, string.Empty);
                flag++;
            }

            //7
            if (radSpinEditorTruHot.Value > 0 && (radSpinEditorTienHot.Value == 0 || radSpinEditorTienCong.Value == 0))
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTruHot, "Mời nhập tiền công và tiền hột");
                flag = 0;
            }
            else
            {
                errorProvider_NhapMatHang.SetError(radSpinEditorTruHot,string.Empty);
                flag++;
            }

            if (flag == 7)
                return true;
            else
                return false;

        }

        private bool Save()
        {
            SqlTransaction tran = null;
            SqlConnection con = StaticMethods.ShowSqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoreProcedureNames.constNhapMatHang_Insert;
                cmd.Connection = con;
                cmd.Parameters.Add("@MaCL", SqlDbType.Int).SqlValue = comboBoxChatLieu.SelectedValue;
                cmd.Parameters.Add("@MaLMH", SqlDbType.Int).SqlValue = comboBoxLoaiMatHang.SelectedValue;
                cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar, 50).SqlValue = textBoxTenMatHang.Text;
                cmd.Parameters.Add("@TrongLuong", SqlDbType.Decimal).SqlValue = radSpinEditorTrongLuong.Value;
                cmd.Parameters.Add("@TruHot", SqlDbType.Decimal).SqlValue = radSpinEditorTruHot.Value;
                cmd.Parameters.Add("@HotNhap", SqlDbType.Decimal).SqlValue = radSpinEditorTienHot.Value;
                cmd.Parameters.Add("@CongNhap", SqlDbType.Decimal).SqlValue = radSpinEditorTienCong.Value;
                cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Decimal).SqlValue = radSpinEditorDonGia.Value;
                cmd.Parameters.Add("@TyGiaUSDNhap", SqlDbType.Decimal).SqlValue = radSpinEditorTyGiaUSD.Value;
                cmd.Parameters.Add("@NgayNhap", SqlDbType.Date).SqlValue = DateTime.Today;
                cmd.Parameters.Add("@MaMH", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@CongXuat", SqlDbType.Decimal).SqlValue = radSpinEditorTienCongBan.Value;
                cmd.Parameters.Add("HotXuat", SqlDbType.Decimal).SqlValue = radSpinEditorTienHotBan.Value;

                con.Open();
                tran = con.BeginTransaction();
                cmd.Transaction = tran;

                bool k = (cmd.ExecuteNonQuery() > 0 && !string.IsNullOrEmpty(cmd.Parameters["@MaMH"].Value.ToString()));

                textBoxMaMatHang.Text = cmd.Parameters["@MaMH"].Value.ToString();
                calculateThanhTien();

                bool i = (bool)dataaccess.Access(ref con,
                                        StoreProcedureNames.constXuatTienMat_Insert,
                                        new Collection<KeyValuePair<object, int>>{
                                                    new KeyValuePair<object,int>(DateTime.Today,(int)ParameterType.String),
                                                    new KeyValuePair<object,int>(radSpinEditorThanhTien.Value,(int)ParameterType.NonString),
                                                    new KeyValuePair<object,int>("NMH",(int)ParameterType.String),
                                                    new KeyValuePair<object,int>(textBoxMaMatHang.Text,(int)ParameterType.NonString),
                                                },
                                        (int)ExecuteType.NonQuery,
                                        (int)TransactionType.DurringTrans,
                                        ref tran);
                if (k & i)
                {
                    tran.Commit();
                    con.Close();
                    return true;
                }
                else
                {
                    tran.Rollback();
                    con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}", ex.Message, ex.StackTrace),
                               "Lỗi hệ thống",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                tran.Rollback();
                con.Close();
                return false;
            }
            
        }

        private bool Update()
        {
            SqlTransaction tran = null;
            SqlConnection con = StaticMethods.ShowSqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = StoreProcedureNames.constNhapMatHang_UpdateByMaMH;
                cmd.Connection = con;
                cmd.Parameters.Add("@MaMH", SqlDbType.NVarChar, 50).SqlValue = textBoxMaMatHang.Text;
                cmd.Parameters.Add("@MaCL", SqlDbType.Int).SqlValue = comboBoxChatLieu.SelectedValue;
                cmd.Parameters.Add("@MaLMH", SqlDbType.Int).SqlValue = comboBoxLoaiMatHang.SelectedValue;
                cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar, 50).SqlValue = textBoxTenMatHang.Text;
                cmd.Parameters.Add("@TrongLuong", SqlDbType.Decimal).SqlValue = radSpinEditorTrongLuong.Value;
                cmd.Parameters.Add("@TruHot", SqlDbType.Decimal).SqlValue = radSpinEditorTruHot.Value;
                cmd.Parameters.Add("@HotNhap", SqlDbType.Decimal).SqlValue = radSpinEditorTienHot.Value;
                cmd.Parameters.Add("@CongNhap", SqlDbType.Decimal).SqlValue = radSpinEditorTienCong.Value;
                cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Decimal).SqlValue = radSpinEditorDonGia.Value;
                cmd.Parameters.Add("@TyGiaUSDNhap", SqlDbType.Decimal).SqlValue = radSpinEditorTyGiaUSD.Value;
                cmd.Parameters.Add("@MaMH_U", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@CongXuat", SqlDbType.Decimal).SqlValue = radSpinEditorTienCongBan.Value;
                cmd.Parameters.Add("@HotXuat", SqlDbType.Decimal).SqlValue = radSpinEditorTienHotBan.Value;

                con.Open();
                tran = con.BeginTransaction();
                cmd.Transaction = tran;

                bool i = (cmd.ExecuteNonQuery() > 0 && !string.IsNullOrEmpty(cmd.Parameters["@MaMH_U"].Value.ToString()));

                bool k = (bool)dataaccess.Access(ref con,
                                StoreProcedureNames.constXuatTienMat_UpdateMaXuat,
                                 new Collection<KeyValuePair<object, int>>{
                                                    new KeyValuePair<object,int>(textBoxMaMatHang.Text,(int)ParameterType.NonString),
                                                    new KeyValuePair<object,int>(cmd.Parameters["@MaMH_U"].Value.ToString(),(int)ParameterType.NonString),
                                                },
                                                    (int)ExecuteType.NonQuery,
                                                    (int)TransactionType.DurringTrans,
                                                    ref tran);

                textBoxMaMatHang.Text = cmd.Parameters["@MaMH_U"].Value.ToString();
                calculateThanhTien();

                bool j = (bool)dataaccess.Access(ref con,
                                        StoreProcedureNames.constXuatTienMat_Update,
                                        new Collection<KeyValuePair<object, int>>{
                                                    new KeyValuePair<object,int>("NULL",(int)ParameterType.NonString),
                                                    new KeyValuePair<object,int>(radSpinEditorThanhTien.Value,(int)ParameterType.NonString),
                                                    new KeyValuePair<object,int>("NMH",(int)ParameterType.String),
                                                    new KeyValuePair<object,int>(textBoxMaMatHang.Text,(int)ParameterType.NonString),
                                                },
                                        (int)ExecuteType.NonQuery,
                                        (int)TransactionType.DurringTrans,
                                        ref tran);
                if (i & k & j)
                {
                    tran.Commit();
                    con.Close();
                    return true;
                }
                else
                {
                    tran.Rollback();
                    con.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}", ex.Message, ex.StackTrace),
                               "Lỗi hệ thống",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                tran.Rollback();
                con.Close();
                return false;
            }
        }

        #endregion

        #region public methods

        public void calculateThanhTien()
        {
            radSpinEditorThanhTien.Value = (radSpinEditorTrongLuong.Value - radSpinEditorTruHot.Value) *
                                                        radSpinEditorDonGia.Value *
                                                        radSpinEditorTyGiaUSD.Value +
                                                        radSpinEditorTienCong.Value +
                                                        radSpinEditorTienHot.Value;
        }

        #endregion

    }
}
