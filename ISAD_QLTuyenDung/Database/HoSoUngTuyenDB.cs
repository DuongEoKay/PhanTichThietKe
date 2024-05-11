using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class HoSoUngTuyenDB
    {
        public static DataTable LayHoSo(OracleConnection conn, HoSoUngTuyen? hoso = null)
        {
            string orderSql = "ORDER BY HS.MAUV, HS.MADN, HS.MAPHIEU";
            string sql = $"SELECT HS.MAUV, UV.HOTEN, HS.MADN, HS.MAPHIEU, DT.VITRIUT, HS.DOUUTIEN, HS.GHICHU, HS.TINHTRANG, HS.NVDUYET " +
                $"FROM {OracleConfig.schema}.HOSOUNGTUYEN HS JOIN {OracleConfig.schema}.UNGVIEN UV ON HS.MAUV=UV.MAUV " +
                $"JOIN {OracleConfig.schema}.PTTDANGTUYEN DT ON HS.MADN=DT.MADN AND HS.MAPHIEU=DT.MAPHIEU";

            if (hoso != null) sql += $" WHERE HS.MAUV='{hoso.maUV}' AND HS.MADN='{hoso.maDN}' AND HS.MAPHIEU='{hoso.maPhieu}'";
            sql += $" {orderSql}";

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

        public static DataTable LapDSHoSoUT(OracleConnection conn, decimal uuTienLow, decimal uuTienHigh, HoSoUngTuyen? hoso = null)
        {
            string orderSql = "ORDER BY HS.MAUV, HS.MADN, HS.MAPHIEU";
            string sql = $"SELECT HS.MAUV, UV.HOTEN, HS.MADN, HS.MAPHIEU, DT.VITRIUT, HS.DOUUTIEN, HS.GHICHU, HS.TINHTRANG, HS.NVDUYET " +
                $"FROM {OracleConfig.schema}.HOSOUNGTUYEN HS JOIN {OracleConfig.schema}.UNGVIEN UV ON HS.MAUV=UV.MAUV " +
                $"JOIN {OracleConfig.schema}.PTTDANGTUYEN DT ON HS.MADN=DT.MADN AND HS.MAPHIEU=DT.MAPHIEU";

            sql += $" WHERE {uuTienLow} <= HS.DOUUTIEN AND HS.DOUUTIEN <= {uuTienHigh}";
            if (hoso != null)
            {
                if (!string.IsNullOrWhiteSpace(hoso.maDN)) sql += $" AND HS.MADN LIKE '%{hoso.maDN}%'";
                if (!string.IsNullOrWhiteSpace(hoso.maPhieu)) sql += $" AND HS.MAPHIEU LIKE '%{hoso.maPhieu}%'";
                if (!string.IsNullOrWhiteSpace(hoso.ghiChu)) sql += $" AND HS.GHICHU LIKE '%{hoso.ghiChu}%'";
                if (hoso.tinhTrang > 0) sql += $" AND HS.TINHTRANG = {hoso.tinhTrang}";
                if (!string.IsNullOrWhiteSpace(hoso.nvDuyet)) sql += $" AND HS.NVDUYET LIKE '%{hoso.nvDuyet}%'";
            }
            sql += $" {orderSql}";

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

        public static void ThemHoSo(HoSoUngTuyen hoso, OracleConnection conn)
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

        public static void DuyetHoSo(HoSoUngTuyen hoso, OracleConnection conn)
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
