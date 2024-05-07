using ISAD_QLTuyenDung.Database;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.NghiepVu
{
    internal class GiayToUT(string maUV, string maDN, string maPhieu, int maGiay,
        string thongTin, int loaiGiay)
    {
        public readonly string maUV = maUV, maDN = maDN, maPhieu = maPhieu, thongTin = thongTin;
        public readonly int loaiGiay = loaiGiay;
        public int maGiay = maGiay;

        public static bool ThemGiayToUT(ref GiayToUT giayTo, OracleConnection conn)
        {
            if (giayTo.loaiGiay == 0) return false;
            try
            {
                giayTo.maGiay = GiayToUTDB.ThemGiayTo(giayTo, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
