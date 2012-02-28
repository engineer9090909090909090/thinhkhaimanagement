namespace ThinhKhaiManagement.UI.TienMat
{
    partial class TienMat
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxTon = new System.Windows.Forms.GroupBox();
            this.buttonXem = new System.Windows.Forms.Button();
            this.dataGridViewXemTienMat = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDen = new System.Windows.Forms.DateTimePicker();
            this.labelDen = new System.Windows.Forms.Label();
            this.dateTimePickerTu = new System.Windows.Forms.DateTimePicker();
            this.labelTu = new System.Windows.Forms.Label();
            this.groupBoxXuat = new System.Windows.Forms.GroupBox();
            this.buttonXemChiTiet = new System.Windows.Forms.Button();
            this.buttonLamSach = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxLyDo = new System.Windows.Forms.TextBox();
            this.radSpinEditorTienMat = new Telerik.WinControls.UI.RadSpinEditor();
            this.comboBoxXuLy = new System.Windows.Forms.ComboBox();
            this.labelLyDo = new System.Windows.Forms.Label();
            this.labelTienMat = new System.Windows.Forms.Label();
            this.labelXuLy = new System.Windows.Forms.Label();
            this.labelNgayTienMat = new System.Windows.Forms.Label();
            this.statusStripTienMat = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTienMat = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelHeaderThongTinTienMat = new System.Windows.Forms.Label();
            this.errorProviderTienMat = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemTienMat)).BeginInit();
            this.groupBoxXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorTienMat)).BeginInit();
            this.statusStripTienMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTienMat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTon
            // 
            this.groupBoxTon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTon.Controls.Add(this.buttonXem);
            this.groupBoxTon.Controls.Add(this.dataGridViewXemTienMat);
            this.groupBoxTon.Controls.Add(this.dateTimePickerDen);
            this.groupBoxTon.Controls.Add(this.labelDen);
            this.groupBoxTon.Controls.Add(this.dateTimePickerTu);
            this.groupBoxTon.Controls.Add(this.labelTu);
            this.groupBoxTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTon.Location = new System.Drawing.Point(21, 63);
            this.groupBoxTon.Name = "groupBoxTon";
            this.groupBoxTon.Size = new System.Drawing.Size(417, 198);
            this.groupBoxTon.TabIndex = 1;
            this.groupBoxTon.TabStop = false;
            this.groupBoxTon.Text = "Xem Tiền Mặt";
            // 
            // buttonXem
            // 
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXem.Location = new System.Drawing.Point(344, 14);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(47, 27);
            this.buttonXem.TabIndex = 5;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // dataGridViewXemTienMat
            // 
            this.dataGridViewXemTienMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewXemTienMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemTienMat.Location = new System.Drawing.Point(25, 51);
            this.dataGridViewXemTienMat.Name = "dataGridViewXemTienMat";
            this.dataGridViewXemTienMat.ReadOnly = true;
            this.dataGridViewXemTienMat.Size = new System.Drawing.Size(366, 135);
            this.dataGridViewXemTienMat.TabIndex = 4;
            // 
            // dateTimePickerDen
            // 
            this.dateTimePickerDen.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDen.Location = new System.Drawing.Point(235, 15);
            this.dateTimePickerDen.Name = "dateTimePickerDen";
            this.dateTimePickerDen.Size = new System.Drawing.Size(89, 22);
            this.dateTimePickerDen.TabIndex = 3;
            // 
            // labelDen
            // 
            this.labelDen.AutoSize = true;
            this.labelDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDen.Location = new System.Drawing.Point(179, 19);
            this.labelDen.Name = "labelDen";
            this.labelDen.Size = new System.Drawing.Size(32, 16);
            this.labelDen.TabIndex = 2;
            this.labelDen.Text = "Đến";
            // 
            // dateTimePickerTu
            // 
            this.dateTimePickerTu.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTu.Location = new System.Drawing.Point(73, 15);
            this.dateTimePickerTu.Name = "dateTimePickerTu";
            this.dateTimePickerTu.Size = new System.Drawing.Size(89, 22);
            this.dateTimePickerTu.TabIndex = 1;
            // 
            // labelTu
            // 
            this.labelTu.AutoSize = true;
            this.labelTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTu.Location = new System.Drawing.Point(22, 20);
            this.labelTu.Name = "labelTu";
            this.labelTu.Size = new System.Drawing.Size(24, 16);
            this.labelTu.TabIndex = 0;
            this.labelTu.Text = "Từ";
            // 
            // groupBoxXuat
            // 
            this.groupBoxXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXuat.Controls.Add(this.buttonXemChiTiet);
            this.groupBoxXuat.Controls.Add(this.buttonLamSach);
            this.groupBoxXuat.Controls.Add(this.buttonLuu);
            this.groupBoxXuat.Controls.Add(this.textBoxLyDo);
            this.groupBoxXuat.Controls.Add(this.radSpinEditorTienMat);
            this.groupBoxXuat.Controls.Add(this.comboBoxXuLy);
            this.groupBoxXuat.Controls.Add(this.labelLyDo);
            this.groupBoxXuat.Controls.Add(this.labelTienMat);
            this.groupBoxXuat.Controls.Add(this.labelXuLy);
            this.groupBoxXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxXuat.Location = new System.Drawing.Point(21, 267);
            this.groupBoxXuat.Name = "groupBoxXuat";
            this.groupBoxXuat.Size = new System.Drawing.Size(417, 152);
            this.groupBoxXuat.TabIndex = 2;
            this.groupBoxXuat.TabStop = false;
            this.groupBoxXuat.Text = "Nhập / Xuất Tiền Mặt";
            // 
            // buttonXemChiTiet
            // 
            this.buttonXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemChiTiet.Location = new System.Drawing.Point(283, 118);
            this.buttonXemChiTiet.Name = "buttonXemChiTiet";
            this.buttonXemChiTiet.Size = new System.Drawing.Size(108, 28);
            this.buttonXemChiTiet.TabIndex = 8;
            this.buttonXemChiTiet.Text = "Xem Chi Tiết";
            this.buttonXemChiTiet.UseVisualStyleBackColor = true;
            this.buttonXemChiTiet.Click += new System.EventHandler(this.buttonXemChiTiet_Click);
            // 
            // buttonLamSach
            // 
            this.buttonLamSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLamSach.Location = new System.Drawing.Point(118, 118);
            this.buttonLamSach.Name = "buttonLamSach";
            this.buttonLamSach.Size = new System.Drawing.Size(93, 28);
            this.buttonLamSach.TabIndex = 7;
            this.buttonLamSach.Text = "Làm Sạch";
            this.buttonLamSach.UseVisualStyleBackColor = true;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(34, 118);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 28);
            this.buttonLuu.TabIndex = 6;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // textBoxLyDo
            // 
            this.textBoxLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLyDo.Location = new System.Drawing.Point(185, 89);
            this.textBoxLyDo.Name = "textBoxLyDo";
            this.textBoxLyDo.Size = new System.Drawing.Size(206, 22);
            this.textBoxLyDo.TabIndex = 5;
            // 
            // radSpinEditorTienMat
            // 
            this.radSpinEditorTienMat.BackColor = System.Drawing.Color.White;
            this.radSpinEditorTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpinEditorTienMat.Location = new System.Drawing.Point(185, 57);
            this.radSpinEditorTienMat.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.radSpinEditorTienMat.Name = "radSpinEditorTienMat";
            // 
            // 
            // 
            this.radSpinEditorTienMat.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radSpinEditorTienMat.ShowBorder = true;
            this.radSpinEditorTienMat.ShowUpDownButtons = false;
            this.radSpinEditorTienMat.Size = new System.Drawing.Size(206, 22);
            this.radSpinEditorTienMat.TabIndex = 4;
            this.radSpinEditorTienMat.Text = "radSpinEditor1";
            this.radSpinEditorTienMat.ThousandsSeparator = true;
            // 
            // comboBoxXuLy
            // 
            this.comboBoxXuLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxXuLy.FormattingEnabled = true;
            this.comboBoxXuLy.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.comboBoxXuLy.Location = new System.Drawing.Point(185, 27);
            this.comboBoxXuLy.Name = "comboBoxXuLy";
            this.comboBoxXuLy.Size = new System.Drawing.Size(206, 24);
            this.comboBoxXuLy.TabIndex = 3;
            // 
            // labelLyDo
            // 
            this.labelLyDo.AutoSize = true;
            this.labelLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLyDo.Location = new System.Drawing.Point(31, 92);
            this.labelLyDo.Name = "labelLyDo";
            this.labelLyDo.Size = new System.Drawing.Size(43, 16);
            this.labelLyDo.TabIndex = 2;
            this.labelLyDo.Text = "Lý Do";
            // 
            // labelTienMat
            // 
            this.labelTienMat.AutoSize = true;
            this.labelTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienMat.Location = new System.Drawing.Point(31, 61);
            this.labelTienMat.Name = "labelTienMat";
            this.labelTienMat.Size = new System.Drawing.Size(60, 16);
            this.labelTienMat.TabIndex = 1;
            this.labelTienMat.Text = "Tiền Mặt";
            // 
            // labelXuLy
            // 
            this.labelXuLy.AutoSize = true;
            this.labelXuLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXuLy.Location = new System.Drawing.Point(31, 30);
            this.labelXuLy.Name = "labelXuLy";
            this.labelXuLy.Size = new System.Drawing.Size(36, 16);
            this.labelXuLy.TabIndex = 0;
            this.labelXuLy.Text = "Xử lý";
            // 
            // labelNgayTienMat
            // 
            this.labelNgayTienMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNgayTienMat.AutoSize = true;
            this.labelNgayTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTienMat.ForeColor = System.Drawing.Color.Blue;
            this.labelNgayTienMat.Location = new System.Drawing.Point(21, 9);
            this.labelNgayTienMat.Name = "labelNgayTienMat";
            this.labelNgayTienMat.Size = new System.Drawing.Size(76, 15);
            this.labelNgayTienMat.TabIndex = 0;
            this.labelNgayTienMat.Text = "ngày hiện tại";
            // 
            // statusStripTienMat
            // 
            this.statusStripTienMat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTienMat});
            this.statusStripTienMat.Location = new System.Drawing.Point(0, 425);
            this.statusStripTienMat.Name = "statusStripTienMat";
            this.statusStripTienMat.Size = new System.Drawing.Size(458, 22);
            this.statusStripTienMat.TabIndex = 3;
            this.statusStripTienMat.Text = "statusStrip1";
            // 
            // toolStripStatusLabelTienMat
            // 
            this.toolStripStatusLabelTienMat.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabelTienMat.Name = "toolStripStatusLabelTienMat";
            this.toolStripStatusLabelTienMat.Size = new System.Drawing.Size(0, 17);
            // 
            // labelHeaderThongTinTienMat
            // 
            this.labelHeaderThongTinTienMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeaderThongTinTienMat.AutoSize = true;
            this.labelHeaderThongTinTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderThongTinTienMat.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeaderThongTinTienMat.Location = new System.Drawing.Point(88, 29);
            this.labelHeaderThongTinTienMat.Name = "labelHeaderThongTinTienMat";
            this.labelHeaderThongTinTienMat.Size = new System.Drawing.Size(248, 31);
            this.labelHeaderThongTinTienMat.TabIndex = 4;
            this.labelHeaderThongTinTienMat.Text = "Thông Tin Tiền Mặt";
            // 
            // errorProviderTienMat
            // 
            this.errorProviderTienMat.ContainerControl = this;
            // 
            // TienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 447);
            this.Controls.Add(this.labelHeaderThongTinTienMat);
            this.Controls.Add(this.statusStripTienMat);
            this.Controls.Add(this.groupBoxXuat);
            this.Controls.Add(this.groupBoxTon);
            this.Controls.Add(this.labelNgayTienMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TienMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiền Mặt";
            this.Load += new System.EventHandler(this.TienMat_Load);
            this.groupBoxTon.ResumeLayout(false);
            this.groupBoxTon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemTienMat)).EndInit();
            this.groupBoxXuat.ResumeLayout(false);
            this.groupBoxXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSpinEditorTienMat)).EndInit();
            this.statusStripTienMat.ResumeLayout(false);
            this.statusStripTienMat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTienMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTon;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.DataGridView dataGridViewXemTienMat;
        private System.Windows.Forms.DateTimePicker dateTimePickerDen;
        private System.Windows.Forms.Label labelDen;
        private System.Windows.Forms.DateTimePicker dateTimePickerTu;
        private System.Windows.Forms.Label labelTu;
        private System.Windows.Forms.GroupBox groupBoxXuat;
        private System.Windows.Forms.Label labelNgayTienMat;
        public Telerik.WinControls.UI.RadSpinEditor radSpinEditorTienMat;
        private System.Windows.Forms.StatusStrip statusStripTienMat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTienMat;
        public System.Windows.Forms.Label labelHeaderThongTinTienMat;
        private System.Windows.Forms.ErrorProvider errorProviderTienMat;
        public System.Windows.Forms.ComboBox comboBoxXuLy;
        public System.Windows.Forms.Label labelLyDo;
        public System.Windows.Forms.Label labelTienMat;
        public System.Windows.Forms.Label labelXuLy;
        public System.Windows.Forms.TextBox textBoxLyDo;
        public System.Windows.Forms.Button buttonXemChiTiet;
        public System.Windows.Forms.Button buttonLamSach;
        public System.Windows.Forms.Button buttonLuu;


    }
}