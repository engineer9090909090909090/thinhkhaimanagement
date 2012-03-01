namespace ThinhKhaiManagement.UI.MatHang
{
    partial class ChiTietNhapMatHang
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
            this.dateTimePickerNgayNhapMatHang = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewChiTietNhapMatHang = new System.Windows.Forms.DataGridView();
            this.groupBoxXemChiTietNhapMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietNhapMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxXemChiTietNhapMatHang
            // 
            this.groupBoxXemChiTietNhapMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXemChiTietNhapMatHang.Controls.Add(this.dateTimePickerNgayNhapMatHang);
            this.groupBoxXemChiTietNhapMatHang.Controls.Add(this.dataGridViewChiTietNhapMatHang);
            this.groupBoxXemChiTietNhapMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxXemChiTietNhapMatHang.Location = new System.Drawing.Point(12, 12);
            this.groupBoxXemChiTietNhapMatHang.Name = "groupBoxXemChiTietNhapMatHang";
            this.groupBoxXemChiTietNhapMatHang.Size = new System.Drawing.Size(830, 361);
            this.groupBoxXemChiTietNhapMatHang.TabIndex = 16;
            this.groupBoxXemChiTietNhapMatHang.TabStop = false;
            this.groupBoxXemChiTietNhapMatHang.Text = "Chi Tiết";
            // 
            // dateTimePickerNgayNhapMatHang
            // 
            this.dateTimePickerNgayNhapMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgayNhapMatHang.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNgayNhapMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayNhapMatHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayNhapMatHang.Location = new System.Drawing.Point(21, 19);
            this.dateTimePickerNgayNhapMatHang.Name = "dateTimePickerNgayNhapMatHang";
            this.dateTimePickerNgayNhapMatHang.Size = new System.Drawing.Size(123, 21);
            this.dateTimePickerNgayNhapMatHang.TabIndex = 14;
            // 
            // dataGridViewChiTietNhapMatHang
            // 
            this.dataGridViewChiTietNhapMatHang.AllowUserToAddRows = false;
            this.dataGridViewChiTietNhapMatHang.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietNhapMatHang.AllowUserToResizeColumns = false;
            this.dataGridViewChiTietNhapMatHang.AllowUserToResizeRows = false;
            this.dataGridViewChiTietNhapMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewChiTietNhapMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietNhapMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewChiTietNhapMatHang.Location = new System.Drawing.Point(21, 46);
            this.dataGridViewChiTietNhapMatHang.MultiSelect = false;
            this.dataGridViewChiTietNhapMatHang.Name = "dataGridViewChiTietNhapMatHang";
            this.dataGridViewChiTietNhapMatHang.ReadOnly = true;
            this.dataGridViewChiTietNhapMatHang.Size = new System.Drawing.Size(789, 297);
            this.dataGridViewChiTietNhapMatHang.TabIndex = 13;
            // 
            // ChiTietNhapMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 385);
            this.Controls.Add(this.groupBoxXemChiTietNhapMatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietNhapMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Nhập Mặt Hàng";
            this.Load += new System.EventHandler(this.ChiTietNhapMatHang_Load);
            this.groupBoxXemChiTietNhapMatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietNhapMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxXemChiTietNhapMatHang;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhapMatHang;
        private System.Windows.Forms.DataGridView dataGridViewChiTietNhapMatHang;
    }
}