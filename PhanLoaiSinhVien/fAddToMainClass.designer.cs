
namespace PhanLoaiSinhVien4
{
    partial class fAddToMainClass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOk = new System.Windows.Forms.Button();
            this.dgvListStudent = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPhone = new System.Windows.Forms.ComboBox();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            this.cbBirthday = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.btChooseFile = new System.Windows.Forms.Button();
            this.erCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.erName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.erBirthday = new System.Windows.Forms.ErrorProvider(this.components);
            this.erEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.erPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.erClass = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Controls.Add(this.dgvListStudent);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbClass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbPhone);
            this.panel1.Controls.Add(this.cbEmail);
            this.panel1.Controls.Add(this.cbBirthday);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.cbName);
            this.panel1.Controls.Add(this.cbCode);
            this.panel1.Controls.Add(this.btChooseFile);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 492);
            this.panel1.TabIndex = 0;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(644, 12);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 17;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btIPOK_Click);
            // 
            // dgvListStudent
            // 
            this.dgvListStudent.AllowUserToAddRows = false;
            this.dgvListStudent.AllowUserToDeleteRows = false;
            this.dgvListStudent.AllowUserToResizeColumns = false;
            this.dgvListStudent.AllowUserToResizeRows = false;
            this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStudent.Location = new System.Drawing.Point(11, 121);
            this.dgvListStudent.Name = "dgvListStudent";
            this.dgvListStudent.ReadOnly = true;
            this.dgvListStudent.RowHeadersVisible = false;
            this.dgvListStudent.Size = new System.Drawing.Size(716, 367);
            this.dgvListStudent.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Lớp hành chính";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(639, 80);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(88, 21);
            this.cbClass.TabIndex = 14;
            this.cbClass.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPClass_DrawItem);
            this.cbClass.SelectionChangeCommitted += new System.EventHandler(this.cbIPClass_SelectionChangeCommitted);
            this.cbClass.Click += new System.EventHandler(this.cbIPClass_Click);
            this.cbClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPClass_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên sinh viên";
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
            // cbPhone
            // 
            this.cbPhone.FormattingEnabled = true;
            this.cbPhone.Location = new System.Drawing.Point(535, 80);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(88, 21);
            this.cbPhone.TabIndex = 7;
            this.cbPhone.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPPhone_DrawItem);
            this.cbPhone.SelectionChangeCommitted += new System.EventHandler(this.cbIPPhone_SelectionChangeCommitted);
            this.cbPhone.Click += new System.EventHandler(this.cbIPPhone_Click);
            this.cbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPPhone_KeyPress);
            // 
            // cbEmail
            // 
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Location = new System.Drawing.Point(431, 80);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(88, 21);
            this.cbEmail.TabIndex = 6;
            this.cbEmail.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPEmail_DrawItem);
            this.cbEmail.SelectionChangeCommitted += new System.EventHandler(this.cbIPEmail_SelectionChangeCommitted);
            this.cbEmail.Click += new System.EventHandler(this.cbIPEmail_Click);
            this.cbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPEmail_KeyPress);
            // 
            // cbBirthday
            // 
            this.cbBirthday.FormattingEnabled = true;
            this.cbBirthday.Location = new System.Drawing.Point(326, 80);
            this.cbBirthday.Name = "cbBirthday";
            this.cbBirthday.Size = new System.Drawing.Size(88, 21);
            this.cbBirthday.TabIndex = 5;
            this.cbBirthday.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPDate_DrawItem);
            this.cbBirthday.SelectionChangeCommitted += new System.EventHandler(this.cbIPDate_SelectionChangeCommitted);
            this.cbBirthday.Click += new System.EventHandler(this.cbIPDate_Click);
            this.cbBirthday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPDate_KeyPress);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(222, 80);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(88, 21);
            this.cbGender.TabIndex = 4;
            this.cbGender.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbIPSex_DrawItem);
            this.cbGender.SelectionChangeCommitted += new System.EventHandler(this.cbIPSex_SelectionChangeCommitted);
            this.cbGender.Click += new System.EventHandler(this.cbIPSex_Click);
            this.cbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIPSex_KeyPress);
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
            // erCode
            // 
            this.erCode.ContainerControl = this;
            // 
            // erName
            // 
            this.erName.ContainerControl = this;
            // 
            // erGender
            // 
            this.erGender.ContainerControl = this;
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
            // erClass
            // 
            this.erClass.ContainerControl = this;
            // 
            // ImportStudentByExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 498);
            this.Controls.Add(this.panel1);
            this.Name = "ImportStudentByExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sinh viên từ excel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btChooseFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhone;
        private System.Windows.Forms.ComboBox cbEmail;
        private System.Windows.Forms.ComboBox cbBirthday;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbCode;
        private System.Windows.Forms.DataGridView dgvListStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.ErrorProvider erCode;
        private System.Windows.Forms.ErrorProvider erName;
        private System.Windows.Forms.ErrorProvider erGender;
        private System.Windows.Forms.ErrorProvider erBirthday;
        private System.Windows.Forms.ErrorProvider erEmail;
        private System.Windows.Forms.ErrorProvider erPhone;
        private System.Windows.Forms.ErrorProvider erClass;
    }
}