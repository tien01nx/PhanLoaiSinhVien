
namespace PhanLoaiSinhVien4
{
    partial class fAddToCreditClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOK = new System.Windows.Forms.Button();
            this.dgvListStudent = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.btChooseFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.dgvListStudent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbName);
            this.panel1.Controls.Add(this.cbCode);
            this.panel1.Controls.Add(this.btChooseFile);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 492);
            this.panel1.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(644, 12);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 17;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btIPOK_Click);
            // 
            // dgvListStudent
            // 
            this.dgvListStudent.AllowUserToAddRows = false;
            this.dgvListStudent.AllowUserToDeleteRows = false;
            this.dgvListStudent.AllowUserToResizeColumns = false;
            this.dgvListStudent.AllowUserToResizeRows = false;
            this.dgvListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudent.Location = new System.Drawing.Point(11, 121);
            this.dgvListStudent.Name = "dgvListStudent";
            this.dgvListStudent.ReadOnly = true;
            this.dgvListStudent.RowHeadersVisible = false;
            this.dgvListStudent.Size = new System.Drawing.Size(716, 367);
            this.dgvListStudent.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã lớp tín chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sinh viên";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(116, 80);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(88, 21);
            this.cbName.TabIndex = 3;
            this.cbName.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPName_DrawItem);
            this.cbName.SelectionChangeCommitted += new System.EventHandler(this.cbIPName_SelectionChangeCommitted);
            this.cbName.Click += new System.EventHandler(this.cbIPName_Click);
            this.cbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPName_KeyPress);
            // 
            // cbCode
            // 
            this.cbCode.FormattingEnabled = true;
            this.cbCode.Location = new System.Drawing.Point(11, 80);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(88, 21);
            this.cbCode.TabIndex = 2;
            this.cbCode.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPCode_DrawItem);
            this.cbCode.SelectionChangeCommitted += new System.EventHandler(this.cbIPCode_SelectionChangeCommitted);
            this.cbCode.Click += new System.EventHandler(this.cbIPCode_Click);
            this.cbCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPCode_KeyPress);
            // 
            // btChooseFile
            // 
            this.btChooseFile.AutoSize = true;
            this.btChooseFile.Location = new System.Drawing.Point(11, 10);
            this.btChooseFile.Name = "btChooseFile";
            this.btChooseFile.Size = new System.Drawing.Size(117, 23);
            this.btChooseFile.TabIndex = 0;
            this.btChooseFile.Text = "Chooe and Read File";
            this.btChooseFile.UseVisualStyleBackColor = true;
            this.btChooseFile.Click += new System.EventHandler(this.btIPChooseFile_Click);
            // 
            // fAddToCreditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 497);
            this.Controls.Add(this.panel1);
            this.Name = "fAddToCreditClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Thêm sinh viên bằng Excel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.DataGridView dgvListStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbCode;
        private System.Windows.Forms.Button btChooseFile;
    }
}