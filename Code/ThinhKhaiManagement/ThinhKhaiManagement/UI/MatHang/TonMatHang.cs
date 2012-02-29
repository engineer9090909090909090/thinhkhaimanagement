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
using System.Globalization;

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class TonMatHang : Form
    {
        DataAccess dataaccess;

        public TonMatHang()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void TonMatHang_Load(object sender, EventArgs e)
        {
            labelNgayTonMatHang.Text = StaticMethods.ShowDate();
            buttonXemToanBo_Click(sender, e);
            FillSortInfo();
        }

        private void buttonXemToanBo_Click(object sender, EventArgs e)
        {
            dataGridViewXem.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constTonMatHang_GetAll,
                new Collection<KeyValuePair<object, int>>(),
                (int)ExecuteType.Query);
            ResetCollummFormat();
        }

        private void FillSortInfo()
        {
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

        private void ResetCollummFormat()
        {
            dataGridViewXem.Columns[2].ValueType = typeof(Decimal);
            dataGridViewXem.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewXem.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridViewXem.Columns[3].ValueType = typeof(Decimal);
            dataGridViewXem.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewXem.Columns[3].DefaultCellStyle.Format = "N2";

            dataGridViewXem.Columns[4].ValueType = typeof(Decimal);
            dataGridViewXem.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewXem.Columns[4].DefaultCellStyle.Format = "N2";

            dataGridViewXem.Columns[5].ValueType = typeof(Decimal);
            dataGridViewXem.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewXem.Columns[5].DefaultCellStyle.Format = "N2";

            dataGridViewXem.Columns[6].ValueType = typeof(Decimal);
            dataGridViewXem.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewXem.Columns[6].DefaultCellStyle.Format = "N2";

            dataGridViewXem.Columns[7].ValueType = typeof(Decimal);
            dataGridViewXem.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewXem.Columns[7].DefaultCellStyle.Format = "N2";
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            dataGridViewXem.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constTonMatHang_GetByCondition,
                new Collection<KeyValuePair<object, int>>() { 
                    new KeyValuePair<object,int>(comboBoxChatLieu.SelectedValue==null?"NULL":comboBoxChatLieu.SelectedValue,(int)ParameterType.NonString),
                    new KeyValuePair<object,int>(comboBoxLoaiMatHang.SelectedValue==null?"NULL":comboBoxLoaiMatHang.SelectedValue,(int)ParameterType.NonString),
                },
                (int)ExecuteType.Query);
            
                DataTable tb= (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constTonMatHang_Count,
                new Collection<KeyValuePair<object, int>>() { 
                    new KeyValuePair<object,int>(comboBoxChatLieu.SelectedValue==null?"NULL":comboBoxChatLieu.SelectedValue,(int)ParameterType.NonString),
                    new KeyValuePair<object,int>(comboBoxLoaiMatHang.SelectedValue==null?"NULL":comboBoxLoaiMatHang.SelectedValue,(int)ParameterType.NonString),
                },
                (int)ExecuteType.Query);
                labelTSL.Text = tb.Rows[0][0].ToString();
        }
    }
}
