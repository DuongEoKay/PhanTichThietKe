using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ApDungChienLuocUuDai
{
    public partial class ApDungCLUuDai : Form
    {
        private readonly OracleConnection conn;
        private static ApDungCL? formAD;

        public ApDungCLUuDai(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void ApDungCLUuDai_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            CLUuDaiData.DataSource = CLApDung.LoadCLApDung(conn);
        }

        private void CLUuDaiData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == CLUuDaiData.RowCount) return;
            DataGridViewRow cRow = CLUuDaiData.Rows[e.RowIndex];

            MaDNBox.Text = cRow.Cells["MADN"].Value.ToString();
            TenCtyBox.Text = cRow.Cells["TENCTY"].Value.ToString();
            MaCLBox.Text = cRow.Cells["MACL"].Value.ToString();
            TenCLBox.Text = cRow.Cells["TENCL"].Value.ToString();
            NgayBDDate.Text = cRow.Cells["NGAYBD"].Value.ToString();
            NgayKTDate.Text = cRow.Cells["NGAYKT"].Value.ToString();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            CLUuDaiData.DataSource = CLApDung.LoadCLApDung(conn, formAD?.clApDung);
        }

        private void ThemADCLButton_Click(object sender, EventArgs e)
        {
            formAD = new(conn);
            formAD.FormClosedEvent += FormClosedEvent;
            formAD.Show();
        }
    }
}
