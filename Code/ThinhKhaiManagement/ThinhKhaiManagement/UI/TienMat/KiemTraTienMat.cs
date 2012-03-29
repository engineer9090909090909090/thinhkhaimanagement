using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using DatabaseAccesser;
using ThinhKhaiManagement.Common;

namespace ThinhKhaiManagement.UI.TienMat
{
    public partial class KiemTraTienMat : Form
    {
        DataAccess dataaccess;
        public KiemTraTienMat()
        {
            InitializeComponent();
            dataaccess = new DataAccess();
            numericUpDown500kL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown200kL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown100kL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown50kL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown20kL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown10kL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown5kL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown2kL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown1kL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown5mL.KeyDown += new KeyEventHandler(TongSoLoaiTien);
            numericUpDown2mL.KeyDown += new KeyEventHandler(TongSoLoaiTien);

            numericUpDown500kL.Enter += new EventHandler(ChonHet);
            numericUpDown200kL.Enter += new EventHandler(ChonHet);
            numericUpDown100kL.Enter += new EventHandler(ChonHet);
            numericUpDown50kL.Enter += new EventHandler(ChonHet);
            numericUpDown20kL.Enter += new EventHandler(ChonHet);
            numericUpDown10kL.Enter += new EventHandler(ChonHet);
            numericUpDown5kL.Enter += new EventHandler(ChonHet);
            numericUpDown2kL.Enter += new EventHandler(ChonHet);
            numericUpDown1kL.Enter += new EventHandler(ChonHet);
            numericUpDown5mL.Enter += new EventHandler(ChonHet);
            numericUpDown2mL.Enter += new EventHandler(ChonHet);
        }

        private void ChonHet(object sender, EventArgs e)
        {
            NumericUpDown nm = (NumericUpDown)sender;
            nm.Select(0,nm.Value.ToString().Length);
        }

        private void TongSoLoaiTien(object sender, KeyEventArgs e)
        {
            NumericUpDown nm = (NumericUpDown)sender;
            if (e.KeyCode == Keys.Enter)
            {
                switch (nm.Name)
                {
                    case "numericUpDown500kL":
                        numericUpDown500kT.Value += nm.Value;
                        break;
                    case "numericUpDown200kL":
                        numericUpDown200kT.Value += nm.Value;
                        break;
                    case "numericUpDown100kL":
                        numericUpDown100kT.Value += nm.Value;
                        break;
                    case "numericUpDown50kL":
                        numericUpDown50kT.Value += nm.Value;
                        break;
                    case "numericUpDown20kL":
                        numericUpDown20kT.Value += nm.Value;
                        break;
                    case "numericUpDown10kL":
                        numericUpDown10kT.Value += nm.Value;
                        break;
                    case "numericUpDown5kL":
                        numericUpDown5kT.Value += nm.Value;
                        break;
                    case "numericUpDown2kL":
                        numericUpDown2kT.Value += nm.Value;
                        break;
                    case "numericUpDown1kL":
                        numericUpDown1kT.Value += nm.Value;
                        break;
                    case "numericUpDown5mL":
                        numericUpDown5mT.Value += nm.Value;
                        break;
                    case "numericUpDown2mL":
                        numericUpDown2mT.Value += nm.Value;
                        break;
                }
                nm.Value = 0;
                nm.Select(0, nm.Value.ToString().Length);
                TongTien();
            }
        }

        private void TongTien()
        {
            decimal temp = 0;
            foreach (var a in panel1.Controls)
            { 
                NumericUpDown nm = (NumericUpDown)a;
                switch (nm.Name)
                {
                    case "numericUpDown500kT":
                        temp += nm.Value * 500000;
                        break;
                    case "numericUpDown200kT":
                        temp += nm.Value * 200000;
                        break;
                    case "numericUpDown100kT":
                        temp += nm.Value * 100000;
                        break;
                    case "numericUpDown50kT":
                        temp += nm.Value * 50000;
                        break;
                    case "numericUpDown20kT":
                        temp += nm.Value * 20000;
                        break;
                    case "numericUpDown10kT":
                        temp += nm.Value * 10000;
                        break;
                    case "numericUpDown5kT":
                        temp += nm.Value * 5000;
                        break;
                    case "numericUpDown2kT":
                        temp += nm.Value * 2000;
                        break;
                    case "numericUpDown1kT":
                        temp += nm.Value * 1000;
                        break;
                    case "numericUpDown5mT":
                        temp += nm.Value * 500;
                        break;
                    case "numericUpDown2mT":
                        temp += nm.Value * 200;
                        break;
                }
                labelTongCong.Text = string.Format("Tổng Cộng: {0}", temp.ToString("#,##0.00"));
            }
        }

        private DataTable ShowTonTienMat()
        {
            return (DataTable)dataaccess.Access(StaticMethods.ShowSqlConnection(),
                                    "select * from TonTienMat where MaTTM = IDENT_CURRENT('TonTienMat')",
                                    new Collection<KeyValuePair<object, int>>(),
                                    (int)ExecuteType.Query);
        }

        private void buttonDoiChieu_Click(object sender, EventArgs e)
        {
            decimal temp;
            if (!string.IsNullOrEmpty(labelTongCong.Text.Split(':')[1]) && decimal.TryParse(labelTongCong.Text.Split(':')[1], out temp) && temp > 0)
            {
                labelTienMatThuc.Text = string.Format("TM thực: {0}", labelTongCong.Text.Split(':')[1].Trim());
                labelTienMatMay.Text = string.Format("TM máy: {0}", Convert.ToDecimal(ShowTonTienMat().Rows[0][2]).ToString("#,##0.00"));
                labelChenhLech.Text = string.Format("Chênh lệch: {0}", (Convert.ToDecimal(labelTienMatThuc.Text.Split(':')[1]) - Convert.ToDecimal(labelTienMatMay.Text.Split(':')[1])).ToString("#,##0.00"));
            }
            else
            {
                MessageBox.Show("Xin mời đếm tiền trước", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            foreach (var a in panel1.Controls) ((NumericUpDown)a).Value = 0;
            foreach (var b in panel2.Controls) ((NumericUpDown)b).Value = 0;
            labelTongCong.Text = "Tổng cộng:";
            labelTienMatThuc.Text = "TM thực:";
            labelTienMatMay.Text = "TM máy:";
            labelChenhLech.Text = "Chênh lệch:";
            numericUpDown500kL.Focus();
        }
    }
}
    