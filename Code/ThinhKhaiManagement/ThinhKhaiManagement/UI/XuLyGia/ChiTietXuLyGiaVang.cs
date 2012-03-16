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

namespace ThinhKhaiManagement.UI.XuLyGia
{
    public partial class LichSuXuLyGiaVang : Form
    {
        DataAccess dataaccess;
        public LichSuXuLyGiaVang()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
        }

        private void LichSuXuLyGiaVang_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = dataaccess.Access(StaticMethods.ShowSqlConnection(),
                StoreProcedureNames.constGiaVang_ShowByNgay,
                new Collection<KeyValuePair<object, int>>{
                    new KeyValuePair<object,int>(dateTimePicker.Value.Date,(int)ParameterType.String)
                },
                (int)ExecuteType.Query);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LichSuXuLyGiaVang_Load(sender, e);
        }

        private void inPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
                InPhieu();
            else
                MessageBox.Show("Mời chọn giá vàng để in phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >=0)
            {
                dataGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void InPhieu()
        {
            ThinhKhaiDataSet ds = new ThinhKhaiDataSet();
            DataRow dr = ds.Tables["GiaVang"].NewRow();
            dr[0] = dataGridView.CurrentRow.Cells[1].Value;
            dr[1] = dataGridView.CurrentRow.Cells[2].Value;
            dr[2] = dataGridView.CurrentRow.Cells[3].Value;
            dr[3] = dataGridView.CurrentRow.Cells[4].Value;
            dr[4] = dataGridView.CurrentRow.Cells[5].Value;
            dr[5] = dataGridView.CurrentRow.Cells[6].Value;
            dr[6] = dataGridView.CurrentRow.Cells[7].Value;
            dr[7] = dataGridView.CurrentRow.Cells[8].Value;
            dr[8] = dataGridView.CurrentRow.Cells[9].Value;
            dr[9] = dataGridView.CurrentRow.Cells[10].Value;
            dr[10] = dataGridView.CurrentRow.Cells[11].Value;
            ds.Tables["GiaVang"].Rows.Add(dr);

            InPhieuXuLyGiaVang inPhieuXuLyGiaVang = new InPhieuXuLyGiaVang();
            inPhieuXuLyGiaVang.printInfo = ds;
            inPhieuXuLyGiaVang.Show();
        }
    }
}
