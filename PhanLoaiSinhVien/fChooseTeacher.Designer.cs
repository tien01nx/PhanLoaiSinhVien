
namespace PhanLoaiSinhVien4
{
    partial class fChooseTeacher
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
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvListTeacher = new System.Windows.Forms.DataGridView();
            this.btChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // cbColumn
            // 
            this.cbColumn.FormattingEnabled = true;
            this.cbColumn.Items.AddRange(new object[] {
            "Mã giảng viên",
            "Tên giảng viên",
            "Giới tính"});
            this.cbColumn.Location = new System.Drawing.Point(2, 13);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(130, 21);
            this.cbColumn.TabIndex = 0;
            this.cbColumn.Text = "Mã giảng viên";
            this.cbColumn.Click += new System.EventHandler(this.cbColumn_Click);
            this.cbColumn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbColumn_KeyPress);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(158, 14);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(361, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // dgvListTeacher
            // 
            this.dgvListTeacher.AllowUserToAddRows = false;
            this.dgvListTeacher.AllowUserToDeleteRows = false;
            this.dgvListTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTeacher.Location = new System.Drawing.Point(2, 41);
            this.dgvListTeacher.Name = "dgvListTeacher";
            this.dgvListTeacher.ReadOnly = true;
            this.dgvListTeacher.RowHeadersVisible = false;
            this.dgvListTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTeacher.Size = new System.Drawing.Size(517, 256);
            this.dgvListTeacher.TabIndex = 2;
            this.dgvListTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTeacher_CellClick);
            // 
            // btChoose
            // 
            this.btChoose.Location = new System.Drawing.Point(412, 303);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(107, 23);
            this.btChoose.TabIndex = 3;
            this.btChoose.Text = "Chọn";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // fChooseTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 332);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.dgvListTeacher);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbColumn);
            this.Name = "fChooseTeacher";
            this.Text = "fChooseTeacher";
            this.Load += new System.EventHandler(this.fChooseTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvListTeacher;
        private System.Windows.Forms.Button btChoose;
    }
}