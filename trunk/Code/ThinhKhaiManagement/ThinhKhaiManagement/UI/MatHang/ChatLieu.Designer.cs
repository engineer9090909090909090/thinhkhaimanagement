namespace ThinhKhaiManagement.UI.MatHang
{
    partial class ChatLieu
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
            this.textBoxKTDD = new System.Windows.Forms.TextBox();
            this.textBoxTCL = new System.Windows.Forms.TextBox();
            this.errorProviderChatLieu = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelKTDD = new System.Windows.Forms.Label();
            this.labelTenCL = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.dataGridViewCL = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChatLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLS
            // 
            this.buttonLS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLS.Location = new System.Drawing.Point(313, 44);
            this.buttonLS.Name = "buttonLS";
            this.buttonLS.Size = new System.Drawing.Size(75, 26);
            this.buttonLS.TabIndex = 13;
            this.buttonLS.Text = "Làm Sạch";
            this.buttonLS.UseVisualStyleBackColor = true;
            this.buttonLS.Click += new System.EventHandler(this.buttonLS_Click);
            // 
            // textBoxKTDD
            // 
            this.textBoxKTDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxKTDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKTDD.Location = new System.Drawing.Point(127, 48);
            this.textBoxKTDD.Name = "textBoxKTDD";
            this.textBoxKTDD.Size = new System.Drawing.Size(131, 22);
            this.textBoxKTDD.TabIndex = 12;
            // 
            // textBoxTCL
            // 
            this.textBoxTCL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTCL.Location = new System.Drawing.Point(127, 16);
            this.textBoxTCL.Name = "textBoxTCL";
            this.textBoxTCL.Size = new System.Drawing.Size(131, 22);
            this.textBoxTCL.TabIndex = 11;
            // 
            // errorProviderChatLieu
            // 
            this.errorProviderChatLieu.ContainerControl = this;
            // 
            // labelKTDD
            // 
            this.labelKTDD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKTDD.AutoSize = true;
            this.labelKTDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKTDD.Location = new System.Drawing.Point(27, 51);
            this.labelKTDD.Name = "labelKTDD";
            this.labelKTDD.Size = new System.Drawing.Size(96, 16);
            this.labelKTDD.TabIndex = 10;
            this.labelKTDD.Text = "Ký Tự Đại Diện";
            // 
            // labelTenCL
            // 
            this.labelTenCL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTenCL.AutoSize = true;
            this.labelTenCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenCL.Location = new System.Drawing.Point(27, 19);
            this.labelTenCL.Name = "labelTenCL";
            this.labelTenCL.Size = new System.Drawing.Size(90, 16);
            this.labelTenCL.TabIndex = 9;
            this.labelTenCL.Text = "Tên Chất Liệu";
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(313, 14);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 26);
            this.buttonLuu.TabIndex = 8;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // dataGridViewCL
            // 
            this.dataGridViewCL.AllowUserToAddRows = false;
            this.dataGridViewCL.AllowUserToDeleteRows = false;
            this.dataGridViewCL.AllowUserToResizeColumns = false;
            this.dataGridViewCL.AllowUserToResizeRows = false;
            this.dataGridViewCL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCL.Location = new System.Drawing.Point(19, 83);
            this.dataGridViewCL.Name = "dataGridViewCL";
            this.dataGridViewCL.ReadOnly = true;
            this.dataGridViewCL.Size = new System.Drawing.Size(378, 257);
            this.dataGridViewCL.TabIndex = 7;
            this.dataGridViewCL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCL_CellDoubleClick);
            // 
            // ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(416, 355);
            this.Controls.Add(this.buttonLS);
            this.Controls.Add(this.textBoxKTDD);
            this.Controls.Add(this.textBoxTCL);
            this.Controls.Add(this.labelKTDD);
            this.Controls.Add(this.labelTenCL);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.dataGridViewCL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chất Liệu";
            this.Load += new System.EventHandler(this.ChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderChatLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLS;
        private System.Windows.Forms.TextBox textBoxKTDD;
        private System.Windows.Forms.TextBox textBoxTCL;
        private System.Windows.Forms.ErrorProvider errorProviderChatLieu;
        private System.Windows.Forms.Label labelKTDD;
        private System.Windows.Forms.Label labelTenCL;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.DataGridView dataGridViewCL;
    }
}