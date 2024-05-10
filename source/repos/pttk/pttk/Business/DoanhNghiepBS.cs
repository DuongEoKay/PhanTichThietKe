using Oracle.ManagedDataAccess.Client;
using pttk.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pttk.Business
{
    internal class DoanhNghiepBS(string maDN, string tenCty, string maSoThue, string nguoiDaiDien, string diachi,
    string email, string lanhDaoDeXuat, string nvPhuTrach)
    {
        public string? maDN = maDN;
        readonly public string tenCty = tenCty, maSoThue = maSoThue, nguoiDaiDien = nguoiDaiDien, diachi = diachi,
        email = email, lanhDaoDeXuat = lanhDaoDeXuat, nvPhuTrach = nvPhuTrach;
        public static DataTable LoadDSDoanhNghiep(OracleConnection conn)
        {
            return DoanhNghiepDB.LayDSDoanhNghiep(conn);
        }


        public static DataTable LoadDSDoanhNghiepTiemNang(OracleConnection conn)
        {
            return DoanhNghiepDB.LayDSDoanhNghiepTiemNang(conn);
        }

        public static bool ThemDoanhNghiep(ref DoanhNghiepBS doanhNghiep, OracleConnection conn)
        {
            if (string.IsNullOrEmpty(doanhNghiep.tenCty) || string.IsNullOrEmpty(doanhNghiep.maSoThue) ||
                string.IsNullOrEmpty(doanhNghiep.nguoiDaiDien) || string.IsNullOrEmpty(doanhNghiep.email) ||
                string.IsNullOrEmpty(doanhNghiep.diachi)) return false;
            try
            {
                doanhNghiep.maDN = DoanhNghiepDB.ThemDoanhNghiep(doanhNghiep, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
