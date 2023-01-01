using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using OfficeOpenXml;


namespace PhanLoaiSinhVien4
{
    class DataProvider
    {
        private static DataProvider instance; //ctrl + R + E

        private string connectionSTR = ConfigurationManager.AppSettings["connString"];

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value;
        }

        private DataProvider() { }

        /// <summary>
        /// Truy vấn trả về một bảng kết quả
        /// </summary>
        /// <param name="StringQuery">Chuỗi truy vấn</param>
        /// <param name="parameter">Tham số truyền vào nếu có new object[]{,,}</param>
        /// <returns></returns>
        public DataTable ExcuteQuery(string StringQuery, object[] parameter = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand commamd = new SqlCommand(StringQuery, connection);

                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = StringQuery.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            commamd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(commamd);

                adapter.Fill(table);

                connection.Close();
            }

            return table;
        }

        /// <summary>
        /// Truy vấn không trả về kết quả.
        /// </summary>
        /// <param name="StringQuery">Chuỗi truy vấn</param>
        /// <param name="parameter">Tham số nếu có new object[]{,,}</param>
        /// <returns></returns>

        public int ExcuteNoneQuery(string StringQuery, object[] parameter = null)
        {
            int row = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand commamd = new SqlCommand(StringQuery, connection);

                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = StringQuery.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            commamd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                row = commamd.ExecuteNonQuery();

                connection.Close();
            }

            return row;
        }

        /// <summary>
        /// Truy vấn trả ra ô có vị trí (0,0)
        /// </summary>
        /// <param name="StringQuery">Chuỗi truy vấn</param>
        /// <param name="parameter">Các tham số truyền vào nếu có new object[]{,,}</param>
        /// <returns></returns>
        public object ExcuteScalar(string StringQuery, object[] parameter = null)
        {
            object row = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand commamd = new SqlCommand(StringQuery, connection);

                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = StringQuery.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            commamd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                row = commamd.ExecuteScalar();
                connection.Close();
            }

            return row;
        }

        /// <summary>
        /// Xuất dữ liệu ra file excel
        /// </summary>
        /// <param name="dgv">DataGridView muốn xuất dữ liệu ra Excel</param>
        public void ExportExcel(DataGridView dgv)
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

                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv.Columns.Count; j++)
                            {
                                alc.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value;
                            }
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

        public DataTable ImportExcel()
        {
            DataTable table = new DataTable();

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Lưu file excel";
            fileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo existingFile = new FileInfo(fileDialog.FileName);

                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (ExcelPackage package = new ExcelPackage(existingFile))
                    {
                        ExcelWorksheet ews = package.Workbook.Worksheets[0];
                        if (ews.Dimension == null) // bảng có null không
                        {
                            MessageBox.Show("Bảng rỗng");
                            return table;
                        }
                        int startCL = ews.Dimension.Start.Column;
                        int endCL = ews.Dimension.End.Column;
                        for (int i = startCL; i <= endCL; i++)
                        {
                            string strValue = ews.Cells[1, i].Value == null ? "Column" + i : ews.Cells[1, i].Value.ToString();
                            table.Columns.Add(strValue);
                        }

                        int startR = ews.Dimension.Start.Row;
                        int endR = ews.Dimension.End.Row;
                        for (int i = startR + 1; i <= endR; i++)
                        {
                            List<string> listCells = new List<string>();
                            for (int j = startCL; j <= endCL; j++)
                            {
                                string strValue = ews.Cells[i, j].Value == null ? "" : ews.Cells[i, j].Value.ToString();
                                listCells.Add(strValue);
                            }
                            table.Rows.Add(listCells.ToArray());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
                }
            }
            return table;
        }
    }
}
