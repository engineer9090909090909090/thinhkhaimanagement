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
    public partial class ChatLieu : Form
    {
        DataAccess dataaccess;

        int maNT = 0;

        public ChatLieu()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void ChatLieu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridViewCL.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constChatLieu_GetAll,
                new Collection<KeyValuePair<object, int>>(),
                (int)ExecuteType.Query);
        }

        private void dataGridViewCL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maNT = Convert.ToInt32(dataGridViewCL.Rows[e.RowIndex].Cells[0].Value);
            textBoxTCL.Text = dataGridViewCL.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxKTDD.Text = dataGridViewCL.Rows[e.RowIndex].Cells[2].Value.ToString();
            buttonLuu.Text = "Cập Nhật";
        }

        private void buttonLS_Click(object sender, EventArgs e)
        {
            textBoxTCL.Text = string.Empty;
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
                        StoreProcedureNames.constChatLieu_Insert,
                        new Collection<KeyValuePair<object, int>>{
                        new KeyValuePair<object,int>(textBoxTCL.Text,(int)ParameterType.String),
                        new KeyValuePair<object,int>(textBoxKTDD.Text,(int)ParameterType.String),
                    },
                        (int)ExecuteType.NonQuery))
                        MessageBox.Show("Thêm chất liệu thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm chất liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if ((bool)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                       StoreProcedureNames.constChatLieu_Update,
                       new Collection<KeyValuePair<object, int>>{
                           new KeyValuePair<object,int>(maNT,(int)ParameterType.NonString),
                           new KeyValuePair<object,int>(textBoxTCL.Text,(int)ParameterType.String),
                           new KeyValuePair<object,int>(textBoxKTDD.Text,(int)ParameterType.String),
                    },
                       (int)ExecuteType.NonQuery))
                        MessageBox.Show("Cập nhật chất liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Cập nhật chất liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                buttonLS_Click(sender, e);
                ChatLieu_Load(sender, e);
            }
        }

        private bool checkControl()
        {
            int a=0;

            if (string.IsNullOrEmpty(textBoxTCL.Text))
            {
                errorProviderChatLieu.SetError(textBoxTCL, "Mời nhập");
                a = 0;
            }
            else
            {
                errorProviderChatLieu.SetError(textBoxTCL, string.Empty);
                a++;
            }

            if (string.IsNullOrEmpty(textBoxKTDD.Text))
            {
                errorProviderChatLieu.SetError(textBoxKTDD, "Mời nhập");
                a = 0;
            }
            else
            {
                errorProviderChatLieu.SetError(textBoxKTDD, string.Empty);
                a++;
            }

            if (a ==2)
                return true;
            else
                return false;
        }
    }
}
