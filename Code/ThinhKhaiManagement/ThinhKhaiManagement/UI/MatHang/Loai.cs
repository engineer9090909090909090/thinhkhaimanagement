using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatabaseAccesser;
using ThinhKhaiManagement.Common;
using System.Collections.ObjectModel;

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class Loai : Form
    {
         DataAccess dataaccess;

        int maNT = 0;

        public Loai()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void Loai_Load(object sender, EventArgs e)
        {
            dataGridViewLoai.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constLoaiMatHang_GetAll,
                new Collection<KeyValuePair<object, int>>(),
                (int)ExecuteType.Query);
        }

        private void dataGridViewLoai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maNT = Convert.ToInt32(dataGridViewLoai.Rows[e.RowIndex].Cells[0].Value);
            textBoxLoai.Text = dataGridViewLoai.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxKTDD.Text = dataGridViewLoai.Rows[e.RowIndex].Cells[2].Value.ToString();
            buttonLuu.Text = "Cập Nhật";
        }

        private void buttonLS_Click(object sender, EventArgs e)
        {
            textBoxLoai.Text = string.Empty;
            textBoxKTDD.Text = string.Empty;
            maNT = 0;
            buttonLuu.Text = "Lưu";
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (checkControl())
            {
                if (maNT == 0)
                {
                    if ((bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                        StoreProcedureNames.constLoaiMatHang_Insert,
                        new Collection<KeyValuePair<object, int>>{
                        new KeyValuePair<object,int>(textBoxLoai.Text,(int)ParameterType.String),
                        new KeyValuePair<object,int>(textBoxKTDD.Text,(int)ParameterType.String),
                    },
                        (int)ExecuteType.NonQuery))
                        MessageBox.Show("Thêm chất liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm chất liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if ((bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                       StoreProcedureNames.constLoaiMatHang_Update,
                       new Collection<KeyValuePair<object, int>>{
                           new KeyValuePair<object,int>(maNT,(int)ParameterType.NonString),
                           new KeyValuePair<object,int>(textBoxLoai.Text,(int)ParameterType.String),
                           new KeyValuePair<object,int>(textBoxKTDD.Text,(int)ParameterType.String),
                    },
                       (int)ExecuteType.NonQuery))
                        MessageBox.Show("Cập nhật chất liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Cập nhật chất liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                buttonLS_Click(sender, e);
                Loai_Load(sender, e);
            }
        }

        private bool checkControl()
        {
            int a=0;

            if (string.IsNullOrEmpty(textBoxLoai.Text))
            {
                errorProviderLoai.SetError(textBoxLoai, "Mời nhập");
                a = 0;
            }
            else
            {
                errorProviderLoai.SetError(textBoxLoai, string.Empty);
                a++;
            }

            if (string.IsNullOrEmpty(textBoxKTDD.Text))
            {
                errorProviderLoai.SetError(textBoxKTDD, "Mời nhập");
                a = 0;
            }
            else
            {
                errorProviderLoai.SetError(textBoxKTDD, string.Empty);
                a++;
            }

            if (a ==2)
                return true;
            else
                return false;
        }
    }
}
