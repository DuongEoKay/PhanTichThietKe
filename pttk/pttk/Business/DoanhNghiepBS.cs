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
    string email, string lanhDaoDeXuat, string nvQuanly)
    {
        public string? maDN = maDN;
        readonly public string tenCty = tenCty, maSoThue = maSoThue, nguoiDaiDien = nguoiDaiDien, diachi = diachi,
        email = email, lanhDaoDeXuat = lanhDaoDeXuat, nvQuanly = nvQuanly;
        public static DataTable LoadDSDoanhNghiep(OracleConnection conn)
        {
            return DoanhNghiepDB.LayDSDoanhNghiep(conn);
        }


        public static bool ThemDoanhNghiep(ref DoanhNghiepBS doanhNghiep, OracleConnection conn)
        {
            if (string.IsNullOrEmpty(doanhNghiep.tenCty) || string.IsNullOrEmpty(doanhNghiep.maSoThue) ||
                string.IsNullOrEmpty(doanhNghiep.nguoiDaiDien) || string.IsNullOrEmpty(doanhNghiep.email) ||
                string.IsNullOrEmpty(doanhNghiep.diachi)) return false;
            try
            {
                DoanhNghiepDB.ThemDoanhNghiep(doanhNghiep, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool CapNhatTrangThaiTN0(string IDDN, OracleConnection conn)
        {
            try
            {
                DoanhNghiepDB.CapNhatTrangThaiTN0(ref IDDN, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool CapNhatTrangThaiTN1(string IDDN, OracleConnection conn)
        {
            try
            {
                DoanhNghiepDB.CapNhatTrangThaiTN1(ref IDDN, conn);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
