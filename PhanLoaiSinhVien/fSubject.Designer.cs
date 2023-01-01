
namespace PhanLoaiSinhVien4
{
    partial class fSubject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btExport = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCancelText = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbNumberCredit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListSubject = new System.Windows.Forms.DataGridView();
            this.erCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.erName = new System.Windows.Forms.ErrorProvider(this.components);
            this.erNumberCredit = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erNumberCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btExport);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.btCancelText);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiển";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(9, 502);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 23);
            this.btExport.TabIndex = 7;
            this.btExport.Text = "Xuất excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(163, 473);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(9, 473);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(163, 444);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCancelText
            // 
            this.btCancelText.Location = new System.Drawing.Point(9, 444);
            this.btCancelText.Name = "btCancelText";
            this.btCancelText.Size = new System.Drawing.Size(75, 23);
            this.btCancelText.TabIndex = 3;
            this.btCancelText.Text = "Hủy nhập";
            this.btCancelText.UseVisualStyleBackColor = true;
            this.btCancelText.Click += new System.EventHandler(this.btCancelText_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbNumberCredit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 46);
            this.panel3.TabIndex = 2;
            // 
            // cbNumberCredit
            // 
            this.cbNumberCredit.FormattingEnabled = true;
            this.cbNumberCredit.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbNumberCredit.Location = new System.Drawing.Point(3, 20);
            this.cbNumberCredit.Name = "cbNumberCredit";
            this.cbNumberCredit.Size = new System.Drawing.Size(229, 21);
            this.cbNumberCredit.TabIndex = 1;
            this.cbNumberCredit.Click += new System.EventHandler(this.cbNumberCredit_Click);
            this.cbNumberCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNumberCredit_KeyPress);
            this.cbNumberCredit.Validating += new System.ComponentModel.CancelEventHandler(this.cbNumberCredit_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tín chỉ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 46);
            this.panel2.TabIndex = 1;
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
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên môn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 46);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListSubject);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 535);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dgvListSubject
            // 
            this.dgvListSubject.AllowUserToAddRows = false;
            this.dgvListSubject.AllowUserToDeleteRows = false;
            this.dgvListSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSubject.Location = new System.Drawing.Point(6, 19);
            this.dgvListSubject.Name = "dgvListSubject";
            this.dgvListSubject.ReadOnly = true;
            this.dgvListSubject.RowHeadersVisible = false;
            this.dgvListSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSubject.Size = new System.Drawing.Size(661, 510);
            this.dgvListSubject.TabIndex = 0;
            this.dgvListSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStudent_CellClick);
            // 
            // erCode
            // 
            this.erCode.ContainerControl = this;
            // 
            // erName
            // 
            this.erName.ContainerControl = this;
            // 
            // erNumberCredit
            // 
            this.erNumberCredit.ContainerControl = this;
            // 
            // fSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Môn";
            this.Load += new System.EventHandler(this.fSubject_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erNumberCredit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancelText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListSubject;
        private System.Windows.Forms.ComboBox cbNumberCredit;
        private System.Windows.Forms.ErrorProvider erCode;
        private System.Windows.Forms.ErrorProvider erName;
        private System.Windows.Forms.ErrorProvider erNumberCredit;
    }
}