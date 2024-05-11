using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    public partial class DuyetHoSo : Form
    {
        public event EventHandler? FormClosedEvent;
        private readonly OracleConnection conn;
        private readonly string curUser;
        internal HoSoUngTuyen? hoso = null;

        public DuyetHoSo(string curUser, OracleConnection conn)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.conn = conn;
        }

        private void DuyetHoSo_Load(object sender, EventArgs e)
        {
            HoSoData.DataSource = HoSoUngTuyen.LoadHoSo(conn);
        }

        private void HoSoData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == HoSoData.RowCount) return;
            DataGridViewRow cRow = HoSoData.Rows[e.RowIndex];

            int index = Convert.ToInt32(cRow.Cells["TINHTRANG"].Value);
            MaUVBox.Text = cRow.Cells["MAUV"].Value.ToString();
            MaPhieuBox.Text = cRow.Cells["MAPHIEU"].Value.ToString();
            MaDNBox.Text = cRow.Cells["MADN"].Value.ToString();
            TinhTrangCbo.SelectedItem = TinhTrangCbo.Items[index - 1];
            UuTienUpDown.Text = cRow.Cells["DOUUTIEN"].Value.ToString();
            GhiChuBox.Text = cRow.Cells["GHICHU"].Value.ToString();
        }

        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            HoSoData.DataSource = HoSoUngTuyen.LoadHoSo(conn);
        }

        private void DuyetButton_Click(object sender, EventArgs e)
        {
            hoso = new(MaUVBox.Text, MaDNBox.Text, MaPhieuBox.Text, (int)UuTienUpDown.Value,
                GhiChuBox.Text, TinhTrangCbo.SelectedIndex + 1, curUser);
            try
            {
                if (!HoSoUngTuyen.DuyetHoSo(ref hoso, conn))
                {
                    MessageBox.Show("Duyệt hồ sơ thất bại!");
                }
                else
                {
                    MessageBox.Show("Duyệt hồ sơ thành công!");
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    hoso = null;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HuyButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn thoát khỏi duyệt hồ sơ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
