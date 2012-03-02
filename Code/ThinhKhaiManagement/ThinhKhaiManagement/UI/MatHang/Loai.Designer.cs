namespace ThinhKhaiManagement.UI.MatHang
{
    partial class Loai
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
            this.buttonLS = new System.Windows.Forms.Button();
            this.labelKTDD = new System.Windows.Forms.Label();
            this.labelTenLoai = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.textBoxLoai = new System.Windows.Forms.TextBox();
            this.errorProviderLoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxKTDD = new System.Windows.Forms.TextBox();
            this.dataGridViewLoai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLS
            // 
            this.buttonLS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLS.Location = new System.Drawing.Point(303, 39);
            this.buttonLS.Name = "buttonLS";
            this.buttonLS.Size = new System.Drawing.Size(75, 26);
            this.buttonLS.TabIndex = 20;
            this.buttonLS.Text = "Làm Sạch";
            this.buttonLS.UseVisualStyleBackColor = true;
            this.buttonLS.Click += new System.EventHandler(this.buttonLS_Click);
            // 
            // labelKTDD
            // 
            this.labelKTDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKTDD.AutoSize = true;
            this.labelKTDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKTDD.Location = new System.Drawing.Point(17, 46);
            this.labelKTDD.Name = "labelKTDD";
            this.labelKTDD.Size = new System.Drawing.Size(96, 16);
            this.labelKTDD.TabIndex = 17;
            this.labelKTDD.Text = "Ký Tự Đại Diện";
            // 
            // labelTenLoai
            // 
            this.labelTenLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTenLoai.AutoSize = true;
            this.labelTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenLoai.Location = new System.Drawing.Point(17, 14);
            this.labelTenLoai.Name = "labelTenLoai";
            this.labelTenLoai.Size = new System.Drawing.Size(61, 16);
            this.labelTenLoai.TabIndex = 16;
            this.labelTenLoai.Text = "Tên Loại";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(303, 9);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 26);
            this.buttonLuu.TabIndex = 15;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // textBoxLoai
            // 
            this.textBoxLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoai.Location = new System.Drawing.Point(129, 11);
            this.textBoxLoai.Name = "textBoxLoai";
            this.textBoxLoai.Size = new System.Drawing.Size(131, 22);
            this.textBoxLoai.TabIndex = 18;
            // 
            // errorProviderLoai
            // 
            this.errorProviderLoai.ContainerControl = this;
            // 
            // textBoxKTDD
            // 
            this.textBoxKTDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKTDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKTDD.Location = new System.Drawing.Point(129, 43);
            this.textBoxKTDD.Name = "textBoxKTDD";
            this.textBoxKTDD.Size = new System.Drawing.Size(131, 22);
            this.textBoxKTDD.TabIndex = 19;
            // 
            // dataGridViewLoai
            // 
            this.dataGridViewLoai.AllowUserToAddRows = false;
            this.dataGridViewLoai.AllowUserToDeleteRows = false;
            this.dataGridViewLoai.AllowUserToResizeColumns = false;
            this.dataGridViewLoai.AllowUserToResizeRows = false;
            this.dataGridViewLoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoai.Location = new System.Drawing.Point(9, 78);
            this.dataGridViewLoai.Name = "dataGridViewLoai";
            this.dataGridViewLoai.Size = new System.Drawing.Size(378, 257);
            this.dataGridViewLoai.TabIndex = 14;
            this.dataGridViewLoai.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoai_CellDoubleClick);
            // 
            // Loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 345);
            this.Controls.Add(this.buttonLS);
            this.Controls.Add(this.labelKTDD);
            this.Controls.Add(this.labelTenLoai);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.textBoxLoai);
            this.Controls.Add(this.textBoxKTDD);
            this.Controls.Add(this.dataGridViewLoai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại";
            this.Load += new System.EventHandler(this.Loai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLS;
        private System.Windows.Forms.Label labelKTDD;
        private System.Windows.Forms.Label labelTenLoai;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.TextBox textBoxLoai;
        private System.Windows.Forms.ErrorProvider errorProviderLoai;
        private System.Windows.Forms.TextBox textBoxKTDD;
        private System.Windows.Forms.DataGridView dataGridViewLoai;
    }
}