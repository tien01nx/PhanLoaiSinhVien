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
    public partial class fUpdateScores : Form
    {
        private DataTable table;
        private int[] choose = new int[2];
        public string MaLHP;

        public fUpdateScores()
        {
            InitializeComponent();
            this.cbCode.DrawMode = DrawMode.OwnerDrawFixed;
            this.cbScores.DrawMode = DrawMode.OwnerDrawFixed;
        }

        public fUpdateScores(string maLHP):this()
        {
            MaLHP = maLHP;
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

            for (int i = 0; i < table.Columns.Count; i++)
            {
                column0.Add(table.Columns[i].ColumnName);
                column1.Add(table.Columns[i].ColumnName);
            }

            cbCode.DataSource = column0;
            cbScores.DataSource = column1;
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
            cbScores.DroppedDown = true;
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
            CheckSelect(cbCode, 0, choose);
        }

        private void cbIPName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckSelect(cbScores, 1, choose);
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
            else if ((e.Index == nho[0] || e.Index == nho[1]))
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
            SetSelect(cbScores, e, choose);
        }

        private void cbIPName_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetSelect(cbScores, e, choose);
        }
        #endregion


        private bool Check()
        {
            if (cbCode.Text.Equals("Chọn"))
            {
                MessageBox.Show("Bạn chưa chọn đủ số trường!");
                cbCode.DroppedDown = true;
                return false;
            }
            if (cbScores.Text.Equals("Chọn"))
            {
                MessageBox.Show("Bạn chưa chọn đủ số trường!");
                cbScores.DroppedDown = true;
                return false;
            }
            return true;
        }

        private void btIPOK_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string[] column = new string[]
                {
                    cbCode.Text,
                    cbScores.Text
                };

                dgvListStudent = ImputScoresDAO.Instance.UpdateScores(MaLHP,column, dgvListStudent);

                if (dgvListStudent.Rows.Count > 0)
                    MessageBox.Show("Các dòng không thể nhập: " + table.Rows.Count);
                else
                    MessageBox.Show("Hoàn thành.");
            }
        }
    }
}
