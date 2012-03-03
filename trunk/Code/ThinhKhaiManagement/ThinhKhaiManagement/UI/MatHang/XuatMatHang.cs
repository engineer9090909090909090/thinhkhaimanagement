﻿using System;
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
    public partial class XuatMatHang : Form
    {
        #region Variables and constants

        DataAccess dataaccess;

        #endregion

        #region handle event

        public XuatMatHang()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void XuatMatHang_Load(object sender, EventArgs e)
        {
            labelNgayXuatMatHang.Text = StaticMethods.ShowDate();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            FillDataToBill();
        }

        private void textBoxMaMH_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FillDataToBill();
        }

        private void buttonThanhTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (radSpinEditorDonGia.Value > 0)
                {
                    radSpinEditorThanhTien.Value = (radSpinEditorTrongLuong.Value - radSpinEditorTruHot.Value) *
                        radSpinEditorDonGia.Value *
                        radSpinEditorTyGiaUSD.Value +
                        radSpinEditorTienHot.Value +
                        radSpinEditorTienCong.Value -
                        radSpinEditorKhuyenMai.Value;
                    errorProviderXuatMatHang.SetError(radSpinEditorDonGia, string.Empty);
                }
                else
                    errorProviderXuatMatHang.SetError(radSpinEditorDonGia, "Mời Nhập Đơn Giá");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}", ex.Message, ex.StackTrace),
                                   "Lỗi hệ thống",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (radSpinEditorThanhTien.Value > 0)
            {
                if (Save())
                {
                    MessageBox.Show("Xuất Mặt Hàng Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xuất Mặt Hàng Thất Bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        #region private methods

        private void FillDataToBill()
        {
            try
            {
                DataTable tb = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                               StoreProcedureNames.constXuatMatHang_ShowByMaMH,
                                                                               new Collection<KeyValuePair<object, int>> { 
                                                                            new KeyValuePair<object,int>(textBoxMaMH.Text,(int)ParameterType.String)
                                                                       },
                                                                               (int)ExecuteType.Query);
                if (tb.Rows.Count > 0)
                {
                    textBoxTenMatHang.Text = tb.Rows[0][4].ToString();
                    radSpinEditorTrongLuong.Value = (decimal)tb.Rows[0][5];
                    radSpinEditorTruHot.Value = (decimal)tb.Rows[0][6];
                    radSpinEditorTienHot.Value = (decimal)tb.Rows[0][12];
                    radSpinEditorTienCong.Value = (decimal)tb.Rows[0][13];
                }
                else
                    MessageBox.Show("Mặt hàng này không tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}", ex.Message, ex.StackTrace),
               "Lỗi hệ thống",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private bool Save()
        {
            SqlTransaction tran = null;
            SqlConnection con = StaticMethods.ShowSqlConnection();

            bool i = (bool)dataaccess.Access(ref con,
                StoreProcedureNames.constXuatMatHang_UpdateByMaMH,
                new Collection<KeyValuePair<object, int>> { 
                    new KeyValuePair<object,int>(textBoxMaMH.Text,(int)ParameterType.String),
                    new KeyValuePair<object,int>(radSpinEditorDonGia.Value,(int)ParameterType.NonString),
                    new KeyValuePair<object,int>(radSpinEditorTyGiaUSD.Value,(int)ParameterType.NonString),
                    new KeyValuePair<object,int>(radSpinEditorKhuyenMai.Value,(int)ParameterType.NonString),
                    new KeyValuePair<object,int>(DateTime.Today,(int)ParameterType.String),
                },
                (int)ExecuteType.NonQuery,
                (int)TransactionType.StartTrans,
                ref tran);

            bool k = (bool)dataaccess.Access(ref con,
                StoreProcedureNames.constNhapTienMat_Insert,
                new Collection<KeyValuePair<object, int>> { 
                    new KeyValuePair<object,int>(DateTime.Today,(int)ParameterType.String),
                    new KeyValuePair<object,int>(radSpinEditorThanhTien.Value,(int)ParameterType.NonString),
                    new KeyValuePair<object,int>("XMH",(int)ParameterType.String),
                    new KeyValuePair<object,int>(textBoxMaMH.Text,(int)ParameterType.String),
                },
                (int)ExecuteType.NonQuery,
                (int)TransactionType.DurringTrans,
                ref tran);

            if (i & k)
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

        #endregion

        private void buttonLamSach_Click(object sender, EventArgs e)
        {
            textBoxMaMH.Text = string.Empty;
            textBoxTenMatHang.Text = string.Empty;
            radSpinEditorTrongLuong.Value = 0;
            radSpinEditorTruHot.Value = 0;
            radSpinEditorTienHot.Value = 0;
            radSpinEditorTienCong.Value = 0;
            radSpinEditorDonGia.Value = 0;
            radSpinEditorTyGiaUSD.Value = 1;
            radSpinEditorKhuyenMai.Value = 0;
            radSpinEditorThanhTien.Value = 0;
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietXuatMatHang chiTietXuatMatHang = new ChiTietXuatMatHang();
            chiTietXuatMatHang.ShowDialog();
        }

        #region public methods

        #endregion
    }
}