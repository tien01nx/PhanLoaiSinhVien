using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanLoaiSinhVien4.DAO
{
    class fChuyenNganhDAO
    {
        private static fChuyenNganhDAO instance;

        public fChuyenNganhDAO() { }

        public static fChuyenNganhDAO Instance
        {
            get { if (instance == null) instance = new fChuyenNganhDAO(); return instance; }
            private set => instance = value;
        }


        public DataTable LoadClass()
        {
            string query = @"select * from datasv";
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
