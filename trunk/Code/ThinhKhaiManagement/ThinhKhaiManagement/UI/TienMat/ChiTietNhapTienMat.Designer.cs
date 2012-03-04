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
            this.labelTT = new System.Windows.Forms.Label();
            this.labelTongThu = new System.Windows.Forms.Label();
            this.dateTimePickerNgayNhapTienMat = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewChiTietNhapTienMat = new System.Windows.Forms.DataGridView();
            this.groupBoxXemChiTietNhapTienMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietNhapTienMat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxXemChiTietNhapTienMat
            // 
            this.groupBoxXemChiTietNhapTienMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXemChiTietNhapTienMat.Controls.Add(this.labelTT);
            this.groupBoxXemChiTietNhapTienMat.Controls.Add(this.labelTongThu);
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
            // labelTT
            // 
            this.labelTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTT.AutoSize = true;
            this.labelTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTT.ForeColor = System.Drawing.Color.Blue;
            this.labelTT.Location = new System.Drawing.Point(276, 13);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(55, 24);
            this.labelTT.TabIndex = 16;
            this.labelTT.Text = "00.00";
            // 
            // labelTongThu
            // 
            this.labelTongThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTongThu.AutoSize = true;
            this.labelTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongThu.ForeColor = System.Drawing.Color.Maroon;
            this.labelTongThu.Location = new System.Drawing.Point(186, 19);
            this.labelTongThu.Name = "labelTongThu";
            this.labelTongThu.Size = new System.Drawing.Size(74, 16);
            this.labelTongThu.TabIndex = 15;
            this.labelTongThu.Text = "Tổng Thu";
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
            this.groupBoxXemChiTietNhapTienMat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietNhapTienMat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxXemChiTietNhapTienMat;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhapTienMat;
        private System.Windows.Forms.DataGridView dataGridViewChiTietNhapTienMat;
        public System.Windows.Forms.Label labelTT;
        public System.Windows.Forms.Label labelTongThu;
    }
}