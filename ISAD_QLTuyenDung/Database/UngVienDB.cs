using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class UngVienDB
    {
        public static DataSet LayIDUngVien(OracleConnection conn)
        {
            string sql = $"SELECT MAUV FROM {OracleConfig.schema}.UNGVIEN ORDER BY MAUV";

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

        public static DataTable LayDSUngVien(OracleConnection conn, UngVien? ungVien = null)
        {
            string sql = $"SELECT * FROM {OracleConfig.schema}.UNGVIEN";
            if (ungVien != null) sql += $" WHERE MAUV='{ungVien.maUV}'";
            sql += " ORDER BY MAUV";
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

        public static string? ThemUV(UngVien ungVien, OracleConnection conn)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new($"{OracleConfig.schema}.USP_UNGVIEN_INS", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("IHOTEN", OracleDbType.Varchar2, 255).Value = ungVien.hoTen;
                cmd.Parameters.Add("IDCHI", OracleDbType.Varchar2, 255).Value = ungVien.dChi;
                cmd.Parameters.Add("ISDT", OracleDbType.Varchar2, 255).Value = ungVien.sdt;
                cmd.Parameters.Add("IEMAIL", OracleDbType.Varchar2, 255).Value = ungVien.email;
                cmd.Parameters.Add("INVPHUTRACH", OracleDbType.Varchar2, 255).Value = ungVien.nvPhuTrach;
                cmd.Parameters.Add("IMAUV", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;

                cmd.ExecuteNonQuery();
                return cmd.Parameters[5].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
