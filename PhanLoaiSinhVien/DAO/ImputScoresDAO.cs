using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4
{
    class ImputScoresDAO
    {
        private static ImputScoresDAO instance;

        public ImputScoresDAO() { }

        internal static ImputScoresDAO Instance
        {
            get { if (instance == null) instance = new ImputScoresDAO(); return instance; }
            private set => instance = value;
        }

        public DataTable LoadClass()
        {
            string query = @"select  concat(m.TenMon, ' - ', l.MaLHP) as 'Display', l.MaLHP
                            from LopHocPhan as l, Mon as m
                            where l.MaM = m.MaM and (DATEDIFF(DAY,l.NgayKT,GETDATE())-30)<0";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (MainClassDAO)\n" + ex.Message);
            }
            return table;
        }

        public DataTable Load(string MaLHP)
        {
            string query = @"select 
                            sv.MaSV as N'Mã SV', sv. TenSV as N'Tên SV', sv.NgaySinhSV as N'Ngày sinh', ROUND(d.DiemM, 2)  as N'Điểm'
                            from DiemMonSinhVien as d, SinhVien as sv
                            where d.MaSV = sv.MaSV and d.MaLHP = '" + MaLHP+"'";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (MainClassDAO)\n" + ex.Message);
            }
            return table;
        }

        public bool Edit(string ClassCode, string StudentCode, float Scores)
        {
            string query = @"exec UpdateDiemMonSinhVien @MaLop , @MaSV , @Diem";
            try
            {
                object[] para = new object[3];
                para[0] = ClassCode;
                para[1] = StudentCode;
                para[2] = Scores;

                DataProvider.Instance.ExcuteNoneQuery(query, para);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
                return false;
            }
        }

        public void ExportExcel(DataGridView dgv)
        {
            DataProvider.Instance.ExportExcel(dgv);
        }

        // thêm điểm bằng excel
        public DataGridView UpdateScores(string ClassCode,string[] column, DataGridView dgv)
        {
            string query = "exec UpdateDiemMonSinhVien @MaLop , @MaSV , @Diem";

            int[] ok = new int[dgv.Rows.Count];
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                try
                {
                    object[] parameter = new object[3];
                    parameter[0] = ClassCode;
                    parameter[1] = dgv.Rows[i].Cells[column[0]].Value.ToString();
                    parameter[2] = dgv.Rows[i].Cells[column[1]].Value.ToString();

                    DataProvider.Instance.ExcuteNoneQuery(query, parameter);
                    ok[i] = 1;
                }
                catch (Exception ex)
                {
                    ok[i] = 0;
                }
            }

            int d = 0;
            for (int i = 0; i < ok.Length; i++)
                if (ok[i] == 1)
                {
                    dgv.Rows.Remove(dgv.Rows[i - d]);
                    d++;
                }

            return dgv;
        }

        
    }
}
