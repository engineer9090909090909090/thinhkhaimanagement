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
        }

        private void TonNgoaiTe_Activated(object sender, EventArgs e)
        {
            // cap nhat lieu vao luoi
            dataGridViewTonNgoaiTe.DataSource = ShowTonNgoaiTe();
        }

        #endregion

        #region private methods

        private DataTable ShowTonNgoaiTe()
        {
            return (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                                StoreProcedureNames.constTonNgoaiTeGetAll,
                                                new Collection<KeyValuePair<object,int>>(),
                                                (int)ExecuteType.Query);
        }

        #endregion

        #region public methods

        #endregion


      

    }
}
