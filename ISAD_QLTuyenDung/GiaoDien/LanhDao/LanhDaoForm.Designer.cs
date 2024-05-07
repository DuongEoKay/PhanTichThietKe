namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class LanhDaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanhDaoForm));
            navigator = new Panel();
            DangXuatButton = new Button();
            QuanLyUDButton = new Button();
            DanhGiaDNButton = new Button();
            LDNameLabel = new Label();
            pictureBox1 = new PictureBox();
            mainPanel = new Panel();
            navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // navigator
            // 
            navigator.BackColor = Color.FromArgb(51, 51, 76);
            navigator.Controls.Add(DangXuatButton);
            navigator.Controls.Add(QuanLyUDButton);
            navigator.Controls.Add(DanhGiaDNButton);
            navigator.Controls.Add(LDNameLabel);
            navigator.Controls.Add(pictureBox1);
            navigator.Dock = DockStyle.Left;
            navigator.Location = new Point(0, 0);
            navigator.Name = "navigator";
            navigator.Size = new Size(300, 700);
            navigator.TabIndex = 0;
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
            DangXuatButton.Location = new Point(0, 330);
            DangXuatButton.Name = "DangXuatButton";
            DangXuatButton.Size = new Size(300, 80);
            DangXuatButton.TabIndex = 3;
            DangXuatButton.Text = "Đăng xuất";
            DangXuatButton.UseVisualStyleBackColor = false;
            DangXuatButton.Click += DangXuatButton_Click;
            // 
            // QuanLyUDButton
            // 
            QuanLyUDButton.BackColor = Color.Transparent;
            QuanLyUDButton.Dock = DockStyle.Top;
            QuanLyUDButton.FlatAppearance.BorderSize = 0;
            QuanLyUDButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            QuanLyUDButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            QuanLyUDButton.FlatStyle = FlatStyle.Flat;
            QuanLyUDButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuanLyUDButton.ForeColor = Color.White;
            QuanLyUDButton.Location = new Point(0, 250);
            QuanLyUDButton.Name = "QuanLyUDButton";
            QuanLyUDButton.Size = new Size(300, 80);
            QuanLyUDButton.TabIndex = 2;
            QuanLyUDButton.Text = "Quản lý chiến lược ưu đãi";
            QuanLyUDButton.UseVisualStyleBackColor = false;
            QuanLyUDButton.Click += QuanLyUDButton_Click;
            // 
            // DanhGiaDNButton
            // 
            DanhGiaDNButton.BackColor = Color.Transparent;
            DanhGiaDNButton.Dock = DockStyle.Top;
            DanhGiaDNButton.FlatAppearance.BorderSize = 0;
            DanhGiaDNButton.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            DanhGiaDNButton.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            DanhGiaDNButton.FlatStyle = FlatStyle.Flat;
            DanhGiaDNButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DanhGiaDNButton.ForeColor = Color.White;
            DanhGiaDNButton.Location = new Point(0, 170);
            DanhGiaDNButton.Name = "DanhGiaDNButton";
            DanhGiaDNButton.Size = new Size(300, 80);
            DanhGiaDNButton.TabIndex = 1;
            DanhGiaDNButton.Text = "Đánh giá doanh nghiệp";
            DanhGiaDNButton.UseVisualStyleBackColor = false;
            DanhGiaDNButton.Click += DanhGiaDNButton_Click;
            // 
            // LDNameLabel
            // 
            LDNameLabel.Dock = DockStyle.Top;
            LDNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LDNameLabel.ForeColor = Color.White;
            LDNameLabel.Location = new Point(0, 120);
            LDNameLabel.Name = "LDNameLabel";
            LDNameLabel.Size = new Size(300, 50);
            LDNameLabel.TabIndex = 5;
            LDNameLabel.Text = "<Name>";
            LDNameLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 700);
            mainPanel.TabIndex = 4;
            // 
            // LanhDaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(mainPanel);
            Controls.Add(navigator);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LanhDaoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ (Lãnh đạo)";
            Load += LanhDaoForm_Load;
            navigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navigator;
        private Button DanhGiaDNButton;
        private Button QuanLyUDButton;
        private Button DangXuatButton;
        private Panel mainPanel;
        private Label LDNameLabel;
        private PictureBox pictureBox1;
    }
}