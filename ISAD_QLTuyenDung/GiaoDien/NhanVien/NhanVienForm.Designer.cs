namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    partial class NhanVienForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVienForm));
            mainPanel = new Panel();
            navigator = new Panel();
            DangXuatButton = new Button();
            HSTuyenDungButton = new Button();
            TTDangTuyenButton = new Button();
            QuanLyDNButton = new Button();
            DKUngVienButton = new Button();
            ChiTietHDButton = new Button();
            NVNameLabel = new Label();
            pictureBox1 = new PictureBox();
            CLUuDaiButton = new Button();
            navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 700);
            mainPanel.TabIndex = 6;
            // 
            // navigator
            // 
            navigator.BackColor = Color.FromArgb(51, 51, 76);
            navigator.Controls.Add(DangXuatButton);
            navigator.Controls.Add(HSTuyenDungButton);
            navigator.Controls.Add(TTDangTuyenButton);
            navigator.Controls.Add(QuanLyDNButton);
            navigator.Controls.Add(DKUngVienButton);
            navigator.Controls.Add(ChiTietHDButton);
            navigator.Controls.Add(CLUuDaiButton);
            navigator.Controls.Add(NVNameLabel);
            navigator.Controls.Add(pictureBox1);
            navigator.Dock = DockStyle.Left;
            navigator.Location = new Point(0, 0);
            navigator.Name = "navigator";
            navigator.Size = new Size(300, 700);
            navigator.TabIndex = 5;
            // 
            // DangXuatButton
            // 
            DangXuatButton.BackColor = Color.Transparent;
            DangXuatButton.Dock = DockStyle.Top;
            DangXuatButton.FlatAppearance.BorderSize = 0;
            DangXuatButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            DangXuatButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            DangXuatButton.FlatStyle = FlatStyle.Flat;
            DangXuatButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DangXuatButton.ForeColor = Color.White;
            DangXuatButton.Location = new Point(0, 590);
            DangXuatButton.Name = "DangXuatButton";
            DangXuatButton.Size = new Size(300, 70);
            DangXuatButton.TabIndex = 3;
            DangXuatButton.Text = "Đăng xuất";
            DangXuatButton.UseVisualStyleBackColor = false;
            DangXuatButton.Click += DangXuatButton_Click;
            // 
            // HSTuyenDungButton
            // 
            HSTuyenDungButton.BackColor = Color.Transparent;
            HSTuyenDungButton.Dock = DockStyle.Top;
            HSTuyenDungButton.FlatAppearance.BorderSize = 0;
            HSTuyenDungButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            HSTuyenDungButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            HSTuyenDungButton.FlatStyle = FlatStyle.Flat;
            HSTuyenDungButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HSTuyenDungButton.ForeColor = Color.White;
            HSTuyenDungButton.Location = new Point(0, 520);
            HSTuyenDungButton.Name = "HSTuyenDungButton";
            HSTuyenDungButton.Size = new Size(300, 70);
            HSTuyenDungButton.TabIndex = 9;
            HSTuyenDungButton.Text = "Hồ sơ tuyển dụng";
            HSTuyenDungButton.UseVisualStyleBackColor = false;
            HSTuyenDungButton.Click += HSTuyenDungButton_Click;
            // 
            // TTDangTuyenButton
            // 
            TTDangTuyenButton.BackColor = Color.Transparent;
            TTDangTuyenButton.Dock = DockStyle.Top;
            TTDangTuyenButton.FlatAppearance.BorderSize = 0;
            TTDangTuyenButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            TTDangTuyenButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            TTDangTuyenButton.FlatStyle = FlatStyle.Flat;
            TTDangTuyenButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TTDangTuyenButton.ForeColor = Color.White;
            TTDangTuyenButton.Location = new Point(0, 450);
            TTDangTuyenButton.Name = "TTDangTuyenButton";
            TTDangTuyenButton.Size = new Size(300, 70);
            TTDangTuyenButton.TabIndex = 8;
            TTDangTuyenButton.Text = "Thông tin đăng tuyển";
            TTDangTuyenButton.UseVisualStyleBackColor = false;
            TTDangTuyenButton.Click += TTDangTuyenButton_Click;
            // 
            // QuanLyDNButton
            // 
            QuanLyDNButton.BackColor = Color.Transparent;
            QuanLyDNButton.Dock = DockStyle.Top;
            QuanLyDNButton.FlatAppearance.BorderSize = 0;
            QuanLyDNButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            QuanLyDNButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            QuanLyDNButton.FlatStyle = FlatStyle.Flat;
            QuanLyDNButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuanLyDNButton.ForeColor = Color.White;
            QuanLyDNButton.Location = new Point(0, 380);
            QuanLyDNButton.Name = "QuanLyDNButton";
            QuanLyDNButton.Size = new Size(300, 70);
            QuanLyDNButton.TabIndex = 2;
            QuanLyDNButton.Text = "Quản lý doanh nghiệp";
            QuanLyDNButton.UseVisualStyleBackColor = false;
            QuanLyDNButton.Click += QuanLyDNButton_Click;
            // 
            // DKUngVienButton
            // 
            DKUngVienButton.BackColor = Color.Transparent;
            DKUngVienButton.Dock = DockStyle.Top;
            DKUngVienButton.FlatAppearance.BorderSize = 0;
            DKUngVienButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            DKUngVienButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            DKUngVienButton.FlatStyle = FlatStyle.Flat;
            DKUngVienButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DKUngVienButton.ForeColor = Color.White;
            DKUngVienButton.Location = new Point(0, 310);
            DKUngVienButton.Name = "DKUngVienButton";
            DKUngVienButton.Size = new Size(300, 70);
            DKUngVienButton.TabIndex = 10;
            DKUngVienButton.Text = "Đăng ký ứng viên";
            DKUngVienButton.UseVisualStyleBackColor = false;
            DKUngVienButton.Click += DKUngVienButton_Click;
            // 
            // ChiTietHDButton
            // 
            ChiTietHDButton.BackColor = Color.Transparent;
            ChiTietHDButton.Dock = DockStyle.Top;
            ChiTietHDButton.FlatAppearance.BorderSize = 0;
            ChiTietHDButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            ChiTietHDButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            ChiTietHDButton.FlatStyle = FlatStyle.Flat;
            ChiTietHDButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChiTietHDButton.ForeColor = Color.White;
            ChiTietHDButton.Location = new Point(0, 240);
            ChiTietHDButton.Name = "ChiTietHDButton";
            ChiTietHDButton.Size = new Size(300, 70);
            ChiTietHDButton.TabIndex = 11;
            ChiTietHDButton.Text = "Chi tiết hóa đơn";
            ChiTietHDButton.UseVisualStyleBackColor = false;
            ChiTietHDButton.Click += ChiTietHDButton_Click;
            // 
            // NVNameLabel
            // 
            NVNameLabel.Dock = DockStyle.Top;
            NVNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NVNameLabel.ForeColor = Color.White;
            NVNameLabel.Location = new Point(0, 120);
            NVNameLabel.Name = "NVNameLabel";
            NVNameLabel.Size = new Size(300, 50);
            NVNameLabel.TabIndex = 5;
            NVNameLabel.Text = "<Name>";
            NVNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // CLUuDaiButton
            // 
            CLUuDaiButton.BackColor = Color.Transparent;
            CLUuDaiButton.Dock = DockStyle.Top;
            CLUuDaiButton.FlatAppearance.BorderSize = 0;
            CLUuDaiButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            CLUuDaiButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            CLUuDaiButton.FlatStyle = FlatStyle.Flat;
            CLUuDaiButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CLUuDaiButton.ForeColor = Color.White;
            CLUuDaiButton.Location = new Point(0, 170);
            CLUuDaiButton.Name = "CLUuDaiButton";
            CLUuDaiButton.Size = new Size(300, 70);
            CLUuDaiButton.TabIndex = 12;
            CLUuDaiButton.Text = "Áp dụng chiến lược ưu đãi";
            CLUuDaiButton.UseVisualStyleBackColor = false;
            CLUuDaiButton.Click += CLUuDaiButton_Click;
            // 
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(mainPanel);
            Controls.Add(navigator);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NhanVienForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ (Nhân viên)";
            Load += NhanVienForm_Load;
            navigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel navigator;
        private Button DangXuatButton;
        private Button QuanLyDNButton;
        private Label NVNameLabel;
        private PictureBox pictureBox1;
        private Button HSTuyenDungButton;
        private Button TTDangTuyenButton;
        private Button DKUngVienButton;
        private Button ChiTietHDButton;
        private Button CLUuDaiButton;
    }
}