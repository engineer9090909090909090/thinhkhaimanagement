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
using System.Globalization;

namespace ThinhKhaiManagement.UI.TienMat
{
    public partial class TienMat : Form
    {
        #region properties

        public DateTime Ngay { get; set; }

        public int MaTemp { get; set; }

        #endregion

        #region Variables and constants

        DataAccess dataaccess;

        #endregion

        #region handle event

        public TienMat()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
            comboBoxXuLy.SelectedIndex = 0;
        }

        private void TienMat_Load(object sender, EventArgs e)
        {
            dateTimePickerTu.Value = dateTimePickerDen.Value =DateTime.Today;
            labelNgayTienMat.Text = StaticMethods.ShowDate();
            dataGridViewXemTienMat.DataSource = ShowTonTienMat();
            dataGridViewXemTienMat.Columns[2].ValueType = typeof(Decimal);
            dataGridViewXemTienMat.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewXemTienMat.Columns[2].DefaultCellStyle.Format = "N2";
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            dataGridViewXemTienMat.DataSource = ShowTonTienMat();
            dataGridViewXemTienMat.Columns[2].ValueType = typeof(Decimal);
            dataGridViewXemTienMat.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewXemTienMat.Columns[2].DefaultCellStyle.Format = "N2";
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (checkControl())
            {
                if (MaTemp == 0)
                {
                    if (Save())
                        toolStripStatusLabelTienMat.Text = string.Format("{0} phiếu thành công", comboBoxXuLy.SelectedItem.ToString());
                    else
                        MessageBox.Show(string.Format("{0} phiếu thất bại", comboBoxXuLy.SelectedItem.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(Update())
                        toolStripStatusLabelTienMat.Text = string.Format("cập nhật phiếu {0} thành công", comboBoxXuLy.SelectedItem.ToString());
                    else
                        MessageBox.Show(string.Format("cập nhật phiếu {0} thất bại", comboBoxXuLy.SelectedItem.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    labelHeaderThongTinTienMat.Text = "Thông Tin Tiền Mặt";
                    buttonLuu.Text = "Lưu";
                    MaTemp = 0;
                }

                buttonXem_Click(sender, e);
            }
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            if (comboBoxXuLy.SelectedIndex == 0)
            {
                ChiTietNhapTienMat chiTietNhapTienMat = new ChiTietNhapTienMat();
                chiTietNhapTienMat.tienMat = this;
                chiTietNhapTienMat.ShowDialog();
            }
            else
            {
                ChiTietXuatTienMat chiTietNhapTienMat = new ChiTietXuatTienMat();
                chiTietNhapTienMat.tienMat = this;
                chiTietNhapTienMat.ShowDialog();
            }
        }

        private void buttonLamSach_Click(object sender, EventArgs e)
        {
            comboBoxXuLy.SelectedIndex = 0;
            radSpinEditorTienMat.Value = 0;
            textBoxLyDo.Text = string.Empty;
            buttonXem_Click(sender, e);
        }

        #endregion

        #region private methods

        private bool checkControl()
        {
            int flag = 0;

            if (radSpinEditorTienMat.Value > 0)
            {
                errorProviderTienMat.SetError(radSpinEditorTienMat, string.Empty);
                flag++;
            }
            else
            {
                errorProviderTienMat.SetError(radSpinEditorTienMat, "Dữ liệu không hợp lệ");
                flag = 0;
            }

            if (!string.IsNullOrEmpty(textBoxLyDo.Text))
            {
                errorProviderTienMat.SetError(textBoxLyDo, string.Empty);
                flag++;
            }
            else
            {
                errorProviderTienMat.SetError(textBoxLyDo, "Dữ liệu không hợp lệ");
                flag = 0;
            }

            if (flag == 2)
                return true;
            else
                return false;

        }

        private DataTable ShowTonTienMat()
        {
            return (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                    StoreProcedureNames.constTonTienMat_GetAllByTuNgayDenNgay,
                                    new Collection<KeyValuePair<object, int>>{
                                        new KeyValuePair<object,int>(dateTimePickerTu.Value,(int)ParameterType.String),
                                        new KeyValuePair<object,int>(dateTimePickerDen.Value,(int)ParameterType.String)
                                    },
                                    (int)ExecuteType.Query);
        }

        private bool Save()
        {
            if (comboBoxXuLy.SelectedIndex == 0)
            {
                return (bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                    StoreProcedureNames.constNhapTienMat_Insert,
                    new Collection<KeyValuePair<object, int>>{
                        new KeyValuePair<object,int>(DateTime.Today,(int)ParameterType.String),
                        new KeyValuePair<object,int>(radSpinEditorTienMat.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(textBoxLyDo.Text,(int)ParameterType.String),
                        new KeyValuePair<object,int>("NULL",(int)ParameterType.NonString),
                    },
                    (int)ExecuteType.NonQuery
                    );
            }
            else
            {
                return (bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                    StoreProcedureNames.constXuatTienMat_Insert,
                    new Collection<KeyValuePair<object, int>>{
                        new KeyValuePair<object,int>(DateTime.Today,(int)ParameterType.String),
                        new KeyValuePair<object,int>(radSpinEditorTienMat.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(textBoxLyDo.Text,(int)ParameterType.String),
                        new KeyValuePair<object,int>("NULL",(int)ParameterType.NonString),
                    },
                    (int)ExecuteType.NonQuery
                    );
            }
        }

        private bool Update()
        {
            if (comboBoxXuLy.SelectedIndex == 0)
            {
                return (bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                    StoreProcedureNames.constNhapTienMat_Update,
                    new Collection<KeyValuePair<object, int>>{
                        new KeyValuePair<object,int>(MaTemp,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(radSpinEditorTienMat.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(textBoxLyDo.Text,(int)ParameterType.String),
                    },
                    (int)ExecuteType.NonQuery
                    );
            }
            else
            {
                return (bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                    StoreProcedureNames.constXuatTienMat_Update,
                    new Collection<KeyValuePair<object, int>>{
                        new KeyValuePair<object,int>(MaTemp,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(radSpinEditorTienMat.Value,(int)ParameterType.NonString),
                        new KeyValuePair<object,int>(textBoxLyDo.Text,(int)ParameterType.String),
                        new KeyValuePair<object,int>("NULL",(int)ParameterType.NonString),
                    },
                    (int)ExecuteType.NonQuery
                    );
            }
        }

        #endregion
       
        #region public methods

        #endregion  
    }
}
