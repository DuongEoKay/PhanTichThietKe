using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ChiTietHoaDon
{
    public partial class ThemChiTietHoaDon : Form
    {
        private readonly OracleConnection conn;
        private static ThemHoaDon? formThemHD;

        public ThemChiTietHoaDon(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void ThemChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            HoaDonData.DataSource = CTHoaDon.LoadCTHoaDon(conn);
        }

        private void HoaDonData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == HoaDonData.RowCount) return;
            DataGridViewRow cRow = HoaDonData.Rows[e.RowIndex];

            MaDNBox.Text = cRow.Cells["MADN"].Value.ToString();
            TenCtyBox.Text = cRow.Cells["TENCTY"].Value.ToString();
            MaPhieuBox.Text = cRow.Cells["MAPHIEU"].Value.ToString();
            MaCTBox.Text = cRow.Cells["MACT"].Value.ToString();
            SoTienBox.Text = cRow.Cells["SOTIEN"].Value.ToString();
            NgayTraDate.Text = cRow.Cells["NGAYTRA"].Value.ToString();
            PhuongThucBox.Text = cRow.Cells["TENPT"].Value.ToString();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            HoaDonData.DataSource = CTHoaDon.LoadCTHoaDon(conn, formThemHD?.hoaDon);
        }

        private void ThemCTHoaDonButton_Click(object sender, EventArgs e)
        {
            formThemHD = new(conn);
            formThemHD.FormClosedEvent += FormClosedEvent;
            formThemHD.Show();
        }
    }
}
