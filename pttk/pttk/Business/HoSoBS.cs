using Excel = Microsoft.Office.Interop.Excel;
using Oracle.ManagedDataAccess.Client;
using pttk.Database;
using System.Data;

namespace pttk.Business
{
    internal class HoSoBS(string maUV, string maPhieu, string idGiayTo, string tinhTrangDuyet,
        string tinhTrangDatUngTuyen, string nvDuyet, string DoUuTien)
    {
        readonly public string maUV = maUV, idGiayTo = idGiayTo, maPhieu = maPhieu, tinhTrangDuyet = tinhTrangDuyet, nvDuyet = nvDuyet, tinhTrangDatUngTuyen = tinhTrangDatUngTuyen;

        public static DataTable LoadHoSo(OracleConnection conn, HoSoBS? hoso = null)
        {
            return HoSoDB.LayHoSo(conn, hoso);
        }

        public static DataTable LapDSHoSoUT(OracleConnection conn, string uuTien, string maphieu, string madn)
        {
            return HoSoDB.LapDSHoSoUT(conn, uuTien, maphieu, madn);
        }

        public static bool ThemHoSo(ref HoSoBS hoso, OracleConnection conn)
        {
            
            try
            {
                HoSoDB.ThemHoSo(hoso, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DuyetHoSo(ref HoSoBS hoso, OracleConnection conn)
        {
            try
            {
                HoSoDB.DuyetHoSo(hoso, conn);
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
