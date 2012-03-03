namespace ThinhKhaiManagement.UI.TienMat
{
    partial class ChiTietNhapTienMat
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
            this.groupBoxXemChiTietNhapTienMat = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayNhapTienMat = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewChiTietNhapTienMat = new System.Windows.Forms.DataGridView();
            this.groupBoxXemChiTietNhapTienMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietNhapTienMat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxXemChiTietNhapTienMat
            // 
            this.groupBoxXemChiTietNhapTienMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXemChiTietNhapTienMat.Controls.Add(this.dateTimePickerNgayNhapTienMat);
            this.groupBoxXemChiTietNhapTienMat.Controls.Add(this.dataGridViewChiTietNhapTienMat);
            this.groupBoxXemChiTietNhapTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxXemChiTietNhapTienMat.Location = new System.Drawing.Point(12, 12);
            this.groupBoxXemChiTietNhapTienMat.Name = "groupBoxXemChiTietNhapTienMat";
            this.groupBoxXemChiTietNhapTienMat.Size = new System.Drawing.Size(493, 310);
            this.groupBoxXemChiTietNhapTienMat.TabIndex = 16;
            this.groupBoxXemChiTietNhapTienMat.TabStop = false;
            this.groupBoxXemChiTietNhapTienMat.Text = "Chi Tiết";
            // 
            // dateTimePickerNgayNhapTienMat
            // 
            this.dateTimePickerNgayNhapTienMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgayNhapTienMat.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNgayNhapTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayNhapTienMat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayNhapTienMat.Location = new System.Drawing.Point(16, 19);
            this.dateTimePickerNgayNhapTienMat.Name = "dateTimePickerNgayNhapTienMat";
            this.dateTimePickerNgayNhapTienMat.Size = new System.Drawing.Size(133, 21);
            this.dateTimePickerNgayNhapTienMat.TabIndex = 14;
            this.dateTimePickerNgayNhapTienMat.ValueChanged += new System.EventHandler(this.dateTimePickerNgayNhapTienMat_ValueChanged);
            // 
            // dataGridViewChiTietNhapTienMat
            // 
            this.dataGridViewChiTietNhapTienMat.AllowUserToAddRows = false;
            this.dataGridViewChiTietNhapTienMat.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietNhapTienMat.AllowUserToResizeColumns = false;
            this.dataGridViewChiTietNhapTienMat.AllowUserToResizeRows = false;
            this.dataGridViewChiTietNhapTienMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewChiTietNhapTienMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietNhapTienMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewChiTietNhapTienMat.Location = new System.Drawing.Point(16, 46);
            this.dataGridViewChiTietNhapTienMat.MultiSelect = false;
            this.dataGridViewChiTietNhapTienMat.Name = "dataGridViewChiTietNhapTienMat";
            this.dataGridViewChiTietNhapTienMat.ReadOnly = true;
            this.dataGridViewChiTietNhapTienMat.Size = new System.Drawing.Size(458, 258);
            this.dataGridViewChiTietNhapTienMat.TabIndex = 13;
            this.dataGridViewChiTietNhapTienMat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietNhapTienMat_CellDoubleClick);
            // 
            // ChiTietNhapTienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 322);
            this.Controls.Add(this.groupBoxXemChiTietNhapTienMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietNhapTienMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Nhập Tiền Mặt";
            this.Load += new System.EventHandler(this.ChiTietNhapTienMat_Load);
            this.groupBoxXemChiTietNhapTienMat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietNhapTienMat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxXemChiTietNhapTienMat;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhapTienMat;
        private System.Windows.Forms.DataGridView dataGridViewChiTietNhapTienMat;
    }
}