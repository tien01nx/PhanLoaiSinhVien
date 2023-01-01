
namespace PhanLoaiSinhVien4
{
    partial class fChuyenNganh
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.cr = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbMang = new System.Windows.Forms.CheckBox();
            this.cbDPT = new System.Windows.Forms.CheckBox();
            this.cbCNPM = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataview);
            this.groupBox2.Controls.Add(this.cr);
            this.groupBox2.Location = new System.Drawing.Point(284, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 581);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dataview
            // 
            this.dataview.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(6, 19);
            this.dataview.Name = "dataview";
            this.dataview.RowHeadersVisible = false;
            this.dataview.Size = new System.Drawing.Size(766, 543);
            this.dataview.TabIndex = 1;
            // 
            // cr
            // 
            this.cr.ActiveViewIndex = -1;
            this.cr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr.Location = new System.Drawing.Point(6, 19);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(766, 543);
            this.cr.TabIndex = 0;
            this.cr.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 581);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiển";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.cbMang);
            this.panel6.Controls.Add(this.cbDPT);
            this.panel6.Controls.Add(this.cbCNPM);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(5, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 142);
            this.panel6.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbMang
            // 
            this.cbMang.AutoSize = true;
            this.cbMang.Location = new System.Drawing.Point(7, 78);
            this.cbMang.Name = "cbMang";
            this.cbMang.Size = new System.Drawing.Size(53, 17);
            this.cbMang.TabIndex = 3;
            this.cbMang.Text = "Mạng";
            this.cbMang.UseVisualStyleBackColor = true;
            // 
            // cbDPT
            // 
            this.cbDPT.AutoSize = true;
            this.cbDPT.Location = new System.Drawing.Point(7, 54);
            this.cbDPT.Name = "cbDPT";
            this.cbDPT.Size = new System.Drawing.Size(99, 17);
            this.cbDPT.TabIndex = 2;
            this.cbDPT.Text = "Đa phương tiện";
            this.cbDPT.UseVisualStyleBackColor = true;
            // 
            // cbCNPM
            // 
            this.cbCNPM.AutoSize = true;
            this.cbCNPM.Location = new System.Drawing.Point(7, 30);
            this.cbCNPM.Name = "cbCNPM";
            this.cbCNPM.Size = new System.Drawing.Size(130, 17);
            this.cbCNPM.TabIndex = 1;
            this.cbCNPM.Text = "Công nghệ phần mềm";
            this.cbCNPM.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lựa chọn chuyên ngành muốn chọn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lọc nâng cao";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fChuyenNganh";
            this.Text = "fChuyenNganh";
            this.Load += new System.EventHandler(this.fChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cbMang;
        private System.Windows.Forms.CheckBox cbDPT;
        private System.Windows.Forms.CheckBox cbCNPM;
        private System.Windows.Forms.Label label6;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Button button2;
    }
}