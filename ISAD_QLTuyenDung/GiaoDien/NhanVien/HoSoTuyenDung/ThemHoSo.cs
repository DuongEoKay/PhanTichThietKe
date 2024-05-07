using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class ThemHoSo : Form
    {
        public event EventHandler? FormClosedEvent;
        readonly OracleConnection conn;
        readonly string curUser;
        readonly List<string> thongTinGiayTo = [];
        readonly List<int> loaiGiayTo = [];
        internal HoSoUngTuyen? hoso = null;

        int YNextCbo = 104, YNextTextBox = 104, soGiayTo = 1;
        readonly string[] loaiGT = ["Sơ yếu lý lịch", "Đơn xin việc",
            "CV xin việc", "Sổ hộ khẩu (Bản sao công chứng)", "Căn cước công dân (Bản sao công chứng)",
            "Giấy khai sinh (Bản sao công chứng)", "Giấy khám sức khỏe (Dưới 6 tháng)", "Ảnh thẻ hồ sơ (3x4 hoặc 4x6)",
            "Chứng chỉ liên quan"];

        public ThemHoSo(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void ThemHoSo_Load(object sender, EventArgs e)
        {
            MaUVCbo.DisplayMember = "MAUV";
            MaUVCbo.ValueMember = "MAUV";
            MaUVCbo.DataSource = UngVien.LoadMaUngVien(conn).Tables[0];

            MaDNCbo.DisplayMember = "MADN";
            MaDNCbo.ValueMember = "MADN";
            MaDNCbo.DataSource = PTTDangTuyen.LoadMaDN(conn).Tables[0];

            MaPhieuCbo.DisplayMember = "MAPHIEU";
            MaPhieuCbo.ValueMember = "MAPHIEU";
            MaPhieuCbo.DataSource = PTTDangTuyen.LoadMaPhieu(conn, MaDNCbo.Text).Tables[0];

            TinhTrangCbo.SelectedIndex = 0;
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= soGiayTo; i++)
            {
                if (Controls.Find($"ThongTin{i}Box", true).FirstOrDefault() is TextBox textBox
                    && Controls.Find($"GiayTo{i}Cbo", true).FirstOrDefault() is ComboBox comboBox)
                {
                    thongTinGiayTo.Add(textBox.Text);
                    loaiGiayTo.Add(comboBox.SelectedIndex + 1);
                }
            }

            string[] thongTinGT = [.. thongTinGiayTo];
            int[] loaiGT = [.. loaiGiayTo];
            hoso = new(MaUVCbo.Text, MaDNCbo.Text, MaPhieuCbo.Text, (int)DoUuTienUpDown.Value, GhiChuBox.Text,
                TinhTrangCbo.SelectedIndex, curUser);

            bool hsFl = false;
            string message = "";
            try
            {
                if (!HoSoUngTuyen.ThemHoSo(ref hoso, conn))
                {
                    MessageBox.Show("Vui lòng chọn tình trạng hồ sơ!");
                    return;
                }
                hsFl = true;

                for (int i = 0; i < loaiGT.Length; i++)
                {
                    if (hoso == null) break;
                    GiayToUT giayTo = new(hoso.maUV, hoso.maDN, hoso.maPhieu, 0, thongTinGT[i], loaiGT[i]);
                    GiayToUT.ThemGiayToUT(ref giayTo, conn);
                }

                message = (loaiGT.Length != 0) ? "Thêm hồ sơ và giấy tờ thành công!"
                    : "Thêm hồ sơ thành công!";
                MessageBox.Show(message);
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                hoso = null;
                Close();
            }
            catch (Exception ex)
            {
                if (hsFl) message = "Thêm hồ sơ thành công, nhưng có giấy tờ bị thất bại!";
                MessageBox.Show($"{message}\n{ex.Message}");
            }
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi thêm hồ sơ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ThemGiayToButton_Click(object sender, EventArgs e)
        {
            if (soGiayTo <= 9)
            {
                ComboBox comboBox = new()
                {
                    Location = new Point(511, YNextCbo),
                    Size = new Size(300, 28)
                };
                comboBox.Items.AddRange(loaiGT);
                comboBox.SelectedIndex = 0;
                comboBox.Name = $"GiayTo{soGiayTo}Cbo";
                Controls.Add(comboBox);
                YNextCbo += 34;

                TextBox textBox = new()
                {
                    Location = new Point(817, YNextTextBox),
                    Size = new Size(300, 27)
                };
                Controls.Add(textBox);
                textBox.Name = $"ThongTin{soGiayTo}Box";
                textBox.PlaceholderText = "Thông tin giấy tờ";
                YNextTextBox += 34;

                soGiayTo++;
                panel1.SendToBack();
            }
            else ThemGiayToButton.Visible = false;
        }

        private void MaDN_TextChanged(object sender, EventArgs e)
        {
            MaPhieuCbo.DataSource = PTTDangTuyen.LoadMaPhieu(conn, MaDNCbo.Text).Tables[0];
        }
    }
}
