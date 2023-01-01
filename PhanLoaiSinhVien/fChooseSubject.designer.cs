
namespace PhanLoaiSinhVien4
{
    partial class ChooseSubject
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
            this.btCSChoose = new System.Windows.Forms.Button();
            this.cbCSListColumn = new System.Windows.Forms.ComboBox();
            this.tbCSListSearch = new System.Windows.Forms.TextBox();
            this.dgvCSListTeacher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSListTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // btCSChoose
            // 
            this.btCSChoose.Location = new System.Drawing.Point(314, 271);
            this.btCSChoose.Name = "btCSChoose";
            this.btCSChoose.Size = new System.Drawing.Size(107, 23);
            this.btCSChoose.TabIndex = 8;
            this.btCSChoose.Text = "Chọn";
            this.btCSChoose.UseVisualStyleBackColor = true;
            this.btCSChoose.Click += new System.EventHandler(this.btCSChoose_Click);
            // 
            // cbCSListColumn
            // 
            this.cbCSListColumn.FormattingEnabled = true;
            this.cbCSListColumn.Items.AddRange(new object[] {
            "Mã môn học",
            "Tên môn học"});
            this.cbCSListColumn.Location = new System.Drawing.Point(12, 12);
            this.cbCSListColumn.Name = "cbCSListColumn";
            this.cbCSListColumn.Size = new System.Drawing.Size(96, 21);
            this.cbCSListColumn.TabIndex = 5;
            this.cbCSListColumn.Text = "Mã môn học";
            this.cbCSListColumn.Click += new System.EventHandler(this.cbCSListColumn_Click);
            this.cbCSListColumn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCSListColumn_KeyPress);
            // 
            // tbCSListSearch
            // 
            this.tbCSListSearch.Location = new System.Drawing.Point(131, 13);
            this.tbCSListSearch.Name = "tbCSListSearch";
            this.tbCSListSearch.Size = new System.Drawing.Size(290, 20);
            this.tbCSListSearch.TabIndex = 6;
            this.tbCSListSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LisSSearch_KeyDown);
            // 
            // dgvCSListTeacher
            // 
            this.dgvCSListTeacher.AllowUserToAddRows = false;
            this.dgvCSListTeacher.AllowUserToDeleteRows = false;
            this.dgvCSListTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCSListTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSListTeacher.Location = new System.Drawing.Point(12, 46);
            this.dgvCSListTeacher.Name = "dgvCSListTeacher";
            this.dgvCSListTeacher.ReadOnly = true;
            this.dgvCSListTeacher.RowHeadersVisible = false;
            this.dgvCSListTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCSListTeacher.Size = new System.Drawing.Size(409, 211);
            this.dgvCSListTeacher.TabIndex = 7;
            this.dgvCSListTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCSListTeacher_CellClick);
            // 
            // ChooseSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 305);
            this.Controls.Add(this.btCSChoose);
            this.Controls.Add(this.cbCSListColumn);
            this.Controls.Add(this.tbCSListSearch);
            this.Controls.Add(this.dgvCSListTeacher);
            this.Name = "ChooseSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Chọn môn";
            this.Load += new System.EventHandler(this.ChooseSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSListTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCSChoose;
        private System.Windows.Forms.ComboBox cbCSListColumn;
        private System.Windows.Forms.TextBox tbCSListSearch;
        private System.Windows.Forms.DataGridView dgvCSListTeacher;
    }
}