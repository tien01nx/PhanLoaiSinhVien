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
    public partial class fUser : Form
    {
        public fUser()
        {
            InitializeComponent();
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInputScores f = new fInputScores();
            f.MdiParent = this;
            f.Show();
        }
    }
}
