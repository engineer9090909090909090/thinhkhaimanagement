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
using System.Data.SqlClient;
using ThinhKhaiManagement.Reports;

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class TonMatHang : Form
    {
        DataAccess dataaccess;

        int x = -1;

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
            buttonXoaHet_Click(sender, e);
            dataGridViewXem.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constTonMatHang_GetAll,
                new Collection<KeyValuePair<object, int>>(),
                (int)ExecuteType.Query);
            ResetCollummFormat();
            labelTSL.Text = (dataGridViewXem.Rows.Count).ToString();
            labelTTiH.Text = String.Format("{0:0,0.00}", CalculateTotalTienHot());
            labelTTC.Text = String.Format("{0:0,0.00}", CalculateTotalTienCong());
            labelTGV.Text = String.Format("{0:0,0.00}", CalculateTotal());
        }

        private decimal CalculateTotal()
        {
            decimal k = 0;
            for (int i = 0; i < dataGridViewXem.Rows.Count; i++)
            {
                if (dataGridViewXem.Rows[i].Cells[0].Value == null)
                    break;

                k = k +
                    ((decimal)dataGridViewXem.Rows[i].Cells[4].Value -
                    (decimal)dataGridViewXem.Rows[i].Cells[5].Value) *
                    (decimal)dataGridViewXem.Rows[i].Cells[8].Value *
                    (decimal)dataGridViewXem.Rows[i].Cells[9].Value +
                    (decimal)dataGridViewXem.Rows[i].Cells[6].Value +
                    (decimal)dataGridViewXem.Rows[i].Cells[7].Value;
            }
            return k;
        }

        private decimal CalculateTotalTrongLuong()
        {
            decimal k = 0;
            for (int i = 0; i < dataGridViewXem.Rows.Count; i++)
            {
                if (dataGridViewXem.Rows[i].Cells[0].Value == null)
                    break;

                k = k +
                    (decimal)dataGridViewXem.Rows[i].Cells[4].Value;
                   
            }
            return k;
        }

        private decimal CalculateTotalTruHot()
        {
            decimal k = 0;
            for (int i = 0; i < dataGridViewXem.Rows.Count; i++)
            {
                if (dataGridViewXem.Rows[i].Cells[0].Value == null)
                    break;

                k = k +
                    (decimal)dataGridViewXem.Rows[i].Cells[5].Value;

            }
            return k;
        }

        private decimal CalculateTotalTienHot()
        {
            decimal k = 0;
            for (int i = 0; i < dataGridViewXem.Rows.Count; i++)
            {
                if (dataGridViewXem.Rows[i].Cells[0].Value == null)
                    break;

                k = k +
                    (decimal)dataGridViewXem.Rows[i].Cells[6].Value;

            }
            return k;
        }

        private decimal CalculateTotalTienCong()
        {
            decimal k = 0;
            for (int i = 0; i < dataGridViewXem.Rows.Count; i++)
            {
                if (dataGridViewXem.Rows[i].Cells[0].Value == null)
                    break;

                k = k +
                    (decimal)dataGridViewXem.Rows[i].Cells[7].Value;

            }
            return k;
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
            buttonXoaHet_Click(sender, e);
            dataGridViewXem.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                    StoreProcedureNames.constTonMatHang_GetByCondition,
                    new Collection<KeyValuePair<object, int>>() { 
                    new KeyValuePair<object,int>(comboBoxChatLieu.SelectedValue==null?"NULL":comboBoxChatLieu.SelectedValue,(int)ParameterType.NonString),
                    new KeyValuePair<object,int>(comboBoxLoaiMatHang.SelectedValue==null?"NULL":comboBoxLoaiMatHang.SelectedValue,(int)ParameterType.NonString),
                },
                    (int)ExecuteType.Query);
            labelTSL.Text = (dataGridViewXem.Rows.Count).ToString();
            labelTGV.Text = String.Format("{0:0,0.00}", CalculateTotal());
            if (string.IsNullOrEmpty(comboBoxChatLieu.Text))
            {
                labelTGV.Text = String.Format("{0:0,0.00}", CalculateTotal());
                labelTTC.Text = String.Format("{0:0,0.00}", CalculateTotalTienCong());

            }
            else 
            {
                labelTGV.Text = String.Format("{0:0,0.00}", CalculateTotal());
                labelTTC.Text = String.Format("{0:0,0.00}", CalculateTotalTienCong());
                labelTTL.Text = String.Format("{0:0,0.00}", CalculateTotalTrongLuong());
                labelTTH.Text = String.Format("{0:0,0.00}", CalculateTotalTruHot());
            }
        }

        private void buttonKiemTra_Click(object sender, EventArgs e)
        {
            if (x == -1)
                MessageBox.Show("Mời chọn mặt hàng cần kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                labelGV.Text = String.Format("{0:0,0.00}",
                    ((decimal)dataGridViewXem.Rows[x].Cells[4].Value -
                    (decimal)dataGridViewXem.Rows[x].Cells[5].Value) *
                    (decimal)dataGridViewXem.Rows[x].Cells[8].Value *
                    (decimal)dataGridViewXem.Rows[x].Cells[9].Value +
                    (decimal)dataGridViewXem.Rows[x].Cells[6].Value +
                    (decimal)dataGridViewXem.Rows[x].Cells[7].Value);
            }
        }

        private void dataGridViewXem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            x = e.RowIndex;
            textBoxMaMatHang.Text = dataGridViewXem.Rows[x].Cells[0].Value.ToString();
            textBoxTenMatHang.Text = dataGridViewXem.Rows[x].Cells[3].Value.ToString();
        }

        private void buttonXoaHet_Click(object sender, EventArgs e)
        {
            labelTSL.Text = "00.00";
            labelTTL.Text = "00.00";
            labelTTH.Text = "00.00";
            labelTTiH.Text = "00.00";
            labelTTC.Text = "00.00";
            labelTGV.Text = "00.00";
        }

        private void buttonInPhieu_Click(object sender, EventArgs e)
        {
            InPhieuTonMathang inPhieuTonMatHang = new InPhieuTonMathang();
            ThinhKhaiDataSet ds = new ThinhKhaiDataSet();
            ds.Tables["TonMatHang"].Merge((DataTable)dataGridViewXem.DataSource);
            inPhieuTonMatHang.ReportDataSet = ds;
            inPhieuTonMatHang.ShowDialog();
        }
    }
} 
