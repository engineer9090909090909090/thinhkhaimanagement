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
using System.Data.SqlClient;
using System.Globalization;

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class ChiTietXuatMatHang : Form
    {
        DataAccess dataaccess;

        public ChiTietXuatMatHang()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void ChiTietXuatMatHang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridViewChiTietXuatMatHang.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constXuatMatHang_ShowSoldByNgay,
                new Collection<KeyValuePair<object, int>>{
                    new KeyValuePair<object,int>(dateTimePickerNgayXuatMatHang.Value,(int)ParameterType.String)
                },
                (int)ExecuteType.Query);
            ResetCollummFormat();
        }

        private void dateTimePickerNgayXuatMatHang_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewChiTietXuatMatHang.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constXuatMatHang_ShowSoldByNgay,
                new Collection<KeyValuePair<object, int>>{
                    new KeyValuePair<object,int>(dateTimePickerNgayXuatMatHang.Value,(int)ParameterType.String)
                },
                (int)ExecuteType.Query);
            ResetCollummFormat();
        }

        private void buttonHuyPhieu_Click(object sender, EventArgs e)
        {

            SqlTransaction tran = null;
            SqlConnection con = StaticMethods.ShowSqlConnection();

            try
            {
                bool i = (bool)dataaccess.Access(ref con,
                    StoreProcedureNames.constXuatMatHang_CancelByMaMH,
                    new Collection<KeyValuePair<object, int>>{
                    new KeyValuePair<object,int>(dataGridViewChiTietXuatMatHang.CurrentRow.Cells[0].Value.ToString(),(int)ParameterType.String)
                },
                    (int)ExecuteType.NonQuery,
                    (int)TransactionType.StartTrans,
                    ref tran);

                bool k = (bool)dataaccess.Access(ref con,
                    StoreProcedureNames.constNhapTienMat_Update,
                    new Collection<KeyValuePair<object, int>>{
                    new KeyValuePair<object,int>("NULL",(int)ParameterType.NonString),
                    new KeyValuePair<object,int>(0,(int)ParameterType.NonString),
                    new KeyValuePair<object,int>("HGD",(int)ParameterType.String),
                    new KeyValuePair<object,int>(dataGridViewChiTietXuatMatHang.CurrentRow.Cells[0].Value.ToString(),(int)ParameterType.String)
                },
                    (int)ExecuteType.NonQuery,
                    (int)TransactionType.DurringTrans,
                    ref tran);

                if (i & k)
                {
                    if (MessageBox.Show("Có chắc muốn hủy phiếu không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        tran.Commit();
                        MessageBox.Show("Hủy phiếu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hủy phiếu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tran.Rollback();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("#Message: {0} \n#StackTrace: {1}", ex.Message, ex.StackTrace),
                               "Lỗi hệ thống",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                tran.Rollback();
            }
            con.Close();
            ChiTietXuatMatHang_Load(sender, e);
        }

        private void ResetCollummFormat()
        {
            dataGridViewChiTietXuatMatHang.Columns[2].ValueType = typeof(Decimal);
            dataGridViewChiTietXuatMatHang.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietXuatMatHang.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietXuatMatHang.Columns[3].ValueType = typeof(Decimal);
            dataGridViewChiTietXuatMatHang.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietXuatMatHang.Columns[3].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietXuatMatHang.Columns[4].ValueType = typeof(Decimal);
            dataGridViewChiTietXuatMatHang.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietXuatMatHang.Columns[4].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietXuatMatHang.Columns[5].ValueType = typeof(Decimal);
            dataGridViewChiTietXuatMatHang.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietXuatMatHang.Columns[5].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietXuatMatHang.Columns[6].ValueType = typeof(Decimal);
            dataGridViewChiTietXuatMatHang.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietXuatMatHang.Columns[6].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietXuatMatHang.Columns[7].ValueType = typeof(Decimal);
            dataGridViewChiTietXuatMatHang.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietXuatMatHang.Columns[7].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietXuatMatHang.Columns[8].ValueType = typeof(Decimal);
            dataGridViewChiTietXuatMatHang.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietXuatMatHang.Columns[8].DefaultCellStyle.Format = "N2";
        }
    }
}
