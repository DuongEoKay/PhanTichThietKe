using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using pttk.Database;
using pttk.NghiepVu;
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
            DanhSachUngVien_dgv.DataSource = UngVienBS.LoadUngVien(this.conn);
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

            DoanhNghiepBS dn = new(MaDN_tb.Text, TenCongTy_tb.Text, MaSoThue_tb.Text, NguoiDaiDien_tb.Text, DiaChi_tb.Text,
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
            DanhSachSDCL.DataSource = SuDungCLBS.LoadCLApDung(conn);
            DanhSachCL_dgv.DataSource = ChienLuocUuDaiBS.LoadChienLuoc(conn);
            DanhSachHopDong_dgv.DataSource = HopDongBS.LoadHopDong(conn);
        }

        private void btnThem5_Click(object sender, EventArgs e)
        {
            SuDungCLBS sudung = new SuDungCLBS(IDChienLuoc_tb.Text, IDHopDong_tb.Text);
            SuDungCLBS.ThemCLApDung(ref sudung, conn);
        }

        private void DanhSachHopDong_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow cRow = DanhSachHopDong_dgv.Rows[e.RowIndex];
            IDHopDong_tb.Text = cRow.Cells["IDHOPDONG"].Value.ToString();
        }

        private void DanhSachSDCL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow cRow = DanhSachCL_dgv.Rows[e.RowIndex];
            IDChienLuoc_tb.Text = cRow.Cells["IDCHIENLUOC"].Value.ToString();
        }

        private void dangkyButton_Click(object sender, EventArgs e)
        {
            ThemUV uv = new ThemUV(label2.Text, conn);
            uv.Show();
        }

        private void ThemHoSoButton_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachHS_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow cRow = DanhSachHS_dgv.Rows[e.RowIndex];
            IDUngVien_tb.Text = cRow.Cells["IDUNGVIEN"].Value.ToString();
            IDPhieuTTDT4.Text = cRow.Cells["IDPHIEUTTDT"].Value.ToString();
        }

        private void LapDSHSButton_Click(object sender, EventArgs e)
        {
            LapDSHoSo form = new LapDSHoSo(conn);
            form.Show();
        }

        private void DuyetHSButton_Click(object sender, EventArgs e)
        {
            HoSoBS hs = new HoSoBS(IDUngVien_tb.Text, IDPhieuTTDT4.Text, null,TinhTrang_tb.Text, TinhTrangDatUngTuyen_tb.Text, label2.Text,null);
            HoSoBS.DuyetHoSo(ref hs, conn);
        }
    }
}
