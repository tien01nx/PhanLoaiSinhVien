using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4
{
    public partial class fTeacher : Form
    {
        DataTable table;
        public fTeacher()
        {
            InitializeComponent();
        }

        private void LoadListTeacher()
        {
            table = TeacherDAO.Instance.Load();
            dgvListTeacher.DataSource = table;
        }

        private void fTeacher_Load(object sender, EventArgs e)
        {
            LoadListTeacher();
        }

        private void dgvListStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            erCode.SetError(tbCode, "");
            int index = e.RowIndex;
            if (index >= 0)
            {
                tbCode.Enabled = false;
                tbCode.Text = dgvListTeacher.Rows[index].Cells[0].Value.ToString();
                tbName.Text = dgvListTeacher.Rows[index].Cells[1].Value.ToString();
                if (dgvListTeacher.Rows[index].Cells[2].Value.ToString().Equals("Nam"))
                    rdMale.Checked = true;
                else
                    rdFemale.Checked = true;
                dtpBirthday.Text = dgvListTeacher.Rows[index].Cells[3].Value.ToString();
                tbEmail.Text = dgvListTeacher.Rows[index].Cells[4].Value.ToString();
                tbPhone.Text = dgvListTeacher.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void CancelText()
        {
            tbCode.Enabled = true;
            tbCode.Text = "";
            tbName.Text = "";
            rdFemale.Checked = false;
            rdMale.Checked = true;
            dtpBirthday.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
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

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            CheckEmail();
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            CheckPhone();
        }

        private void mtbBirthday_Validating(object sender, CancelEventArgs e)
        {
            CheckBirthday();
        }

        private TeacherDTO GetText()
        {
            TeacherDTO obj = new TeacherDTO();
            obj.Code = tbCode.Text;
            obj.Name = tbName.Text;
            if (rdFemale.Checked == true)
                obj.Gender = "Nam";
            else
                obj.Gender = "Nữ";
            obj.Birthday = dtpBirthday.Text;
            obj.Email = tbEmail.Text;
            obj.Phone = tbPhone.Text;

            return obj;
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

        private bool CheckBirthday()
        {
            DateTime birthday = dtpBirthday.Value;
            int age = DateTime.Now.Year - birthday.Year;

            if (DateTime.Now < birthday.AddYears(age))
                age--;

            if (age > 21)
            {
                erBirthday.SetError(dtpBirthday, "");
                return true;
            }
            else
            {
                erBirthday.SetError(dtpBirthday, "Chưa đủ tuổi (từ 22)");
                dtpBirthday.Focus();
                return false;
            }
        }

        private bool CheckEmail()
        {
            if (CheckNullOrEmpty(tbEmail, erEmail))
            {
                string email = tbEmail.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);

                if (match.Success)
                {
                    erEmail.SetError(tbEmail, "");
                    return true;
                }
                else
                {
                    tbEmail.Focus();
                    erEmail.SetError(tbEmail, "Không phải định dạng email");
                    return false;
                }
            }
            else
                return false;
        }

        private bool CheckPhone()
        {
            if (CheckNullOrEmpty(tbPhone, erPhone))
            {
                Regex regex = new Regex(@"^((0(\d){9})|0(\d){10})$");
                Match match = regex.Match(tbPhone.Text);

                if (match.Success)
                {
                    erPhone.SetError(tbPhone, "");
                    return true;
                }
                else
                {
                    erPhone.SetError(tbPhone, "Không phải định dạng SDT");
                    tbPhone.Focus();
                    return false;
                }
            }
            else
                return false;

        }

        private bool CheckInput()
        {
            if (!CheckNullOrEmpty(tbCode, erCode))
                return false;

            if (!CheckNullOrEmpty(tbName, erName))
                return false;

            if (!CheckBirthday())
                return false;

            if (!CheckEmail())
                return false;

            if (!CheckPhone())
                return false;

            return true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                TeacherDTO obj = GetText();

                bool ok = TeacherDAO.Instance.Add(obj);
                if (ok)
                {
                    CancelText();
                    LoadListTeacher();
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                TeacherDTO obj = GetText();

                bool ok = TeacherDAO.Instance.Edit(obj);
                if (ok)
                {
                    CancelText();
                    LoadListTeacher();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(CheckNullOrEmpty(tbCode, erCode)){
                TeacherDTO obj = GetText();

                bool ok = TeacherDAO.Instance.Delete(obj);
                if (ok)
                {
                    CancelText();
                    LoadListTeacher();
                }
            }
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            TeacherDAO.Instance.ExportExcel(dgvListTeacher);
        }

        private void btListSubject_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbCode.Text))
            {
                MessageBox.Show("Nhập mã trước");
                tbCode.Focus();
            }
            else if (TeacherDAO.Instance.CheckEdit(tbCode.Text))
            {
                fChooseSOT f = new fChooseSOT();
                f.TeacherCode = tbCode.Text;
                f.ShowDialog();
                f.Close();

                LoadListTeacher();
            }
        }
    }
}
