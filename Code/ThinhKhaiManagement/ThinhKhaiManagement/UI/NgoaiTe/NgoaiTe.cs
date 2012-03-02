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

namespace ThinhKhaiManagement.UI.NgoaiTe
{
    public partial class NgoaiTe : Form
    {
        DataAccess dataaccess;

        int maNT = 0;

        public NgoaiTe()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void NgoaiTe_Load(object sender, EventArgs e)
        {
            dataGridViewNT.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constNgoaiTe_GetAll,
                new Collection<KeyValuePair<object, int>>(),
                (int)ExecuteType.Query);
        }

        private void dataGridViewNT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maNT = Convert.ToInt32(dataGridViewNT.Rows[e.RowIndex].Cells[0].Value);
            textBoxTNT.Text = dataGridViewNT.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxGhiChu.Text = dataGridViewNT.Rows[e.RowIndex].Cells[2].Value.ToString();
            buttonLuu.Text = "Cập Nhật";
        }

        private void buttonLS_Click(object sender, EventArgs e)
        {
            textBoxTNT.Text = string.Empty;
            textBoxGhiChu.Text = string.Empty;
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
                        StoreProcedureNames.constNgoaiTe_Insert,
                        new Collection<KeyValuePair<object, int>>{
                        new KeyValuePair<object,int>(textBoxTNT.Text,(int)ParameterType.String),
                        new KeyValuePair<object,int>(textBoxGhiChu.Text,(int)ParameterType.String),
                    },
                        (int)ExecuteType.NonQuery))
                        MessageBox.Show("Thêm ngoại tệ thành công");
                    else
                        MessageBox.Show("Thêm ngoại tệ thất bại");
                }
                else
                {
                    if ((bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                       StoreProcedureNames.constNgoaiTe_Update,
                       new Collection<KeyValuePair<object, int>>{
                           new KeyValuePair<object,int>(maNT,(int)ParameterType.NonString),
                           new KeyValuePair<object,int>(textBoxTNT.Text,(int)ParameterType.String),
                           new KeyValuePair<object,int>(textBoxGhiChu.Text,(int)ParameterType.String),
                    },
                       (int)ExecuteType.NonQuery))
                        MessageBox.Show("Cập nhật ngoại tệ thành công");
                    else
                        MessageBox.Show("Cập nhật ngoại tệ thất bại");
                }
                buttonLS_Click(sender, e);
                NgoaiTe_Load(sender, e);
            }
        }

        private bool checkControl()
        {
            int a=0;

            if (string.IsNullOrEmpty(textBoxTNT.Text))
            {
                errorProviderNgoaiTe.SetError(textBoxTNT, "Mời nhập");
                a = 0;
            }
            else
            {
                errorProviderNgoaiTe.SetError(textBoxTNT, string.Empty);
                a++;
            }

            if (string.IsNullOrEmpty(textBoxGhiChu.Text))
            {
                errorProviderNgoaiTe.SetError(textBoxGhiChu, "Mời nhập");
                a = 0;
            }
            else
            {
                errorProviderNgoaiTe.SetError(textBoxGhiChu, string.Empty);
                a++;
            }

            if (a ==2)
                return true;
            else
                return false;
        }
    }
}
