using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;
using ISAD_QLTuyenDung.HoTro;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class CLApDungDB
    {
        public static DataTable LayChienLuocApDung(OracleConnection conn, CLApDung? clApDung = null)
        {
            string sql = $"SELECT DN.IDDOANHNGHIEP, DN.TENCONGTY, CL.IDCHIENLUOC, HD.NGAYDANGKY, HD.NGAYHETHAN " +
            $"FROM {OracleConfig.schema}.SUDUNGCL CL JOIN {OracleConfig.schema}.HOPDONG HD ON CL.IDHOPDONG=HD.IDHOPDONG " +
            $"JOIN {OracleConfig.schema}.DOANHNGHIEP DN  ON HD.IDDOANHNGHIEP = DN.IDDOANHNGHIEP";
          
              

            //if (clApDung != null) sql += $" WHERE CL.MADN='{clApDung.maDN}' AND CL.MACL='{clApDung.maCL}'";
            //sql += " ORDER BY CL.MADN, CL.MACL";
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

        public static void ApDungCL(CLApDung clApDung, OracleConnection conn)
        {
            string insSql = $"INSERT INTO {OracleConfig.schema}.CLAPDUNG " +
                $"VALUES('{clApDung.maDN}', '{clApDung.maCL}', TO_DATE('{clApDung.ngayBD}', 'DD/MM/YYYY'), " +
                $"TO_DATE('{clApDung.ngayKT}', 'DD/MM/YYYY'))";

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
