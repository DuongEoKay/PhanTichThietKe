using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using PTTK_ORACLE;
using System.Data;

namespace pttk.Database
{
    internal class ChienLuocUuDaiDB
    {


        public static DataTable LayChienLuocUuDai(OracleConnection conn, ChienLuocUuDaiBS? chienLuoc = null)
        {
            string sql = $"SELECT * from chienluocuudai ";
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



        public static void ThemCL(ChienLuocUuDaiBS cl, OracleConnection conn)
        {
            try
            {
                conn.Open();
                string hoSoSql = $"INSERT INTO {OracleConfig.schema}.CHIENLUOCUUDAI VALUES('{cl.IDCHIENLUOC}', '{cl.MOTA}', '{cl.IDLANHDAO}')";
                OracleCommand cmdHoSo = new(hoSoSql, conn);
                cmdHoSo.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
