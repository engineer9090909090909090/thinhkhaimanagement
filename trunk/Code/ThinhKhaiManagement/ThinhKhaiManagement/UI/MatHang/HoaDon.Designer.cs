namespace ThinhKhaiManagement.UI.MatHang
{
    partial class HoaDon
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
            this.crystalReportViewerHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerHoaDon
            // 
            this.crystalReportViewerHoaDon.ActiveViewIndex = -1;
            this.crystalReportViewerHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerHoaDon.Name = "crystalReportViewerHoaDon";
            this.crystalReportViewerHoaDon.Size = new System.Drawing.Size(616, 478);
            this.crystalReportViewerHoaDon.TabIndex = 0;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 478);
            this.Controls.Add(this.crystalReportViewerHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HoaDon";
            this.Text = "Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerHoaDon;
    }
}