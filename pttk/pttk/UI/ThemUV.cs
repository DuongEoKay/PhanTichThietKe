using Oracle.ManagedDataAccess.Client;
using pttk.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pttk.UI
{
    public partial class ThemUV : Form
    {
        string idnv;
        readonly OracleConnection conn;
        public ThemUV(string idnv, OracleConnection conn)
        {
            InitializeComponent();
            this.idnv = idnv;
            IDNhanVienQL_tb.Text = idnv;
            this.conn = conn;
        }

        private void btnThem3_Click(object sender, EventArgs e)
        {
            UngVienBS uv = new UngVienBS(Email_tb.Text, Hoten_tb.Text, IDUngVien_tb.Text, SDT_tb.Text, IDNhanVienQL_tb.Text);
            UngVienBS.ThemUngVien(ref uv, conn);
        }
    }
}
