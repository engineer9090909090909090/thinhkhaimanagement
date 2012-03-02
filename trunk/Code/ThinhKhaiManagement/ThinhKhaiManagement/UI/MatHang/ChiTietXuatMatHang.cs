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
            dataGridViewChiTietXuatMatHang.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constXuatMatHang_ShowSoldByNgay,
                new Collection<KeyValuePair<object, int>>{
                    new KeyValuePair<object,int>(dateTimePickerNgayXuatMatHang.Value,(int)ParameterType.String)
                },
                (int)ExecuteType.Query);
        }

        private void dateTimePickerNgayXuatMatHang_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewChiTietXuatMatHang.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constXuatMatHang_ShowSoldByNgay,
                new Collection<KeyValuePair<object, int>>{
                    new KeyValuePair<object,int>(dateTimePickerNgayXuatMatHang.Value,(int)ParameterType.String)
                },
                (int)ExecuteType.Query);
        }
    }
}
