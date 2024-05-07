using Excel = Microsoft.Office.Interop.Excel;
using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class DoanhNghiep(string maDN, string tenCty, string maSoThue, string ngDaiDien, string dchi, 
        string email, string ngayLapHD, string ngayHHHD, string nvPhuTrach)
    {
        public string? maDN = maDN;
        readonly public string tenCty = tenCty, maSoThue = maSoThue, ngDaiDien = ngDaiDien, dchi = dchi,
            email = email, ngayLapHD = ngayLapHD, ngayHHHD = ngayHHHD, nvPhuTrach = nvPhuTrach;

        public static DataSet LoadTenDoanhNghiep(OracleConnection conn)
        {
            return DoanhNghiepDB.LayTenDoanhNghiep(conn);
        }

        public static DataTable LoadDSDoanhNghiep(OracleConnection conn, DoanhNghiep? doanhNghiep = null)
        {
            return DoanhNghiepDB.LayDSDoanhNghiep(conn, doanhNghiep);
        }

        public static bool ThemDoanhNghiep(ref DoanhNghiep doanhNghiep, OracleConnection conn)
        {
            if (string.IsNullOrEmpty(doanhNghiep.tenCty) || string.IsNullOrEmpty(doanhNghiep.maSoThue) ||
                string.IsNullOrEmpty(doanhNghiep.ngDaiDien) || string.IsNullOrEmpty(doanhNghiep.email) ||
                string.IsNullOrEmpty(doanhNghiep.dchi)) return false;
            try
            {
                doanhNghiep.maDN = DoanhNghiepDB.ThemDoanhNghiep(doanhNghiep, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool CapNhatHanHopDong(OracleConnection conn, string maDN, string ngayHH)
        {
            try
            {
                DoanhNghiepDB.CapNhatHopDong(conn, maDN, ngayHH);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ExportHDSapHetHan(DataGridView grid)
        {
            try
            {
                grid.SelectAll();
                DataObject dObj = grid.GetClipboardContent();
                if (dObj != null) Clipboard.SetDataObject(dObj);

                Excel.Application xlexcel;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application
                {
                    Visible = true
                };
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                xlexcel.Columns.AutoFit();
                xlexcel.Rows.AutoFit();
                xlexcel.Columns.Font.Size = 12;
                xlexcel.Visible = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
