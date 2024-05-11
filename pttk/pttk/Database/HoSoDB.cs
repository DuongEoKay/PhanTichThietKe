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

        public static DataTable LapDSHoSoUT(OracleConnection conn, decimal uuTienLow, decimal uuTienHigh, HoSoBS? hoso = null)
        {
            string orderSql = "ORDER BY HS.MAUV, HS.MADN, HS.MAPHIEU";
            string sql = $"SELECT HS.MAUV, UV.HOTEN, HS.MADN, HS.MAPHIEU, DT.VITRIUT, HS.DOUUTIEN, HS.GHICHU, HS.TINHTRANG, HS.NVDUYET " +
                $"FROM {OracleConfig.schema}.HOSOUNGTUYEN HS JOIN {OracleConfig.schema}.UNGVIEN UV ON HS.MAUV=UV.MAUV " +
                $"JOIN {OracleConfig.schema}.PTTDANGTUYEN DT ON HS.MADN=DT.MADN AND HS.MAPHIEU=DT.MAPHIEU";

         

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
                string hoSoSql = $"INSERT INTO {OracleConfig.schema}.HOSOUNGTUYEN " +
                    $"VALUES('{hoso.maUV}', '{hoso.maDN}', '{hoso.maPhieu}', '{hoso.doUuTien}', " +
                    $"'{hoso.ghiChu}', {hoso.tinhTrang}, '{hoso.nvDuyet}')";
                OracleCommand cmdHoSo = new(hoSoSql, conn);
                cmdHoSo.ExecuteNonQuery();
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
                    $"SET DOUUTIEN={hoso.doUuTien}, GHICHU='{hoso.ghiChu}', TINHTRANG={hoso.tinhTrang} " +
                    $"WHERE MAUV='{hoso.maUV}' AND MADN='{hoso.maDN}' AND MAPHIEU='{hoso.maPhieu}'";

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
