using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using pttk.NghiepVu;
using PTTK_ORACLE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pttk.Database
{
    internal class DoanhNghiepDB
    {
        public static DataTable LayDSDoanhNghiep(OracleConnection conn)
        {
            string sql = $"SELECT * FROM {OracleConfig.schema}.DOANHNGHIEP";
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


        public static void ThemDoanhNghiep(DoanhNghiepBS doanhNghiep,OracleConnection conn)
        {
            try
            {
                string query = $"INSERT INTO {OracleConfig.schema}.DOANHNGHIEP Values ('{doanhNghiep.diachi}','{doanhNghiep.email}','{doanhNghiep.maDN}','{doanhNghiep.maSoThue}','{doanhNghiep.nguoiDaiDien}','{doanhNghiep.tenCty}',null,'{doanhNghiep.nvQuanly}','{doanhNghiep.lanhDaoDeXuat}')";
                conn.Open();
                OracleCommand cmd = new(query, conn);
                cmd.ExecuteNonQuery();             
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }

        public static void CapNhatTrangThaiTN0(ref string ID, OracleConnection conn)
        {
            string insSql = $"UPDATE {OracleConfig.schema}.DOANHNGHIEP SET TIEMNANG = 0 where IDDOANHNGHIEP = '{ID}'";
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

        public static void CapNhatTrangThaiTN1(ref string ID, OracleConnection conn)
        {
            string insSql = $"UPDATE {OracleConfig.schema}.DOANHNGHIEP SET TIEMNANG = 1 where IDDOANHNGHIEP = '{ID}'";
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
