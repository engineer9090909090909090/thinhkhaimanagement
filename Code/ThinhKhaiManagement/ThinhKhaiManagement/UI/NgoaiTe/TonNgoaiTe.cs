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

namespace ThinhKhaiManagement.UI.NgoaiTe
{
    public partial class TonNgoaiTe : Form
    {
        #region Variables and constants

        DataAccess dataaccess;

        #endregion

        #region handle event

        public TonNgoaiTe()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void TonNgoaiTe_Load(object sender, EventArgs e)
        {
            // hien thi ngay thang hien tai
            labelNgayTonNgoaiTe.Text = StaticMethods.ShowDate();

            // do du lieu vao luoi
            dataGridViewTonNgoaiTe.DataSource = ShowTonNgoaiTe();
            dataGridViewTonNgoaiTe.Columns[3].ValueType = typeof(Decimal);
            dataGridViewTonNgoaiTe.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewTonNgoaiTe.Columns[3].DefaultCellStyle.Format = "N2";

            dataGridViewTonNgoaiTe.Columns[4].ValueType = typeof(Decimal);
            dataGridViewTonNgoaiTe.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewTonNgoaiTe.Columns[4].DefaultCellStyle.Format = "N2";

            labelTGV.Text = String.Format("{0:0.00}", CalculateTotal());
        }

        private void TonNgoaiTe_Activated(object sender, EventArgs e)
        {
            // cap nhat lieu vao luoi
            UpdateTonNgoaiTe();
        }

        private void buttonCapNhatTonNgoaiTe_Click(object sender, EventArgs e)
        {
            // cap nhat lieu vao luoi
            UpdateTonNgoaiTe();
        }

        private void dataGridViewTonNgoaiTe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((decimal)dataGridViewTonNgoaiTe.Rows[e.RowIndex].Cells[3].Value != 0)
                {
                    XuatNgoaiTe xuatNgoaiTe = new XuatNgoaiTe();
                    xuatNgoaiTe.TonNgoaiTe = this;
                    xuatNgoaiTe.RowsIndexSelect = e.RowIndex;
                    xuatNgoaiTe.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ngoại tệ không còn hàng để xuất.", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        #region private methods

        private DataTable ShowTonNgoaiTe()
        {
            return (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                StoreProcedureNames.constTonNgoaiTe_GetAll,
                                                new Collection<KeyValuePair<object,int>>(),
                                                (int)ExecuteType.Query);
        }

        private decimal CalculateTotal() 
        { 
            decimal k = 0;
            for (int i = 0; i < dataGridViewTonNgoaiTe.Rows.Count;i++ )
            {
                k += (decimal)dataGridViewTonNgoaiTe.Rows[i].Cells[3].Value *
                    (decimal)dataGridViewTonNgoaiTe.Rows[i].Cells[4].Value;
            }
            return k;
        }

        #endregion

        #region public methods

        public void UpdateTonNgoaiTe()
        {
            // cap nhat lieu vao luoi
            dataGridViewTonNgoaiTe.DataSource = ShowTonNgoaiTe();
            dataGridViewTonNgoaiTe.Columns[3].ValueType = typeof(Decimal);
            dataGridViewTonNgoaiTe.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewTonNgoaiTe.Columns[3].DefaultCellStyle.Format = "N2";

            dataGridViewTonNgoaiTe.Columns[4].ValueType = typeof(Decimal);
            dataGridViewTonNgoaiTe.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewTonNgoaiTe.Columns[4].DefaultCellStyle.Format = "N2";
            labelTGV.Text = String.Format("{0:0,0.00}", CalculateTotal());
        }

        #endregion


      

    }
}
