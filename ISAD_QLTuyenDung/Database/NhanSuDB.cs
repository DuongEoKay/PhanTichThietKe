using ISAD_QLTuyenDung.HoTro;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class NhanSuDB
    {
        public static string LayTenNhanSu(string curUser, OracleConnection conn)
        {
            string sql = $"SELECT HOTEN FROM {OracleConfig.schema}.NHANSU WHERE IDNHANSU='{curUser}'";
            string name = " ";
            OracleCommand cmd = new(sql, conn);
            try
            {
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = reader.GetString(0);
                }
                return name;
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public static DataSet LayMaNhanVien(OracleConnection conn)
        {
            string sql = $"SELECT MANV FROM {OracleConfig.schema}.NHANSU WHERE MANV LIKE 'N3NV%' ORDER BY MANV";

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
    }
}
