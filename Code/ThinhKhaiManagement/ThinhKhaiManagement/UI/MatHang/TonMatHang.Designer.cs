namespace ThinhKhaiManagement.UI.MatHang
{
    partial class TonMatHang
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
            this.labelNgayTonMatHang = new System.Windows.Forms.Label();
            this.labelHeaderTonMatHang = new System.Windows.Forms.Label();
            this.dataGridViewXem = new System.Windows.Forms.DataGridView();
            this.groupBoxLoc = new System.Windows.Forms.GroupBox();
            this.labelTSL = new System.Windows.Forms.Label();
            this.comboBoxLoaiMatHang = new System.Windows.Forms.ComboBox();
            this.comboBoxChatLieu = new System.Windows.Forms.ComboBox();
            this.labelTongSoLuong = new System.Windows.Forms.Label();
            this.labelLoaiMatHang = new System.Windows.Forms.Label();
            this.labelChatLieu = new System.Windows.Forms.Label();
            this.buttonXemToanBo = new System.Windows.Forms.Button();
            this.buttonLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXem)).BeginInit();
            this.groupBoxLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNgayTonMatHang
            // 
            this.labelNgayTonMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNgayTonMatHang.AutoSize = true;
            this.labelNgayTonMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTonMatHang.ForeColor = System.Drawing.Color.Blue;
            this.labelNgayTonMatHang.Location = new System.Drawing.Point(12, 9);
            this.labelNgayTonMatHang.Name = "labelNgayTonMatHang";
            this.labelNgayTonMatHang.Size = new System.Drawing.Size(76, 15);
            this.labelNgayTonMatHang.TabIndex = 3;
            this.labelNgayTonMatHang.Text = "ngày hiện tại";
            // 
            // labelHeaderTonMatHang
            // 
            this.labelHeaderTonMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeaderTonMatHang.AutoSize = true;
            this.labelHeaderTonMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderTonMatHang.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeaderTonMatHang.Location = new System.Drawing.Point(247, 30);
            this.labelHeaderTonMatHang.Name = "labelHeaderTonMatHang";
            this.labelHeaderTonMatHang.Size = new System.Drawing.Size(261, 31);
            this.labelHeaderTonMatHang.TabIndex = 2;
            this.labelHeaderTonMatHang.Text = "Phiếu Tồn Mặt Hàng";
            // 
            // dataGridViewXem
            // 
            this.dataGridViewXem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewXem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXem.Location = new System.Drawing.Point(11, 226);
            this.dataGridViewXem.Name = "dataGridViewXem";
            this.dataGridViewXem.Size = new System.Drawing.Size(741, 293);
            this.dataGridViewXem.TabIndex = 4;
            // 
            // groupBoxLoc
            // 
            this.groupBoxLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxLoc.Controls.Add(this.buttonLoc);
            this.groupBoxLoc.Controls.Add(this.buttonXemToanBo);
            this.groupBoxLoc.Controls.Add(this.labelTSL);
            this.groupBoxLoc.Controls.Add(this.comboBoxLoaiMatHang);
            this.groupBoxLoc.Controls.Add(this.comboBoxChatLieu);
            this.groupBoxLoc.Controls.Add(this.labelTongSoLuong);
            this.groupBoxLoc.Controls.Add(this.labelLoaiMatHang);
            this.groupBoxLoc.Controls.Add(this.labelChatLieu);
            this.groupBoxLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoc.Location = new System.Drawing.Point(12, 80);
            this.groupBoxLoc.Name = "groupBoxLoc";
            this.groupBoxLoc.Size = new System.Drawing.Size(737, 140);
            this.groupBoxLoc.TabIndex = 5;
            this.groupBoxLoc.TabStop = false;
            this.groupBoxLoc.Text = "Lọc Theo Điều Kiện";
            // 
            // labelTSL
            // 
            this.labelTSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTSL.AutoSize = true;
            this.labelTSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTSL.ForeColor = System.Drawing.Color.Blue;
            this.labelTSL.Location = new System.Drawing.Point(380, 106);
            this.labelTSL.Name = "labelTSL";
            this.labelTSL.Size = new System.Drawing.Size(24, 16);
            this.labelTSL.TabIndex = 5;
            this.labelTSL.Text = "##";
            // 
            // comboBoxLoaiMatHang
            // 
            this.comboBoxLoaiMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxLoaiMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiMatHang.FormattingEnabled = true;
            this.comboBoxLoaiMatHang.Location = new System.Drawing.Point(237, 70);
            this.comboBoxLoaiMatHang.Name = "comboBoxLoaiMatHang";
            this.comboBoxLoaiMatHang.Size = new System.Drawing.Size(165, 24);
            this.comboBoxLoaiMatHang.TabIndex = 3;
            // 
            // comboBoxChatLieu
            // 
            this.comboBoxChatLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChatLieu.FormattingEnabled = true;
            this.comboBoxChatLieu.Location = new System.Drawing.Point(237, 31);
            this.comboBoxChatLieu.Name = "comboBoxChatLieu";
            this.comboBoxChatLieu.Size = new System.Drawing.Size(165, 24);
            this.comboBoxChatLieu.TabIndex = 2;
            // 
            // labelTongSoLuong
            // 
            this.labelTongSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTongSoLuong.AutoSize = true;
            this.labelTongSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongSoLuong.ForeColor = System.Drawing.Color.Maroon;
            this.labelTongSoLuong.Location = new System.Drawing.Point(94, 106);
            this.labelTongSoLuong.Name = "labelTongSoLuong";
            this.labelTongSoLuong.Size = new System.Drawing.Size(113, 16);
            this.labelTongSoLuong.TabIndex = 4;
            this.labelTongSoLuong.Text = "Tổng Số Lượng";
            // 
            // labelLoaiMatHang
            // 
            this.labelLoaiMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoaiMatHang.AutoSize = true;
            this.labelLoaiMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiMatHang.Location = new System.Drawing.Point(94, 73);
            this.labelLoaiMatHang.Name = "labelLoaiMatHang";
            this.labelLoaiMatHang.Size = new System.Drawing.Size(95, 16);
            this.labelLoaiMatHang.TabIndex = 1;
            this.labelLoaiMatHang.Text = "Loại Mặt Hàng";
            // 
            // labelChatLieu
            // 
            this.labelChatLieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChatLieu.AutoSize = true;
            this.labelChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChatLieu.Location = new System.Drawing.Point(94, 34);
            this.labelChatLieu.Name = "labelChatLieu";
            this.labelChatLieu.Size = new System.Drawing.Size(63, 16);
            this.labelChatLieu.TabIndex = 0;
            this.labelChatLieu.Text = "Chất Liệu";
            // 
            // buttonXemToanBo
            // 
            this.buttonXemToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemToanBo.Location = new System.Drawing.Point(565, 49);
            this.buttonXemToanBo.Name = "buttonXemToanBo";
            this.buttonXemToanBo.Size = new System.Drawing.Size(108, 28);
            this.buttonXemToanBo.TabIndex = 6;
            this.buttonXemToanBo.Text = "Xem Toàn Bộ";
            this.buttonXemToanBo.UseVisualStyleBackColor = true;
            this.buttonXemToanBo.Click += new System.EventHandler(this.buttonXemToanBo_Click);
            // 
            // buttonLoc
            // 
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(429, 49);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(130, 28);
            this.buttonLoc.TabIndex = 7;
            this.buttonLoc.Text = "Xem Theo Điều Kiện";
            this.buttonLoc.UseVisualStyleBackColor = true;
            this.buttonLoc.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // TonMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 531);
            this.Controls.Add(this.groupBoxLoc);
            this.Controls.Add(this.dataGridViewXem);
            this.Controls.Add(this.labelNgayTonMatHang);
            this.Controls.Add(this.labelHeaderTonMatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TonMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn Mặt Hàng";
            this.Load += new System.EventHandler(this.TonMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXem)).EndInit();
            this.groupBoxLoc.ResumeLayout(false);
            this.groupBoxLoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNgayTonMatHang;
        public System.Windows.Forms.Label labelHeaderTonMatHang;
        private System.Windows.Forms.DataGridView dataGridViewXem;
        private System.Windows.Forms.GroupBox groupBoxLoc;
        private System.Windows.Forms.Label labelTongSoLuong;
        private System.Windows.Forms.ComboBox comboBoxLoaiMatHang;
        private System.Windows.Forms.ComboBox comboBoxChatLieu;
        private System.Windows.Forms.Label labelLoaiMatHang;
        private System.Windows.Forms.Label labelChatLieu;
        private System.Windows.Forms.Label labelTSL;
        private System.Windows.Forms.Button buttonXemToanBo;
        private System.Windows.Forms.Button buttonLoc;
    }
}