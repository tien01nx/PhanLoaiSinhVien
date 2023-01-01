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
    public partial class fChooseTeacher : Form
    {
        public string SubjectCode;
        public string TeacherCode;
        public string Choose;
        DataView table;

        public fChooseTeacher()
        {
            InitializeComponent();
        }

        private void LoadListTeacher()
        {
            table = TeacherDAO.Instance.LoadChoose(SubjectCode).DefaultView;
            dgvListTeacher.DataSource = table;
        }

        private void fChooseTeacher_Load(object sender, EventArgs e)
        {
            LoadListTeacher();
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
                table.RowFilter = "[" + cbColumn.Text + "]" + " Like '%" + tbSearch.Text + "%'";
                dgvListTeacher.DataSource = table;
            }
        }

        private void dgvListTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                Choose = dgvListTeacher.Rows[index].Cells[0].Value.ToString();
            }
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Choose))
            {
                MessageBox.Show("Chưa chọn giảng viên nào");
            }
            else
            {
                TeacherCode = Choose;
                this.Close();
            }
        }
    }
}
