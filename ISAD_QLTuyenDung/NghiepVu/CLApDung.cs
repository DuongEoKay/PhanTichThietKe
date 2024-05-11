using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class CLApDung (string maDN, string maCL, string ngayBD, string ngayKT)
    {
        readonly public string maDN = maDN, maCL = maCL, ngayBD = ngayBD, ngayKT = ngayKT;

        public static DataTable LoadCLApDung(OracleConnection conn, CLApDung? clApDung = null)
        {
            return CLApDungDB.LayChienLuocApDung(conn, clApDung);
        }

        public static bool ThemCLApDung(ref CLApDung clApDung, OracleConnection conn)
        {
            try
            {
                CLApDungDB.ApDungCL(clApDung, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
