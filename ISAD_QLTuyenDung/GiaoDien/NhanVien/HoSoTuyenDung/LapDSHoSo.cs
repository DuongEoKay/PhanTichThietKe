using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;
using System.Data;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class LapDSHoSo : Form
    {
        readonly OracleConnection conn;

        public LapDSHoSo(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void LapDSHoSo_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            HoSoUngTuyen hoso = new("", MaDNBox.Text, MaPhieuBox.Text, 0,
                GhiChuBox.Text, TinhTrangCbo.SelectedIndex, MaNVDuyetBox.Text);

            DanhSachHoSoData.DataSource = HoSoUngTuyen.LapDSHoSoUT(conn, UuTienLowUpDown.Value,
                UuTienHighUpDown.Value, hoso);
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi lập danh sách hồ sơ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void LapDSButton_Click(object sender, EventArgs e)
        {
            try
            {
                HoSoUngTuyen.ExportHoSo(DanhSachHoSoData);
                MessageBox.Show("Copy vào clipboard thành công! Nếu Excel không tự động mở, " +
                    "vui lòng paste vào nơi cần thiết!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
