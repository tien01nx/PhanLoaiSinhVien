
namespace PhanLoaiSinhVien4
{
    partial class fArrangeSICC
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
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            this.tbLoadRegister = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.tbAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btExportExcel = new System.Windows.Forms.Button();
            this.btImportExcel = new System.Windows.Forms.Button();
            this.btLoadClass = new System.Windows.Forms.Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSubject);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(255, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 29);
            this.panel1.TabIndex = 0;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(46, 4);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(151, 21);
            this.cbSubject.TabIndex = 1;
            this.cbSubject.SelectionChangeCommitted += new System.EventHandler(this.cbSubject_SelectionChangeCommitted);
            this.cbSubject.Click += new System.EventHandler(this.cbSubject_Click);
            this.cbSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSubject_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbClass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(573, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 29);
            this.panel2.TabIndex = 2;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(46, 4);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(151, 21);
            this.cbClass.TabIndex = 1;
            this.cbClass.SelectionChangeCommitted += new System.EventHandler(this.cbClass_SelectionChangeCommitted);
            this.cbClass.Click += new System.EventHandler(this.cbClass_Click);
            this.cbClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbClass_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRegister);
            this.groupBox1.Controls.Add(this.tbLoadRegister);
            this.groupBox1.Controls.Add(this.tbSearch);
            this.groupBox1.Controls.Add(this.cbColumn);
            this.groupBox1.Location = new System.Drawing.Point(2, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 469);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sinh viên có thể đăng ký môn";
            // 
            // dgvRegister
            // 
            this.dgvRegister.AllowUserToAddRows = false;
            this.dgvRegister.AllowUserToDeleteRows = false;
            this.dgvRegister.AllowUserToResizeColumns = false;
            this.dgvRegister.AllowUserToResizeRows = false;
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegister.Location = new System.Drawing.Point(7, 48);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.ReadOnly = true;
            this.dgvRegister.RowHeadersVisible = false;
            this.dgvRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegister.Size = new System.Drawing.Size(440, 415);
            this.dgvRegister.TabIndex = 3;
            this.dgvRegister.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegister_CellClick);
            // 
            // tbLoadRegister
            // 
            this.tbLoadRegister.Location = new System.Drawing.Point(372, 20);
            this.tbLoadRegister.Name = "tbLoadRegister";
            this.tbLoadRegister.Size = new System.Drawing.Size(75, 23);
            this.tbLoadRegister.TabIndex = 2;
            this.tbLoadRegister.Text = "Tải lại";
            this.tbLoadRegister.UseVisualStyleBackColor = true;
            this.tbLoadRegister.Click += new System.EventHandler(this.tbLoadRegister_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(130, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(231, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // cbColumn
            // 
            this.cbColumn.FormattingEnabled = true;
            this.cbColumn.Items.AddRange(new object[] {
            "Mã SV",
            "Tên SV",
            "Mã lớp HC"});
            this.cbColumn.Location = new System.Drawing.Point(7, 20);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(117, 21);
            this.cbColumn.TabIndex = 0;
            this.cbColumn.Text = "Mã SV";
            this.cbColumn.Click += new System.EventHandler(this.cbColumn_Click);
            this.cbColumn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbColumn_KeyPress);
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(476, 251);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(75, 23);
            this.tbAdd.TabIndex = 4;
            this.tbAdd.Text = ">>>";
            this.tbAdd.UseVisualStyleBackColor = true;
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(476, 315);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "<<<";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btExportExcel);
            this.groupBox2.Controls.Add(this.btImportExcel);
            this.groupBox2.Controls.Add(this.btLoadClass);
            this.groupBox2.Controls.Add(this.dgvClass);
            this.groupBox2.Location = new System.Drawing.Point(573, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 469);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sinh viên đang có của lớp";
            // 
            // btExportExcel
            // 
            this.btExportExcel.Location = new System.Drawing.Point(372, 21);
            this.btExportExcel.Name = "btExportExcel";
            this.btExportExcel.Size = new System.Drawing.Size(75, 23);
            this.btExportExcel.TabIndex = 2;
            this.btExportExcel.Text = "Xuất Excel";
            this.btExportExcel.UseVisualStyleBackColor = true;
            this.btExportExcel.Click += new System.EventHandler(this.btExportExcel_Click);
            // 
            // btImportExcel
            // 
            this.btImportExcel.Location = new System.Drawing.Point(93, 21);
            this.btImportExcel.Name = "btImportExcel";
            this.btImportExcel.Size = new System.Drawing.Size(75, 23);
            this.btImportExcel.TabIndex = 1;
            this.btImportExcel.Text = "Thêm Excel";
            this.btImportExcel.UseVisualStyleBackColor = true;
            this.btImportExcel.Click += new System.EventHandler(this.btImportExcel_Click);
            // 
            // btLoadClass
            // 
            this.btLoadClass.Location = new System.Drawing.Point(7, 21);
            this.btLoadClass.Name = "btLoadClass";
            this.btLoadClass.Size = new System.Drawing.Size(75, 23);
            this.btLoadClass.TabIndex = 0;
            this.btLoadClass.Text = "Tải lại";
            this.btLoadClass.UseVisualStyleBackColor = true;
            this.btLoadClass.Click += new System.EventHandler(this.btLoadClass_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AllowUserToResizeColumns = false;
            this.dgvClass.AllowUserToResizeRows = false;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(7, 48);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersVisible = false;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(440, 415);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);
            // 
            // fArrangeSICC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 548);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fArrangeSICC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fArrangeStudentToCreditClass";
            this.Load += new System.EventHandler(this.fArrangeSICC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRegister;
        private System.Windows.Forms.Button tbLoadRegister;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.Button tbAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btImportExcel;
        private System.Windows.Forms.Button btLoadClass;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Button btExportExcel;
    }
}