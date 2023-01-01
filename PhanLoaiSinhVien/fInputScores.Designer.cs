
namespace PhanLoaiSinhVien4
{
    partial class fInputScores
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListStudent = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btImport = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbScores = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btCancelText = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbStudentCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbClassCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.erScores = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSubjectName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erScores)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListStudent);
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 535);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dgvListStudent
            // 
            this.dgvListStudent.AllowUserToAddRows = false;
            this.dgvListStudent.AllowUserToDeleteRows = false;
            this.dgvListStudent.AllowUserToResizeColumns = false;
            this.dgvListStudent.AllowUserToResizeRows = false;
            this.dgvListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudent.Location = new System.Drawing.Point(6, 19);
            this.dgvListStudent.Name = "dgvListStudent";
            this.dgvListStudent.ReadOnly = true;
            this.dgvListStudent.RowHeadersVisible = false;
            this.dgvListStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListStudent.Size = new System.Drawing.Size(729, 510);
            this.dgvListStudent.TabIndex = 0;
            this.dgvListStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListMainClass_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.btImport);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.btExport);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btCancelText);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 535);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiển";
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(160, 502);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(75, 23);
            this.btImport.TabIndex = 8;
            this.btImport.Text = "Thêm Excel";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbScores);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 46);
            this.panel5.TabIndex = 4;
            // 
            // tbScores
            // 
            this.tbScores.Location = new System.Drawing.Point(3, 21);
            this.tbScores.Name = "tbScores";
            this.tbScores.Size = new System.Drawing.Size(229, 20);
            this.tbScores.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(6, 502);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 7;
            this.btExport.Text = "Xuất excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(160, 473);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Cập nhập";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btCancelText
            // 
            this.btCancelText.Location = new System.Drawing.Point(6, 473);
            this.btCancelText.Name = "btCancelText";
            this.btCancelText.Size = new System.Drawing.Size(75, 23);
            this.btCancelText.TabIndex = 5;
            this.btCancelText.Text = "Hủy nhập";
            this.btCancelText.UseVisualStyleBackColor = true;
            this.btCancelText.Click += new System.EventHandler(this.btCancelText_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbStudentCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 46);
            this.panel2.TabIndex = 3;
            // 
            // tbStudentCode
            // 
            this.tbStudentCode.Enabled = false;
            this.tbStudentCode.Location = new System.Drawing.Point(3, 21);
            this.tbStudentCode.Name = "tbStudentCode";
            this.tbStudentCode.Size = new System.Drawing.Size(229, 20);
            this.tbStudentCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbClassCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 46);
            this.panel1.TabIndex = 2;
            // 
            // cbClassCode
            // 
            this.cbClassCode.FormattingEnabled = true;
            this.cbClassCode.Location = new System.Drawing.Point(3, 20);
            this.cbClassCode.Name = "cbClassCode";
            this.cbClassCode.Size = new System.Drawing.Size(229, 21);
            this.cbClassCode.TabIndex = 3;
            this.cbClassCode.SelectionChangeCommitted += new System.EventHandler(this.cbClassCode_SelectionChangeCommitted);
            this.cbClassCode.Click += new System.EventHandler(this.cbClassCode_Click);
            this.cbClassCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbClassCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp";
            // 
            // erScores
            // 
            this.erScores.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbSubjectName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 46);
            this.panel3.TabIndex = 1;
            // 
            // cbSubjectName
            // 
            this.cbSubjectName.FormattingEnabled = true;
            this.cbSubjectName.Location = new System.Drawing.Point(3, 20);
            this.cbSubjectName.Name = "cbSubjectName";
            this.cbSubjectName.Size = new System.Drawing.Size(229, 21);
            this.cbSubjectName.TabIndex = 3;
            this.cbSubjectName.SelectionChangeCommitted += new System.EventHandler(this.cbSubjectCode_SelectionChangeCommitted);
            this.cbSubjectName.Click += new System.EventHandler(this.cbSubjectCode_Click);
            this.cbSubjectName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSubjectCode_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Môn";
            // 
            // fInputScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fInputScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Nhập điểm";
            this.Load += new System.EventHandler(this.fInputScores_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erScores)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbScores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btCancelText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbStudentCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClassCode;
        private System.Windows.Forms.ErrorProvider erScores;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbSubjectName;
        private System.Windows.Forms.Label label3;
    }
}