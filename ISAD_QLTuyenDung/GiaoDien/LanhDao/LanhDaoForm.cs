using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;
using ISAD_QLTuyenDung.HoTro;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class LanhDaoForm : Form
    {
        private readonly string curUser;
        private readonly OracleConnection conn;

        public LanhDaoForm(string curUser, string conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = new(conn);
        }

        private void LanhDaoForm_Load(object sender, EventArgs e)
        {
            LDNameLabel.Text = $"{curUser} - " + NhanSu.NhanSuLoad(curUser, conn);
        }

        private void DanhGiaDNButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new DanhGiaTiemNang(curUser, conn), mainPanel);
        }

        private void QuanLyUDButton_Click(object sender, EventArgs e)
        {
            Helper.Loadform(new DeXuatCLUuDai(curUser, conn), mainPanel);
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
