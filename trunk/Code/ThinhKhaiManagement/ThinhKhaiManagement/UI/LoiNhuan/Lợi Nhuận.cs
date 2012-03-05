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

namespace ThinhKhaiManagement.UI.LoiNhuan
{
    public partial class LoiNhuan : Form
    {
        DataAccess dataaccess;
        public LoiNhuan()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void LoiNhuan_Load(object sender, EventArgs e)
        {
            labelNgay.Text = StaticMethods.ShowDate();
            buttonXoaHetGKL_Click(sender, e);
            buttonXem_Click(sender, e);
        }

        private void buttonXoaHetGKL_Click(object sender, EventArgs e)
        {
            dateTimePickerThoiGian.Value = DateTime.Today;
            comboBoxPhuongThuc.SelectedIndex = 0;
            comboBoxLoại.SelectedIndex = 0;
            labelTLN.Text = string.Empty;
            dataGridViewChiTietLoiNhuan.DataSource = null;
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            GetLoiNhuanByCondition();
            labelTLN.Text = String.Format("{0:0,0.00}", CalculateTongLoiNhuan());
        }

        private void GetLoiNhuanByCondition()
        {
            
            dataGridViewChiTietLoiNhuan.DataSource = (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constLoiNhuan_CalculateByCondition,
                new Collection<KeyValuePair<object, int>>{
                    new KeyValuePair<object,int>(dateTimePickerThoiGian.Value,(int)ParameterType.String),
                    new KeyValuePair<object,int>(comboBoxPhuongThuc.SelectedIndex,(int)ParameterType.NonString),
                    new KeyValuePair<object,int>(comboBoxLoại.SelectedIndex,(int)ParameterType.NonString),
                },
                (int)ExecuteType.Query);
            dataGridViewChiTietLoiNhuan.Refresh();
        }

        private decimal CalculateTongLoiNhuan()
        {
            decimal k = 0;
            for (int i = 0; i < dataGridViewChiTietLoiNhuan.Rows.Count; i++)
            {
                if (dataGridViewChiTietLoiNhuan.Rows[i].Cells[0].Value == null)
                    break;

                k = k +(decimal)dataGridViewChiTietLoiNhuan.Rows[i].Cells[3].Value;
            }
            return k;
        }
    }
}
