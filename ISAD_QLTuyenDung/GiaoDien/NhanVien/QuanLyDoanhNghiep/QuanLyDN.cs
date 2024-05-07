using ISAD_QLTuyenDung.GiaoDien.NhanVien.QuanLyDoanhNghiep;
using ISAD_QLTuyenDung.NghiepVu;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    public partial class QuanLyDN : Form
    {
        static TimDoanhNghiep? formTimDN;
        static ThemDoanhNghiep? formDN;
        internal DoanhNghiep? doanhNghiep = null;
        readonly OracleConnection conn;

        public QuanLyDN(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void QuanLyDN_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            DoanhNghiepData.DataSource = DoanhNghiep.LoadDSDoanhNghiep(conn);
        }

        private void FormClosedEvent(object? sender, EventArgs e)
        {
            doanhNghiep = formTimDN?.doanhNghiep ?? formDN?.doanhNghiep;
            DoanhNghiepData.DataSource = DoanhNghiep.LoadDSDoanhNghiep(conn, doanhNghiep);
            doanhNghiep = null;
        }

        private void TimDNButton_Click(object sender, EventArgs e)
        {
            formTimDN = new();
            formTimDN.FormClosedEvent += FormClosedEvent;
            formTimDN.Show();
        }

        private void ThemDNButton_Click(object sender, EventArgs e)
        {
            formDN = new(conn);
            formDN.FormClosedEvent += FormClosedEvent;
            formDN.Show();
        }

        private void CapNhatButton_Click(object sender, EventArgs e)
        {
            try
            {
                DoanhNghiep.CapNhatHanHopDong(conn, NgayHHDate.Text, MaDNBox.Text);
                MessageBox.Show("Gia hạn hợp đồng thành công!");
                DoanhNghiep updDN = new(MaDNBox.Text, "", "", "", "", "", "", "", "");
                DoanhNghiepData.DataSource = DoanhNghiep.LoadDSDoanhNghiep(conn, updDN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoanhNghiepData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == DoanhNghiepData.RowCount) return;
            DataGridViewRow cRow = DoanhNghiepData.Rows[e.RowIndex];

            MaDNBox.Text = cRow.Cells["MADN"].Value.ToString();
            TenCtyBox.Text = cRow.Cells["TENCTY"].Value.ToString();
            NVPhuTrachBox.Text = cRow.Cells["NVPHUTRACH"].Value.ToString();
            MaSoThueBox.Text = cRow.Cells["MASOTHUE"].Value.ToString();
            EmailBox.Text = cRow.Cells["EMAIL"].Value.ToString();
            NgDaiDienBox.Text = cRow.Cells["NGDAIDIEN"].Value.ToString();
            DiaChiBox.Text = cRow.Cells["DCHI"].Value.ToString();
            NgayLapDate.Text = cRow.Cells["NGAYLAPHD"].Value.ToString();
            NgayHHDate.Text = cRow.Cells["NGAYHHHD"].Value.ToString();
        }

        private void ThongKeHDButton_Click(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
            DateTime ngayHH = DateTime.Today.AddDays(3);
            ((DataTable)DoanhNghiepData.DataSource).DefaultView.RowFilter =
                $"CONVERT(NGAYHHHD, 'System.DateTime') < '{ngayHH}'";
            try
            {
                DoanhNghiep.ExportHDSapHetHan(DoanhNghiepData);
                MessageBox.Show("Danh sách lọc ra các doanh nghiệp đã hết hạn hợp đồng, hoặc có " +
                    "ngày hết hạn cách hiện tại 3 ngày!\nCopy vào clipboard thành công! " +
                    "Nếu Excel không tự động mở, vui lòng paste vào nơi cần thiết!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
