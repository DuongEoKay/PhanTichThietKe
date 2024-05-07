using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.QuanLyUngVien
{
    public partial class DangKyUngVien : Form
    {
        private readonly OracleConnection conn;
        private static ThemUngVien? formThemUV;

        public DangKyUngVien(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void DangKyUngVien_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            UngVienData.DataSource = UngVien.LoadDSUngVien(conn);
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            UngVienData.DataSource = UngVien.LoadDSUngVien(conn, formThemUV?.ungVien);
        }

        private void ThemUVButton_Click(object sender, EventArgs e)
        {
            formThemUV = new(conn);
            formThemUV.FormClosedEvent += FormClosedEvent;
            formThemUV.Show();
        }

        private void UngVienData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == UngVienData.RowCount) return;
            DataGridViewRow cRow = UngVienData.Rows[e.RowIndex];

            MaUVBox.Text = cRow.Cells["MAUV"].Value.ToString();
            HoTenBox.Text = cRow.Cells["HOTEN"].Value.ToString();
            DiaChiBox.Text = cRow.Cells["DCHI"].Value.ToString();
            SoDienThoaiBox.Text = cRow.Cells["SDT"].Value.ToString();
            EmailBox.Text = cRow.Cells["EMAIL"].Value.ToString();
            NVPhuTrachBox.Text = cRow.Cells["NVPHUTRACH"].Value.ToString();
        }
    }
}
