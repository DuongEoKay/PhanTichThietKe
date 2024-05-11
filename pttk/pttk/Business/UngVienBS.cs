using pttk.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.Business
{
    internal class UngVienBS(string EMAIL, string HOTEN, string IDUNGVIEN, string SDT, string IDNVQL)
    {
        public string email = EMAIL, hoten = HOTEN, idungvien = IDUNGVIEN, sdt = SDT, idnvql = IDNVQL;
      
        public static DataTable LoadUngVien(OracleConnection conn, HoadonBS? hoaDon = null)
        {
            return UngVienDB.LayUngVien(conn);
        }

        public static bool ThemUngVien(ref UngVienBS uv, OracleConnection conn)
        {
            
            try
            {
                UngVienDB.ThemUngVien(uv, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
