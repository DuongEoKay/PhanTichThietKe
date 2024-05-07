using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class PTTDangTuyenDB
    {
        public static DataSet LayMaPhieu(OracleConnection conn, string? maDN = null)
        {
            string sql = $"SELECT DISTINCT MAPHIEU FROM {OracleConfig.schema}.PTTDANGTUYEN";
            if (maDN != null) sql += $" WHERE MADN='{maDN}'";
            sql += " ORDER BY MAPHIEU";
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

        public static DataSet LayMaDN(OracleConnection conn)
        {
            string sql = $"SELECT DISTINCT MADN FROM {OracleConfig.schema}.PTTDANGTUYEN ORDER BY MADN";

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
            finally { conn.Close() ; }
        }

        public static DataTable LayPhieuTTDT(OracleConnection conn, PTTDangTuyen? phieu = null)
        {
            string sql = $"SELECT * FROM {OracleConfig.schema}.PTTDANGTUYEN";
            if (phieu!= null) sql += $" WHERE MAPHIEU='{phieu.maPhieu}' AND MADN='{phieu.maDN}'";
            sql += " ORDER BY MADN, MAPHIEU";
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

        public static string? ThemPhieu(PTTDangTuyen phieu, OracleConnection conn)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new($"{OracleConfig.schema}.USP_PTTDANGTUYEN_INS", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("IMADN", OracleDbType.Varchar2, 255).Value = phieu.maDN;
                cmd.Parameters.Add("IVITRIUT", OracleDbType.Varchar2, 255).Value = phieu.viTriUT;
                cmd.Parameters.Add("ISOLUONGTD", OracleDbType.Int64, 255).Value = phieu.soLuongTD;
                cmd.Parameters.Add("INGAYBD", OracleDbType.Varchar2, 255).Value = phieu.ngayBD;
                cmd.Parameters.Add("INGAYKT", OracleDbType.Varchar2, 255).Value = phieu.ngayKT;
                cmd.Parameters.Add("IYEUCAUUV", OracleDbType.Varchar2, 255).Value = phieu.yeuCauUV;
                cmd.Parameters.Add("ITONGTIEN", OracleDbType.Int64, 255).Value = phieu.tongTien;
                cmd.Parameters.Add("IHTTHANHTOAN", OracleDbType.Int64, 255).Value = phieu.htThanhToan;
                cmd.Parameters.Add("INVLAP", OracleDbType.Varchar2, 255).Value = phieu.nvLap;
                cmd.Parameters.Add("IMAPHIEU", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;

                cmd.ExecuteNonQuery();
                return cmd.Parameters[9].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close();  }
        }
    }
}
