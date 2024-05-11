using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.Database;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class PDKQuangCao(string maDN, string? maPhieu, int maHT, string ngayBD, string ngayKT)
    {
        readonly public string? maPhieu = maPhieu;
        readonly public string maDN = maDN, ngayBD = ngayBD, ngayKT = ngayKT;
        readonly public int maHT = maHT;

        public static bool ThemQuangCao(ref PDKQuangCao qc, OracleConnection conn)
        {
            if (qc.maHT == 0) return false;
            try
            {
                PDKQuangCaoDB.ThemQuangCao(qc, conn);
                return true;
            }
            catch (Exception) 
            {
                throw;
            }
        }
    }
}
