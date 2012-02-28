namespace ThinhKhaiManagement.UI.TienMat
{
    partial class ChiTietXuatTienMat
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
            this.groupBoxXemChiTietXuatTienMat = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayXuatTienMat = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewChiTietXuatTienMat = new System.Windows.Forms.DataGridView();
            this.groupBoxXemChiTietXuatTienMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietXuatTienMat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxXemChiTietXuatTienMat
            // 
            this.groupBoxXemChiTietXuatTienMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXemChiTietXuatTienMat.Controls.Add(this.dateTimePickerNgayXuatTienMat);
            this.groupBoxXemChiTietXuatTienMat.Controls.Add(this.dataGridViewChiTietXuatTienMat);
            this.groupBoxXemChiTietXuatTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxXemChiTietXuatTienMat.Location = new System.Drawing.Point(8, 3);
            this.groupBoxXemChiTietXuatTienMat.Name = "groupBoxXemChiTietXuatTienMat";
            this.groupBoxXemChiTietXuatTienMat.Size = new System.Drawing.Size(432, 310);
            this.groupBoxXemChiTietXuatTienMat.TabIndex = 16;
            this.groupBoxXemChiTietXuatTienMat.TabStop = false;
            this.groupBoxXemChiTietXuatTienMat.Text = "Chi Tiết";
            // 
            // dateTimePickerNgayXuatTienMat
            // 
            this.dateTimePickerNgayXuatTienMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgayXuatTienMat.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNgayXuatTienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayXuatTienMat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayXuatTienMat.Location = new System.Drawing.Point(11, 19);
            this.dateTimePickerNgayXuatTienMat.Name = "dateTimePickerNgayXuatTienMat";
            this.dateTimePickerNgayXuatTienMat.Size = new System.Drawing.Size(123, 21);
            this.dateTimePickerNgayXuatTienMat.TabIndex = 14;
            this.dateTimePickerNgayXuatTienMat.ValueChanged += new System.EventHandler(this.dateTimePickerNgayXuatTienMat_ValueChanged);
            // 
            // dataGridViewChiTietXuatTienMat
            // 
            this.dataGridViewChiTietXuatTienMat.AllowUserToAddRows = false;
            this.dataGridViewChiTietXuatTienMat.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietXuatTienMat.AllowUserToResizeColumns = false;
            this.dataGridViewChiTietXuatTienMat.AllowUserToResizeRows = false;
            this.dataGridViewChiTietXuatTienMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewChiTietXuatTienMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewChiTietXuatTienMat.Location = new System.Drawing.Point(11, 46);
            this.dataGridViewChiTietXuatTienMat.MultiSelect = false;
            this.dataGridViewChiTietXuatTienMat.Name = "dataGridViewChiTietXuatTienMat";
            this.dataGridViewChiTietXuatTienMat.ReadOnly = true;
            this.dataGridViewChiTietXuatTienMat.Size = new System.Drawing.Size(409, 258);
            this.dataGridViewChiTietXuatTienMat.TabIndex = 13;
            this.dataGridViewChiTietXuatTienMat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietXuatTienMat_CellDoubleClick);
            // 
            // ChiTietXuatTienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 316);
            this.Controls.Add(this.groupBoxXemChiTietXuatTienMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietXuatTienMat";
            this.Text = "Chi Tiết Xuất Tiền Mặt";
            this.Load += new System.EventHandler(this.ChiTietXuatTienMat_Load);
            this.groupBoxXemChiTietXuatTienMat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietXuatTienMat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxXemChiTietXuatTienMat;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayXuatTienMat;
        private System.Windows.Forms.DataGridView dataGridViewChiTietXuatTienMat;
    }
}