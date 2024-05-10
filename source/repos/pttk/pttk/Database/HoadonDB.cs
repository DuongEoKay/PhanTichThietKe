using PTTK_ORACLE;
using pttk.Business;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.Database
{
    internal class HoadonDB
    {
        public static int? ThemHoaDon(HoadonBS hoaDon, OracleConnection conn)
        {
            try
            {
                conn.Open();
                string sql = $"INSERT INTO {OracleConfig.schema}.HOADON VALUES ('{hoaDon.HINHTHUCGIAODICH}','{hoaDon.HINHTHUCTHANHTOAN}', '{hoaDon.IDHOADON}', {hoaDon.TINHTRANG}, {hoaDon.TONGTIEN}, '{hoaDon.IDHINHTHUC}', '{hoaDon.IDPHIEU}', '{hoaDon.IDNHANVIEN}' )";
                OracleCommand cmd = new(sql, conn);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public static DataTable LayDSHoaDon(OracleConnection conn, HoadonBS? hoaDon = null)
        {
            /* string sql = $"SELECT HD.MADN, DN.TENCTY, HD.MAPHIEU, HD.MACT, HD.SOTIEN, HD.NGAYTRA, PT.TENPT " +
                 $"FROM {OracleConfig.schema}.CTHOADON HD JOIN {OracleConfig.schema}.DOANHNGHIEP DN ON HD.MADN=DN.MADN " +
                 $"JOIN {OracleConfig.schema}.PTTHANHTOAN PT ON PT.MAPT=HD.PTTHANHTOAN";*/
            string sql = $"Select * from {OracleConfig.schema}.Hoadon";
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
