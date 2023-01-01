using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4
{
    class StudentDAO
    {
        private static StudentDAO instance;

        public StudentDAO() { }

        internal static StudentDAO Instance
        {
            get { if (instance == null) instance = new StudentDAO(); return instance; }
            private set => instance = value;
        }

        public DataTable Load(string MaL)
        {
            string query = @"select MaSV as N'Mã sinh viên', TenSV as N'Tên sinh viên', GioiTinhSV as N'Giới tính', NgaySinhSV as N'Ngày sinh', EmailSV as N'Email', SdtSV as N'Số điện thoại', MaLHC as N'Mã lớp hành chính' 
                            from SinhVien as sv where sv.MaLHC = '" + MaL + "'";
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
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaSinhVien @Ma", new object[] { Code }) != 0)
                {
                    MessageBox.Show("Mã giảng viên đã tồn tại", "Lỗi");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (StudentDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool Add(StudentDTO obj)
        {
            string query = "exec InsertSinhVien @MaSV , @TenSV , @GioiTinh , @NgaySinh , @Email , @Sdt , @MaLHC";

            if (CheckAdd(obj.Code))
            {
                try
                {
                    object[] para = new object[7];
                    para[0] = obj.Code;
                    para[1] = obj.Name;
                    para[2] = obj.Gender;
                    para[3] = obj.Birthday;
                    para[4] = obj.Email;
                    para[5] = obj.Phone;
                    para[6] = obj.ClassCode;

                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được CSDL (StudentDAO)\n" + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Delete(StudentDTO ojb)
        {
            string query = "exec DeleteSinhVien @Ma";

            try
            {
                object[] para = new object[1];
                para[0] = ojb.Code;

                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaSinhVien @Ma", para) != 0)
                {
                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                else
                {
                    MessageBox.Show("Mã sinh viên không tồn tại để xóa", "Lỗi");
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
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaSinhVien @Ma", new object[] { SubjectCode }) == 0)
                {
                    MessageBox.Show("Mã sinh viên chưa tồn tại", "Lỗi");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (StudentDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool Edit(StudentDTO obj)
        {
            string query = "exec UpdateSinhVien @MaSV , @TenSV , @GioiTinh , @NgaySinh , @Email , @Sdt , @MaLHC";

            if (CheckEdit(obj.Code))
            {
                try
                {
                    object[] para = new object[7];
                    para[0] = obj.Code;
                    para[1] = obj.Name;
                    para[2] = obj.Gender;
                    para[3] = obj.Birthday;
                    para[4] = obj.Email;
                    para[5] = obj.Phone;
                    para[6] = obj.ClassCode;

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

    }
}
