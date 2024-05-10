﻿using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using pttk.Database;
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
    public partial class NhanVienUI : Form
    {
        readonly OracleConnection conn;
        public NhanVienUI(string text, string conn)
        {
            InitializeComponent();
            this.conn = new(conn);
            btnRefresh.PerformClick();
            label2.Text = "NV1";
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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DoanhNghiepBS dn = new("", TenCongTy_tb.Text, MaSoThue_tb.Text, NguoiDaiDien_tb.Text, DiaChi_tb.Text,
                Email_tb.Text, ID_LanhDaoDeXuat_tb.Text, IDNhanVienQuanLi_tb.Text);
            try
            {
                if (!DoanhNghiepBS.ThemDoanhNghiep(ref dn, conn))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm doanh nghiệp thành công!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            DanhSachDN_dgv2.DataSource = DoanhNghiepBS.LoadDSDoanhNghiep(conn);
            DanhSachPhieuTTDT_dgv.DataSource = PTTDTDB.LayPhieuTTDT(conn);
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = PTTDTBS.LoadPhieuTTDT(conn);
            dataGridView1.DataSource = PDKQCBS.LayPhieuDKQC(conn);
        }

        private void btnRefresh3_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon_dgv.DataSource = HoadonBS.LoadCTHoaDon(conn);
            DanhSachPhieuDKQC_dgv.DataSource = PDKQCBS.LayPhieuDKQC(conn);
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            DanhSachHS_dgv.DataSource = HoSoBS.LoadHoSo(conn);
        }

        private void btnRefreshTN_Click(object sender, EventArgs e)
        {
            DanhSachDN_dgv.DataSource = DoanhNghiepBS.LoadDSDoanhNghiepTiemNang(conn);
        }

        private void DanhSachDN_dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == DanhSachDN_dgv2.RowCount) return;
            DataGridViewRow cRow = DanhSachDN_dgv2.Rows[e.RowIndex];
            MaDN_tb1.Text = cRow.Cells["IDDoanhNghiep"].Value.ToString();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            PTTDTBS ptt = new PTTDTBS(MaDN_tb1.Text, ViTriUngTuyen_tb.Text, SoLuongTuyenDung_tb.Text, ThongTinYeuCauUV_tb.Text, IDPhieuTTDT_tb.Text, KhoangThoiGianDangTuyen_tb.Text);
            PTTDTBS.ThemPhieu(ref ptt, conn);
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            PDKQCBS pdk = new PDKQCBS(IDHinhThuc_tb.Text, IDPhieuTTDT_tb2.Text, ThoiGianDangTuyen_tb.Value.Date.ToString("dd-MM-yy"));
            PDKQCBS.ThemQuangCao(ref pdk, conn);
        }

        private void DanhSachPhieuDKQC_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow cRow = DanhSachPhieuDKQC_dgv.Rows[e.RowIndex];
            IDHinhThucDangTuyen_tb.Text = cRow.Cells["IDHINHTHUC"].Value.ToString();
            IDPhieuTTDT_tb1.Text = cRow.Cells["IDPHIEUTTDT"].Value.ToString();
        }

        private void btnThem3_Click(object sender, EventArgs e)
        {
            HoadonBS hoadon = new HoadonBS(HinhThucGiaoDich_tb.Text, HinhThucThanhToan_tb.Text, IDHinhThucDangTuyen_tb.Text, IDHoaDon_tb.Text, IDPhieuTTDT_tb1.Text, TinhTrang_tb.Text, TongTien_tb.Text, label2.Text);
            HoadonBS.ThemHoaDon(ref hoadon, conn);
        }

        private void btnRefresh5_Click(object sender, EventArgs e)
        {

        }
    }
}
