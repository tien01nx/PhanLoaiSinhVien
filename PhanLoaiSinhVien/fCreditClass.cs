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
    public partial class fCreditClass : Form
    {
        DataTable table;

        public fCreditClass()
        {
            InitializeComponent();
        }

        private void LoadListCreditClass()
        {
            table = CreditClassDAO.Instance.Load();
            dgvListCreditClass.DataSource = table;
        }

        private void fCreditClass_Load(object sender, EventArgs e)
        {
            /*dtpDateStart.MinDate = DateTime.Now.AddDays(2);
            dtpDateEnd.MinDate = DateTime.Now.AddDays(2);*/
            LoadListCreditClass();
        }

        private void dgvListCreditClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            erClassCode.SetError(tbClassCode, "");
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbClassCode.Enabled = false;
                tbClassCode.Text = dgvListCreditClass.Rows[index].Cells[0].Value.ToString();
                dtpDateStart.Text = dgvListCreditClass.Rows[index].Cells[1].Value.ToString();
                dtpDateEnd.Text = dgvListCreditClass.Rows[index].Cells[2].Value.ToString();
                tbTeacherCode.Text = dgvListCreditClass.Rows[index].Cells[3].Value.ToString();
                tbSubjectCode.Text = dgvListCreditClass.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void CancelText()
        {
            tbClassCode.Enabled = true;
            tbClassCode.Text = "";
            dtpDateStart.Text = "";
            dtpDateEnd.Text = "";
            tbSubjectCode.Text = "";
            tbTeacherCode.Text = "";
        }

        private void btCancelText_Click(object sender, EventArgs e)
        {
            CancelText();
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
            if (!CheckNullOrEmpty(tbClassCode, erClassCode))
                return false;

            if (!CheckDateEnd())
                return false;

            if (!CheckNullOrEmpty(tbSubjectCode, erSubjectCode))
                return false;

            if (!CheckNullOrEmpty(tbTeacherCode, erTeacherCode))
                return false;

            return true;
        }

        private bool CheckDateEnd()
        {
            if (dtpDateEnd.Value.DayOfYear <= dtpDateStart.Value.DayOfYear)
            {
                erEndDate.SetError(dtpDateEnd, "Ngày kết thúc phải lớn hơn ngày bắt đầu");
                dtpDateEnd.Focus();
                return false;
            }
            else
            {
                erEndDate.SetError(dtpDateEnd, "");
                return true;
            }
        }

        private void tbClassCode_Validating(object sender, CancelEventArgs e)
        {
            CheckNullOrEmpty(tbClassCode, erClassCode);
        }

        private void dtpDateEnd_Validating(object sender, CancelEventArgs e)
        {
            CheckDateEnd();
        }

        private void tbSubjectCode_Validating(object sender, CancelEventArgs e)
        {
            CheckNullOrEmpty(tbSubjectCode, erSubjectCode);
        }

        private void tbTeacherCode_Validating(object sender, CancelEventArgs e)
        {
            if(CheckNullOrEmpty(tbSubjectCode, erSubjectCode))
                CheckNullOrEmpty(tbTeacherCode, erTeacherCode);
        }

        private CreditClassDTO GetText()
        {
            CreditClassDTO obj = new CreditClassDTO();
            obj.ClassCode = tbClassCode.Text;
            obj.StartDate = dtpDateStart.Text;
            obj.EndDate = dtpDateEnd.Text;
            obj.SubjectCode = tbSubjectCode.Text;
            obj.TeacherCode = tbTeacherCode.Text;

            return obj;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                CreditClassDTO obj = GetText();

                bool ok = CreditClassDAO.Instance.Add(obj);
                if (ok)
                {
                    CancelText();
                    LoadListCreditClass();
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                CreditClassDTO obj = GetText();

                bool ok = CreditClassDAO.Instance.Edit(obj);
                if (ok)
                {
                    CancelText();
                    LoadListCreditClass();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (CheckNullOrEmpty(tbClassCode, erClassCode))
            {
                CreditClassDTO obj = GetText();

                bool ok = CreditClassDAO.Instance.Delete(obj);
                if (ok)
                {
                    CancelText();
                    LoadListCreditClass();
                }
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            CreditClassDAO.Instance.ExportExcel(dgvListCreditClass);
        }

        private void tbSubjectCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbSubjectCode_Click(object sender, EventArgs e)
        {
            ChooseSubject f = new ChooseSubject();
            f.ShowDialog();
            if (f.SubjectCode != null)
            {
                tbSubjectCode.Text = f.SubjectCode;
                tbTeacherCode.Text = "";
            }  
            f.Close();
        }

        private void tbTeacherCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbTeacherCode_Click(object sender, EventArgs e)
        {
            if (CheckNullOrEmpty(tbSubjectCode, erSubjectCode))
            {
                fChooseTeacher f = new fChooseTeacher();
                f.SubjectCode = tbSubjectCode.Text;
                f.ShowDialog();
                if (f.TeacherCode != null)
                    tbTeacherCode.Text = f.TeacherCode;
                f.Close();

                CheckNullOrEmpty(tbTeacherCode, erTeacherCode);
            }
        }
    }
}
