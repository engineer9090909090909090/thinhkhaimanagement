using ThinhKhaiManagement;

namespace ThinhKhaiManagement.UI.NgoaiTe
{
    partial class TonNgoaiTe
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
            this.labelNgayTonNgoaiTe = new System.Windows.Forms.Label();
            this.labelHeaderTồnNgoaiTe = new System.Windows.Forms.Label();
            this.dataGridViewTonNgoaiTe = new System.Windows.Forms.DataGridView();
            this.buttonCapNhatTonNgoaiTe = new System.Windows.Forms.Button();
            this.labelTGV = new System.Windows.Forms.Label();
            this.labelTongGiaVon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTonNgoaiTe)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNgayTonNgoaiTe
            // 
            this.labelNgayTonNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNgayTonNgoaiTe.AutoSize = true;
            this.labelNgayTonNgoaiTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTonNgoaiTe.ForeColor = System.Drawing.Color.Blue;
            this.labelNgayTonNgoaiTe.Location = new System.Drawing.Point(9, 13);
            this.labelNgayTonNgoaiTe.Name = "labelNgayTonNgoaiTe";
            this.labelNgayTonNgoaiTe.Size = new System.Drawing.Size(76, 15);
            this.labelNgayTonNgoaiTe.TabIndex = 2;
            this.labelNgayTonNgoaiTe.Text = "ngày hiện tại";
            // 
            // labelHeaderTồnNgoaiTe
            // 
            this.labelHeaderTồnNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeaderTồnNgoaiTe.AutoSize = true;
            this.labelHeaderTồnNgoaiTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderTồnNgoaiTe.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeaderTồnNgoaiTe.Location = new System.Drawing.Point(157, 38);
            this.labelHeaderTồnNgoaiTe.Name = "labelHeaderTồnNgoaiTe";
            this.labelHeaderTồnNgoaiTe.Size = new System.Drawing.Size(254, 31);
            this.labelHeaderTồnNgoaiTe.TabIndex = 3;
            this.labelHeaderTồnNgoaiTe.Text = "Phiếu Tồn Ngoại Tệ";
            // 
            // dataGridViewTonNgoaiTe
            // 
            this.dataGridViewTonNgoaiTe.AllowUserToAddRows = false;
            this.dataGridViewTonNgoaiTe.AllowUserToDeleteRows = false;
            this.dataGridViewTonNgoaiTe.AllowUserToResizeColumns = false;
            this.dataGridViewTonNgoaiTe.AllowUserToResizeRows = false;
            this.dataGridViewTonNgoaiTe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewTonNgoaiTe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTonNgoaiTe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTonNgoaiTe.Location = new System.Drawing.Point(12, 111);
            this.dataGridViewTonNgoaiTe.Name = "dataGridViewTonNgoaiTe";
            this.dataGridViewTonNgoaiTe.ReadOnly = true;
            this.dataGridViewTonNgoaiTe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTonNgoaiTe.Size = new System.Drawing.Size(547, 263);
            this.dataGridViewTonNgoaiTe.TabIndex = 4;
            this.dataGridViewTonNgoaiTe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTonNgoaiTe_CellDoubleClick);
            // 
            // buttonCapNhatTonNgoaiTe
            // 
            this.buttonCapNhatTonNgoaiTe.Location = new System.Drawing.Point(489, 36);
            this.buttonCapNhatTonNgoaiTe.Name = "buttonCapNhatTonNgoaiTe";
            this.buttonCapNhatTonNgoaiTe.Size = new System.Drawing.Size(75, 23);
            this.buttonCapNhatTonNgoaiTe.TabIndex = 5;
            this.buttonCapNhatTonNgoaiTe.Text = "Cập Nhật";
            this.buttonCapNhatTonNgoaiTe.UseVisualStyleBackColor = true;
            this.buttonCapNhatTonNgoaiTe.Click += new System.EventHandler(this.buttonCapNhatTonNgoaiTe_Click);
            // 
            // labelTGV
            // 
            this.labelTGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTGV.AutoSize = true;
            this.labelTGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTGV.ForeColor = System.Drawing.Color.Blue;
            this.labelTGV.Location = new System.Drawing.Point(271, 80);
            this.labelTGV.Name = "labelTGV";
            this.labelTGV.Size = new System.Drawing.Size(24, 16);
            this.labelTGV.TabIndex = 13;
            this.labelTGV.Text = "##";
            // 
            // labelTongGiaVon
            // 
            this.labelTongGiaVon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTongGiaVon.AutoSize = true;
            this.labelTongGiaVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongGiaVon.ForeColor = System.Drawing.Color.Maroon;
            this.labelTongGiaVon.Location = new System.Drawing.Point(12, 80);
            this.labelTongGiaVon.Name = "labelTongGiaVon";
            this.labelTongGiaVon.Size = new System.Drawing.Size(103, 16);
            this.labelTongGiaVon.TabIndex = 12;
            this.labelTongGiaVon.Text = "Tổng Giá Vốn";
            // 
            // TonNgoaiTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 387);
            this.Controls.Add(this.labelTGV);
            this.Controls.Add(this.labelTongGiaVon);
            this.Controls.Add(this.buttonCapNhatTonNgoaiTe);
            this.Controls.Add(this.dataGridViewTonNgoaiTe);
            this.Controls.Add(this.labelHeaderTồnNgoaiTe);
            this.Controls.Add(this.labelNgayTonNgoaiTe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TonNgoaiTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn Ngoại Tệ";
            this.Activated += new System.EventHandler(this.TonNgoaiTe_Activated);
            this.Load += new System.EventHandler(this.TonNgoaiTe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTonNgoaiTe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelHeaderTồnNgoaiTe;
        public System.Windows.Forms.DataGridView dataGridViewTonNgoaiTe;
        public System.Windows.Forms.Label labelNgayTonNgoaiTe;
        public System.Windows.Forms.Button buttonCapNhatTonNgoaiTe;
        public System.Windows.Forms.Label labelTGV;
        public System.Windows.Forms.Label labelTongGiaVon;



    }
}