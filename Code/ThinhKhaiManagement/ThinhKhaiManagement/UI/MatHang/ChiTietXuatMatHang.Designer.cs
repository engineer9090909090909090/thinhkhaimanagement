namespace ThinhKhaiManagement.UI.MatHang
{
    partial class ChiTietXuatMatHang
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
            this.groupBoxXemChiTietNhapMatHang = new System.Windows.Forms.GroupBox();
            this.buttonHuyPhieu = new System.Windows.Forms.Button();
            this.dataGridViewChiTietXuatMatHang = new System.Windows.Forms.DataGridView();
            this.dateTimePickerNgayXuatMatHang = new System.Windows.Forms.DateTimePicker();
            this.groupBoxXemChiTietNhapMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietXuatMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxXemChiTietNhapMatHang
            // 
            this.groupBoxXemChiTietNhapMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXemChiTietNhapMatHang.Controls.Add(this.buttonHuyPhieu);
            this.groupBoxXemChiTietNhapMatHang.Controls.Add(this.dataGridViewChiTietXuatMatHang);
            this.groupBoxXemChiTietNhapMatHang.Controls.Add(this.dateTimePickerNgayXuatMatHang);
            this.groupBoxXemChiTietNhapMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxXemChiTietNhapMatHang.Location = new System.Drawing.Point(12, 12);
            this.groupBoxXemChiTietNhapMatHang.Name = "groupBoxXemChiTietNhapMatHang";
            this.groupBoxXemChiTietNhapMatHang.Size = new System.Drawing.Size(906, 374);
            this.groupBoxXemChiTietNhapMatHang.TabIndex = 17;
            this.groupBoxXemChiTietNhapMatHang.TabStop = false;
            this.groupBoxXemChiTietNhapMatHang.Text = "Chi Tiết";
            // 
            // buttonHuyPhieu
            // 
            this.buttonHuyPhieu.Location = new System.Drawing.Point(825, 26);
            this.buttonHuyPhieu.Name = "buttonHuyPhieu";
            this.buttonHuyPhieu.Size = new System.Drawing.Size(75, 23);
            this.buttonHuyPhieu.TabIndex = 16;
            this.buttonHuyPhieu.Text = "Hủy Phiếu";
            this.buttonHuyPhieu.UseVisualStyleBackColor = true;
            this.buttonHuyPhieu.Click += new System.EventHandler(this.buttonHuyPhieu_Click);
            // 
            // dataGridViewChiTietXuatMatHang
            // 
            this.dataGridViewChiTietXuatMatHang.AllowUserToAddRows = false;
            this.dataGridViewChiTietXuatMatHang.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietXuatMatHang.AllowUserToResizeRows = false;
            this.dataGridViewChiTietXuatMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewChiTietXuatMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietXuatMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietXuatMatHang.Location = new System.Drawing.Point(6, 56);
            this.dataGridViewChiTietXuatMatHang.MultiSelect = false;
            this.dataGridViewChiTietXuatMatHang.Name = "dataGridViewChiTietXuatMatHang";
            this.dataGridViewChiTietXuatMatHang.Size = new System.Drawing.Size(894, 311);
            this.dataGridViewChiTietXuatMatHang.TabIndex = 15;
            // 
            // dateTimePickerNgayXuatMatHang
            // 
            this.dateTimePickerNgayXuatMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgayXuatMatHang.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNgayXuatMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayXuatMatHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayXuatMatHang.Location = new System.Drawing.Point(6, 26);
            this.dateTimePickerNgayXuatMatHang.Name = "dateTimePickerNgayXuatMatHang";
            this.dateTimePickerNgayXuatMatHang.Size = new System.Drawing.Size(123, 21);
            this.dateTimePickerNgayXuatMatHang.TabIndex = 14;
            this.dateTimePickerNgayXuatMatHang.ValueChanged += new System.EventHandler(this.dateTimePickerNgayXuatMatHang_ValueChanged);
            // 
            // ChiTietXuatMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 391);
            this.Controls.Add(this.groupBoxXemChiTietNhapMatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietXuatMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Xuất Mặt Hàng";
            this.Load += new System.EventHandler(this.ChiTietXuatMatHang_Load);
            this.groupBoxXemChiTietNhapMatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietXuatMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxXemChiTietNhapMatHang;
        private System.Windows.Forms.DataGridView dataGridViewChiTietXuatMatHang;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayXuatMatHang;
        private System.Windows.Forms.Button buttonHuyPhieu;
    }
}