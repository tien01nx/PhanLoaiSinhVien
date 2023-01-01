using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4
{
    public partial class fArrangeSICC : Form // arrange student in Credit class
    {
        DataTable Class;
        DataView StudentRe;
        DataView StudentCl;

        private string CodeAdd;
        private string CodeDelete;
        private string CodeClass;

        /*DataGridViewRow RowAdd;
        DataGridViewRow RowDelete;*/

        DataRow RowAdd;
        DataRow RowDelete;


        public fArrangeSICC()
        {
            InitializeComponent();
            Class = CreditClassDAO.Instance.LoadClassNew();
        }

        private void cbSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSubject_Click(object sender, EventArgs e)
        {
            cbSubject.DroppedDown = true;
        }

        private void cbClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbClass_Click(object sender, EventArgs e)
        {
            cbClass.DroppedDown = true;
        }

        private void LoadSubject()
        {
            DataView sb = new DataView(Class);
            if (Class.Rows.Count > 0)
            {
                cbSubject.DataSource = sb.ToTable("Mon", true, Class.Columns[0].ColumnName.ToString(), Class.Columns[1].ColumnName.ToString());
                cbSubject.DisplayMember = Class.Columns[1].ColumnName.ToString();
                cbSubject.ValueMember = Class.Columns[0].ColumnName.ToString();
            }
        }

        private void LoadClass()
        {
            if (Class.Rows.Count > 0)
            {
                DataView sb = new DataView(Class);
                DataRowView row = (DataRowView)cbSubject.SelectedItem;
                sb.RowFilter = Class.Columns[0].ColumnName.ToString() + " Like '" + row[0] + "'";
                cbClass.DataSource = sb.ToTable("Lop", true, Class.Columns[2].ColumnName.ToString());
                cbClass.DisplayMember = Class.Columns[2].ColumnName.ToString();
                cbClass.ValueMember = Class.Columns[2].ColumnName.ToString();
            }
        }

        private void LoadStudentRegister()
        {
            if (Class.Rows.Count > 0)
            {
                DataRowView row = (DataRowView)cbSubject.SelectedItem;
                StudentRe = CreditClassDAO.Instance.LoadStudentRegister("" + row[0]).DefaultView;
                dgvRegister.DataSource = StudentRe;
            }
        }

        private void LoadStudentClass()
        {
            if (Class.Rows.Count > 0)
            {
                DataRowView row = (DataRowView)cbClass.SelectedItem;
                CodeClass = row[0].ToString();
                StudentCl = CreditClassDAO.Instance.LoadListStudentClass("" + row[0]).DefaultView;
                dgvClass.DataSource = StudentCl;
            }
        }

        private void fArrangeSICC_Load(object sender, EventArgs e)
        {
            LoadSubject();
            LoadClass();
            LoadStudentRegister();
            LoadStudentClass();
        }

        private void cbSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadClass();
            LoadStudentRegister();
            LoadStudentClass();
        }

        private void cbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadStudentClass();
        }

        private void cbColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbColumn_Click(object sender, EventArgs e)
        {
            cbColumn.DroppedDown = true;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Class.Rows.Count > 0)
                {
                    StudentRe.RowFilter = "[" + cbColumn.Text + "]" + " Like '%" + tbSearch.Text + "%'";
                    dgvRegister.DataSource = StudentRe;
                }
            }
        }

        private void tbLoadRegister_Click(object sender, EventArgs e)
        {
            LoadStudentRegister();
            tbSearch.Text = "";
            cbColumn.SelectedIndex = 0;
            CodeAdd = "";
        }

        private void btLoadClass_Click(object sender, EventArgs e)
        {
            LoadStudentClass();
            CodeDelete = "";
        }

        private void dgvRegister_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CodeAdd = dgvRegister.Rows[e.RowIndex].Cells[0].Value.ToString();
                /*RowAdd = dgvRegister.Rows[e.RowIndex];
                DataRow r = (dgvRegister.DataSource as DataTable).NewRow();
                r = ((DataRowView)dgvRegister.SelectedRows[e.RowIndex].DataBoundItem).Row;*/
                //RowAdd = ((DataRowView)dgvRegister.SelectedRows[e.RowIndex].DataBoundItem).Row;
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CodeDelete = dgvClass.Rows[e.RowIndex].Cells[0].Value.ToString();
                /*RowDelete = dgvClass.Rows[e.RowIndex];*/
                //RowDelete = ((DataRowView)dgvClass.SelectedRows[e.RowIndex].DataBoundItem).Row;
            }
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CodeAdd))
            {
                bool ok = CreditClassDAO.Instance.AddStudent(CodeAdd, CodeClass);
                if (ok)
                {
                    LoadStudentRegister();
                    LoadStudentClass();

                    // thêm và class
                    /*DataRowView newRow = StudentCl.AddNew();
                    newRow["Mã SV"] = RowAdd["Mã SV"];
                    newRow["Tên SV"] = RowAdd[1];
                    newRow["Giới tính"] = RowAdd[2];
                    newRow["Ngày sinh"] = RowAdd[3];
                    newRow["Mã lớp HC"] = RowAdd[4];
                    newRow.EndEdit();
                    StudentCl.Sort = "Mã SV";
                    dgvClass.DataSource = StudentCl;

                    // xóa khỏi register
                    int index = StudentRe.Table.Rows.IndexOf(RowAdd);
                    StudentRe.Delete(index);
                    dgvRegister.DataSource = StudentRe;*/

                    CodeAdd = null;
                }
            }
            else
                MessageBox.Show("Chọn sinh viên cân thêm.");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CodeDelete))
            {
                bool ok = CreditClassDAO.Instance.DeleteStudent(CodeDelete, CodeClass);
                if (ok)
                {
                    LoadStudentRegister();
                    LoadStudentClass();
                    CodeDelete = null;
                }
            }
            else
                MessageBox.Show("Chọn sinh viên cần hủy.");
        }

        private void btImportExcel_Click(object sender, EventArgs e)
        {
            fAddToCreditClass f = new fAddToCreditClass();
            f.ShowDialog();
            f.Close();

            LoadStudentClass();
            LoadStudentRegister();
        }

        private void btExportExcel_Click(object sender, EventArgs e)
        {
            CreditClassDAO.Instance.ExportExcelStudent(dgvClass, CodeClass);
        }
    }
}
