using Excel = Microsoft.Office.Interop.Excel;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using ISAD_QLTuyenDung.Database;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class DNTiemNang(string maDN, string ldDanhGia, int tiemNang, string ghiChu, DateTime ngayCapNhat)
    {
        readonly public string maDN = maDN, ldDanhGia = ldDanhGia, ghiChu = ghiChu;
        readonly public int tiemNang = tiemNang;
        readonly public DateTime ngayCapNhat = ngayCapNhat;

        public static DataTable LoadDanhGia(OracleConnection conn, DNTiemNang? danhGia = null)
        {
            return DNTiemNangDB.LayDanhGia(conn, danhGia);
        }

        public static DataTable LoadThongKe(string maDN, OracleConnection conn)
        {
            return DNTiemNangDB.ThongKeDoanhNghiep(maDN, conn);
        }

        public static DataTable LoadDSTiemNang(OracleConnection conn, decimal lower=0, decimal upper=10)
        {
            return DNTiemNangDB.LapDSTiemNang(conn, lower, upper);
        }

        public static bool ThemDanhGia(DNTiemNang danhGia, OracleConnection conn)
        {
            if (danhGia.tiemNang < 1 || danhGia.tiemNang > 10) return false;
            try
            {
                DNTiemNangDB.ThemDanhGia(danhGia, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ExportDSTiemNang(DataGridView grid)
        {
            try
            {
                grid.SelectAll();
                DataObject dObj = grid.GetClipboardContent();
                if (dObj != null ) Clipboard.SetDataObject(dObj);

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
