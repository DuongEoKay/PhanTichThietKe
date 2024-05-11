using PTTK.Database;

namespace PTTK_BUSINESS
{
    public class LoginBS
    {
        public static bool XuLyLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) return false;
            try
            {
                LoginDB.KiemTraLogin(username, password);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
