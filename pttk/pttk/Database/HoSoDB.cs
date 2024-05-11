using PTTK_ORACLE;
using pttk.Business;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.Database
{
    internal class HoSoDB
    {
        public static DataTable LayHoSo(OracleConnection conn, HoSoBS? hoso = null)
        {
        
            string sql = $"select * from {OracleConfig.schema}.HoSoUngTuyen";

            

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

        public static DataTable LapDSHoSoUT(OracleConnection conn, string uuTien, string maphieu, string madn)
        {

            string sql = $"SELECT * from HoSoUngTUyen where DOUUTIEN = {uuTien} and Maphieu = {maphieu} and madn = {madn}";

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

        public static void ThemHoSo(HoSoBS hoso, OracleConnection conn)
        {
            try
            {
                conn.Open();
                /*string hoSoSql = $"INSERT INTO {OracleConfig.schema}.HOSOUNGTUYEN " +
                    $"VALUES('{hoso.maUV}', '{hoso.maDN}', '{hoso.maPhieu}', '{hoso.doUuTien}', " +
                    $"'{hoso.ghiChu}', {hoso.tinhTrang}, '{hoso.nvDuyet}')";
                OracleCommand cmdHoSo = new(hoSoSql, conn);
                cmdHoSo.ExecuteNonQuery();*/
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public static void DuyetHoSo(HoSoBS hoso, OracleConnection conn)
        {
            try
            {
                conn.Open();
                string hoSoSql = $"UPDATE {OracleConfig.schema}.HOSOUNGTUYEN " +
                    $"SET TINHTRANGDATUNGTUYEN={hoso.tinhTrangDatUngTuyen}, TINHTRANGDUYET='{hoso.tinhTrangDuyet}' WHERE IDUNGVIEN='{hoso.maUV}' AND IDPHIEUTTDT='{hoso.maPhieu}'";
                OracleCommand cmd = new(hoSoSql, conn);
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
