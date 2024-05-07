using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    public partial class ThemDoanhNghiep : Form
    {
        public event EventHandler? FormClosedEvent;
        internal DoanhNghiep? doanhNghiep = null;
        readonly OracleConnection conn;

        public ThemDoanhNghiep(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi thêm doanh nghiệp?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ThemDoanhNghiep_Load(object sender, EventArgs e)
        {
            NVPhuTrachCbo.DisplayMember = "MANV";
            NVPhuTrachCbo.ValueMember = "MANV";
            NVPhuTrachCbo.DataSource = NhanSu.LoadMaNhanVien(conn).Tables[0];
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            doanhNghiep = new("", TenCtyBox.Text, MaSoThueBox.Text, NguoiDaiDienBox.Text, DiaChiBox.Text,
                EmailBox.Text, NgayLapDate.Text, NgayHHDate.Text, NVPhuTrachCbo.Text);
            try
            {
                if (!DoanhNghiep.ThemDoanhNghiep(ref doanhNghiep, conn))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm doanh nghiệp thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    doanhNghiep = null;
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
