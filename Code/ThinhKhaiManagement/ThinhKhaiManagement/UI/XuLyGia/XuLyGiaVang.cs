using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThinhKhaiManagement.Common;
using Telerik.WinControls.UI;
using DatabaseAccesser;
using System.Collections.ObjectModel;

namespace ThinhKhaiManagement.UI.XuLyGia
{
    public partial class XuLyGiaVang : Form
    {
        decimal temp=0;
        DataAccess dataaccess;

        public XuLyGiaVang()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void XuLyGiaVang_Load(object sender, EventArgs e)
        {
            labelNgayHienTai.Text = StaticMethods.ShowDate();
            labelGioHienTai.Text = StaticMethods.ShowTime();
        }

        private void timerXuLyGiaVang_Tick(object sender, EventArgs e)
        {
            labelGioHienTai.Text = StaticMethods.ShowTime();
        }

        private void buttonXuLy_Click(object sender, EventArgs e)
        {
            XuLy();
        }

        private void XuLy()
        {
            //Xu Ly SJC
            radSpinEditorSJCMua.Value = (radSpinEditorSJCLMua.Value - radSpinEditorSJCHeSo.Value) * 1000;
            radSpinEditorSJCBan.Value = (radSpinEditorSJCLBan.Value + radSpinEditorSJCHeSo.Value) * 1000;

            temp = radSpinEditor95.Value + 5;

            //Xu Ly 9999
            radSpinEditor9999Ban.Value = Math.Round(temp * decimal.Parse("99.99") / 95) * 1000;
            decimal mua = radSpinEditor95.Value * 98 / 95;
            if (mua <= (temp * decimal.Parse("99.99") / 95) - 120)
                mua = Math.Round((temp * Math.Round(decimal.Parse("99.99") / 95)));
            else if (mua >= (temp * decimal.Parse("99.99") / 95) - 100)
                mua = Math.Round((temp * decimal.Parse("99.99") / 95) - 100);
            radSpinEditor9999Mua.Value = mua * 1000;

            // Xu Ly NT
            radSpinEditorNTBan.Value = radSpinEditor9999Ban.Value - 20000;
            radSpinEditorNTMua.Value = radSpinEditor9999Mua.Value - 20000;

            // Xu Ly 75
            radSpinEditor75Ban.Value = Math.Round(temp * 75 / 95) * 1000;
            radSpinEditor75Mua.Value = (Math.Round(temp * 75 / 95) - 300) * 1000;

            // Xu Ly 70
            radSpinEditor70Ban.Value = Math.Round(temp * 70 / 95) * 1000;
            radSpinEditor70Mua.Value = (Math.Round(temp * 70 / 95) - 300) * 1000;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckControl())
                {
                    if ((bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                        StoreProcedureNames.constGiaVang_Insert,
                                        new Collection<KeyValuePair<object, int>>{
                                        new KeyValuePair<object,int>(DateTime.Now,(int)ParameterType.String),
                                        new KeyValuePair<object,int>(radSpinEditorSJCMua.Value,(int)ParameterType.NonString),
                                        new KeyValuePair<object,int>(radSpinEditorSJCBan.Value,(int)ParameterType.NonString),
                                        new KeyValuePair<object,int>(radSpinEditor9999Mua.Value,(int)ParameterType.NonString),
                                        new KeyValuePair<object,int>(radSpinEditor9999Ban.Value,(int)ParameterType.NonString),
                                        new KeyValuePair<object,int>(radSpinEditorNTMua.Value,(int)ParameterType.NonString),
                                        new KeyValuePair<object,int>(radSpinEditorNTBan.Value,(int)ParameterType.NonString),
                                        new KeyValuePair<object,int>(radSpinEditor75Mua.Value,(int)ParameterType.NonString),
                                        new KeyValuePair<object,int>(radSpinEditor75Ban.Value,(int)ParameterType.NonString),
                                        new KeyValuePair<object,int>(radSpinEditor70Mua.Value,(int)ParameterType.NonString),
                                        new KeyValuePair<object,int>(radSpinEditor70Ban.Value,(int)ParameterType.NonString)
                                    },
                                        (int)ExecuteType.NonQuery))
                    {
                        MessageBox.Show("Lưu Giá Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Lưu Giá Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Giá chưa được xử lý", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}", ex.Message, ex.StackTrace),
                               "Lỗi hệ thống",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private bool CheckControl()
        {
            bool rs = false;
            foreach (var c in panelGiaVang.Controls)
            {
                if (((RadSpinEditor)c).Value == 0)
                {
                    rs = false;
                    break;
                }
                else
                {
                    rs = true;
                    continue;
                }
            }
            return rs;
        }

        private void buttonXemLichSu_Click(object sender, EventArgs e)
        {
            LichSuXuLyGiaVang lichSuXuLyGiaVang = new LichSuXuLyGiaVang();
            lichSuXuLyGiaVang.ShowDialog();
        }
    }
}
