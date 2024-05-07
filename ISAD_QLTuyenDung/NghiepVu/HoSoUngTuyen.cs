using Excel = Microsoft.Office.Interop.Excel;
using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.Database;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class HoSoUngTuyen(string maUV, string maDN, string maPhieu, int doUuTien, string ghiChu,
        int tinhTrang, string nvDuyet)
    {
        readonly public string maUV = maUV, maDN = maDN, maPhieu = maPhieu, ghiChu = ghiChu, nvDuyet = nvDuyet;
        readonly public int doUuTien = doUuTien, tinhTrang = tinhTrang;

        public static DataTable LoadHoSo(OracleConnection conn, HoSoUngTuyen? hoso = null)
        {
            return HoSoUngTuyenDB.LayHoSo(conn, hoso);
        }

        public static DataTable LapDSHoSoUT(OracleConnection conn, decimal uuTienLow, decimal uuTienHigh, HoSoUngTuyen? hoso = null)
        {
            return HoSoUngTuyenDB.LapDSHoSoUT(conn, uuTienLow, uuTienHigh, hoso);
        }

        public static bool ThemHoSo(ref HoSoUngTuyen hoso, OracleConnection conn)
        {
            if (hoso.tinhTrang == 0) return false;
            try
            {
                HoSoUngTuyenDB.ThemHoSo(hoso, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DuyetHoSo(ref HoSoUngTuyen hoso, OracleConnection conn)
        {
            try
            {
                HoSoUngTuyenDB.DuyetHoSo(hoso, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ExportHoSo(DataGridView grid)
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
