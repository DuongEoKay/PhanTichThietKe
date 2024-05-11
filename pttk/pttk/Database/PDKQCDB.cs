using PTTK_ORACLE;
using pttk.Business;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.Database
{
    internal class PDKQCDB
    {
        public static void ThemQuangCao(PDKQCBS qc, OracleConnection conn)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO {OracleConfig.schema}.PHIEUDANGKYQUANGCAO VALUES (to_date('{qc.THOIGIAN}','DD-MM-YY'), '{qc.IDHINHTHUC}', '{qc.IDPHIEU}')";
                MessageBox.Show(sql);
                OracleCommand cmd = new(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }


        public static DataTable LayTTPhieuDKQC(OracleConnection conn, PTTDTBS? phieu = null)
        {
            string sql = $"SELECT * FROM {OracleConfig.schema}.PHIEUDANGKYQUANGCAO";
            try
            {
                conn.Open();
                DataTable dt = new();
                OracleDataAdapter ap = new(sql, conn);
                ap.Fill(dt);
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
