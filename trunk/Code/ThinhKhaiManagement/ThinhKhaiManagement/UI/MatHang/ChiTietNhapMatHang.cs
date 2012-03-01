using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using ThinhKhaiManagement.Common;
using DatabaseAccesser;
using System.Globalization;

namespace ThinhKhaiManagement.UI.MatHang
{
    public partial class ChiTietNhapMatHang : Form
    {
        DataAccess dataaccess;

        public ChiTietNhapMatHang()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void ChiTietNhapMatHang_Load(object sender, EventArgs e)
        {
            dataGridViewChiTietNhapMatHang.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                                    StoreProcedureNames.constTonMatHang_GetAll,
                                                                    new Collection<KeyValuePair<object, int>>(),
                                                                    (int)ExecuteType.Query);
            ResetCollummFormat();
        }

        private void ResetCollummFormat()
        {
            dataGridViewChiTietNhapMatHang.Columns[2].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[2].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[3].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[3].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[4].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[4].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[5].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[5].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[6].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[6].DefaultCellStyle.Format = "N2";

            dataGridViewChiTietNhapMatHang.Columns[7].ValueType = typeof(Decimal);
            dataGridViewChiTietNhapMatHang.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.CreateSpecificCulture("en-US");
            dataGridViewChiTietNhapMatHang.Columns[7].DefaultCellStyle.Format = "N2";
        }
    }
}
