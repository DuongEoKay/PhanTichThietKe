using pttk.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.Business
{
    internal class HoadonBS(string HINHTHUCGIAODICH, string HinhThucThanhToan, string IDHINHTHUC, string IDHOADON, string IDPHIEU, string TINHTRANG, string TONGTIEN, string IDNHANVIEN)
    {
        public string HINHTHUCGIAODICH = HINHTHUCGIAODICH, HINHTHUCTHANHTOAN = HinhThucThanhToan, IDHINHTHUC = IDHINHTHUC, IDHOADON = IDHOADON, IDPHIEU = IDPHIEU, TINHTRANG = TINHTRANG, TONGTIEN = TONGTIEN, IDNHANVIEN = IDNHANVIEN;
      
        public static DataTable LoadCTHoaDon(OracleConnection conn, HoadonBS? hoaDon = null)
        {
            return HoadonDB.LayDSHoaDon(conn, hoaDon);
        }

        public static bool ThemHoaDon(ref HoadonBS hoaDon, OracleConnection conn)
        {
            
            try
            {
                HoadonDB.ThemHoaDon(hoaDon, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
