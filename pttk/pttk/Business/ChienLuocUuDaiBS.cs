using pttk.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.Business
{
    internal class ChienLuocUuDaiBS(string IDCHIENLUOC, string IDLANHDAO, string MOTA)
    {
        readonly public string IDCHIENLUOC = IDCHIENLUOC, IDLANHDAO = IDLANHDAO, MOTA = MOTA;

        public static DataTable LoadChienLuoc(OracleConnection conn, ChienLuocUuDaiBS? chienLuoc = null)
        {
            return ChienLuocUuDaiDB.LayChienLuocUuDai(conn, chienLuoc);
        }

        public static void ThemCL(OracleConnection conn, ref ChienLuocUuDaiBS cl)
        {
            ChienLuocUuDaiDB.ThemCL(cl, conn);
        }
    }
}
