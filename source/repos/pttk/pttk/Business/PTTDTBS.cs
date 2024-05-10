using pttk.Database;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace pttk.Business
{
    internal class PTTDTBS (string IDDN, string viTriUT, string soLuongTD,
        string yeuCauUV,  string IDPHIEU, string KHOANGTHOIGIAN)
    {
       
        readonly public string IDDN = IDDN, viTriUT = viTriUT, yeuCauUV = yeuCauUV, IDPHIEU = IDPHIEU;
        readonly public string soLuongTD = soLuongTD, KHOANGTHOIGIAN=KHOANGTHOIGIAN;

        public static DataTable LoadPhieuTTDT(OracleConnection conn, PTTDTBS? phieu = null)
        {
            return PTTDTDB.LayPhieuTTDT(conn, phieu);
        }

     
      
        public static bool ThemPhieu(ref PTTDTBS phieu, OracleConnection conn)
        {
            if (string.IsNullOrEmpty(phieu.yeuCauUV)) return false;
            try
            {
                PTTDTDB.ThemPhieu(phieu, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
