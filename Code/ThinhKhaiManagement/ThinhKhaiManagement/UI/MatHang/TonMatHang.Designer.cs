namespace ThinhKhaiManagement.UI.MatHang
{
    partial class TonMatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNgayTonMatHang = new System.Windows.Forms.Label();
            this.labelHeaderTonMatHang = new System.Windows.Forms.Label();
            this.dataGridViewXem = new System.Windows.Forms.DataGridView();
            this.groupBoxLoc = new System.Windows.Forms.GroupBox();
            this.comboBoxLoaiMatHang = new System.Windows.Forms.ComboBox();
            this.buttonXemToanBo = new System.Windows.Forms.Button();
            this.comboBoxChatLieu = new System.Windows.Forms.ComboBox();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.labelLoaiMatHang = new System.Windows.Forms.Label();
            this.labelChatLieu = new System.Windows.Forms.Label();
            this.labelTGV = new System.Windows.Forms.Label();
            this.labelTongSoLuong = new System.Windows.Forms.Label();
            this.labelTongGiaVon = new System.Windows.Forms.Label();
            this.labelTSL = new System.Windows.Forms.Label();
            this.labelGiaVonTungMatHang = new System.Windows.Forms.Label();
            this.groupBoxKiemTraVonTungMatHang = new System.Windows.Forms.GroupBox();
            this.buttonKiemTra = new System.Windows.Forms.Button();
            this.textBoxTenMatHang = new System.Windows.Forms.TextBox();
            this.textBoxMaMatHang = new System.Windows.Forms.TextBox();
            this.labelTenMatHang = new System.Windows.Forms.Label();
            this.labelMaMH = new System.Windows.Forms.Label();
            this.labelGV = new System.Windows.Forms.Label();
            this.labelTTH = new System.Windows.Forms.Label();
            this.labelTongTruHot = new System.Windows.Forms.Label();
            this.labelTTL = new System.Windows.Forms.Label();
            this.labelTongTrongLuong = new System.Windows.Forms.Label();
            this.labelTTiH = new System.Windows.Forms.Label();
            this.labelTongTienHot = new System.Windows.Forms.Label();
            this.labelTTC = new System.Windows.Forms.Label();
            this.labelTongTienCong = new System.Windows.Forms.Label();
            this.buttonXoaHet = new System.Windows.Forms.Button();
            this.buttonInPhieu = new System.Windows.Forms.Button();
            this.groupBoxLocTheoSTT = new System.Windows.Forms.GroupBox();
            this.radSpinEditorDen = new Telerik.WinControls.UI.RadSpinEditor();
            this.radSpinEditorTu = new Telerik.WinControls.UI.RadSpinEditor();
            this.buttonLoc2 = new System.Windows.Forms.Button();
            this.labelTu = new System.Windows.Forms.Label();
            this.labelDen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXem)).BeginInit();
            this.groupBoxLoc.SuspendLayout();
            this.groupBoxKiemTraVonTungMatHang.SuspendLayout();
            this.groupBoxLocTheoSTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorTu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNgayTonMatHang
            // 
            this.labelNgayTonMatHang.AutoSize = true;
            this.labelNgayTonMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTonMatHang.ForeColor = System.Drawing.Color.Blue;
            this.labelNgayTonMatHang.Location = new System.Drawing.Point(11, 11);
            this.labelNgayTonMatHang.Name = "labelNgayTonMatHang";
            this.labelNgayTonMatHang.Size = new System.Drawing.Size(76, 15);
            this.labelNgayTonMatHang.TabIndex = 3;
            this.labelNgayTonMatHang.Text = "ngày hiện tại";
            // 
            // labelHeaderTonMatHang
            // 
            this.labelHeaderTonMatHang.AutoSize = true;
            this.labelHeaderTonMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderTonMatHang.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeaderTonMatHang.Location = new System.Drawing.Point(263, 39);
            this.labelHeaderTonMatHang.Name = "labelHeaderTonMatHang";
            this.labelHeaderTonMatHang.Size = new System.Drawing.Size(261, 31);
            this.labelHeaderTonMatHang.TabIndex = 2;
            this.labelHeaderTonMatHang.Text = "Phiếu Tồn Mặt Hàng";
            // 
            // dataGridViewXem
            // 
            this.dataGridViewXem.AllowUserToAddRows = false;
            this.dataGridViewXem.AllowUserToDeleteRows = false;
            this.dataGridViewXem.AllowUserToResizeColumns = false;
            this.dataGridViewXem.AllowUserToResizeRows = false;
            this.dataGridViewXem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXem.Location = new System.Drawing.Point(14, 389);
            this.dataGridViewXem.Name = "dataGridViewXem";
            this.dataGridViewXem.ReadOnly = true;
            this.dataGridViewXem.Size = new System.Drawing.Size(741, 292);
            this.dataGridViewXem.TabIndex = 4;
            this.dataGridViewXem.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewXem_RowHeaderMouseClick);
            // 
            // groupBoxLoc
            // 
            this.groupBoxLoc.Controls.Add(this.comboBoxLoaiMatHang);
            this.groupBoxLoc.Controls.Add(this.buttonXemToanBo);
            this.groupBoxLoc.Controls.Add(this.comboBoxChatLieu);
            this.groupBoxLoc.Controls.Add(this.buttonLoc);
            this.groupBoxLoc.Controls.Add(this.labelLoaiMatHang);
            this.groupBoxLoc.Controls.Add(this.labelChatLieu);
            this.groupBoxLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoc.Location = new System.Drawing.Point(14, 81);
            this.groupBoxLoc.Name = "groupBoxLoc";
            this.groupBoxLoc.Size = new System.Drawing.Size(384, 118);
            this.groupBoxLoc.TabIndex = 5;
            this.groupBoxLoc.TabStop = false;
            this.groupBoxLoc.Text = "Lọc Theo Điều Kiện";
            // 
            // comboBoxLoaiMatHang
            // 
            this.comboBoxLoaiMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxLoaiMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiMatHang.FormattingEnabled = true;
            this.comboBoxLoaiMatHang.Location = new System.Drawing.Point(153, 50);
            this.comboBoxLoaiMatHang.Name = "comboBoxLoaiMatHang";
            this.comboBoxLoaiMatHang.Size = new System.Drawing.Size(194, 24);
            this.comboBoxLoaiMatHang.TabIndex = 3;
            // 
            // buttonXemToanBo
            // 
            this.buttonXemToanBo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXemToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemToanBo.Location = new System.Drawing.Point(134, 84);
            this.buttonXemToanBo.Name = "buttonXemToanBo";
            this.buttonXemToanBo.Size = new System.Drawing.Size(80, 24);
            this.buttonXemToanBo.TabIndex = 5;
            this.buttonXemToanBo.Text = "Xem Toàn Bộ";
            this.buttonXemToanBo.UseVisualStyleBackColor = true;
            this.buttonXemToanBo.Click += new System.EventHandler(this.buttonXemToanBo_Click);
            // 
            // comboBoxChatLieu
            // 
            this.comboBoxChatLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChatLieu.FormattingEnabled = true;
            this.comboBoxChatLieu.Location = new System.Drawing.Point(153, 20);
            this.comboBoxChatLieu.Name = "comboBoxChatLieu";
            this.comboBoxChatLieu.Size = new System.Drawing.Size(194, 24);
            this.comboBoxChatLieu.TabIndex = 2;
            // 
            // buttonLoc
            // 
            this.buttonLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(13, 84);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(115, 24);
            this.buttonLoc.TabIndex = 4;
            this.buttonLoc.Text = "Xem Theo Điều Kiện";
            this.buttonLoc.UseVisualStyleBackColor = true;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // labelLoaiMatHang
            // 
            this.labelLoaiMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoaiMatHang.AutoSize = true;
            this.labelLoaiMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiMatHang.Location = new System.Drawing.Point(10, 53);
            this.labelLoaiMatHang.Name = "labelLoaiMatHang";
            this.labelLoaiMatHang.Size = new System.Drawing.Size(95, 16);
            this.labelLoaiMatHang.TabIndex = 1;
            this.labelLoaiMatHang.Text = "Loại Mặt Hàng";
            // 
            // labelChatLieu
            // 
            this.labelChatLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChatLieu.AutoSize = true;
            this.labelChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChatLieu.Location = new System.Drawing.Point(10, 23);
            this.labelChatLieu.Name = "labelChatLieu";
            this.labelChatLieu.Size = new System.Drawing.Size(63, 16);
            this.labelChatLieu.TabIndex = 0;
            this.labelChatLieu.Text = "Chất Liệu";
            // 
            // labelTGV
            // 
            this.labelTGV.AutoSize = true;
            this.labelTGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTGV.ForeColor = System.Drawing.Color.Blue;
            this.labelTGV.Location = new System.Drawing.Point(515, 351);
            this.labelTGV.Name = "labelTGV";
            this.labelTGV.Size = new System.Drawing.Size(66, 25);
            this.labelTGV.TabIndex = 9;
            this.labelTGV.Text = "00.00";
            this.labelTGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTongSoLuong
            // 
            this.labelTongSoLuong.AutoSize = true;
            this.labelTongSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongSoLuong.ForeColor = System.Drawing.Color.Maroon;
            this.labelTongSoLuong.Location = new System.Drawing.Point(13, 297);
            this.labelTongSoLuong.Name = "labelTongSoLuong";
            this.labelTongSoLuong.Size = new System.Drawing.Size(113, 16);
            this.labelTongSoLuong.TabIndex = 4;
            this.labelTongSoLuong.Text = "Tổng Số Lượng";
            // 
            // labelTongGiaVon
            // 
            this.labelTongGiaVon.AutoSize = true;
            this.labelTongGiaVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongGiaVon.ForeColor = System.Drawing.Color.Maroon;
            this.labelTongGiaVon.Location = new System.Drawing.Point(347, 358);
            this.labelTongGiaVon.Name = "labelTongGiaVon";
            this.labelTongGiaVon.Size = new System.Drawing.Size(103, 16);
            this.labelTongGiaVon.TabIndex = 8;
            this.labelTongGiaVon.Text = "Tổng Giá Vốn";
            // 
            // labelTSL
            // 
            this.labelTSL.AutoSize = true;
            this.labelTSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTSL.ForeColor = System.Drawing.Color.Blue;
            this.labelTSL.Location = new System.Drawing.Point(162, 290);
            this.labelTSL.Name = "labelTSL";
            this.labelTSL.Size = new System.Drawing.Size(66, 25);
            this.labelTSL.TabIndex = 5;
            this.labelTSL.Text = "00.00";
            this.labelTSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGiaVonTungMatHang
            // 
            this.labelGiaVonTungMatHang.AutoSize = true;
            this.labelGiaVonTungMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaVonTungMatHang.ForeColor = System.Drawing.Color.Maroon;
            this.labelGiaVonTungMatHang.Location = new System.Drawing.Point(491, 35);
            this.labelGiaVonTungMatHang.Name = "labelGiaVonTungMatHang";
            this.labelGiaVonTungMatHang.Size = new System.Drawing.Size(63, 16);
            this.labelGiaVonTungMatHang.TabIndex = 10;
            this.labelGiaVonTungMatHang.Text = "Giá Vốn";
            // 
            // groupBoxKiemTraVonTungMatHang
            // 
            this.groupBoxKiemTraVonTungMatHang.Controls.Add(this.buttonKiemTra);
            this.groupBoxKiemTraVonTungMatHang.Controls.Add(this.textBoxTenMatHang);
            this.groupBoxKiemTraVonTungMatHang.Controls.Add(this.textBoxMaMatHang);
            this.groupBoxKiemTraVonTungMatHang.Controls.Add(this.labelTenMatHang);
            this.groupBoxKiemTraVonTungMatHang.Controls.Add(this.labelMaMH);
            this.groupBoxKiemTraVonTungMatHang.Controls.Add(this.labelGV);
            this.groupBoxKiemTraVonTungMatHang.Controls.Add(this.labelGiaVonTungMatHang);
            this.groupBoxKiemTraVonTungMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKiemTraVonTungMatHang.Location = new System.Drawing.Point(14, 205);
            this.groupBoxKiemTraVonTungMatHang.Name = "groupBoxKiemTraVonTungMatHang";
            this.groupBoxKiemTraVonTungMatHang.Size = new System.Drawing.Size(743, 83);
            this.groupBoxKiemTraVonTungMatHang.TabIndex = 6;
            this.groupBoxKiemTraVonTungMatHang.TabStop = false;
            this.groupBoxKiemTraVonTungMatHang.Text = "Kiểm Tra Vốn Từng Mặt Hàng";
            // 
            // buttonKiemTra
            // 
            this.buttonKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKiemTra.Location = new System.Drawing.Point(393, 32);
            this.buttonKiemTra.Name = "buttonKiemTra";
            this.buttonKiemTra.Size = new System.Drawing.Size(75, 23);
            this.buttonKiemTra.TabIndex = 9;
            this.buttonKiemTra.Text = "Kiểm Tra";
            this.buttonKiemTra.UseVisualStyleBackColor = true;
            this.buttonKiemTra.Click += new System.EventHandler(this.buttonKiemTra_Click);
            // 
            // textBoxTenMatHang
            // 
            this.textBoxTenMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMatHang.Location = new System.Drawing.Point(153, 50);
            this.textBoxTenMatHang.Name = "textBoxTenMatHang";
            this.textBoxTenMatHang.ReadOnly = true;
            this.textBoxTenMatHang.Size = new System.Drawing.Size(173, 22);
            this.textBoxTenMatHang.TabIndex = 15;
            // 
            // textBoxMaMatHang
            // 
            this.textBoxMaMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaMatHang.Location = new System.Drawing.Point(153, 22);
            this.textBoxMaMatHang.Name = "textBoxMaMatHang";
            this.textBoxMaMatHang.ReadOnly = true;
            this.textBoxMaMatHang.Size = new System.Drawing.Size(173, 22);
            this.textBoxMaMatHang.TabIndex = 14;
            // 
            // labelTenMatHang
            // 
            this.labelTenMatHang.AutoSize = true;
            this.labelTenMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMatHang.Location = new System.Drawing.Point(10, 53);
            this.labelTenMatHang.Name = "labelTenMatHang";
            this.labelTenMatHang.Size = new System.Drawing.Size(93, 16);
            this.labelTenMatHang.TabIndex = 13;
            this.labelTenMatHang.Text = "Tên Mặt Hàng";
            // 
            // labelMaMH
            // 
            this.labelMaMH.AutoSize = true;
            this.labelMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaMH.Location = new System.Drawing.Point(10, 25);
            this.labelMaMH.Name = "labelMaMH";
            this.labelMaMH.Size = new System.Drawing.Size(88, 16);
            this.labelMaMH.TabIndex = 12;
            this.labelMaMH.Text = "Mã Mặt Hàng";
            // 
            // labelGV
            // 
            this.labelGV.AutoSize = true;
            this.labelGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGV.ForeColor = System.Drawing.Color.Blue;
            this.labelGV.Location = new System.Drawing.Point(560, 28);
            this.labelGV.Name = "labelGV";
            this.labelGV.Size = new System.Drawing.Size(66, 25);
            this.labelGV.TabIndex = 11;
            this.labelGV.Text = "00.00";
            this.labelGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTTH
            // 
            this.labelTTH.AutoSize = true;
            this.labelTTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTH.ForeColor = System.Drawing.Color.Blue;
            this.labelTTH.Location = new System.Drawing.Point(162, 320);
            this.labelTTH.Name = "labelTTH";
            this.labelTTH.Size = new System.Drawing.Size(66, 25);
            this.labelTTH.TabIndex = 11;
            this.labelTTH.Text = "00.00";
            this.labelTTH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTongTruHot
            // 
            this.labelTongTruHot.AutoSize = true;
            this.labelTongTruHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTruHot.ForeColor = System.Drawing.Color.Maroon;
            this.labelTongTruHot.Location = new System.Drawing.Point(14, 329);
            this.labelTongTruHot.Name = "labelTongTruHot";
            this.labelTongTruHot.Size = new System.Drawing.Size(99, 16);
            this.labelTongTruHot.TabIndex = 10;
            this.labelTongTruHot.Text = "Tổng Trừ Hột";
            // 
            // labelTTL
            // 
            this.labelTTL.AutoSize = true;
            this.labelTTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTL.ForeColor = System.Drawing.Color.Blue;
            this.labelTTL.Location = new System.Drawing.Point(515, 291);
            this.labelTTL.Name = "labelTTL";
            this.labelTTL.Size = new System.Drawing.Size(66, 25);
            this.labelTTL.TabIndex = 13;
            this.labelTTL.Text = "00.00";
            this.labelTTL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTongTrongLuong
            // 
            this.labelTongTrongLuong.AutoSize = true;
            this.labelTongTrongLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTrongLuong.ForeColor = System.Drawing.Color.Maroon;
            this.labelTongTrongLuong.Location = new System.Drawing.Point(347, 297);
            this.labelTongTrongLuong.Name = "labelTongTrongLuong";
            this.labelTongTrongLuong.Size = new System.Drawing.Size(135, 16);
            this.labelTongTrongLuong.TabIndex = 12;
            this.labelTongTrongLuong.Text = "Tổng Trọng Lượng";
            // 
            // labelTTiH
            // 
            this.labelTTiH.AutoSize = true;
            this.labelTTiH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTiH.ForeColor = System.Drawing.Color.Blue;
            this.labelTTiH.Location = new System.Drawing.Point(515, 320);
            this.labelTTiH.Name = "labelTTiH";
            this.labelTTiH.Size = new System.Drawing.Size(66, 25);
            this.labelTTiH.TabIndex = 15;
            this.labelTTiH.Text = "00.00";
            this.labelTTiH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTongTienHot
            // 
            this.labelTongTienHot.AutoSize = true;
            this.labelTongTienHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTienHot.ForeColor = System.Drawing.Color.Maroon;
            this.labelTongTienHot.Location = new System.Drawing.Point(347, 329);
            this.labelTongTienHot.Name = "labelTongTienHot";
            this.labelTongTienHot.Size = new System.Drawing.Size(107, 16);
            this.labelTongTienHot.TabIndex = 14;
            this.labelTongTienHot.Text = "Tổng Tiền Hột";
            // 
            // labelTTC
            // 
            this.labelTTC.AutoSize = true;
            this.labelTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTC.ForeColor = System.Drawing.Color.Blue;
            this.labelTTC.Location = new System.Drawing.Point(162, 351);
            this.labelTTC.Name = "labelTTC";
            this.labelTTC.Size = new System.Drawing.Size(66, 25);
            this.labelTTC.TabIndex = 17;
            this.labelTTC.Text = "00.00";
            this.labelTTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTongTienCong
            // 
            this.labelTongTienCong.AutoSize = true;
            this.labelTongTienCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTienCong.ForeColor = System.Drawing.Color.Maroon;
            this.labelTongTienCong.Location = new System.Drawing.Point(13, 358);
            this.labelTongTienCong.Name = "labelTongTienCong";
            this.labelTongTienCong.Size = new System.Drawing.Size(119, 16);
            this.labelTongTienCong.TabIndex = 16;
            this.labelTongTienCong.Text = "Tổng Tiền Công";
            // 
            // buttonXoaHet
            // 
            this.buttonXoaHet.Location = new System.Drawing.Point(703, 297);
            this.buttonXoaHet.Name = "buttonXoaHet";
            this.buttonXoaHet.Size = new System.Drawing.Size(54, 23);
            this.buttonXoaHet.TabIndex = 10;
            this.buttonXoaHet.Text = "Xóa Hết";
            this.buttonXoaHet.UseVisualStyleBackColor = true;
            this.buttonXoaHet.Click += new System.EventHandler(this.buttonXoaHet_Click);
            // 
            // buttonInPhieu
            // 
            this.buttonInPhieu.Location = new System.Drawing.Point(682, 11);
            this.buttonInPhieu.Name = "buttonInPhieu";
            this.buttonInPhieu.Size = new System.Drawing.Size(75, 23);
            this.buttonInPhieu.TabIndex = 19;
            this.buttonInPhieu.Text = "In Phiếu";
            this.buttonInPhieu.UseVisualStyleBackColor = true;
            this.buttonInPhieu.Click += new System.EventHandler(this.buttonInPhieu_Click);
            // 
            // groupBoxLocTheoSTT
            // 
            this.groupBoxLocTheoSTT.Controls.Add(this.radSpinEditorDen);
            this.groupBoxLocTheoSTT.Controls.Add(this.radSpinEditorTu);
            this.groupBoxLocTheoSTT.Controls.Add(this.buttonLoc2);
            this.groupBoxLocTheoSTT.Controls.Add(this.labelTu);
            this.groupBoxLocTheoSTT.Controls.Add(this.labelDen);
            this.groupBoxLocTheoSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLocTheoSTT.Location = new System.Drawing.Point(407, 81);
            this.groupBoxLocTheoSTT.Name = "groupBoxLocTheoSTT";
            this.groupBoxLocTheoSTT.Size = new System.Drawing.Size(348, 118);
            this.groupBoxLocTheoSTT.TabIndex = 20;
            this.groupBoxLocTheoSTT.TabStop = false;
            this.groupBoxLocTheoSTT.Text = "Lọc Theo Số Thứ Tự";
            // 
            // radSpinEditorDen
            // 
            this.radSpinEditorDen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSpinEditorDen.BackColor = System.Drawing.Color.White;
            this.radSpinEditorDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpinEditorDen.Location = new System.Drawing.Point(62, 53);
            this.radSpinEditorDen.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.radSpinEditorDen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditorDen.Name = "radSpinEditorDen";
            // 
            // 
            // 
            this.radSpinEditorDen.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorDen.ShowBorder = true;
            this.radSpinEditorDen.ShowUpDownButtons = false;
            this.radSpinEditorDen.Size = new System.Drawing.Size(263, 21);
            this.radSpinEditorDen.TabIndex = 7;
            this.radSpinEditorDen.Text = "radSpinEditor1";
            this.radSpinEditorDen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radSpinEditorTu
            // 
            this.radSpinEditorTu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSpinEditorTu.BackColor = System.Drawing.Color.White;
            this.radSpinEditorTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpinEditorTu.Location = new System.Drawing.Point(62, 23);
            this.radSpinEditorTu.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.radSpinEditorTu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radSpinEditorTu.Name = "radSpinEditorTu";
            // 
            // 
            // 
            this.radSpinEditorTu.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorTu.ShowBorder = true;
            this.radSpinEditorTu.ShowUpDownButtons = false;
            this.radSpinEditorTu.Size = new System.Drawing.Size(263, 21);
            this.radSpinEditorTu.TabIndex = 6;
            this.radSpinEditorTu.Text = "radSpinEditor1";
            this.radSpinEditorTu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonLoc2
            // 
            this.buttonLoc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLoc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc2.Location = new System.Drawing.Point(6, 84);
            this.buttonLoc2.Name = "buttonLoc2";
            this.buttonLoc2.Size = new System.Drawing.Size(319, 24);
            this.buttonLoc2.TabIndex = 8;
            this.buttonLoc2.Text = "Xem Theo Điều Kiện";
            this.buttonLoc2.UseVisualStyleBackColor = true;
            this.buttonLoc2.Click += new System.EventHandler(this.buttonLoc2_Click);
            // 
            // labelTu
            // 
            this.labelTu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTu.AutoSize = true;
            this.labelTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTu.Location = new System.Drawing.Point(12, 23);
            this.labelTu.Name = "labelTu";
            this.labelTu.Size = new System.Drawing.Size(24, 16);
            this.labelTu.TabIndex = 0;
            this.labelTu.Text = "Từ";
            // 
            // labelDen
            // 
            this.labelDen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDen.AutoSize = true;
            this.labelDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDen.Location = new System.Drawing.Point(12, 53);
            this.labelDen.Name = "labelDen";
            this.labelDen.Size = new System.Drawing.Size(32, 16);
            this.labelDen.TabIndex = 1;
            this.labelDen.Text = "Đến";
            // 
            // TonMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 693);
            this.Controls.Add(this.groupBoxLocTheoSTT);
            this.Controls.Add(this.buttonInPhieu);
            this.Controls.Add(this.buttonXoaHet);
            this.Controls.Add(this.labelTTC);
            this.Controls.Add(this.labelTongTienCong);
            this.Controls.Add(this.labelTTiH);
            this.Controls.Add(this.labelTongTienHot);
            this.Controls.Add(this.labelTTL);
            this.Controls.Add(this.labelTongTrongLuong);
            this.Controls.Add(this.labelTTH);
            this.Controls.Add(this.groupBoxKiemTraVonTungMatHang);
            this.Controls.Add(this.labelTongTruHot);
            this.Controls.Add(this.groupBoxLoc);
            this.Controls.Add(this.dataGridViewXem);
            this.Controls.Add(this.labelTGV);
            this.Controls.Add(this.labelNgayTonMatHang);
            this.Controls.Add(this.labelTongSoLuong);
            this.Controls.Add(this.labelTongGiaVon);
            this.Controls.Add(this.labelHeaderTonMatHang);
            this.Controls.Add(this.labelTSL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TonMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn Mặt Hàng";
            this.Load += new System.EventHandler(this.TonMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXem)).EndInit();
            this.groupBoxLoc.ResumeLayout(false);
            this.groupBoxLoc.PerformLayout();
            this.groupBoxKiemTraVonTungMatHang.ResumeLayout(false);
            this.groupBoxKiemTraVonTungMatHang.PerformLayout();
            this.groupBoxLocTheoSTT.ResumeLayout(false);
            this.groupBoxLocTheoSTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNgayTonMatHang;
        public System.Windows.Forms.Label labelHeaderTonMatHang;
        private System.Windows.Forms.DataGridView dataGridViewXem;
        private System.Windows.Forms.GroupBox groupBoxLoc;
        private System.Windows.Forms.Label labelTongSoLuong;
        private System.Windows.Forms.ComboBox comboBoxLoaiMatHang;
        private System.Windows.Forms.ComboBox comboBoxChatLieu;
        private System.Windows.Forms.Label labelLoaiMatHang;
        private System.Windows.Forms.Label labelChatLieu;
        private System.Windows.Forms.Label labelTSL;
        private System.Windows.Forms.Button buttonXemToanBo;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.Label labelTGV;
        private System.Windows.Forms.Label labelTongGiaVon;
        private System.Windows.Forms.Label labelGiaVonTungMatHang;
        private System.Windows.Forms.GroupBox groupBoxKiemTraVonTungMatHang;
        private System.Windows.Forms.Button buttonKiemTra;
        private System.Windows.Forms.TextBox textBoxTenMatHang;
        private System.Windows.Forms.TextBox textBoxMaMatHang;
        private System.Windows.Forms.Label labelTenMatHang;
        private System.Windows.Forms.Label labelMaMH;
        private System.Windows.Forms.Label labelGV;
        private System.Windows.Forms.Label labelTTH;
        private System.Windows.Forms.Label labelTongTruHot;
        private System.Windows.Forms.Label labelTTL;
        private System.Windows.Forms.Label labelTongTrongLuong;
        private System.Windows.Forms.Label labelTTiH;
        private System.Windows.Forms.Label labelTongTienHot;
        private System.Windows.Forms.Label labelTTC;
        private System.Windows.Forms.Label labelTongTienCong;
        private System.Windows.Forms.Button buttonXoaHet;
        private System.Windows.Forms.Button buttonInPhieu;
        private System.Windows.Forms.GroupBox groupBoxLocTheoSTT;
        private System.Windows.Forms.Button buttonLoc2;
        private System.Windows.Forms.Label labelTu;
        private System.Windows.Forms.Label labelDen;
        public Telerik.WinControls.UI.RadSpinEditor radSpinEditorDen;
        public Telerik.WinControls.UI.RadSpinEditor radSpinEditorTu;
    }
}