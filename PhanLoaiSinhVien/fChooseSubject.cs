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
    public partial class ChooseSubject : Form
    {
        public string SubjectCode;
        private string Choose;
        private DataView table;

        public ChooseSubject()
        {
            InitializeComponent();
        }

        public void LoadSubjectAll()
        {
            table = SubjectDAO.Instance.Load().DefaultView;
            dgvCSListTeacher.DataSource = table;
        }

        private void ChooseSubject_Load(object sender, EventArgs e)
        {
            LoadSubjectAll();
        }

        private void cbCSListColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbCSListColumn_Click(object sender, EventArgs e)
        {
            cbCSListColumn.DroppedDown = true;
        }

        private void LisSSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                table.RowFilter = "[" + cbCSListColumn.Text + "]" + " Like '%" + tbCSListSearch.Text + "%'";
                dgvCSListTeacher.DataSource = table;
            }
        }

        private void dgvCSListTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                Choose = dgvCSListTeacher.Rows[index].Cells[0].Value.ToString();
            }
        }

        private void btCSChoose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Choose))
            {
                MessageBox.Show("Chưa chọn môn!");
            }
            else
            {
                SubjectCode = Choose;
                this.Close();
            }
        }

    }
}
