using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using pttk.NghiepVu;
using PTTK_ORACLE;
using System.Data;

namespace pttk.Database
{
    internal class SuDungCLDB
    {
        public static DataTable LayChienLuocSD(OracleConnection conn, SuDungCLDB? clApDung = null)
        {
            string sql = $"SELECT * from sudungcl";
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

        public static void ApDungCL(SuDungCLBS clApDung, OracleConnection conn)
        {
            string insSql = $"INSERT INTO {OracleConfig.schema}.sudungcl VALUES ('{clApDung.IDCHIENLUOC}', '{clApDung.IDHOPDONG}')"; 
            OracleCommand cmd = new(insSql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
