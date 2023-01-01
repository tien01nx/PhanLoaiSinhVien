using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PhanLoaiSinhVien4
{
    class CreditClassDAO
    {
        private static CreditClassDAO instance;

        public CreditClassDAO() { }

        internal static CreditClassDAO Instance
        {
            get { if (instance == null) instance = new CreditClassDAO(); return instance; }
            private set => instance = value;
        }

        public DataTable Load()
        {
            string query = @"select MaLHP as N'Mã lớp học phần', NgayBD as N'Ngày bắt đầu',
                            NgayKT as N'Ngày kết thúc', MaGV as N'Mã giảng viên',
                            MaM as N'Mã Môn' from LopHocPhan";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (CreditClassDAO)\n" + ex.Message);
            }
            return table;
        }

        public bool CheckAdd(string Code)
        {
            try
            {
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaLopHocPhan @Ma", new object[] { Code }) != 0)
                {
                    MessageBox.Show("Mã lớp đã tồn tại", "Lỗi");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (CreditClassDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool Add(CreditClassDTO obj)
        {
            string query = "exec InsertLopHocPhan @MaLHP , @NgayBD , @NgayKT , @MaGV , @MaM";

            if (CheckAdd(obj.ClassCode))
            {
                try
                {
                    object[] para = new object[5];
                    para[0] = obj.ClassCode;
                    para[1] = obj.StartDate;
                    para[2] = obj.EndDate;
                    para[3] = obj.TeacherCode;
                    para[4] = obj.SubjectCode;

                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được CSDL (CreditClassDAO)\n" + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Delete(CreditClassDTO ojb)
        {
            string query = "exec DeleteLopHocPhan @Ma";

            try
            {
                object[] para = new object[1];
                para[0] = ojb.ClassCode;

                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaLopHocPhan @Ma", para) != 0)
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
                MessageBox.Show("Không kết nối được CSDL (CreditClassDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool CheckEdit(string Code)
        {
            try
            {
                if ((int)DataProvider.Instance.ExcuteScalar("exec CheckMaLopHocPhan @Ma", new object[] { Code }) == 0)
                {
                    MessageBox.Show("Mã lớp chưa tồn tại", "Lỗi");
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (CreditClassDAO)\n" + ex.Message);
                return false;
            }
        }

        public bool Edit(CreditClassDTO obj)
        {
            string query = "exec UpdateLopHocPhan @MaLHP , @NgayBD , @NgayKT , @MaGV , @MaM";

            if (CheckEdit(obj.ClassCode))
            {
                try
                {
                    object[] para = new object[5];
                    para[0] = obj.ClassCode;
                    para[1] = obj.StartDate;
                    para[2] = obj.EndDate;
                    para[3] = obj.TeacherCode;
                    para[4] = obj.SubjectCode;

                    DataProvider.Instance.ExcuteNoneQuery(query, para);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không kết nối được CSDL (CreditClassDAO)\n" + ex.Message);
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

        /// thêm sinh viên vào lớp

        public DataTable LoadClassNew() // đang hiện toàn bộ các lớp tín chỉ. muốn chỉ lấy lớp chưa vào học thì bỏ comment "--" ở query
        {
            string query = "select m.MaM, m.TenMon, lhp.MaLHP from LopHocPhan as lhp, Mon as m where lhp.MaM = m.MaM -- and DATEDIFF(DAY,NgayBD, GETDATE()) < 0";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (LoadListMainClass)\n" + ex.Message);
            }
            return table;
        }

        public DataTable LoadStudentRegister(string MaM)
        {
            string query = "exec LoadSinhVienDangKyMon '" + MaM + "'";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (LoadListMainClassOfStudent)\n" + ex.Message);
            }
            return table;
        }

        public DataTable LoadListStudentClass(string MaLHP)
        {
            string query = @"select sv.MaSV as N'Mã SV', sv.TenSV as N'Tên SV', 
                            sv.GioiTinhSV as N'Giới tính', sv.NgaySinhSV as N'Ngày sinh',
                            sv.MaLHC as N'Mã lớp HC' from DiemMonSinhVien as dm, 
                            SinhVien as sv where dm.MaSV = sv.MaSV and MaLHP = '" + MaLHP + "'; ";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (LoadListMainClassOfStudent)\n" + ex.Message);
            }
            return table;
        }

        public bool AddStudent(string StudentCode, string ClassCode)
        {
            string query = "exec InsertDiemMonSinhVien @MaSV , @MaLHP";
            try
            {
                object[] parameter = new object[] { StudentCode, ClassCode };
                DataProvider.Instance.ExcuteNoneQuery(query, parameter);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (AddStudentScore)\n" + ex.Message);
                return false;
            }
        }

        public bool DeleteStudent(string StudentCode, string ClassCode)
        {
            string query = "exec DeleteDiemMonSinhVien @MaSV , @MaLHP";
            try
            {
                object[] parameter = new object[] { StudentCode, ClassCode };
                DataProvider.Instance.ExcuteNoneQuery(query, parameter);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL (DeleteStudentScore)\n" + ex.Message);
                return false;
            }
        }

        public DataGridView AddToCreditClass(string[] column, DataGridView dgv)
        {
            string query = "exec InsertDiemMonSinhVien @MaSV , @MaLHP";

            int[] ok = new int[dgv.Rows.Count];
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                try
                {
                    object[] parameter = new object[2];
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
            for(int i = 0; i < ok.Length; i++)
                if (ok[i] == 1)
                {
                    dgv.Rows.Remove(dgv.Rows[i - d]);
                    d++;
                }
 
            return dgv;
        }

        public void ExportExcelStudent(DataGridView dgv, string MaLTC)
        {
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Title = "Lưu file excel";
                fileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Excel.Application alc = new Excel.Application();
                        alc.Application.Workbooks.Add(Type.Missing);

                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            alc.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                        }
                        alc.Cells[1, dgv.Columns.Count + 1] = "Mã lớp tín chỉ";

                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv.Columns.Count; j++)
                            {
                                alc.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value;
                            }
                            alc.Cells[i + 2, dgv.Columns.Count + 1] = MaLTC;
                        }

                        alc.Columns.AutoFit();
                        alc.ActiveWorkbook.SaveCopyAs(fileDialog.FileName);
                        alc.ActiveWorkbook.Saved = true;
                        MessageBox.Show("Xuất file thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bảng hiện tại giỗng");
            }
        }
    }
}
