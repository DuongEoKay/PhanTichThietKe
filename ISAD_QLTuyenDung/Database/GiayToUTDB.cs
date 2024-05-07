using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;
using ISAD_QLTuyenDung.HoTro;
using System.Data;

namespace ISAD_QLTuyenDung.Database
{
    internal class GiayToUTDB
    {
        public static int ThemGiayTo(GiayToUT giayTo, OracleConnection conn)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new($"{OracleConfig.schema}.USP_GIAYTOUT_INS", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("IMAUV", OracleDbType.Varchar2, 255).Value = giayTo.maUV;
                cmd.Parameters.Add("IMADN", OracleDbType.Varchar2, 255).Value = giayTo.maDN;
                cmd.Parameters.Add("IMAPHIEU", OracleDbType.Varchar2, 255).Value = giayTo.maPhieu;
                cmd.Parameters.Add("ITHONGTIN", OracleDbType.Varchar2, 255).Value = giayTo.thongTin;
                cmd.Parameters.Add("ILOAIGIAY", OracleDbType.Int64, 255).Value = giayTo.loaiGiay;
                cmd.Parameters.Add("IMAGIAY", OracleDbType.Varchar2, ParameterDirection.Output).Size = 255;
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(cmd.Parameters[5].Value.ToString());
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
        }
    }
}
