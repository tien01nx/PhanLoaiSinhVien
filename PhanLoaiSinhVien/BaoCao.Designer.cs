
namespace PhanLoaiSinhVien4
{
    partial class BaoCao
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
            this.cr = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cr
            // 
            this.cr.ActiveViewIndex = -1;
            this.cr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr.Location = new System.Drawing.Point(0, 0);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(800, 450);
            this.cr.TabIndex = 0;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cr);
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr;
    }
}