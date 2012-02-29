namespace ThinhKhaiManagement.UI.NgoaiTe
{
    partial class ChiTietNhapNgoaiTe
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
            this.groupBoxXemChiTietNhapNgoaiTe = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgayNhapNgoaiTe = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewChiTietNhapNgoaiTe = new System.Windows.Forms.DataGridView();
            this.groupBoxXemChiTietNhapNgoaiTe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietNhapNgoaiTe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxXemChiTietNhapNgoaiTe
            // 
            this.groupBoxXemChiTietNhapNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXemChiTietNhapNgoaiTe.Controls.Add(this.dateTimePickerNgayNhapNgoaiTe);
            this.groupBoxXemChiTietNhapNgoaiTe.Controls.Add(this.dataGridViewChiTietNhapNgoaiTe);
            this.groupBoxXemChiTietNhapNgoaiTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxXemChiTietNhapNgoaiTe.Location = new System.Drawing.Point(5, 12);
            this.groupBoxXemChiTietNhapNgoaiTe.Name = "groupBoxXemChiTietNhapNgoaiTe";
            this.groupBoxXemChiTietNhapNgoaiTe.Size = new System.Drawing.Size(656, 310);
            this.groupBoxXemChiTietNhapNgoaiTe.TabIndex = 15;
            this.groupBoxXemChiTietNhapNgoaiTe.TabStop = false;
            this.groupBoxXemChiTietNhapNgoaiTe.Text = "Chi Tiết";
            // 
            // dateTimePickerNgayNhapNgoaiTe
            // 
            this.dateTimePickerNgayNhapNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgayNhapNgoaiTe.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNgayNhapNgoaiTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayNhapNgoaiTe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayNhapNgoaiTe.Location = new System.Drawing.Point(17, 19);
            this.dateTimePickerNgayNhapNgoaiTe.Name = "dateTimePickerNgayNhapNgoaiTe";
            this.dateTimePickerNgayNhapNgoaiTe.Size = new System.Drawing.Size(123, 21);
            this.dateTimePickerNgayNhapNgoaiTe.TabIndex = 14;
            this.dateTimePickerNgayNhapNgoaiTe.ValueChanged += new System.EventHandler(this.dateTimePickerNgayNhapNgoaiTe_ValueChanged);
            // 
            // dataGridViewChiTietNhapNgoaiTe
            // 
            this.dataGridViewChiTietNhapNgoaiTe.AllowUserToAddRows = false;
            this.dataGridViewChiTietNhapNgoaiTe.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietNhapNgoaiTe.AllowUserToResizeColumns = false;
            this.dataGridViewChiTietNhapNgoaiTe.AllowUserToResizeRows = false;
            this.dataGridViewChiTietNhapNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewChiTietNhapNgoaiTe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTietNhapNgoaiTe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewChiTietNhapNgoaiTe.Location = new System.Drawing.Point(17, 46);
            this.dataGridViewChiTietNhapNgoaiTe.MultiSelect = false;
            this.dataGridViewChiTietNhapNgoaiTe.Name = "dataGridViewChiTietNhapNgoaiTe";
            this.dataGridViewChiTietNhapNgoaiTe.ReadOnly = true;
            this.dataGridViewChiTietNhapNgoaiTe.Size = new System.Drawing.Size(622, 258);
            this.dataGridViewChiTietNhapNgoaiTe.TabIndex = 13;
            this.dataGridViewChiTietNhapNgoaiTe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChiTietNhapNgoaiTe_CellDoubleClick);
            // 
            // ChiTietNhapNgoaiTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 334);
            this.Controls.Add(this.groupBoxXemChiTietNhapNgoaiTe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietNhapNgoaiTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Nhập Ngoại Tệ";
            this.Load += new System.EventHandler(this.ChiTietNhapNgoaiTe_Load);
            this.groupBoxXemChiTietNhapNgoaiTe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietNhapNgoaiTe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxXemChiTietNhapNgoaiTe;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhapNgoaiTe;
        private System.Windows.Forms.DataGridView dataGridViewChiTietNhapNgoaiTe;
    }
}