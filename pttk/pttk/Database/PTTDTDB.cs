using PTTK_ORACLE;
using pttk.Business;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.Database
{
    internal class PTTDTDB
    {
        public static DataSet LayMaPhieu(OracleConnection conn)
        {
            string sql = $"SELECT * FROM {OracleConfig.schema}.PHIEUTHONGTINDANGTUYEN";
            try
            {
                conn.Open();
                DataSet dt = new();
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

       

        public static DataTable LayPhieuTTDT(OracleConnection conn, PTTDTBS? phieu = null)
        {
            string sql = $"SELECT * FROM {OracleConfig.schema}.PHIEUTHONGTINDANGTUYEN";
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

        public static string? ThemPhieu(PTTDTBS phieu, OracleConnection conn)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO {OracleConfig.schema}.PhieuThongTinDangTuyen " +
                 $"VALUES('{phieu.IDPHIEU}', {phieu.KHOANGTHOIGIAN}, {phieu.soLuongTD}, '{phieu.yeuCauUV}', " +
                 $"'{phieu.viTriUT}', '{phieu.IDDN}')";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                        
                    cmd.ExecuteNonQuery();
                }
                return "1";
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close();  }
        }
    }
}
