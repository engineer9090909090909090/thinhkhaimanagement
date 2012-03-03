namespace ThinhKhaiManagement.UI.NgoaiTe
{
    partial class NgoaiTe
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewNT = new System.Windows.Forms.DataGridView();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.labelTenNT = new System.Windows.Forms.Label();
            this.labelGhiChu = new System.Windows.Forms.Label();
            this.textBoxTNT = new System.Windows.Forms.TextBox();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.errorProviderNgoaiTe = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonLS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNgoaiTe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNT
            // 
            this.dataGridViewNT.AllowUserToAddRows = false;
            this.dataGridViewNT.AllowUserToDeleteRows = false;
            this.dataGridViewNT.AllowUserToResizeColumns = false;
            this.dataGridViewNT.AllowUserToResizeRows = false;
            this.dataGridViewNT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewNT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNT.Location = new System.Drawing.Point(13, 84);
            this.dataGridViewNT.Name = "dataGridViewNT";
            this.dataGridViewNT.ReadOnly = true;
            this.dataGridViewNT.Size = new System.Drawing.Size(378, 257);
            this.dataGridViewNT.TabIndex = 0;
            this.dataGridViewNT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNT_CellDoubleClick);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(307, 15);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 26);
            this.buttonLuu.TabIndex = 1;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // labelTenNT
            // 
            this.labelTenNT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTenNT.AutoSize = true;
            this.labelTenNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNT.Location = new System.Drawing.Point(21, 20);
            this.labelTenNT.Name = "labelTenNT";
            this.labelTenNT.Size = new System.Drawing.Size(92, 16);
            this.labelTenNT.TabIndex = 2;
            this.labelTenNT.Text = "Tên Ngoại Tệ";
            // 
            // labelGhiChu
            // 
            this.labelGhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGhiChu.AutoSize = true;
            this.labelGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGhiChu.Location = new System.Drawing.Point(21, 52);
            this.labelGhiChu.Name = "labelGhiChu";
            this.labelGhiChu.Size = new System.Drawing.Size(54, 16);
            this.labelGhiChu.TabIndex = 3;
            this.labelGhiChu.Text = "Ghi Chú";
            // 
            // textBoxTNT
            // 
            this.textBoxTNT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTNT.Location = new System.Drawing.Point(121, 17);
            this.textBoxTNT.Name = "textBoxTNT";
            this.textBoxTNT.Size = new System.Drawing.Size(131, 22);
            this.textBoxTNT.TabIndex = 4;
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGhiChu.Location = new System.Drawing.Point(121, 49);
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(131, 22);
            this.textBoxGhiChu.TabIndex = 5;
            // 
            // errorProviderNgoaiTe
            // 
            this.errorProviderNgoaiTe.ContainerControl = this;
            // 
            // buttonLS
            // 
            this.buttonLS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLS.Location = new System.Drawing.Point(307, 45);
            this.buttonLS.Name = "buttonLS";
            this.buttonLS.Size = new System.Drawing.Size(75, 26);
            this.buttonLS.TabIndex = 6;
            this.buttonLS.Text = "Làm Sạch";
            this.buttonLS.UseVisualStyleBackColor = true;
            this.buttonLS.Click += new System.EventHandler(this.buttonLS_Click);
            // 
            // NgoaiTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 353);
            this.Controls.Add(this.buttonLS);
            this.Controls.Add(this.textBoxGhiChu);
            this.Controls.Add(this.textBoxTNT);
            this.Controls.Add(this.labelGhiChu);
            this.Controls.Add(this.labelTenNT);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.dataGridViewNT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NgoaiTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngoại Tệ";
            this.Load += new System.EventHandler(this.NgoaiTe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNgoaiTe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNT;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Label labelTenNT;
        private System.Windows.Forms.Label labelGhiChu;
        private System.Windows.Forms.TextBox textBoxTNT;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.ErrorProvider errorProviderNgoaiTe;
        private System.Windows.Forms.Button buttonLS;
    }
}