using PhanLoaiSinhVien4.DAO;
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
    public partial class BaoCaoDiem : Form
    {
        public BaoCaoDiem()
        {
            InitializeComponent();
        }
        DataTable table;

        private void btnInDiemLHP_Click(object sender, EventArgs e)
        {
            string DieuKien = "";
            DieuKien += "{LopHocPhan.MaLHP} ='" + txtMaLHP.Text + "'";
            BaoCao formBaoCao = new BaoCao();
            formBaoCao.showReport("BaoCaoLHP.rpt", DieuKien);
            formBaoCao.Show();
        }

        private void BaoCaoDiem_Load(object sender, EventArgs e)
        {
            Hien();
        }
        private void Hien()
        {
            table = BaoCaoDiemDAO.Instance.Load();
            DataView view = new DataView(table);
            txtMaLHP.DataSource = view;
            txtMaLHP.DisplayMember = "MaLHP";
            txtMaLHP.ValueMember = "MaLHP";

        }
    }
}
