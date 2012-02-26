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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxXemChiTietNhapNgoaiTe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxXemChiTietNhapNgoaiTe
            // 
            this.groupBoxXemChiTietNhapNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxXemChiTietNhapNgoaiTe.Controls.Add(this.dateTimePickerNgayNhapNgoaiTe);
            this.groupBoxXemChiTietNhapNgoaiTe.Controls.Add(this.dataGridView1);
            this.groupBoxXemChiTietNhapNgoaiTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxXemChiTietNhapNgoaiTe.Location = new System.Drawing.Point(8, 13);
            this.groupBoxXemChiTietNhapNgoaiTe.Name = "groupBoxXemChiTietNhapNgoaiTe";
            this.groupBoxXemChiTietNhapNgoaiTe.Size = new System.Drawing.Size(424, 250);
            this.groupBoxXemChiTietNhapNgoaiTe.TabIndex = 15;
            this.groupBoxXemChiTietNhapNgoaiTe.TabStop = false;
            this.groupBoxXemChiTietNhapNgoaiTe.Text = "Chi Tiết";
            // 
            // dateTimePickerNgayNhapNgoaiTe
            // 
            this.dateTimePickerNgayNhapNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerNgayNhapNgoaiTe.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerNgayNhapNgoaiTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayNhapNgoaiTe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayNhapNgoaiTe.Location = new System.Drawing.Point(18, 25);
            this.dateTimePickerNgayNhapNgoaiTe.Name = "dateTimePickerNgayNhapNgoaiTe";
            this.dateTimePickerNgayNhapNgoaiTe.Size = new System.Drawing.Size(108, 21);
            this.dateTimePickerNgayNhapNgoaiTe.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 182);
            this.dataGridView1.TabIndex = 13;
            // 
            // ChiTietNhapNgoaiTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 270);
            this.Controls.Add(this.groupBoxXemChiTietNhapNgoaiTe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChiTietNhapNgoaiTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Nhập Ngoại Tệ";
            this.groupBoxXemChiTietNhapNgoaiTe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxXemChiTietNhapNgoaiTe;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhapNgoaiTe;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}