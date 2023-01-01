
namespace PhanLoaiSinhVien4
{
    partial class BaoCaoDiem
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
            this.gbDiemLHP = new System.Windows.Forms.GroupBox();
            this.btnInDiemLHP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLHP = new System.Windows.Forms.ComboBox();
            this.btnBCDiemLopHocPhan = new System.Windows.Forms.Button();
            this.gbDiemLHP.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDiemLHP
            // 
            this.gbDiemLHP.Controls.Add(this.btnInDiemLHP);
            this.gbDiemLHP.Controls.Add(this.label4);
            this.gbDiemLHP.Controls.Add(this.txtMaLHP);
            this.gbDiemLHP.Location = new System.Drawing.Point(29, 43);
            this.gbDiemLHP.Margin = new System.Windows.Forms.Padding(2);
            this.gbDiemLHP.Name = "gbDiemLHP";
            this.gbDiemLHP.Padding = new System.Windows.Forms.Padding(2);
            this.gbDiemLHP.Size = new System.Drawing.Size(215, 193);
            this.gbDiemLHP.TabIndex = 6;
            this.gbDiemLHP.TabStop = false;
            this.gbDiemLHP.Text = "Điều Kiện";
            // 
            // btnInDiemLHP
            // 
            this.btnInDiemLHP.Location = new System.Drawing.Point(62, 124);
            this.btnInDiemLHP.Margin = new System.Windows.Forms.Padding(2);
            this.btnInDiemLHP.Name = "btnInDiemLHP";
            this.btnInDiemLHP.Size = new System.Drawing.Size(83, 24);
            this.btnInDiemLHP.TabIndex = 3;
            this.btnInDiemLHP.Text = "In Báo Cáo";
            this.btnInDiemLHP.UseVisualStyleBackColor = true;
            this.btnInDiemLHP.Click += new System.EventHandler(this.btnInDiemLHP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp Học Phần";
            // 
            // txtMaLHP
            // 
            this.txtMaLHP.FormattingEnabled = true;
            this.txtMaLHP.Items.AddRange(new object[] {
            ""});
            this.txtMaLHP.Location = new System.Drawing.Point(104, 79);
            this.txtMaLHP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLHP.Name = "txtMaLHP";
            this.txtMaLHP.Size = new System.Drawing.Size(96, 21);
            this.txtMaLHP.TabIndex = 2;
            // 
            // btnBCDiemLopHocPhan
            // 
            this.btnBCDiemLopHocPhan.Location = new System.Drawing.Point(28, 13);
            this.btnBCDiemLopHocPhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnBCDiemLopHocPhan.Name = "btnBCDiemLopHocPhan";
            this.btnBCDiemLopHocPhan.Size = new System.Drawing.Size(216, 24);
            this.btnBCDiemLopHocPhan.TabIndex = 5;
            this.btnBCDiemLopHocPhan.Text = "Báo Cáo Điểm theo Lớp Học Phần";
            this.btnBCDiemLopHocPhan.UseVisualStyleBackColor = true;
            // 
            // BaoCaoDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 247);
            this.Controls.Add(this.gbDiemLHP);
            this.Controls.Add(this.btnBCDiemLopHocPhan);
            this.Name = "BaoCaoDiem";
            this.Text = "BaoCaoDiem";
            this.Load += new System.EventHandler(this.BaoCaoDiem_Load);
            this.gbDiemLHP.ResumeLayout(false);
            this.gbDiemLHP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDiemLHP;
        private System.Windows.Forms.Button btnInDiemLHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtMaLHP;
        private System.Windows.Forms.Button btnBCDiemLopHocPhan;
    }
}