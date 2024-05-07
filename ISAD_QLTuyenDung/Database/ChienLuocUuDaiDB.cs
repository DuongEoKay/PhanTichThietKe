using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;
using ISAD_QLTuyenDung.HoTro;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class ChienLuocUuDaiDB
    {
        static readonly string sql = $"SELECT CL.*, NS.HOTEN " +
            $"FROM {OracleConfig.schema}.CHIENLUOCUUDAI CL JOIN {OracleConfig.schema}.NHANSU NS " +
            $"ON CL.IDLANHDAO = NS.IDNHANSU";
        static readonly string orderSql = "ORDER BY CL.MACL";

        public static DataTable LayChienLuocUuDai(OracleConnection conn, ChienLuocUuDai? chienLuoc = null)
        {
            string seSql = sql;
            if (chienLuoc != null) seSql += $" WHERE CL.IDCHIENLUOC = '{chienLuoc.maCL}'";
            OracleDataAdapter adp = new($"{seSql} {orderSql}", conn);
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

        public static DataSet LayMaTenCL(OracleConnection conn)
        {
            string sql = $"SELECT IDCHIENLUOC  FROM {OracleConfig.schema}.CHIENLUOCUUDAI ORDER BY IDCHIENLUOC";
            OracleDataAdapter adp = new(sql, conn);
            try
            {
                conn.Open();
                DataSet dt = new();
                adp.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public static string? ThemChienLuoc(ChienLuocUuDai chienLuoc, OracleConnection conn)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new($"{OracleConfig.schema}.USP_CHIENLUOCUUDAI_INS", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("ITENCL", OracleDbType.Varchar2, 255).Value = chienLuoc.tenCL;
                cmd.Parameters.Add("IMOTA", OracleDbType.Varchar2, 255).Value = chienLuoc.moTa;
                cmd.Parameters.Add("ILDDEXUAT", OracleDbType.Varchar2, 255).Value = chienLuoc.ldDeXuat;
                cmd.Parameters.Add("IMACL", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;

                cmd.ExecuteNonQuery();
                return cmd.Parameters[3].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
