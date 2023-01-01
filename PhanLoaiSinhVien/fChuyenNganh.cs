using CrystalDecisions.CrystalReports.Engine;
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
    public partial class fChuyenNganh : Form
    {
        public fChuyenNganh()
        {
            InitializeComponent();

        }
        DataTable table;
        /*     table = fChuyenNganhDAO.Instance.Load();*/
        /* viewCN.DataSource = table;*/
        /*    a += b a = a + b*/


        private void button1_Click(object sender, EventArgs e)
        {
            dataview.Visible = false;
            cr.Visible = true;

            string DieuKien = "";
            if (cbCNPM.Checked == false && cbDPT.Checked == false && cbMang.Checked == false)
            {

                showReport("koCN.rpt", DieuKien);
            }
            else if (cbCNPM.Checked == true && cbDPT.Checked == false && cbMang.Checked == false)
            {
                showReport("ChuyenNganhCNPM.rpt", DieuKien);
            }
            else if (cbCNPM.Checked == false && cbDPT.Checked == true && cbMang.Checked == false)
            {
                showReport("ChuyenNganhDPT.rpt", DieuKien);
            }
            else if (cbCNPM.Checked == false && cbDPT.Checked == false && cbMang.Checked == true)
            {
                showReport("ChuyenNganhMang.rpt", DieuKien);
            }
            else if (cbCNPM.Checked == true && cbDPT.Checked == true && cbMang.Checked == false)
            {
                showReport("ChuyenNganhPMDPT.rpt", DieuKien);
            }
            else if (cbCNPM.Checked == true && cbDPT.Checked == false && cbMang.Checked == true)
            {
                showReport("ChuyenNganhPMM.rpt", DieuKien);
            }
            else if (cbCNPM.Checked == false && cbDPT.Checked == true && cbMang.Checked == true)
            {
                showReport("ChuyenNganhDPTM.rpt", DieuKien);
            }
            else if (cbCNPM.Checked == true && cbDPT.Checked == true && cbMang.Checked == true)
            {
                showReport("ChuyenNganh.rpt", DieuKien);
            }











            //BaoCao formBaoCao = new BaoCao();
            //formBaoCao.showReport("SinhVienReport.rpt", DieuKien);
            //formBaoCao.Show();
        }


        public void showReport(string reportFileName, string recordFilter = "")
        {

            ReportDocument reportDocument = new ReportDocument();
            string reportfile = string.Format("{0}\\CrystalReport\\{1}", Application.StartupPath, reportFileName);
            reportDocument.Load(reportfile);
            if (!string.IsNullOrEmpty(recordFilter))
            {
                reportDocument.RecordSelectionFormula = recordFilter;
            }
            cr.ReportSource = reportDocument;
            cr.Refresh();
        }

        private void fChuyenNganh_Load(object sender, EventArgs e)
        {
            table = fChuyenNganhDAO.Instance.LoadClass();
            dataview.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fLocNangCao f = new fLocNangCao();
            /*  f.MdiParent = this;*/
            f.Show();
        }
    }
}
