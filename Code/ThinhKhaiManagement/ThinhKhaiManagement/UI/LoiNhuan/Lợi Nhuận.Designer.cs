namespace ThinhKhaiManagement.UI.LoiNhuan
{
    partial class LoiNhuan
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
            this.labelNgay = new System.Windows.Forms.Label();
            this.labelLoiNhuanThinhKhai = new System.Windows.Forms.Label();
            this.groupBoxDieuKienLoc = new System.Windows.Forms.GroupBox();
            this.labelPhuongThuc = new System.Windows.Forms.Label();
            this.labelThoiGian = new System.Windows.Forms.Label();
            this.comboBoxPhuongThuc = new System.Windows.Forms.ComboBox();
            this.dateTimePickerThoiGian = new System.Windows.Forms.DateTimePicker();
            this.buttonXem = new System.Windows.Forms.Button();
            this.groupBoxChiTiet = new System.Windows.Forms.GroupBox();
            this.dataGridViewChiTietLoiNhuan = new System.Windows.Forms.DataGridView();
            this.buttonXoaHetGKL = new System.Windows.Forms.Button();
            this.labelLoai = new System.Windows.Forms.Label();
            this.comboBoxLoại = new System.Windows.Forms.ComboBox();
            this.labelTongLoiNhuan = new System.Windows.Forms.Label();
            this.labelTLN = new System.Windows.Forms.Label();
            this.groupBoxDieuKienLoc.SuspendLayout();
            this.groupBoxChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietLoiNhuan)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNgay
            // 
            this.labelNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNgay.AutoSize = true;
            this.labelNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgay.ForeColor = System.Drawing.Color.Blue;
            this.labelNgay.Location = new System.Drawing.Point(15, 9);
            this.labelNgay.Name = "labelNgay";
            this.labelNgay.Size = new System.Drawing.Size(76, 15);
            this.labelNgay.TabIndex = 0;
            this.labelNgay.Text = "ngày hiện tại";
            // 
            // labelLoiNhuanThinhKhai
            // 
            this.labelLoiNhuanThinhKhai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoiNhuanThinhKhai.AutoSize = true;
            this.labelLoiNhuanThinhKhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoiNhuanThinhKhai.ForeColor = System.Drawing.Color.Maroon;
            this.labelLoiNhuanThinhKhai.Location = new System.Drawing.Point(69, 33);
            this.labelLoiNhuanThinhKhai.Name = "labelLoiNhuanThinhKhai";
            this.labelLoiNhuanThinhKhai.Size = new System.Drawing.Size(314, 33);
            this.labelLoiNhuanThinhKhai.TabIndex = 1;
            this.labelLoiNhuanThinhKhai.Text = "Lợi Nhuận Thịnh Khai";
            // 
            // groupBoxDieuKienLoc
            // 
            this.groupBoxDieuKienLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDieuKienLoc.Controls.Add(this.buttonXoaHetGKL);
            this.groupBoxDieuKienLoc.Controls.Add(this.buttonXem);
            this.groupBoxDieuKienLoc.Controls.Add(this.labelTLN);
            this.groupBoxDieuKienLoc.Controls.Add(this.labelTongLoiNhuan);
            this.groupBoxDieuKienLoc.Controls.Add(this.dateTimePickerThoiGian);
            this.groupBoxDieuKienLoc.Controls.Add(this.comboBoxLoại);
            this.groupBoxDieuKienLoc.Controls.Add(this.comboBoxPhuongThuc);
            this.groupBoxDieuKienLoc.Controls.Add(this.labelThoiGian);
            this.groupBoxDieuKienLoc.Controls.Add(this.labelLoai);
            this.groupBoxDieuKienLoc.Controls.Add(this.labelPhuongThuc);
            this.groupBoxDieuKienLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDieuKienLoc.Location = new System.Drawing.Point(14, 73);
            this.groupBoxDieuKienLoc.Name = "groupBoxDieuKienLoc";
            this.groupBoxDieuKienLoc.Size = new System.Drawing.Size(430, 197);
            this.groupBoxDieuKienLoc.TabIndex = 2;
            this.groupBoxDieuKienLoc.TabStop = false;
            this.groupBoxDieuKienLoc.Text = "Điều Kiện Lọc";
            // 
            // labelPhuongThuc
            // 
            this.labelPhuongThuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhuongThuc.AutoSize = true;
            this.labelPhuongThuc.Location = new System.Drawing.Point(32, 69);
            this.labelPhuongThuc.Name = "labelPhuongThuc";
            this.labelPhuongThuc.Size = new System.Drawing.Size(87, 16);
            this.labelPhuongThuc.TabIndex = 0;
            this.labelPhuongThuc.Text = "Phương Thức";
            // 
            // labelThoiGian
            // 
            this.labelThoiGian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelThoiGian.AutoSize = true;
            this.labelThoiGian.Location = new System.Drawing.Point(32, 38);
            this.labelThoiGian.Name = "labelThoiGian";
            this.labelThoiGian.Size = new System.Drawing.Size(66, 16);
            this.labelThoiGian.TabIndex = 1;
            this.labelThoiGian.Text = "Thời Gian";
            // 
            // comboBoxPhuongThuc
            // 
            this.comboBoxPhuongThuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhuongThuc.FormattingEnabled = true;
            this.comboBoxPhuongThuc.Items.AddRange(new object[] {
            "Ngày-Tháng-Năm",
            "Tháng-Năm",
            "Năm"});
            this.comboBoxPhuongThuc.Location = new System.Drawing.Point(150, 66);
            this.comboBoxPhuongThuc.Name = "comboBoxPhuongThuc";
            this.comboBoxPhuongThuc.Size = new System.Drawing.Size(248, 24);
            this.comboBoxPhuongThuc.TabIndex = 2;
            // 
            // dateTimePickerThoiGian
            // 
            this.dateTimePickerThoiGian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerThoiGian.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerThoiGian.Location = new System.Drawing.Point(150, 33);
            this.dateTimePickerThoiGian.Name = "dateTimePickerThoiGian";
            this.dateTimePickerThoiGian.Size = new System.Drawing.Size(248, 21);
            this.dateTimePickerThoiGian.TabIndex = 1;
            // 
            // buttonXem
            // 
            this.buttonXem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXem.Location = new System.Drawing.Point(348, 152);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(50, 23);
            this.buttonXem.TabIndex = 3;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // groupBoxChiTiet
            // 
            this.groupBoxChiTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxChiTiet.Controls.Add(this.dataGridViewChiTietLoiNhuan);
            this.groupBoxChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChiTiet.Location = new System.Drawing.Point(14, 278);
            this.groupBoxChiTiet.Name = "groupBoxChiTiet";
            this.groupBoxChiTiet.Size = new System.Drawing.Size(430, 263);
            this.groupBoxChiTiet.TabIndex = 5;
            this.groupBoxChiTiet.TabStop = false;
            this.groupBoxChiTiet.Text = "Chi Tiết Lợi Nhuận";
            // 
            // dataGridViewChiTietLoiNhuan
            // 
            this.dataGridViewChiTietLoiNhuan.AllowUserToAddRows = false;
            this.dataGridViewChiTietLoiNhuan.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietLoiNhuan.AllowUserToResizeColumns = false;
            this.dataGridViewChiTietLoiNhuan.AllowUserToResizeRows = false;
            this.dataGridViewChiTietLoiNhuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewChiTietLoiNhuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietLoiNhuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietLoiNhuan.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewChiTietLoiNhuan.Name = "dataGridViewChiTietLoiNhuan";
            this.dataGridViewChiTietLoiNhuan.ReadOnly = true;
            this.dataGridViewChiTietLoiNhuan.Size = new System.Drawing.Size(418, 228);
            this.dataGridViewChiTietLoiNhuan.TabIndex = 10;
            // 
            // buttonXoaHetGKL
            // 
            this.buttonXoaHetGKL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoaHetGKL.Location = new System.Drawing.Point(267, 152);
            this.buttonXoaHetGKL.Name = "buttonXoaHetGKL";
            this.buttonXoaHetGKL.Size = new System.Drawing.Size(65, 23);
            this.buttonXoaHetGKL.TabIndex = 4;
            this.buttonXoaHetGKL.Text = "Xóa Hết";
            this.buttonXoaHetGKL.UseVisualStyleBackColor = true;
            this.buttonXoaHetGKL.Click += new System.EventHandler(this.buttonXoaHetGKL_Click);
            // 
            // labelLoai
            // 
            this.labelLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoai.AutoSize = true;
            this.labelLoai.Location = new System.Drawing.Point(32, 105);
            this.labelLoai.Name = "labelLoai";
            this.labelLoai.Size = new System.Drawing.Size(87, 16);
            this.labelLoai.TabIndex = 0;
            this.labelLoai.Text = "Lợi Nhuận Từ";
            // 
            // comboBoxLoại
            // 
            this.comboBoxLoại.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxLoại.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoại.FormattingEnabled = true;
            this.comboBoxLoại.Items.AddRange(new object[] {
            "Toàn Bộ",
            "Mặt Hàng",
            "Ngoại Tệ"});
            this.comboBoxLoại.Location = new System.Drawing.Point(150, 102);
            this.comboBoxLoại.Name = "comboBoxLoại";
            this.comboBoxLoại.Size = new System.Drawing.Size(248, 24);
            this.comboBoxLoại.TabIndex = 2;
            // 
            // labelTongLoiNhuan
            // 
            this.labelTongLoiNhuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTongLoiNhuan.AutoSize = true;
            this.labelTongLoiNhuan.Location = new System.Drawing.Point(32, 143);
            this.labelTongLoiNhuan.Name = "labelTongLoiNhuan";
            this.labelTongLoiNhuan.Size = new System.Drawing.Size(103, 16);
            this.labelTongLoiNhuan.TabIndex = 16;
            this.labelTongLoiNhuan.Text = "Tổng Lợi Nhuận";
            // 
            // labelTLN
            // 
            this.labelTLN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTLN.AutoSize = true;
            this.labelTLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTLN.ForeColor = System.Drawing.Color.Maroon;
            this.labelTLN.Location = new System.Drawing.Point(81, 169);
            this.labelTLN.Name = "labelTLN";
            this.labelTLN.Size = new System.Drawing.Size(104, 16);
            this.labelTLN.TabIndex = 17;
            this.labelTLN.Text = "tổng lợi nhuận";
            // 
            // LoiNhuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 550);
            this.Controls.Add(this.groupBoxChiTiet);
            this.Controls.Add(this.groupBoxDieuKienLoc);
            this.Controls.Add(this.labelLoiNhuanThinhKhai);
            this.Controls.Add(this.labelNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoiNhuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lợi Nhuận";
            this.Load += new System.EventHandler(this.LoiNhuan_Load);
            this.groupBoxDieuKienLoc.ResumeLayout(false);
            this.groupBoxDieuKienLoc.PerformLayout();
            this.groupBoxChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietLoiNhuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNgay;
        private System.Windows.Forms.Label labelLoiNhuanThinhKhai;
        private System.Windows.Forms.GroupBox groupBoxDieuKienLoc;
        private System.Windows.Forms.ComboBox comboBoxPhuongThuc;
        private System.Windows.Forms.Label labelThoiGian;
        private System.Windows.Forms.Label labelPhuongThuc;
        private System.Windows.Forms.Button buttonXoaHetGKL;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.DateTimePicker dateTimePickerThoiGian;
        private System.Windows.Forms.GroupBox groupBoxChiTiet;
        private System.Windows.Forms.DataGridView dataGridViewChiTietLoiNhuan;
        private System.Windows.Forms.ComboBox comboBoxLoại;
        private System.Windows.Forms.Label labelLoai;
        private System.Windows.Forms.Label labelTLN;
        private System.Windows.Forms.Label labelTongLoiNhuan;
    }
}