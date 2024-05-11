using pttk.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.NghiepVu
{
    internal class HopDongBS (string IDCHIENLUOC, string IDHOPDONG)
    {
        public string IDCHIENLUOC = IDCHIENLUOC, IDHOPDONG = IDHOPDONG;

        public static DataTable LoadHopDong(OracleConnection conn)
        {
            return HopDongDB.LayHopDong(conn);
        }

    }
}
