using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pttk.UI
{
    public partial class LapDSHoSo : Form
    {
        readonly OracleConnection conn;
        public LapDSHoSo(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;

        }

        private void LapDSButton_Click(object sender, EventArgs e)
        {
            DanhSachLapHS_dgv.DataSource = HoSoBS.LapDSHoSoUT(conn, DoUuTien_tb.Text, IDPhieuTTDT_tb.Text, IDDoanhNghiep_tb.Text);
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            HoSoBS.ExportHoSo(DanhSachLapHS_dgv);
        }
    }
}
