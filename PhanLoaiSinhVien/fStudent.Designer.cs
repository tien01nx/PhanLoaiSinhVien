
namespace PhanLoaiSinhVien4
{
    partial class fStudent
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.btMainClass = new System.Windows.Forms.Button();
            this.cbMainClass = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancelText = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.erMainClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.erCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.erName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erBirthday = new System.Windows.Forms.ErrorProvider(this.components);
            this.erEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erMainClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListStudent);
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 535);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dgvListStudent
            // 
            this.dgvListStudent.AllowUserToAddRows = false;
            this.dgvListStudent.AllowUserToDeleteRows = false;
            this.dgvListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudent.Location = new System.Drawing.Point(6, 19);
            this.dgvListStudent.Name = "dgvListStudent";
            this.dgvListStudent.ReadOnly = true;
            this.dgvListStudent.RowHeadersVisible = false;
            this.dgvListStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListStudent.Size = new System.Drawing.Size(729, 510);
            this.dgvListStudent.TabIndex = 0;
            this.dgvListStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStudent_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btImport);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.btExport);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.btCancelText);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 535);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiển";
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(163, 501);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(75, 23);
            this.btImport.TabIndex = 12;
            this.btImport.Text = "Thêm excel";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btMainClass);
            this.panel7.Controls.Add(this.cbMainClass);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(6, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 46);
            this.panel7.TabIndex = 0;
            // 
            // btMainClass
            // 
            this.btMainClass.Location = new System.Drawing.Point(167, 20);
            this.btMainClass.Name = "btMainClass";
            this.btMainClass.Size = new System.Drawing.Size(65, 23);
            this.btMainClass.TabIndex = 2;
            this.btMainClass.Text = "Thêm";
            this.btMainClass.UseVisualStyleBackColor = true;
            // 
            // cbMainClass
            // 
            this.cbMainClass.FormattingEnabled = true;
            this.cbMainClass.Location = new System.Drawing.Point(3, 21);
            this.cbMainClass.Name = "cbMainClass";
            this.cbMainClass.Size = new System.Drawing.Size(158, 21);
            this.cbMainClass.TabIndex = 1;
            this.cbMainClass.SelectedIndexChanged += new System.EventHandler(this.cbMainClass_SelectionChangeCommitted);
            this.cbMainClass.SelectionChangeCommitted += new System.EventHandler(this.cbMainClass_SelectionChangeCommitted);
            this.cbMainClass.Click += new System.EventHandler(this.cbMainClass_Click);
            this.cbMainClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMainClass_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã lớp hành chính";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbPhone);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(6, 331);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 46);
            this.panel6.TabIndex = 6;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(3, 21);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(229, 20);
            this.tbPhone.TabIndex = 1;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbEmail);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 279);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 46);
            this.panel5.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(3, 21);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(229, 20);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpBirthday);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 46);
            this.panel4.TabIndex = 4;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(3, 23);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(229, 20);
            this.dtpBirthday.TabIndex = 1;
            this.dtpBirthday.Validating += new System.ComponentModel.CancelEventHandler(this.dtpBirthday_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(9, 502);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 11;
            this.btExport.Text = "Xuất excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(163, 473);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(9, 473);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 9;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(163, 444);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancelText
            // 
            this.btCancelText.Location = new System.Drawing.Point(9, 444);
            this.btCancelText.Name = "btCancelText";
            this.btCancelText.Size = new System.Drawing.Size(75, 23);
            this.btCancelText.TabIndex = 7;
            this.btCancelText.Text = "Hủy nhập";
            this.btCancelText.UseVisualStyleBackColor = true;
            this.btCancelText.Click += new System.EventHandler(this.btCancelText_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdFemale);
            this.panel3.Controls.Add(this.rdMale);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 46);
            this.panel3.TabIndex = 3;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Checked = true;
            this.rdFemale.Location = new System.Drawing.Point(81, 26);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(39, 17);
            this.rdFemale.TabIndex = 2;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(3, 26);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(47, 17);
            this.rdMale.TabIndex = 1;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 46);
            this.panel2.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(229, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sinh viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 46);
            this.panel1.TabIndex = 1;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(3, 21);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(229, 20);
            this.tbCode.TabIndex = 1;
            this.tbCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbCode_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // erMainClass
            // 
            this.erMainClass.ContainerControl = this;
            // 
            // erCode
            // 
            this.erCode.ContainerControl = this;
            // 
            // erName
            // 
            this.erName.ContainerControl = this;
            // 
            // erBirthday
            // 
            this.erBirthday.ContainerControl = this;
            // 
            // erEmail
            // 
            this.erEmail.ContainerControl = this;
            // 
            // erPhone
            // 
            this.erPhone.ContainerControl = this;
            // 
            // fStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Sinh viên";
            this.Load += new System.EventHandler(this.fStudent_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erMainClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancelText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMainClass;
        private System.Windows.Forms.Button btMainClass;
        private System.Windows.Forms.ErrorProvider erMainClass;
        private System.Windows.Forms.ErrorProvider erCode;
        private System.Windows.Forms.ErrorProvider erName;
        private System.Windows.Forms.ErrorProvider erBirthday;
        private System.Windows.Forms.ErrorProvider erEmail;
        private System.Windows.Forms.ErrorProvider erPhone;
    }
}