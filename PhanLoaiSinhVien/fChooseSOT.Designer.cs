
namespace PhanLoaiSinhVien4
{
    partial class fChooseSOT
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
            this.dgvAllSubject = new System.Windows.Forms.DataGridView();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dgvSubjectOfTeacher = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectOfTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllSubject
            // 
            this.dgvAllSubject.AllowUserToAddRows = false;
            this.dgvAllSubject.AllowUserToDeleteRows = false;
            this.dgvAllSubject.AllowUserToResizeRows = false;
            this.dgvAllSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSubject.Location = new System.Drawing.Point(2, 39);
            this.dgvAllSubject.Name = "dgvAllSubject";
            this.dgvAllSubject.ReadOnly = true;
            this.dgvAllSubject.RowHeadersVisible = false;
            this.dgvAllSubject.Size = new System.Drawing.Size(281, 338);
            this.dgvAllSubject.TabIndex = 0;
            this.dgvAllSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllSubject_CellClick);
            // 
            // cbColumn
            // 
            this.cbColumn.FormattingEnabled = true;
            this.cbColumn.Items.AddRange(new object[] {
            "Mã môn",
            "Tên môn"});
            this.cbColumn.Location = new System.Drawing.Point(2, 12);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(74, 21);
            this.cbColumn.TabIndex = 1;
            this.cbColumn.Text = "Mã môn";
            this.cbColumn.Click += new System.EventHandler(this.cbColumn_Click);
            this.cbColumn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbColumn_KeyPress);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(82, 13);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(201, 20);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(289, 182);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = ">>>";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(289, 236);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "<<<";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dgvSubjectOfTeacher
            // 
            this.dgvSubjectOfTeacher.AllowUserToAddRows = false;
            this.dgvSubjectOfTeacher.AllowUserToDeleteRows = false;
            this.dgvSubjectOfTeacher.AllowUserToResizeRows = false;
            this.dgvSubjectOfTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjectOfTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectOfTeacher.Location = new System.Drawing.Point(370, 39);
            this.dgvSubjectOfTeacher.Name = "dgvSubjectOfTeacher";
            this.dgvSubjectOfTeacher.ReadOnly = true;
            this.dgvSubjectOfTeacher.RowHeadersVisible = false;
            this.dgvSubjectOfTeacher.Size = new System.Drawing.Size(281, 338);
            this.dgvSubjectOfTeacher.TabIndex = 5;
            this.dgvSubjectOfTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjectOfTeacher_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Môn của giảng viên";
            // 
            // fChooseSOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSubjectOfTeacher);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbColumn);
            this.Controls.Add(this.dgvAllSubject);
            this.Name = "fChooseSOT";
            this.Text = "fChooseSOT";
            this.Load += new System.EventHandler(this.fChooseSOT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectOfTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllSubject;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dgvSubjectOfTeacher;
        private System.Windows.Forms.Label label1;
    }
}