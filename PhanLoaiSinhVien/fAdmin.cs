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
    public partial class AdminRights : Form
    {
        public AdminRights()
        {
            InitializeComponent();
        }

        private void AdminRights_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng lại không ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void mônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSubject f = new fSubject();
            f.MdiParent = this;
            f.Show();
        }

        private void giảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTeacher f = new fTeacher();
            f.MdiParent = this;
            f.Show();
        }

        private void lớpHànhChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMainClass f = new fMainClass();
            f.MdiParent = this;
            f.Show();
        }

        private void sinhVieenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStudent f = new fStudent();
            f.MdiParent = this;
            f.Show();
        }

        private void lớpTínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCreditClass f = new fCreditClass();
            f.MdiParent = this;
            f.Show();
        }

        private void xếpLớpTínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fArrangeSICC f = new fArrangeSICC();
            f.MdiParent = this;
            f.Show();
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInputScores f = new fInputScores();
            f.MdiParent = this;
            f.Show();
        }


        private void chuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChuyenNganh f = new fChuyenNganh();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void báoCáoĐiểmLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDiem f = new BaoCaoDiem();
            f.MdiParent = this;
            f.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
