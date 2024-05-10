using PTTK_ORACLE;
using PTTK_BUSINESS;
using pttk.UI;
namespace PTTK_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = username;
            username.Focus();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
        
            try 
            {
                if (!LoginBS.XuLyLogin(username.Text, password.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                
                string connString = $"Data Source = {OracleConfig.connString};" +
                    $"User Id = {username.Text};password = {password.Text};";

                this.Hide();
                if (username.Text == "PTTK")
                {
                    NhanVienUI form = new(username.Text, connString);
                    form.ShowDialog();
                }
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("ID hoặc mật khẩu sai! " + ex.Message);
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                password.Focus();
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                LoginButton.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Up)
            {
                username.Focus();
            }
        }
    }
}
