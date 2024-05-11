using ISAD_QLTuyenDung.HoTro;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.Database
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
