using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4
{
    class TeacherDAO
    {
        private static TeacherDAO instance;

        public TeacherDAO() { }

        public static TeacherDAO Instance
        {
            get { if (instance == null) instance = new TeacherDAO(); return instance; }
            private set => instance = value;
        }

        public DataTable Load()
        {
            string query = @"select MaGV as N'Mã giảng viên', TenGV as N'Tên giảng viên', 
                            GioiTinhGV as N'Giới tính', NgaySinhGV as N'Ngày sinh', 
                            EmailGV as N'Email', SdtGV as N'Số điện thoại', 
                            ListSubject as N'Môn giảng dạy' from vwGiangVienVaMon";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
            }
            return table;
        }

        public bool CheckAdd(string Code)
        {
            try
            {
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckGiangVien @Ma", new object[] { Code }) != 0)
                {
                    MessageBox.Show("Mã giảng viên đã tồn tại", "Lỗi");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool Add(TeacherDTO obj)
        {
            string query = "exec InsertGiangVien @Ma , @Ten , @GioiTinh , @NgaySinh , @Email , @Sdt";

            if (CheckAdd(obj.Code))
            {
                try
                {
                    object[] para = new object[6];
                    para[0] = obj.Code;
                    para[1] = obj.Name;
                    para[2] = obj.Gender;
                    para[3] = obj.Birthday;
                    para[4] = obj.Email;
                    para[5] = obj.Phone;

                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Delete(TeacherDTO ojb)
        {
            string query = "exec DeleteGiangVien @Ma";

            try
            {
                object[] para = new object[1];
                para[0] = ojb.Code;

                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckGiangVien @Ma", para) != 0)
                {
                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                else
                {
                    MessageBox.Show("Mã giảng viên không tồn tại để xóa", "Lỗi");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool CheckEdit(string SubjectCode)
        {
            try
            {
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckGiangVien @Ma", new object[] { SubjectCode }) == 0)
                {
                    MessageBox.Show("Mã giảng viên chưa tồn tại", "Lỗi");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (TeacherDTO)\n" + ex.Message);
                return false;
            }
        }

        public bool Edit(TeacherDTO obj)
        {
            string query = "exec UpdateGiangVien @Ma , @Ten , @GioiTinh , @NgaySinh , @Email , @Sdt";

            if (CheckEdit(obj.Code))
            {
                try
                {
                    object[] para = new object[6];
                    para[0] = obj.Code;
                    para[1] = obj.Name;
                    para[2] = obj.Gender;
                    para[3] = obj.Birthday;
                    para[4] = obj.Email;
                    para[5] = obj.Phone;

                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
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

        // Môn của giảng viên
        public DataTable LoadSubjectAll(string MaGV)
        {
            string query = "exec MonKhongCuaGiangVien @Ma";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query, new object[] { MaGV });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
            }
            return table;
        }

        public DataTable LoadSubjectTeacher(string MaGV)
        {
            string query = "exec MonCuaGiangVien @Ma";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query, new object[] { MaGV });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
            }
            return table;
        }

        public bool AddSubject(string MaMon, string MaGV)
        {
            try
            {
                string query = "exec InsertMonGiangVien @MaM , @MaGV";
                object[] parameter = new object[] { MaMon, MaGV };
                DataProvider.Instance.ExcuteNoneQuery(query, parameter);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool DeleteSubject(string MaMon, string MaGV)
        {
            try
            {
                string query = "exec DeleteMonGiangVien @MaM , @MaGV";
                object[] parameter = new object[] { MaMon, MaGV };
                DataProvider.Instance.ExcuteNoneQuery(query, parameter);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (TeacherDAO)\n" + ex.Message);
                return false;
            }
        }

        // Chọn giảng viện
        public DataTable LoadChoose(string MaM = null)
        {
            string query;
            if (string.IsNullOrEmpty(MaM))
            {
                query = @"select gv.MaGV as N'Mã giảng viên', gv.TenGV as N'Tên giảng viên', gv.GioiTinhGV as N'Giới tính', gv.NgaySinhGV as N'Ngày sinh' from GiangVien as gv";
            }
            else
            {
                query = @"select gv.MaGV as N'Mã giảng viên', gv.TenGV as N'Tên giảng viên', gv.GioiTinhGV as N'Giới tính', gv.NgaySinhGV as N'Ngày sinh' from GiangVien as gv, MonGiangVien as mgv
                            where gv.MaGV = mgv.MaGV and mgv.MaM = '" + MaM + "'";
            }
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
    }
}
