using Oracle.ManagedDataAccess.Client;
using pttk.Business;
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



        public static DataTable LayDSDoanhNghiepTiemNang(OracleConnection conn)
        {
            string sql = $"SELECT * FROM {OracleConfig.schema}.DOANHNGHIEP where TiemNang = 1";
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

        public static string? ThemDoanhNghiep(DoanhNghiepBS doanhNghiep,OracleConnection conn)
        {
            try
            {
                string query = "INSERT INTO {OracleConfig.schema}.DOANHNGHIEP (IDPHIEUTTDT, KHOANGTHOIGIANDANGTUYEN, SOLUONGTUYENDUNG, THONGTINYEUCAUUNGVIEN, VITRIUNGTUYEN, IDDOANHNGHIEP) VALUES (@id, @period, @quantity, @info, @position, @businessId)";
                conn.Open();
                OracleCommand cmd = new(query, conn)
                {
                  
                };

                cmd.Parameters.Add("TENCTY", OracleDbType.Varchar2, 255).Value = doanhNghiep.tenCty;
                cmd.Parameters.Add("MASOTHUE", OracleDbType.Varchar2, 255).Value = doanhNghiep.maSoThue;
                cmd.Parameters.Add("NGDAIDIEN", OracleDbType.Varchar2, 255).Value = doanhNghiep.nguoiDaiDien;
                cmd.Parameters.Add("IDCHI", OracleDbType.Varchar2, 255).Value = doanhNghiep.diachi;
                cmd.Parameters.Add("EMAIL", OracleDbType.Varchar2, 255).Value = doanhNghiep.email;
                cmd.Parameters.Add("IDLANHDAODEXUAT", OracleDbType.Varchar2, 255).Value = doanhNghiep.lanhDaoDeXuat;
                cmd.Parameters.Add("IDNVPHUTRACH", OracleDbType.Varchar2, 255).Value = doanhNghiep.nvPhuTrach;
                cmd.Parameters.Add("IMADN", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;

                cmd.ExecuteNonQuery();
                return cmd.Parameters[8].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
