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
    public partial class fDieuKienLoc : Form
    {
        int rowDelete = -1;
        public DataTable table;
        bool addNR = false;

        public fDieuKienLoc(DataTable dt)
        {
            InitializeComponent();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(row[0].ToString(),
                        row[1].ToString(), row[2].ToString(), row[3]);
                }
                table = dt;
            }
            else
            {
                table = new DataTable();
                table.Columns.Add("And/Or", typeof(string));
                table.Columns.Add("Subject", typeof(string));
                table.Columns.Add("Operator", typeof(string));
                table.Columns.Add("Value", typeof(float));
            }



            addNR = true;
        }





        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex < dataGridView1.Rows.Count - 1)
                {
                    rowDelete = e.RowIndex;
                    mntDelete.Show(Cursor.Position);
                }
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                table.Rows.Add(
                    row.Cells[0].FormattedValue.ToString(),
                    row.Cells[1].FormattedValue.ToString(),
                    row.Cells[2].FormattedValue.ToString(),
                    row.Cells[3].Value);
            }

            this.Close();
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (addNR)
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 0)
                {
                    dataGridView1.Rows[e.RowIndex - 1].Cells[1].Value = "CSLT";
                    dataGridView1.Rows[e.RowIndex - 1].Cells[2].Value = ">";
                    dataGridView1.Rows[e.RowIndex - 1].Cells[3].Value = "4.00";
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    dataGridView1.Rows[e.RowIndex - 1].Cells[2].Value = ">";
                    dataGridView1.Rows[e.RowIndex - 1].Cells[3].Value = "4.00";
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 2)
                {
                    dataGridView1.Rows[e.RowIndex - 1].Cells[1].Value = "CSLT";
                    dataGridView1.Rows[e.RowIndex - 1].Cells[3].Value = "4.00";
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 3)
                {
                    dataGridView1.Rows[e.RowIndex - 1].Cells[1].Value = "CSLT";
                    dataGridView1.Rows[e.RowIndex - 1].Cells[2].Value = ">";
                }
            }
        }
    }

}
