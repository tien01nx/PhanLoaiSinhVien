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
    public partial class fAddToMainClass : Form
    {
        private DataTable table;
        private int[] Choose = new int[7];

        public bool addNew = false;

        public fAddToMainClass()
        {
            InitializeComponent();

            this.cbCode.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbName.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbGender.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbBirthday.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbEmail.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbPhone.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbClass.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void btIPChooseFile_Click(object sender, EventArgs e)
        {
            table = DataProvider.Instance.ImportExcel();
            if (table.Rows.Count > 0)
            {
                dgvListStudent.DataSource = table;
                ListNameColumn();
            }
            else
                MessageBox.Show("Bạn chưa chọn file!");
        }

        private void ListNameColumn()
        {
            List<string> column0 = new List<string>();
            column0.Add("Chọn");
            List<string> column1 = new List<string>();
            column1.Add("Chọn");
            List<string> column2 = new List<string>();
            column2.Add("Chọn");
            List<string> column3 = new List<string>();
            column3.Add("Chọn");
            List<string> column4 = new List<string>();
            column4.Add("Chọn");
            List<string> column5 = new List<string>();
            column5.Add("Chọn");
            List<string> column6 = new List<string>();
            column6.Add("Chọn");

            for (int i=0; i< table.Columns.Count; i++)
            {
                column0.Add(table.Columns[i].ColumnName);
                column1.Add(table.Columns[i].ColumnName);
                column2.Add(table.Columns[i].ColumnName);
                column3.Add(table.Columns[i].ColumnName);
                column4.Add(table.Columns[i].ColumnName);
                column5.Add(table.Columns[i].ColumnName);
                column6.Add(table.Columns[i].ColumnName);
            }

            cbCode.DataSource = column0;
            cbName.DataSource = column1;
            cbGender.DataSource = column2;
            cbBirthday.DataSource = column3;
            cbEmail.DataSource = column4;
            cbPhone.DataSource = column5;
            cbClass.DataSource = column6;
        }

        #region event combobox
        private void cbIPCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPCode_Click(object sender, EventArgs e)
        {
            cbCode.DroppedDown = true;
        }

        private void cbIPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPName_Click(object sender, EventArgs e)
        {
            cbName.DroppedDown = true;
        }

        private void cbIPSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPSex_Click(object sender, EventArgs e)
        {
            cbGender.DroppedDown = true;
        }

        private void cbIPDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPDate_Click(object sender, EventArgs e)
        {
            cbBirthday.DroppedDown = true;
        }

        private void cbIPEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPEmail_Click(object sender, EventArgs e)
        {
            cbEmail.DroppedDown = true;
        }

        private void cbIPPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPPhone_Click(object sender, EventArgs e)
        {
            cbPhone.DroppedDown = true;
        }

        private void cbIPClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbIPClass_Click(object sender, EventArgs e)
        {
            cbClass.DroppedDown = true;
        }
        
        private void CheckSelect(ComboBox cb, int stt, int[] nho)
        {
            if (cb.SelectedIndex == 0)
            {
                nho[stt] = 0;
            }
            else
            {
                bool ok = true;
                for (int i = 0; i < nho.Length; i++)
                {
                    if (i != stt && cb.SelectedIndex == nho[i])
                    {
                        ok = false;
                    }
                }
                if (ok)
                {
                    nho[stt] = cb.SelectedIndex;
                }
                else
                {
                    cb.SelectedIndex = nho[stt];
                }
            }
        }

        private void cbIPCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbCode, 0, Choose);
        }

        private void cbIPName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbName, 1, Choose);
        }

        private void cbIPSex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbGender, 2, Choose);
        }

        private void cbIPDate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbBirthday, 3, Choose);
        }

        private void cbIPEmail_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbEmail, 4, Choose);
        }

        private void cbIPPhone_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbPhone, 5, Choose);
        }

        private void cbIPClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbClass, 6, Choose);
        }

        Font fontT = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        Font fontF = new Font("Microsoft Sans Serif", 8, FontStyle.Strikeout);

        private void SetSelect(ComboBox cb, DrawItemEventArgs e, int[] nho)
        {
            if (e.Index == 0)
            {
                e.DrawBackground();
                e.Graphics.DrawString(cb.Items[e.Index].ToString(), fontT, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
            else if((e.Index == nho[0] || e.Index == nho[1] || e.Index == nho[2] ||
                e.Index == nho[3] || e.Index == nho[4] || e.Index == nho[5] || e.Index == nho[6]))
                e.Graphics.DrawString(cb.Items[e.Index].ToString(), fontF, Brushes.LightSlateGray, e.Bounds);
            else
            {
                e.DrawBackground();
                e.Graphics.DrawString(cb.Items[e.Index].ToString(), fontT, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void cbIPCode_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbCode, e, Choose);
        }

        private void cbIPName_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbName, e, Choose);
        }

        private void cbIPSex_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbGender, e, Choose);
        }

        private void cbIPDate_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbBirthday, e, Choose);
        }

        private void cbIPEmail_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbEmail, e, Choose);
        }

        private void cbIPPhone_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbPhone, e, Choose);
        }

        private void cbIPClass_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbClass, e, Choose);
        }

        #endregion

        private bool CheckInput()
        {
            if (!CheckChoose(cbCode,erCode) ||
                !CheckChoose(cbName, erName) ||
                !CheckChoose(cbGender, erGender) ||
                !CheckChoose(cbBirthday, erBirthday) ||
                !CheckChoose(cbEmail, erEmail) ||
                !CheckChoose(cbPhone, erPhone) ||
                !CheckChoose(cbClass, erCode))
                return false;

            return true;
        }

        private bool CheckChoose(ComboBox control, ErrorProvider er)
        {
            if (control.Text.Equals("Chọn"))
            {
                control.DroppedDown = true;
                er.SetError(control, "Bạn chưa chọn");
                return false;
            }
            else
            {
                er.SetError(control, "");
                return true;
            }
        }

        private void btIPOK_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string[] column = new string[]
                {
                    cbCode.Text,
                    cbName.Text,
                    cbGender.Text,
                    cbBirthday.Text,
                    cbEmail.Text,
                    cbPhone.Text,
                    cbClass.Text
                };

                dgvListStudent =  MainClassDAO.Instance.AddToMainClass(column,dgvListStudent);

                if (dgvListStudent.Rows.Count > 0)
                    MessageBox.Show("Có " + table.Rows.Count + " dòng không thể thêm");
                else
                {
                    addNew = true;
                    MessageBox.Show("Hoàn thành.");
                }
            }
        }
    }
}

