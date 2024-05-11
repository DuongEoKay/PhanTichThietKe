using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class DeXuatCLUuDai : Form
    {
        private static ThemChienLuoc? f;
        private readonly OracleConnection conn;
        private readonly string curUser;

        public DeXuatCLUuDai(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.curUser = curUser;
        }

        private void DeXuatCLUuDai_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void ThemChienLuocButton_Click(object sender, EventArgs e)
        {
            f = new(curUser, conn);
            f.FormClosedEvent += FormClosedEvent;
            f.Show();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            ChienLuocData.DataSource = ChienLuocUuDai.LoadChienLuoc(conn, f?.chienLuoc);
        }

        private void ChienLuocData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == ChienLuocData.RowCount) return;
            DataGridViewRow cRow = ChienLuocData.Rows[e.RowIndex];
            MaCLBox.Text = cRow.Cells["MACL"].Value.ToString();
            TenCLBox.Text = cRow.Cells["TENCL"].Value.ToString();
            MoTaBox.Text = cRow.Cells["MOTA"].Value.ToString();
            TenLDBox.Text = cRow.Cells["HOTEN"].Value.ToString();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            ChienLuocData.DataSource = ChienLuocUuDai.LoadChienLuoc(conn);
        }
    }
}
