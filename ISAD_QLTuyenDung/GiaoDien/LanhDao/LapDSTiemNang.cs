using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class LapDSTiemNang : Form
    {
        readonly OracleConnection conn;

        public LapDSTiemNang(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void LapDSTiemNang_Load(object sender, EventArgs e)
        {
            LamMoiButton.PerformClick();
        }
        private void LamMoiButton_Click(object sender, EventArgs e)
        {
            DSTiemNangData.DataSource = DNTiemNang.LoadDSTiemNang(conn, CanDuoiUpDown.Value, CanTrenUpDown.Value);
        }

        private void LapDSButton_Click(object sender, EventArgs e)
        {
            try
            {
                DNTiemNang.ExportDSTiemNang(DSTiemNangData);
                MessageBox.Show("Copy vào clipboard thành công! Nếu Excel không tự động mở, " +
                    "vui lòng paste vào nơi cần thiết!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
