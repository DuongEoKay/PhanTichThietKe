using ISAD_QLTuyenDung.HoTro;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class PDKQuangCaoDB
    {
        public static void ThemQuangCao(PDKQuangCao qc, OracleConnection conn)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new($"{OracleConfig.schema}.USP_PDKQUANGCAO_INS", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("IMADN", OracleDbType.Varchar2, 255).Value = qc.maDN;
                cmd.Parameters.Add("IMAPHIEU", OracleDbType.Varchar2, 255).Value = qc.maPhieu;
                cmd.Parameters.Add("IMAHT", OracleDbType.Int64, 255).Value = qc.maHT;
                cmd.Parameters.Add("INGAYBD", OracleDbType.Varchar2, 255).Value = qc.ngayBD;
                cmd.Parameters.Add("INGAYKT", OracleDbType.Varchar2, 255).Value = qc.ngayKT;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
