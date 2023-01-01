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
    public partial class fChooseSOT : Form // choose subject of teacher
    {
        public string TeacherCode;
        DataView SubjectAll;
        DataView SubjectTeacher;
        string Add;
        string Delete;

        public fChooseSOT() 
        {
            InitializeComponent();
        }

        private void LoadSubjectAll()
        {
            SubjectAll = TeacherDAO.Instance.LoadSubjectAll(TeacherCode).DefaultView;
            dgvAllSubject.DataSource = SubjectAll;
        }

        private void LoadSubjectTeacher()
        {
            SubjectTeacher = TeacherDAO.Instance.LoadSubjectTeacher(TeacherCode).DefaultView;
            dgvSubjectOfTeacher.DataSource = SubjectTeacher;
        }

        private void fChooseSOT_Load(object sender, EventArgs e)
        {
            LoadSubjectAll();
            LoadSubjectTeacher();
        }

        private void dgvAllSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Add = dgvAllSubject.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dgvSubjectOfTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Delete = dgvSubjectOfTeacher.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Add))
            {
                
                
                bool ok = TeacherDAO.Instance.AddSubject(Add,TeacherCode);
                if (ok)
                {
                    LoadSubjectAll();
                    LoadSubjectTeacher();
                    Add = null;
                }
            }
            else
                MessageBox.Show("Chọn môn trước.");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Delete))
            {


                bool ok = TeacherDAO.Instance.DeleteSubject(Delete, TeacherCode);
                if (ok)
                {
                    LoadSubjectAll();
                    LoadSubjectTeacher();
                    Delete = null;
                }
            }
            else
                MessageBox.Show("Chọn môn trước.");
        }

        private void cbColumn_Click(object sender, EventArgs e)
        {
            cbColumn.DroppedDown = true;
        }

        private void cbColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubjectAll.RowFilter = "[" + cbColumn.Text + "] Like '%" + tbSearch.Text + "%'";
                dgvAllSubject.DataSource = SubjectAll;
            }
        }
    }
}
