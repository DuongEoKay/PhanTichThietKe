using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class ThemChienLuoc : Form
    {
        public event EventHandler? FormClosedEvent;
        readonly OracleConnection conn;
        readonly string curUser;
        internal ChienLuocUuDai? chienLuoc;

        public ThemChienLuoc(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.curUser = curUser;
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi thêm chiến lược?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            chienLuoc = new("", TenCLBox.Text, MoTaBox.Text, curUser);
            try
            {
                if (!ChienLuocUuDai.ThemChienLuoc(ref chienLuoc, conn))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                MessageBox.Show("Thêm đánh giá thành công!");
                FormClosedEvent?.Invoke(this, EventArgs.Empty);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
