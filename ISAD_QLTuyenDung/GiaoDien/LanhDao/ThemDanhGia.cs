using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class ThemDanhGia : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        private readonly string curUser;
        internal DNTiemNang? danhGia;

        public ThemDanhGia(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.curUser = curUser;
        }

        private void ThemDanhGia_Load(object sender, EventArgs e)
        {
            TenDNCbo.DisplayMember = "TENCTY";
            TenDNCbo.ValueMember = "MADN";
            TenDNCbo.DataSource = DoanhNghiep.LoadTenDoanhNghiep(conn).Tables[0];
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi thêm đánh giá?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            string? id = TenDNCbo?.SelectedValue?.ToString() ?? "1";
            danhGia = new(id, curUser, (int)TiemNangUpDown.Value, GhiChuBox.Text, DateTime.Now);
            try
            {
                if (!DNTiemNang.ThemDanhGia(danhGia, conn))
                {
                    MessageBox.Show("Tiềm năng phải nằm trong khoảng từ 1 đến 10!");
                    return;
                }
                MessageBox.Show("Thêm đánh giá thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
