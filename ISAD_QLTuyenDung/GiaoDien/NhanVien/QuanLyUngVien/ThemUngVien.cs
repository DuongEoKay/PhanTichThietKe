using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.QuanLyUngVien
{
    public partial class ThemUngVien : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        internal UngVien? ungVien;

        public ThemUngVien(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void ThemUngVien_Load(object sender, EventArgs e)
        {
            MaNVCbo.DisplayMember = "MANV";
            MaNVCbo.ValueMember = "MANV";
            MaNVCbo.DataSource = NhanSu.LoadMaNhanVien(conn).Tables[0];
        }

        private void DangKyButton_Click(object sender, EventArgs e)
        {
            ungVien = new(HoTenBox.Text, DiaChiBox.Text, SoDienThoaiBox.Text, EmailBox.Text, MaNVCbo.Text);
            try
            {
                if (!UngVien.ThemUngVien(ref ungVien, conn))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                MessageBox.Show("Đăng ký ứng viên thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát đăng ký ứng viên?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
