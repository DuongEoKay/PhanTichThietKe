using ISAD_QLTuyenDung.Database;

namespace ISAD_QLTuyenDung.NghiepVu
{
    public class Login
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
