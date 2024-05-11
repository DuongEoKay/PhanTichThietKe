using Oracle.ManagedDataAccess.Client;
using PTTK_ORACLE;
namespace PTTK.Database
{
    public class LoginDB
    {
        public static void KiemTraLogin(string username, string password)
        {
            string connString = $"Data Source = {OracleConfig.connString};" +
                $"User Id = {username};password = {password};";

            OracleConnection conn = new(connString);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
