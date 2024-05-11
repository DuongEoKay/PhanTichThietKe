using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class ChienLuocUuDai(string maCL, string tenCL, string moTa, string ldDeXuat)
    {
        public string? maCL = maCL;
        readonly public string tenCL = tenCL, moTa = moTa, ldDeXuat = ldDeXuat;

        public static DataTable LoadChienLuoc(OracleConnection conn, ChienLuocUuDai? chienLuoc = null)
        {
            return ChienLuocUuDaiDB.LayChienLuocUuDai(conn, chienLuoc);
        }

        public static DataSet LoadMaTenCL(OracleConnection conn)
        {
            return ChienLuocUuDaiDB.LayMaTenCL(conn);
        }

        public static bool ThemChienLuoc(ref ChienLuocUuDai chienLuoc, OracleConnection conn)
        {
            if (string.IsNullOrEmpty(chienLuoc.tenCL)) return false;
            try
            {
                chienLuoc.maCL = ChienLuocUuDaiDB.ThemChienLuoc(chienLuoc, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
