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
    public partial class fLocNangCao : Form
    {
        public fLocNangCao()
        {
            InitializeComponent();
        }
        DataTable dtPointFilter;
        string FilterData = " ";
        string Specializes = "";
        object[] ojbCNPM;
        object[] ojbDPT;
        object[] ojbMang;

        private void CNPM_CheckedChanged(object sender, EventArgs e)
        {

            plCNPM.Enabled = CNPM.Checked;

        }

        private void DPT_CheckedChanged(object sender, EventArgs e)
        {
            plDPT.Enabled = DPT.Checked;
        }

        private void Mang_CheckedChanged(object sender, EventArgs e)
        {
            plMang.Enabled = Mang.Checked;
        }

        private void btPointFilter_Click(object sender, EventArgs e)
        {
            fDieuKienLoc f = new fDieuKienLoc(dtPointFilter);
            f.ShowDialog();
            dtPointFilter = f.table;

            for (int i = 0; i < dtPointFilter.Rows.Count; i++)
            {
                DataRow row = dtPointFilter.Rows[i];
                FilterData += " " + row[0].ToString()
                    + " " + row[1].ToString()
                    + " " + row[2].ToString()
                    + " " + row[3].ToString();
            }
        }
        private void Kmean()
        {
            string queryData = "exec FilterData '" + FilterData + "'";
            DataProvider.Instance.ExcuteNoneQuery(queryData);

            CheckSpecialized();

            string queryCNPM = "exec PhanCum_CNPM @M1T , @M2T , @M3T , @M1F , @M2F , @M3F ";
            if (CNPM.Checked)
                DataProvider.Instance.ExcuteNoneQuery(queryCNPM, ojbCNPM);

            string queryDPT = "exec PhanCum_DPT @M1T , @M2T , @M3T , @M1F , @M2F , @M3F ";
            if (DPT.Checked)
                DataProvider.Instance.ExcuteNoneQuery(queryDPT, ojbDPT);

            string queryMang = "exec PhanCum_Mang @M1T , @M2T , @M3T , @M1F , @M2F , @M3F ";
            if (Mang.Checked)
                DataProvider.Instance.ExcuteNoneQuery(queryMang, ojbMang);
        }

        private void LoadDataView()
        {
            string query = "";
            if (!string.IsNullOrEmpty(Specializes))
            {
                query = @"select "
                                + "MaSV, TenSV, GioiTinhSV, NgaySinhSV, MaLHC"
                                + ", CSLT, CSDL, LTHDT, NTKW, MMT, QTM, LTWE " + Specializes
                                + " from vw_km_data_2"
                                + " order by " + Specializes.Substring(1, Specializes.Length - 1) + " ASC";
            }
            else
            {
                query = @"select "
                                + " MaSV, TenSV, GioiTinhSV, NgaySinhSV, MaLHC "
                                + " , CSLT, CSDL, LTHDT, NTKW, MMT, QTM, LTWE "
                                + " from vw_km_data_2";
            }

            dgvSpecialized.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void CheckSpecialized()
        {
            Specializes = "";
            if (CNPM.Checked == true)
            {
                ojbCNPM = new object[6];
                ojbCNPM[0] = tbMon1_T_CNPM.Text;
                ojbCNPM[1] = tbMon2_T_CNPM.Text;
                ojbCNPM[2] = tbMon3_T_CNPM.Text;
                ojbCNPM[3] = tbMon1_F_CNPM.Text;
                ojbCNPM[4] = tbMon2_F_CNPM.Text;
                ojbCNPM[5] = tbMon3_F_CNPM.Text;
                Specializes += ", CNPM";
            }
            if (DPT.Checked == true)
            {
                ojbDPT = new object[6];
                ojbDPT[0] = tbMon1_T_DPT.Text;
                ojbDPT[1] = tbMon2_T_DPT.Text;
                ojbDPT[2] = tbMon3_T_DPT.Text;
                ojbDPT[3] = tbMon1_F_DPT.Text;
                ojbDPT[4] = tbMon2_F_DPT.Text;
                ojbDPT[5] = tbMon3_F_DPT.Text;
                Specializes += ", DPT";
            }
            if (Mang.Checked == true)
            {
                ojbMang = new object[6];
                ojbMang[0] = tbMon1_T_Mang.Text;
                ojbMang[1] = tbMon2_T_Mang.Text;
                ojbMang[2] = tbMon3_T_Mang.Text;
                ojbMang[3] = tbMon1_F_Mang.Text;
                ojbMang[4] = tbMon2_F_Mang.Text;
                ojbMang[5] = tbMon3_F_Mang.Text;
                Specializes += ", Mang";
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            try
            {
                Kmean();
                LoadDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (fSpecialized)\n" + ex.Message);
            }
        }
    }
}
