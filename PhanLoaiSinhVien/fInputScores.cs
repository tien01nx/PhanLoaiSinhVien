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
    public partial class fInputScores : Form
    {
        DataTable table;
        DataTable AllClass;

        public fInputScores()
        {
            InitializeComponent();
            AllClass = CreditClassDAO.Instance.LoadClassNew();
        }

        private void LoadSubject()
        {
            DataView sb = new DataView(AllClass);
            if (AllClass.Rows.Count > 0)
            {
                cbSubjectName.DataSource = sb.ToTable("Mon", true, AllClass.Columns[0].ColumnName.ToString(), AllClass.Columns[1].ColumnName.ToString());
                cbSubjectName.DisplayMember = AllClass.Columns[1].ColumnName.ToString();
                cbSubjectName.ValueMember = AllClass.Columns[0].ColumnName.ToString();
            }
        }

        private void LoadClass()
        {
            if (AllClass.Rows.Count > 0)
            {
                DataView sb = new DataView(AllClass);
                DataRowView row = (DataRowView)cbSubjectName.SelectedItem;
                sb.RowFilter = AllClass.Columns[0].ColumnName.ToString() + " Like '" + row[0] + "'";
                cbClassCode.DataSource = sb.ToTable("Lop", true, AllClass.Columns[2].ColumnName.ToString());
                cbClassCode.DisplayMember = AllClass.Columns[2].ColumnName.ToString();
                cbClassCode.ValueMember = AllClass.Columns[2].ColumnName.ToString();
            }
        }

        private void LoadListStudent()
        {
            if (cbClassCode.Items.Count > 0)
            {
                DataRowView row = (DataRowView)cbClassCode.SelectedItem;
                table = ImputScoresDAO.Instance.Load(""+row[0]);
                dgvListStudent.DataSource = table;
            }
        }

        private void fInputScores_Load(object sender, EventArgs e)
        {
            LoadSubject();
            LoadClass();
            LoadListStudent();
        }

        private void cbClassCode_Click(object sender, EventArgs e)
        {
            cbClassCode.DroppedDown = true;
        }

        private void cbClassCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSubjectCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSubjectCode_Click(object sender, EventArgs e)
        {
            cbSubjectName.DroppedDown = true;
        }

        private void cbSubjectCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadClass();
            LoadListStudent();
        }

        private void cbClassCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadListStudent();
        }

        private void dgvListMainClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                erScores.SetError(tbScores, "");
                tbStudentCode.Text = dgvListStudent.Rows[index].Cells[0].Value.ToString();
                tbScores.Text = dgvListStudent.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void CancelText()
        {
            tbStudentCode.Text = "";
            tbScores.Text = "";
        }

        private void btCancelText_Click(object sender, EventArgs e)
        {
            CancelText();
        }

        private bool CheckImput(out float diem)
        {
            if (string.IsNullOrEmpty(tbStudentCode.Text))
            {
                MessageBox.Show("Chọn sinh viên");
                diem = 0;
                return false;
            }

            if (float.TryParse(tbScores.Text, out diem))
            {
                if(diem < 0 || diem > 10)
                {
                    erScores.SetError(tbScores, "Không phải điểm");
                    return false;
                }
                diem = (float) Math.Round(diem, 2);
                erScores.SetError(tbScores, "");
            }
            else
            {
                erScores.SetError(tbScores, "Không phải số");
                tbScores.Focus();
                return false;
            }

            return true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            float diem;
            if (CheckImput(out diem))
            {
                DataRowView row = (DataRowView)cbClassCode.SelectedItem;
                bool ok = ImputScoresDAO.Instance.Edit(""+row[0], tbStudentCode.Text, diem);
                if (ok)
                {
                    CancelText();
                    LoadListStudent();
                }
            }
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbClassCode.SelectedItem;
            fUpdateScores f = new fUpdateScores(""+row[0]);
            f.ShowDialog();
            f.Close();

            LoadListStudent();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            ImputScoresDAO.Instance.ExportExcel(dgvListStudent);
        }

    }
}
