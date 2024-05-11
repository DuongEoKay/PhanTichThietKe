using pttk.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.NghiepVu
{
    internal class SuDungCLBS (string IDCHIENLUOC, string IDHOPDONG)
    {
        public string IDCHIENLUOC = IDCHIENLUOC, IDHOPDONG = IDHOPDONG;

        public static DataTable LoadCLApDung(OracleConnection conn)
        {
            return SuDungCLDB.LayChienLuocSD(conn);
        }

        public static bool ThemCLApDung(ref SuDungCLBS clApDung, OracleConnection conn)
        {
            try
            {
                SuDungCLDB.ApDungCL(clApDung,conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
