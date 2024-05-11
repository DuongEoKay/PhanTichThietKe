using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    public partial class ThemPhieu : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        private readonly string curUser;
        internal PTTDangTuyen? phieu;
        internal CTHoaDon? hoaDon;
        internal PDKQuangCao? qc;

        public ThemPhieu(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void ThemPhieu_Load(object sender, EventArgs e)
        {
            NgayKTPhieuDate.Value = NgayBDPhieuDate.Value.AddDays(31);
            CapNhatMinDate();

            HinhThucTTCbo.SelectedIndex = 0;
            PhuongThucTTCbo.SelectedIndex = 0;

            MaDNCbo.DisplayMember = "MADN";
            MaDNCbo.ValueMember = "MADN";
            MaDNCbo.DataSource = PTTDangTuyen.LoadMaDN(conn).Tables[0];
        }

        private void CapNhatMinDate()
        {
            NgayKTPhieuDate.MinDate = NgayBDPhieuDate.Value.AddDays(1);

            NgayBDBaoGiayDate.MinDate = NgayBDPhieuDate.Value;
            NgayBDBannerDate.MinDate = NgayBDPhieuDate.Value;
            NgayBDMangDate.MinDate = NgayBDPhieuDate.Value;

            NgayKTBaoGiayDate.MinDate = NgayBDBaoGiayDate.Value.AddDays(1);
            NgayKTBannerDate.MinDate = NgayBDBannerDate.Value.AddDays(1);
            NgayKTMangDate.MinDate = NgayBDMangDate.Value.AddDays(1);
        }

        private void LapButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ViTriUTBox.Text)) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            phieu = new(MaDNCbo.Text, ViTriUTBox.Text, (int)SoLuongUpDown.Value, NgayBDPhieuDate.Text,
                NgayKTPhieuDate.Text, YeuCauUVBox.Text, (int)TongTienUpDown.Value, HinhThucTTCbo.SelectedIndex + 1, curUser);

            bool phFlag = false, htFlag = false;
            string message = "";
            try
            {
                if (!PTTDangTuyen.ThemPhieu(ref phieu, conn))
                {
                    MessageBox.Show("Cần nhập yêu cầu ứng tuyển!");
                    return;
                }
                if (phieu == null) { MessageBox.Show("Thất bại!"); return; }
                phFlag = true;

                List<(int soHT, string ngayBD, string ngayKT)> hinhThucs = [];
                if (BaoGiayCheckBox.Checked) hinhThucs.Add((1, NgayBDBaoGiayDate.Text, NgayKTBaoGiayDate.Text));
                if (BannerCheckBox.Checked) hinhThucs.Add((2, NgayBDBannerDate.Text, NgayKTBannerDate.Text));
                if (MangCheckBox.Checked) hinhThucs.Add((3, NgayBDMangDate.Text, NgayKTMangDate.Text));

                foreach (var (soHT, ngayBD, ngayKT) in hinhThucs)
                {
                    qc = new(MaDNCbo.Text, phieu.maPhieu, soHT, ngayBD, ngayKT);
                    PDKQuangCao.ThemQuangCao(ref qc, conn);
                }
                htFlag = true;

                hoaDon = new(MaDNCbo.Text, phieu.maPhieu, (int)SoTienUpDown.Value, NgayTraDate.Text,
                    PhuongThucTTCbo.SelectedIndex + 1);
                CTHoaDon.ThemHoaDon(ref hoaDon, conn);

                MessageBox.Show("Lập phiếu đăng tuyển, hình thức, và thanh toán thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                Close();
            }
            catch (Exception ex)
            {
                if (phFlag) message = "Thêm phiếu đăng tuyển thành công, nhưng hình thức và thanh toán thất bại!";
                if (htFlag) message = "Thêm phiếu đăng tuyển và hình thức thành công, nhưng thanh toán thất bại!";
                MessageBox.Show($"{message}\n{ex.Message}");
            }
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát lập phiếu?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BaoGiayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!MangCheckBox.Checked && !BannerCheckBox.Checked)
            {
                BaoGiayCheckBox.Checked = true;
            }
            NgayBDBaoGiayDate.Enabled = BaoGiayCheckBox.Checked;
            NgayKTBaoGiayDate.Enabled = BaoGiayCheckBox.Checked;
        }

        private void BannerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!BaoGiayCheckBox.Checked && !MangCheckBox.Checked)
            {
                BaoGiayCheckBox_CheckedChanged(sender, EventArgs.Empty);
            }
            NgayBDBannerDate.Enabled = BannerCheckBox.Checked;
            NgayKTBannerDate.Enabled = BannerCheckBox.Checked;
        }

        private void MangCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!BaoGiayCheckBox.Checked && !BannerCheckBox.Checked)
            {
                BaoGiayCheckBox_CheckedChanged(sender, EventArgs.Empty);
            }
            NgayBDMangDate.Enabled = MangCheckBox.Checked;
            NgayKTMangDate.Enabled = MangCheckBox.Checked;
        }

        private void NgayBDPhieuDate_ValueChanged(object sender, EventArgs e)
        {
            CapNhatMinDate();
            CapNhatHinhThucTT();
        }

        private void NgayKTPhieuDate_ValueChanged(object sender, EventArgs e)
        {
            CapNhatHinhThucTT();
        }

        private void NgayBDBaoGiayDate_ValueChanged(object sender, EventArgs e)
        {
            NgayKTBaoGiayDate.MinDate = NgayBDBaoGiayDate.Value.AddDays(1);
        }

        private void NgayBDBannerDate_ValueChanged(object sender, EventArgs e)
        {
            NgayKTBannerDate.MinDate = NgayBDBannerDate.Value.AddDays(1);
        }

        private void NgayBDMangDate_ValueChanged(object sender, EventArgs e)
        {
            NgayKTMangDate.MinDate = NgayBDMangDate.Value.AddDays(1);
        }

        private void CapNhatHinhThucTT()
        {
            TimeSpan difference = NgayKTPhieuDate.Value - NgayBDPhieuDate.Value;
            int differenceInDays = difference.Days;

            if (differenceInDays <= 30)
            {
                HinhThucTTCbo.SelectedIndex = 0;
                HinhThucTTCbo.Enabled = false;
                CapNhatSoTien(HinhThucTTCbo.SelectedIndex);
            }
            else HinhThucTTCbo.Enabled = true;
        }

        private void CapNhatSoTien(int luaChon)
        {
            SoTienUpDown.Maximum = TongTienUpDown.Value;
            if (luaChon == 0)
            {
                SoTienUpDown.Enabled = false;
                SoTienUpDown.Value = TongTienUpDown.Value;
            }
            else
            {
                SoTienUpDown.Enabled = true;
                SoTienUpDown.Value = SoTienUpDown.Minimum = TongTienUpDown.Value * 0.3m;
            }
        }

        private void HinhThucTTCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatSoTien(HinhThucTTCbo.SelectedIndex);
        }

        private void TongTienUpDown_ValueChanged(object sender, EventArgs e)
        {
            CapNhatSoTien(HinhThucTTCbo.SelectedIndex);
        }
    }
}
