using Oracle.ManagedDataAccess.Client;
using ISAD_QLTuyenDung.NghiepVu;

namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    public partial class ThongKeDN : Form
    {
        readonly string maDoanhNghiep;
        readonly OracleConnection conn;

        public ThongKeDN(string maDN, OracleConnection conn)
        {
            InitializeComponent();
            this.maDoanhNghiep = maDN;
            this.conn = conn;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            MaDNBox.Text = maDoanhNghiep;
            DoanhNghiepData.DataSource = DNTiemNang.LoadThongKe(maDoanhNghiep, conn);
        }
    }
}
