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
    public partial class fMainClass : Form
    {
        DataTable table;

        public fMainClass()
        {
            InitializeComponent();
        }

        private void LoadListMainClass()
        {
            table = MainClassDAO.Instance.Load();
            dgvListMainClass.DataSource = table;
        }

        private void fMainClass_Load(object sender, EventArgs e)
        {
            LoadListMainClass();
        }

        private void dgvListMainClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            erCode.SetError(tbCode, "");
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbCode.Enabled = false;
                tbCode.Text = dgvListMainClass.Rows[index].Cells[0].Value.ToString();
                tbName.Text = dgvListMainClass.Rows[index].Cells[1].Value.ToString();
                dtpDateCreate.Text = dgvListMainClass.Rows[index].Cells[2].Value.ToString();
                tbTeacherCode.Text = dgvListMainClass.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void CancelText()
        {
            tbCode.Enabled = true;
            tbCode.Text = "";
            tbName.Text = "";
            dtpDateCreate.Text = "";
            tbTeacherCode.Text = "";
        }

        private void btCancelText_Click(object sender, EventArgs e)
        {
            CancelText();
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            CheckNullOrEmpty(tbCode, erCode);
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            CheckNullOrEmpty(tbName, erName);
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
                && CheckNullOrEmpty(tbTeacherCode, erTeacherCode);
        }

        private MainClassDTO GetText()
        {
            MainClassDTO obj = new MainClassDTO();
            obj.Code = tbCode.Text;
            obj.Name = tbName.Text;
            obj.DateCreate = dtpDateCreate.Text;
            obj.TeacherCode = tbTeacherCode.Text;

            return obj;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                MainClassDTO obj = GetText();

                bool ok = MainClassDAO.Instance.Add(obj);
                if (ok)
                {
                    CancelText();
                    LoadListMainClass();
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                MainClassDTO obj = GetText();

                bool ok = MainClassDAO.Instance.Edit(obj);
                if (ok)
                {
                    CancelText();
                    LoadListMainClass();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(CheckNullOrEmpty(tbCode, erCode)){
                MainClassDTO obj = GetText();

                bool ok = MainClassDAO.Instance.Delete(obj);
                if (ok)
                {
                    CancelText();
                    LoadListMainClass();
                }
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            TeacherDAO.Instance.ExportExcel(dgvListMainClass);
        }

        private void tbTeacherCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            ChooseTeacher();
        }

        private void ChooseTeacher()
        {
            if (CheckNullOrEmpty(tbCode, erCode) && CheckNullOrEmpty(tbName, erName))
            {
                fChooseTeacher f = new fChooseTeacher();
                f.SubjectCode = "";
                f.ShowDialog();
                if (f.TeacherCode != null)
                    tbTeacherCode.Text = f.TeacherCode;
                f.Close();

                CheckNullOrEmpty(tbTeacherCode, erTeacherCode);
            }
        }

        private void tbTeacherCode_Click(object sender, EventArgs e)
        {
            ChooseTeacher();
        }
    }
}
