using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using pttk.NghiepVu;
using PTTK_ORACLE;
using System.Data;

namespace pttk.Database
{
    internal class HopDongDB
    {
        public static DataTable LayHopDong(OracleConnection conn)
        {
            string sql = $"SELECT * from hopdong";
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                conn.Open();
                DataTable dt = new();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

    
    }
}
