using Oracle.ManagedDataAccess.Client;
using pttk.Database;
using System.Data;

namespace pttk.Business
{
    internal class PDKQCBS(string IDHINHTHUC, string IDPHIEU, string THOIGIAN)
    {
        readonly public string IDHINHTHUC = IDHINHTHUC, THOIGIAN = THOIGIAN, IDPHIEU = IDPHIEU;
    

        public static bool ThemQuangCao(ref PDKQCBS qc, OracleConnection conn)
        {

            try
            {
                PDKQCDB.ThemQuangCao(qc, conn);
                return true;
            }
            catch (Exception) 
            {
                throw;
            }
        }


        public static DataTable LayPhieuDKQC(OracleConnection conn, PTTDTBS? phieu = null)
        {
            return PDKQCDB.LayTTPhieuDKQC(conn, phieu);
        }
    }
}
