using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using pttk.NghiepVu;
using PTTK_ORACLE;
using System.Data;

namespace pttk.Database
{
    internal class UngVienDB
    {
        public static DataTable LayUngVien(OracleConnection conn, SuDungCLDB? clApDung = null)
        {
            string sql = $"SELECT * from ungvien";
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

        public static void ThemUngVien(UngVienBS uv, OracleConnection conn)
        {
            string insSql = $"INSERT INTO {OracleConfig.schema}.ungvien VALUES ('{uv.email}', '{uv.hoten}', '{uv.idungvien}', '{uv.sdt}', '{uv.idnvql}')"; 
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
