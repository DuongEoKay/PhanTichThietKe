using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pttk.UI
{
    public partial class LanhDaoUI : Form
    {
        readonly OracleConnection conn;
        string manv;
        public LanhDaoUI(string conn, string manv)
        {
            InitializeComponent();
            this.conn = new(conn);
            this.manv = manv;
            IDLanhDao_tb.Text = manv;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DanhSachDN_dgv.DataSource = DoanhNghiepBS.LoadDSDoanhNghiep(conn);
        }

        private void DanhSachDN_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == DanhSachDN_dgv.RowCount) return;
            DataGridViewRow cRow = DanhSachDN_dgv.Rows[e.RowIndex];
            MaDN_tb.Text = cRow.Cells["IDDoanhNghiep"].Value.ToString();
            TenCongTy_tb.Text = cRow.Cells["TENCongTY"].Value.ToString();
            IDNhanVienQuanLi_tb.Text = cRow.Cells["IDnhanvienquanly"].Value.ToString();
            MaSoThue_tb.Text = cRow.Cells["MASOTHUE"].Value.ToString();
            Email_tb.Text = cRow.Cells["EMAIL"].Value.ToString();
            NguoiDaiDien_tb.Text = cRow.Cells["NGuoidaidien"].Value.ToString();
            DiaChi_tb.Text = cRow.Cells["DIAChi"].Value.ToString();
            ID_LanhDaoDeXuat_tb.Text = cRow.Cells["IDlanhdaodexuat"].Value.ToString();
            TiemNang_tb.Text = cRow.Cells["TIEMNANG"].Value.ToString();
        }

        private void btnTiemNang_Click(object sender, EventArgs e)
        {
            DoanhNghiepBS.CapNhatTrangThaiTN0(MaDN_tb.Text, conn);
            btnRefresh.PerformClick();
        }

        private void btnHuyTiemNang_Click(object sender, EventArgs e)
        {
            DoanhNghiepBS.CapNhatTrangThaiTN1(MaDN_tb.Text, conn);
            btnRefresh.PerformClick();
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            DanhSachCL_dgv.DataSource = ChienLuocUuDaiBS.LoadChienLuoc(conn);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChienLuocUuDaiBS cl = new ChienLuocUuDaiBS(IDChienLuoc_tb.Text, IDLanhDao_tb.Text, MoTa_tb.Text);
            ChienLuocUuDaiBS.ThemCL(conn, ref cl);
        }
    }
}
