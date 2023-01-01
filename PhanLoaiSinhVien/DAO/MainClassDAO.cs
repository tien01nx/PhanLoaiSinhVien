using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4
{
    class MainClassDAO
    {
        private static MainClassDAO instance;

        public MainClassDAO() { }

        internal static MainClassDAO Instance
        {
            get { if (instance == null) instance = new MainClassDAO(); return instance; }
            private set => instance = value;
        }

        public DataTable Load()
        {
            string query = @"select MaLHC as N'Mã lớp', TenLHC as N'Tên lớp', 
                            NgayLap as N'Ngày lập', MaGV as N'Cố vấn' from LopHanhChinh";
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

        public bool CheckAdd(string SubjectCode)
        {
            try
            {
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaMon @Ma", new object[] { SubjectCode }) != 0)
                {
                    MessageBox.Show("Mã môn đã tồn tại", "Lỗi");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (MainClassDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool Add(MainClassDTO obj)
        {
            string query = "exec InsertLopHanhChinh @MaLHC , @TenLHC , @NgayLap , @MaGV";

            if (CheckAdd(obj.Code))
            {
                try
                {
                    object[] para = new object[4];
                    para[0] = obj.Code;
                    para[1] = obj.Name;
                    para[2] = obj.DateCreate;
                    para[3] = obj.TeacherCode;

                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được CSDL (MainClassDAO)\n" + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Delete(MainClassDTO ojb)
        {
            string query = "exec DeleteLopHanhChinh @Ma";

            try
            {
                object[] para = new object[1];
                para[0] = ojb.Code;

                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaLopHanhChinh @Ma", para) != 0)
                {
                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                else
                {
                    MessageBox.Show("Mã môn không tồn tại để xóa", "Lỗi");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (MainClassDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool CheckEdit(string SubjectCode)
        {
            try
            {
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaLopHanhChinh @Ma", new object[] { SubjectCode }) == 0)
                {
                    MessageBox.Show("Mã lớp chưa tồn tại", "Lỗi");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (MainClassDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool Edit(MainClassDTO obj)
        {
            string query = "exec UpdateLopHanhChinh @MaLHC , @TenLHC , @NgayLap , @MaGV";

            if (CheckEdit(obj.Code))
            {
                try
                {
                    object[] para = new object[4];
                    para[0] = obj.Code;
                    para[1] = obj.Name;
                    para[2] = obj.DateCreate;
                    para[3] = obj.TeacherCode;

                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được CSDL (MainClassDAO)\n" + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void ExportExcel(DataGridView dgv)
        {
            DataProvider.Instance.ExportExcel(dgv);
        }

        // Load lớp hành chính mới của năm nay
        public DataTable LoadClassNew()
        {
            string query = @"select concat(MaLHC, ' - ', TenLHC) as 'Display', MaLHC from LopHanhChinh 
                            --where Year(NgayLap) = YEAR(GETDATE())";
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

        public DataGridView AddToMainClass(string[] column, DataGridView dgv)
        {
            string query = "exec InsertSinhVien @MaSV , @TenSV , @GioiTinh , @NgaySinh , @Email , @Sdt , @MaLHC";

            int[] ok = new int[dgv.Rows.Count];
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                try
                {
                    object[] parameter = new object[7];
                    for (int j = 0; j < column.Length; j++)
                    {
                        parameter[j] = dgv.Rows[i].Cells[column[j]].Value.ToString();
                    }

                    DataProvider.Instance.ExcuteNoneQuery(query, parameter);
                    //dgv.Rows.Remove(dgv.Rows[i]);
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
