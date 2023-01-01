
namespace PhanLoaiSinhVien4
{
    partial class fCreditClass
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
            this.dgvListCreditClass = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbSubjectCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancelText = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbClassCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbTeacherCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.erClassCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.erStartDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.erEndDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.erSubjectCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.erTeacherCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCreditClass)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erClassCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erSubjectCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erTeacherCode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListCreditClass);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 535);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dgvListCreditClass
            // 
            this.dgvListCreditClass.AllowUserToAddRows = false;
            this.dgvListCreditClass.AllowUserToDeleteRows = false;
            this.dgvListCreditClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCreditClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCreditClass.Location = new System.Drawing.Point(6, 19);
            this.dgvListCreditClass.Name = "dgvListCreditClass";
            this.dgvListCreditClass.ReadOnly = true;
            this.dgvListCreditClass.RowHeadersVisible = false;
            this.dgvListCreditClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCreditClass.Size = new System.Drawing.Size(729, 510);
            this.dgvListCreditClass.TabIndex = 0;
            this.dgvListCreditClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCreditClass_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.btExport);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.btCancelText);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 535);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiển";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbSubjectCode);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 46);
            this.panel5.TabIndex = 4;
            // 
            // tbSubjectCode
            // 
            this.tbSubjectCode.Location = new System.Drawing.Point(3, 21);
            this.tbSubjectCode.Name = "tbSubjectCode";
            this.tbSubjectCode.Size = new System.Drawing.Size(229, 20);
            this.tbSubjectCode.TabIndex = 1;
            this.tbSubjectCode.Click += new System.EventHandler(this.tbSubjectCode_Click);
            this.tbSubjectCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSubjectCode_KeyPress);
            this.tbSubjectCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbSubjectCode_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã môn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpDateEnd);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 46);
            this.panel4.TabIndex = 3;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(3, 23);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(229, 20);
            this.dtpDateEnd.TabIndex = 1;
            this.dtpDateEnd.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDateEnd_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày kết thúc";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(9, 502);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 10;
            this.btExport.Text = "Xuất excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(163, 473);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(9, 473);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 8;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(163, 444);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancelText
            // 
            this.btCancelText.Location = new System.Drawing.Point(9, 444);
            this.btCancelText.Name = "btCancelText";
            this.btCancelText.Size = new System.Drawing.Size(75, 23);
            this.btCancelText.TabIndex = 6;
            this.btCancelText.Text = "Hủy nhập";
            this.btCancelText.UseVisualStyleBackColor = true;
            this.btCancelText.Click += new System.EventHandler(this.btCancelText_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpDateStart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 46);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbClassCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 46);
            this.panel1.TabIndex = 0;
            // 
            // tbClassCode
            // 
            this.tbClassCode.Location = new System.Drawing.Point(3, 21);
            this.tbClassCode.Name = "tbClassCode";
            this.tbClassCode.Size = new System.Drawing.Size(229, 20);
            this.tbClassCode.TabIndex = 1;
            this.tbClassCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbClassCode_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp tín chỉ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbTeacherCode);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 46);
            this.panel3.TabIndex = 5;
            // 
            // tbTeacherCode
            // 
            this.tbTeacherCode.Location = new System.Drawing.Point(3, 21);
            this.tbTeacherCode.Name = "tbTeacherCode";
            this.tbTeacherCode.Size = new System.Drawing.Size(229, 20);
            this.tbTeacherCode.TabIndex = 1;
            this.tbTeacherCode.Click += new System.EventHandler(this.tbTeacherCode_Click);
            this.tbTeacherCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTeacherCode_KeyPress);
            this.tbTeacherCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbTeacherCode_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã giảng viên";
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(3, 23);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(229, 20);
            this.dtpDateStart.TabIndex = 2;
            // 
            // erClassCode
            // 
            this.erClassCode.ContainerControl = this;
            // 
            // erStartDate
            // 
            this.erStartDate.ContainerControl = this;
            // 
            // erEndDate
            // 
            this.erEndDate.ContainerControl = this;
            // 
            // erSubjectCode
            // 
            this.erSubjectCode.ContainerControl = this;
            // 
            // erTeacherCode
            // 
            this.erTeacherCode.ContainerControl = this;
            // 
            // fCreditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fCreditClass";
            this.Text = "fCreditClass";
            this.Load += new System.EventHandler(this.fCreditClass_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCreditClass)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erClassCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erSubjectCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erTeacherCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListCreditClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbTeacherCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbSubjectCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancelText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbClassCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erClassCode;
        private System.Windows.Forms.ErrorProvider erStartDate;
        private System.Windows.Forms.ErrorProvider erEndDate;
        private System.Windows.Forms.ErrorProvider erSubjectCode;
        private System.Windows.Forms.ErrorProvider erTeacherCode;
    }
}