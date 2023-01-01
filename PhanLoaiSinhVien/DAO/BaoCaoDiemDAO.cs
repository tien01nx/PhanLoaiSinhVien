using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4.DAO
{
    class BaoCaoDiemDAO
    {
        private static BaoCaoDiemDAO instance;

        public BaoCaoDiemDAO() { }

        public static BaoCaoDiemDAO Instance
        {
            get { if (instance == null) instance = new BaoCaoDiemDAO(); return instance; }
            private set => instance = value;
        }

        public DataTable Load()
        {
            string query = @"select * from LopHocPhan";
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
    }
}
