using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4
{
    class SubjectDAO
    {
        private static SubjectDAO instance;

        public SubjectDAO() { }

        public static SubjectDAO Instance
        {
            get { if (instance == null) instance = new SubjectDAO(); return instance; }
            private set => instance = value;
        }

        public DataTable Load()
        {
            string query = "select MaM as N'Mã môn học', TenMon as N'Tên môn học', SoTin as N'Số tín chỉ' from Mon";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (SubjectDAO)\n" + ex.Message);
            }
            return table;
        }

        public DataTable LoadToChoose()
        {
            string query = "select MaLHP, MaM from LopHocPhan where DATEDIFF(DAY,NgayBD, GETDATE()) < 0";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (SubjectDAO)\n" + ex.Message);
            }
            return table;
        }

        public bool CheckAdd(string SubjectCode, string SubjectName)
        {
            try
            {
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaMon @Ma", new object[] { SubjectCode }) != 0)
                {
                    MessageBox.Show("Mã môn đã tồn tại", "Lỗi");
                    return false;
                }
                else
                {
                    if ((int)DataProvider.Instance.ExcuteScalar("exec CheckTenMon @Ten", new object[] { SubjectName }) != 0)
                    {
                        MessageBox.Show("Tên môn đã tồn tại", "Lỗi");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (SubjectDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool Add(SubjectDTO obj)
        {
            string query = "exec InsertMon @Ma , @Ten , @SoTin";

            if (CheckAdd(obj.Code, obj.Name))
            {
                try
                {
                    object[] para = new object[3];
                    para[0] = obj.Code;
                    para[1] = obj.Name;
                    para[2] = obj.NumberCredit;

                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được CSDL (SubjectDAO)\n" + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Delete(SubjectDTO ojb)
        {
            string query = "exec DeleteMon @Ma";

            try
            {
                object[] para = new object[1];
                para[0] = ojb.Code;

                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaMon @Ma", para) != 0)
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
                MessageBox.Show("Không kết nối được CSDL (SubjectDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool CheckEdit(string SubjectCode, string SubjectName)
        {
            try
            {
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaMon @Ma", new object[] { SubjectCode }) == 0)
                {
                    MessageBox.Show("Mã môn chưa tồn tại", "Lỗi");
                    return false;
                }
                else
                {
                    if ((int)DataProvider.Instance.ExcuteScalar("exec CheckTenMonUpdate @Ma , @Ten", new object[] { SubjectCode, SubjectName }) != 0)
                    {
                        MessageBox.Show("Tên môn đã tồn tại", "Lỗi");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (SubjectDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool Edit(SubjectDTO obj)
        {
            string query = "exec UpdateMon @Ma , @Ten , @SoTin";

            if (CheckEdit(obj.Code, obj.Name))
            {
                try
                {
                    object[] para = new object[3];
                    para[0] = obj.Code;
                    para[1] = obj.Name;
                    para[2] = obj.NumberCredit;

                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được CSDL (SubjectDAO)\n" + ex.Message);
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
