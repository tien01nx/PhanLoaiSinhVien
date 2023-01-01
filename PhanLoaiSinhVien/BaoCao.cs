using CrystalDecisions.CrystalReports.Engine;
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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }
        public void showReport(string reportFileName, string recordFilter = "")
        {

            ReportDocument reportDocument = new ReportDocument();
            string reportfile = string.Format("{0}\\CrystalReport\\{1}", Application.StartupPath, reportFileName);
            reportDocument.Load(reportfile);
            /*    C: \Users\admin\Downloads\v4\v4\PhanLoaiSinhVien4\CrystalReport
                        { 0}\\CrystalReport\\{ 1}*/
            //TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
            //tableLogOnInfo.ConnectionInfo.ServerName = "TIEN";
            //tableLogOnInfo.ConnectionInfo.DatabaseName = "PhanLoaiSinhVien";
            //tableLogOnInfo.ConnectionInfo.UserID = "sa";
            //tableLogOnInfo.ConnectionInfo.Password = "123123";

            //foreach (Table table in reportDocument.Database.Tables)
            //{
            //    table.ApplyLogOnInfo(tableLogOnInfo);
            //}
            if (!string.IsNullOrEmpty(recordFilter))
            {
                reportDocument.RecordSelectionFormula = recordFilter;
            }
            cr.ReportSource = reportDocument;
            cr.Refresh();
        }
    }
}
