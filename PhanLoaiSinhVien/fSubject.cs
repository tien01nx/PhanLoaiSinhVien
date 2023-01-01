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
    public partial class fSubject : Form
    {
        DataTable table;

        public fSubject()
        {
            InitializeComponent();
        }

        private void fSubject_Load(object sender, EventArgs e)
        {
            LoadListStudent();
        }

        private void LoadListStudent()
        {
            table = SubjectDAO.Instance.Load();
            dgvListSubject.DataSource = table;
        }

        private void dgvListStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbCode.Enabled = false;
                tbCode.Text = dgvListSubject.Rows[index].Cells[0].Value.ToString();
                tbName.Text = dgvListSubject.Rows[index].Cells[1].Value.ToString();
                cbNumberCredit.Text = dgvListSubject.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void CancelText()
        {
            tbCode.Enabled = true;
            tbCode.Text = "";
            tbName.Text = "";
            cbNumberCredit.Text = "";
        }

        private void btCancelText_Click(object sender, EventArgs e)
        {
            CancelText();
        }

        private void cbNumberCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbNumberCredit_Click(object sender, EventArgs e)
        {
            if (CheckNullOrEmpty(tbCode, erCode) && CheckNullOrEmpty(tbName, erName))
            {
                cbNumberCredit.DroppedDown = true;
            }
        }

        private SubjectDTO GetText()
        {
            SubjectDTO obj = new SubjectDTO();
            obj.Code = tbCode.Text;
            obj.Name = tbName.Text;
            obj.NumberCredit = Int32.Parse(cbNumberCredit.Text);

            return obj;
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            SubjectDAO.Instance.ExportExcel(dgvListSubject);
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            CheckNullOrEmpty(tbCode, erCode);
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            CheckNullOrEmpty(tbName, erName);
        }

        private void cbNumberCredit_Validating(object sender, CancelEventArgs e)
        {
            CheckNullOrEmpty(cbNumberCredit, erNumberCredit);
        }

        bool CheckNullOrEmpty(Control control, ErrorProvider error)
        {
            if (String.IsNullOrEmpty(control.Text))
            {
                error.SetError(control, "Không bỏ trống");
                control.Focus();
                return false;
            }
            else
                error.SetError(control, "");

            return true;
        }

        private bool CheckInput()
        {
            return CheckNullOrEmpty(tbCode, erCode)
                && CheckNullOrEmpty(tbName, erName)
                && CheckNullOrEmpty(cbNumberCredit, erNumberCredit);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                SubjectDTO obj = GetText();

                bool ok = SubjectDAO.Instance.Add(obj);
                if (ok)
                {
                    CancelText();
                    LoadListStudent();
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                SubjectDTO obj = GetText();

                bool ok = SubjectDAO.Instance.Edit(obj);
                if (ok)
                {
                    CancelText();
                    LoadListStudent();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(CheckNullOrEmpty(tbCode, erCode)){
                SubjectDTO obj = GetText();

                bool ok = SubjectDAO.Instance.Delete(obj);
                if (ok)
                {
                    CancelText();
                    LoadListStudent();
                }
            }
        }
    }
}
