using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class DanhGiaTiemNang : Form
    {
        private static ThemDanhGia? formDG;
        private static ThongKeDN? formTK;
        private static LapDSTiemNang? formLapDSTiemNang;
        private readonly OracleConnection conn;
        private readonly string curUser;

        public DanhGiaTiemNang(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.curUser = curUser;
        }

        private void DanhGiaTiemNang_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void ThemDGButton_Click(object sender, EventArgs e)
        {
            formDG = new(curUser, conn);
            formDG.FormClosedEvent += FormClosedEvent;
            formDG.Show();
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            DanhGiaData.DataSource = DNTiemNang.LoadDanhGia(conn, formDG?.danhGia);
        }

        private void DanhGiaData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == DanhGiaData.RowCount) return;
            DataGridViewRow cRow = DanhGiaData.Rows[e.RowIndex];

            DNThongKeBox.Text = cRow.Cells["MADN"].Value.ToString();
            TenDNBox.Text = cRow.Cells["TENCTY"].Value.ToString();
            TenLDBox.Text = cRow.Cells["HOTEN"].Value.ToString();
            TiemNangBox.Text = cRow.Cells["TIEMNANG"].Value.ToString();
            GhiChuBox.Text = cRow.Cells["GHICHU"].Value.ToString();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            DanhGiaData.DataSource = DNTiemNang.LoadDanhGia(conn);
        }

        private void LapDSTNButton_Click(object sender, EventArgs e)
        {
            formLapDSTiemNang = new(conn);
            formLapDSTiemNang.Show();
        }

        private void ThongKeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DNThongKeBox.Text))
            {
                MessageBox.Show("Cần nhập mã doanh nghiệp để thống kê!");
            }
            else
            {
                formTK = new(DNThongKeBox.Text, conn);
                formTK.Show();
            }
        }
    }
}
