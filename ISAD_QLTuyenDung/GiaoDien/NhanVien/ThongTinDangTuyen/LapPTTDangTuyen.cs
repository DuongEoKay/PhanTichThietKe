using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    public partial class LapPTTDangTuyen : Form
    {
        private static ThemPhieu? formThemPhieu;
        private readonly OracleConnection conn;
        private readonly string curUser;

        public LapPTTDangTuyen(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void LapPTTDangTuyen_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            PTTDangTuyenData.DataSource = PTTDangTuyen.LoadPhieuTTDT(conn);
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            PTTDangTuyenData.DataSource = PTTDangTuyen.LoadPhieuTTDT(conn, formThemPhieu?.phieu);
        }

        private void PTTDangTuyenData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == PTTDangTuyenData.RowCount) return;
            DataGridViewRow cRow = PTTDangTuyenData.Rows[e.RowIndex];

            MaDNBox.Text = cRow.Cells["MADN"].Value.ToString();
            MaPhieuBox.Text = cRow.Cells["MAPHIEU"].Value.ToString();
            ViTriUTBox.Text = cRow.Cells["VITRIUT"].Value.ToString();
            HTThanhToanBox.Text = cRow.Cells["HTTHANHTOAN"].Value.ToString();
            NgayBDDate.Text = cRow.Cells["NGAYBD"].Value.ToString();
            NgayKTDate.Text = cRow.Cells["NGAYKT"].Value.ToString();
            TongTienBox.Text = cRow.Cells["TONGTIEN"].Value.ToString();
            TienDaTraBox.Text = cRow.Cells["TIENDATRA"].Value.ToString();
            YeuCauUVBox.Text = cRow.Cells["YEUCAUUV"].Value.ToString();
        }

        private void ThemPhieuButton_Click(object sender, EventArgs e)
        {
            formThemPhieu = new(curUser, conn);
            formThemPhieu.FormClosedEvent += FormClosedEvent;
            formThemPhieu.Show();
        }
    }
}
