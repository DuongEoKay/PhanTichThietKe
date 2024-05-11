using ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen;
using ISAD_QLTuyenDung.GiaoDien.NhanVien.ApDungChienLuocUuDai;
using ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung;
using ISAD_QLTuyenDung.GiaoDien.NhanVien.QuanLyUngVien;
using ISAD_QLTuyenDung.GiaoDien.NhanVien.ChiTietHoaDon;
using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;
using ISAD_QLTuyenDung.HoTro;


namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    public partial class NhanVienForm : Form
    {
        private readonly string curUser;
        private readonly OracleConnection conn;

        public NhanVienForm(string curUser, string conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = new(conn);
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            NVNameLabel.Text = $"{curUser} - " + NhanSu.NhanSuLoad(curUser, conn);
        }

        private void CLUuDaiButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new ApDungCLUuDai(conn), mainPanel);
        }

        private void ChiTietHDButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new ThemChiTietHoaDon(conn), mainPanel);
        }

        private void DKUngVienButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new DangKyUngVien(conn), mainPanel);
        }

        private void QuanLyDNButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new QuanLyDN(conn), mainPanel);
        }

        private void TTDangTuyenButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new LapPTTDangTuyen(curUser, conn), mainPanel);
        }

        private void HSTuyenDungButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new LapHoSoTuyenDung(curUser, conn), mainPanel);
        }

        private void DangXuatButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                new Login().ShowDialog();
                this.Close();
            }
        }
    }
}
