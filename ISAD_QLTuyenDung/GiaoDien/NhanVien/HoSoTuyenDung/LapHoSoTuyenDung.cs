using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class LapHoSoTuyenDung : Form
    {
        static ThemHoSo? formHS;
        static DuyetHoSo? formDHS;
        static LapDSHoSo? formDSHS;
        static HoSoUngTuyen? hoso;
        readonly OracleConnection conn;
        readonly string curUser;

        public LapHoSoTuyenDung(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void LapHoSoTuyenDung_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void HoSoData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == HoSoData.RowCount) return;
            DataGridViewRow cRow = HoSoData.Rows[e.RowIndex];
            string[] tinhTrangs = ["Chưa đủ điều kiện", "Đủ điều kiện", "Đã xử lý", "Đã đạt"];

            MaUVBox.Text = cRow.Cells["MAUV"].Value.ToString();
            TenUVBox.Text = cRow.Cells["HOTEN"].Value.ToString();
            ViTriUTBox.Text = cRow.Cells["VITRIUT"].Value.ToString();
            TinhTrangBox.Text = tinhTrangs[Convert.ToInt32(cRow.Cells["TINHTRANG"].Value) - 1];
            MaDNBox.Text = cRow.Cells["MADN"].Value.ToString();
            MaPhieuBox.Text = cRow.Cells["MAPHIEU"].Value.ToString();
            GhiChuBox.Text = cRow.Cells["GHICHU"].Value.ToString();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            hoso = formHS?.hoso ?? formDHS?.hoso;
            HoSoData.DataSource = HoSoUngTuyen.LoadHoSo(conn, hoso);
            hoso = null;
        }

        private void ThemHoSoButton_Click(object sender, EventArgs e)
        {
            formHS = new(curUser, conn);
            formHS.FormClosedEvent += FormClosedEvent;
            formHS.Show();
        }

        private void DuyetHSButton_Click(object sender, EventArgs e)
        {
            formDHS = new(curUser, conn);
            formDHS.FormClosedEvent += FormClosedEvent;
            formDHS.Show();
        }

        private void LapDSHSButton_Click(object sender, EventArgs e)
        {
            formDSHS = new(conn);
            formDSHS.Show();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            HoSoData.DataSource = HoSoUngTuyen.LoadHoSo(conn);
        }
    }
}
