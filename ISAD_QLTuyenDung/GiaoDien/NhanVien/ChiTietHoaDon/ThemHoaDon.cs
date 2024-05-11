using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ChiTietHoaDon
{
    public partial class ThemHoaDon : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        internal CTHoaDon? hoaDon;

        public ThemHoaDon(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            MaDNCbo.DisplayMember = "MADN";
            MaDNCbo.ValueMember = "MADN";
            MaDNCbo.DataSource = DoanhNghiep.LoadTenDoanhNghiep(conn).Tables[0];

            MaPhieuCbo.DisplayMember = "MAPHIEU";
            MaPhieuCbo.ValueMember = "MAPHIEU";
            MaPhieuCbo.DataSource = PTTDangTuyen.LoadMaPhieu(conn, MaDNCbo.Text).Tables[0];

            PhuongThucTTCbo.SelectedIndex = 0;
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát lập hóa đơn?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void LapButton_Click(object sender, EventArgs e)
        {
            hoaDon = new(MaDNCbo.Text, MaPhieuCbo.Text, (int)SoTienUpDown.Value,
                NgayTraDate.Text, PhuongThucTTCbo.SelectedIndex + 1);
            try
            {
                if (!CTHoaDon.ThemHoaDon(ref hoaDon, conn))
                {
                    MessageBox.Show("Vui lòng chọn phương thức thanh toán!");
                    return;
                }
                MessageBox.Show("Lập hóa đơn thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MaDNCbo_TextChanged(object sender, EventArgs e)
        {
            MaPhieuCbo.DataSource = PTTDangTuyen.LoadMaPhieu(conn, MaDNCbo.Text).Tables[0];
        }
    }
}
