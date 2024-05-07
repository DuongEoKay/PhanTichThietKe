using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class DoanhNghiepDB
    {
        public static DataSet LayTenDoanhNghiep(OracleConnection conn)
        {
            string sql = $"SELECT IDDOANHNGHIEP FROM {OracleConfig.schema}.DOANHNGHIEP";
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

        public static DataTable LayDSDoanhNghiep(OracleConnection conn, DoanhNghiep? doanhNghiep = null)
        {
            string sql = $"SELECT * FROM {OracleConfig.schema}.DOANHNGHIEP";
            if (doanhNghiep != null)
            {
                sql += " WHERE 1=1";
                if (!string.IsNullOrWhiteSpace(doanhNghiep.maDN)) sql += $" AND MADN LIKE '%{doanhNghiep.maDN}%'";
                if (!string.IsNullOrWhiteSpace(doanhNghiep.tenCty)) sql += $" AND TENCTY LIKE '%{doanhNghiep.tenCty}%'";
                if (!string.IsNullOrWhiteSpace(doanhNghiep.maSoThue))
                    sql += $" AND MASOTHUE LIKE '%{doanhNghiep.maSoThue}%'";
                if (!string.IsNullOrWhiteSpace(doanhNghiep.ngDaiDien))
                    sql += $" AND NGDAIDIEN LIKE '%{doanhNghiep.ngDaiDien}%'";
                if (!string.IsNullOrWhiteSpace(doanhNghiep.dchi)) sql += $" AND DCHI LIKE '%{doanhNghiep.dchi}%'";
                if (!string.IsNullOrWhiteSpace(doanhNghiep.email)) sql += $" AND EMAIL LIKE '%{doanhNghiep.email}%'";
                if (!string.IsNullOrWhiteSpace(doanhNghiep.ngayLapHD))
                    sql += $" AND NGAYLAPHD >= TO_DATE('{doanhNghiep.ngayLapHD}', 'DD/MM/YYYY')";
                if (!string.IsNullOrWhiteSpace(doanhNghiep.ngayHHHD))
                    sql += $" AND NGAYHHHD <= TO_DATE('{doanhNghiep.ngayHHHD}', 'DD/MM/YYYY')";
                if (!string.IsNullOrWhiteSpace(doanhNghiep.nvPhuTrach))
                    sql += $" AND NVPHUTRACH LIKE '%{doanhNghiep.nvPhuTrach}%'";
            }
            sql += " ORDER BY MADN";
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

        public static string? ThemDoanhNghiep(DoanhNghiep doanhNghiep, OracleConnection conn)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new($"{OracleConfig.schema}.USP_DOANHNGHIEP_INS", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("ITENCTY", OracleDbType.Varchar2, 255).Value = doanhNghiep.tenCty;
                cmd.Parameters.Add("IMASOTHUE", OracleDbType.Varchar2, 255).Value = doanhNghiep.maSoThue;
                cmd.Parameters.Add("INGDAIDIEN", OracleDbType.Varchar2, 255).Value = doanhNghiep.ngDaiDien;
                cmd.Parameters.Add("IDCHI", OracleDbType.Varchar2, 255).Value = doanhNghiep.dchi;
                cmd.Parameters.Add("IEMAIL", OracleDbType.Varchar2, 255).Value = doanhNghiep.email;
                cmd.Parameters.Add("INGAYLAPHD", OracleDbType.Varchar2, 255).Value = doanhNghiep.ngayLapHD;
                cmd.Parameters.Add("INGAYHHHD", OracleDbType.Varchar2, 255).Value = doanhNghiep.ngayHHHD;
                cmd.Parameters.Add("INVPHUTRACH", OracleDbType.Varchar2, 255).Value = doanhNghiep.nvPhuTrach;
                cmd.Parameters.Add("IMADN", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;

                cmd.ExecuteNonQuery();
                return cmd.Parameters[8].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close();  }
        }

        public static void CapNhatHopDong(OracleConnection conn, string maDN, string ngayHH)
        {
            string sql = $"UPDATE {OracleConfig.schema}.DOANHNGHIEP " +
                $"SET NGAYHHHD=TO_DATE('{ngayHH}', 'DD-MM-YYYY') WHERE MADN='{maDN}'";
            try
            {
                conn.Open();
                OracleCommand cmd = new(sql, conn);
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
