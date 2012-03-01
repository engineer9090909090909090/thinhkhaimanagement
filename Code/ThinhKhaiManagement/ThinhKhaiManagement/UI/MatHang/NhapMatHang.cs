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

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class NhapMatHang : Form
    {
        #region properties

        public Int64 Stt { get; set; }

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
            radSpinEditorDonGia.Value = 0;
            radSpinEditorTyGiaUSD.Value = 1;
            textBoxMaMatHang.Focus();
        }

        private void buttonXemChiTietNhapMatHang_Click(object sender, EventArgs e)
        {
            ChiTietNhapMatHang chiTietNhapMatHang = new ChiTietNhapMatHang();
            chiTietNhapMatHang.ShowDialog();
        }

        private void buttonLuuNhapMatHang_Click(object sender, EventArgs e)
        {
            if (CheckControl())
            {
                if (Stt==0)
                {
                    if (Save())
                    {
                        DataTable tb = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                            StoreProcedureNames.constNhapMatHang_GetMaMH,
                            new Collection<KeyValuePair<object, int>>(),
                            (int)ExecuteType.Query);
                        MessageBox.Show(string.Format("- Nhập mặt hàng thành công. \n- Đây là Mã Mặt Hàng: {0}",tb.Rows[0][0].ToString()), 
                                    "Thông báo", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);
                        textBoxMaMatHang.Text = tb.Rows[0][0].ToString();
                        radSpinEditorThanhTien.Value = (radSpinEditorTrongLuong.Value - radSpinEditorTruHot.Value) *
                                                        radSpinEditorDonGia.Value *
                                                        radSpinEditorTyGiaUSD.Value +
                                                        radSpinEditorTienCong.Value +
                                                        radSpinEditorTienHot.Value;
                    }
                }
                else
                { 
                
                }
            }
        }

        #endregion

        #region private methods

        private bool CheckControl()
        {
            int flag = 0;

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

            if (flag == 3)
                return true;
            else
                return false;

        }

        private bool Save()
        {
            return (bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                    StoreProcedureNames.constNhapMatHang_Insert,
                    new Collection<KeyValuePair<object, int>>{
                        new KeyValuePair<object,int>(comboBoxChatLieu.SelectedValue,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(comboBoxLoaiMatHang.SelectedValue,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(textBoxTenMatHang.Text,(int)ParameterType.String),
                        new KeyValuePair<object,int>(radSpinEditorTrongLuong.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(radSpinEditorTruHot.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(radSpinEditorTienHot.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(radSpinEditorTienCong.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(radSpinEditorDonGia.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(radSpinEditorTyGiaUSD.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(DateTime.Today.ToShortDateString(),(int)ParameterType.String),
                    },
                    (int)ExecuteType.NonQuery
                    );

        }

        #endregion

        #region public methods

        #endregion
    }
}
