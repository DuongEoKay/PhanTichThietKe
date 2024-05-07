using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class UngVien(string hoTen, string dChi, string sdt, string email, string nvPhuTrach)
    {
        public string? maUV;
        readonly public string hoTen = hoTen, dChi = dChi, sdt = sdt, email = email, nvPhuTrach = nvPhuTrach;

        public static DataSet LoadMaUngVien(OracleConnection conn)
        {
            return UngVienDB.LayIDUngVien(conn);
        }

        public static DataTable LoadDSUngVien(OracleConnection conn, UngVien? ungVien = null)
        {
            return UngVienDB.LayDSUngVien(conn, ungVien);
        }

        public static bool ThemUngVien(ref UngVien ungVien, OracleConnection conn)
        {
            if (string.IsNullOrEmpty(ungVien.hoTen) || string.IsNullOrEmpty(ungVien.dChi) ||
                string.IsNullOrEmpty(ungVien.sdt) || string.IsNullOrEmpty(ungVien.email)) return false;

            try
            {
                ungVien.maUV = UngVienDB.ThemUV(ungVien, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
