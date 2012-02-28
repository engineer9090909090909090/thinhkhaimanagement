namespace ThinhKhaiManagement.UI.NgoaiTe
{
    partial class ChiTietXuatNgoaiTe
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
            this.groupBoxXemChiTietXuatNgoaiTe = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayXuatNgoaiTe = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewChiTietXuatNgoaiTe = new System.Windows.Forms.DataGridView();
            this.groupBoxXemChiTietXuatNgoaiTe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietXuatNgoaiTe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxXemChiTietXuatNgoaiTe
            // 
            this.groupBoxXemChiTietXuatNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXemChiTietXuatNgoaiTe.Controls.Add(this.dateTimePickerNgayXuatNgoaiTe);
            this.groupBoxXemChiTietXuatNgoaiTe.Controls.Add(this.dataGridViewChiTietXuatNgoaiTe);
            this.groupBoxXemChiTietXuatNgoaiTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxXemChiTietXuatNgoaiTe.Location = new System.Drawing.Point(5, 4);
            this.groupBoxXemChiTietXuatNgoaiTe.Name = "groupBoxXemChiTietXuatNgoaiTe";
            this.groupBoxXemChiTietXuatNgoaiTe.Size = new System.Drawing.Size(656, 310);
            this.groupBoxXemChiTietXuatNgoaiTe.TabIndex = 16;
            this.groupBoxXemChiTietXuatNgoaiTe.TabStop = false;
            this.groupBoxXemChiTietXuatNgoaiTe.Text = "Chi Tiết";
            // 
            // dateTimePickerNgayXuatNgoaiTe
            // 
            this.dateTimePickerNgayXuatNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgayXuatNgoaiTe.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNgayXuatNgoaiTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayXuatNgoaiTe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayXuatNgoaiTe.Location = new System.Drawing.Point(17, 19);
            this.dateTimePickerNgayXuatNgoaiTe.Name = "dateTimePickerNgayXuatNgoaiTe";
            this.dateTimePickerNgayXuatNgoaiTe.Size = new System.Drawing.Size(123, 21);
            this.dateTimePickerNgayXuatNgoaiTe.TabIndex = 14;
            this.dateTimePickerNgayXuatNgoaiTe.ValueChanged += new System.EventHandler(this.dateTimePickerNgayXuatNgoaiTe_ValueChanged);
            // 
            // dataGridViewChiTietXuatNgoaiTe
            // 
            this.dataGridViewChiTietXuatNgoaiTe.AllowUserToAddRows = false;
            this.dataGridViewChiTietXuatNgoaiTe.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietXuatNgoaiTe.AllowUserToResizeColumns = false;
            this.dataGridViewChiTietXuatNgoaiTe.AllowUserToResizeRows = false;
            this.dataGridViewChiTietXuatNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewChiTietXuatNgoaiTe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewChiTietXuatNgoaiTe.Location = new System.Drawing.Point(17, 46);
            this.dataGridViewChiTietXuatNgoaiTe.MultiSelect = false;
            this.dataGridViewChiTietXuatNgoaiTe.Name = "dataGridViewChiTietXuatNgoaiTe";
            this.dataGridViewChiTietXuatNgoaiTe.ReadOnly = true;
            this.dataGridViewChiTietXuatNgoaiTe.Size = new System.Drawing.Size(622, 258);
            this.dataGridViewChiTietXuatNgoaiTe.TabIndex = 13;
            this.dataGridViewChiTietXuatNgoaiTe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietXuatNgoaiTe_CellDoubleClick);
            // 
            // ChiTietXuatNgoaiTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 318);
            this.Controls.Add(this.groupBoxXemChiTietXuatNgoaiTe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChiTietXuatNgoaiTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Xuất Ngoại Tệ";
            this.Load += new System.EventHandler(this.ChiTietXuatNgoaiTe_Load);
            this.groupBoxXemChiTietXuatNgoaiTe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietXuatNgoaiTe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxXemChiTietXuatNgoaiTe;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayXuatNgoaiTe;
        private System.Windows.Forms.DataGridView dataGridViewChiTietXuatNgoaiTe;
    }
}