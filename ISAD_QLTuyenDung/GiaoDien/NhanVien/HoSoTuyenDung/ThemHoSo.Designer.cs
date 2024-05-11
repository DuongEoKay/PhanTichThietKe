namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    partial class ThemHoSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHoSo));
            panel1 = new Panel();
            ThemGiayToButton = new Button();
            label7 = new Label();
            MaDNCbo = new ComboBox();
            HuyButton = new Button();
            ThemButton = new Button();
            label6 = new Label();
            DoUuTienUpDown = new NumericUpDown();
            label5 = new Label();
            TinhTrangCbo = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            MaPhieuCbo = new ComboBox();
            MaUVCbo = new ComboBox();
            label3 = new Label();
            GhiChuBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoUuTienUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ThemGiayToButton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(MaDNCbo);
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(ThemButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(DoUuTienUpDown);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TinhTrangCbo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(MaPhieuCbo);
            panel1.Controls.Add(MaUVCbo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(GhiChuBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 453);
            panel1.TabIndex = 0;
            // 
            // ThemGiayToButton
            // 
            ThemGiayToButton.BackColor = Color.LightSeaGreen;
            ThemGiayToButton.FlatAppearance.BorderSize = 0;
            ThemGiayToButton.FlatStyle = FlatStyle.Flat;
            ThemGiayToButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemGiayToButton.ForeColor = Color.White;
            ThemGiayToButton.Location = new Point(732, 58);
            ThemGiayToButton.Name = "ThemGiayToButton";
            ThemGiayToButton.Size = new Size(175, 40);
            ThemGiayToButton.TabIndex = 26;
            ThemGiayToButton.Text = "Thêm giấy tờ";
            ThemGiayToButton.UseVisualStyleBackColor = false;
            ThemGiayToButton.Click += ThemGiayToButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(65, 175);
            label7.Name = "label7";
            label7.Size = new Size(147, 23);
            label7.TabIndex = 25;
            label7.Text = "Mã doanh nghiệp";
            // 
            // MaDNCbo
            // 
            MaDNCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNCbo.FormattingEnabled = true;
            MaDNCbo.Location = new Point(65, 200);
            MaDNCbo.Name = "MaDNCbo";
            MaDNCbo.Size = new Size(150, 31);
            MaDNCbo.TabIndex = 24;
            MaDNCbo.TextChanged += MaDN_TextChanged;
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(290, 360);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(175, 40);
            HuyButton.TabIndex = 23;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // ThemButton
            // 
            ThemButton.BackColor = Color.LightSeaGreen;
            ThemButton.FlatAppearance.BorderSize = 0;
            ThemButton.FlatStyle = FlatStyle.Flat;
            ThemButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemButton.ForeColor = Color.White;
            ThemButton.Location = new Point(65, 360);
            ThemButton.Name = "ThemButton";
            ThemButton.Size = new Size(175, 40);
            ThemButton.TabIndex = 11;
            ThemButton.Text = "Thêm";
            ThemButton.UseVisualStyleBackColor = false;
            ThemButton.Click += ThemButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(415, 175);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 22;
            label6.Text = "Ưu tiên";
            // 
            // DoUuTienUpDown
            // 
            DoUuTienUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoUuTienUpDown.Location = new Point(415, 201);
            DoUuTienUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            DoUuTienUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DoUuTienUpDown.Name = "DoUuTienUpDown";
            DoUuTienUpDown.Size = new Size(50, 30);
            DoUuTienUpDown.TabIndex = 21;
            DoUuTienUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(239, 79);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 20;
            label5.Text = "Tình trạng";
            // 
            // TinhTrangCbo
            // 
            TinhTrangCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TinhTrangCbo.FormattingEnabled = true;
            TinhTrangCbo.Items.AddRange(new object[] { "-- Tình trạng hồ sơ --", "Chưa đủ điều kiện", "Đủ điều kiện", "Đã xử lý", "Đã đạt" });
            TinhTrangCbo.Location = new Point(239, 105);
            TinhTrangCbo.Name = "TinhTrangCbo";
            TinhTrangCbo.Size = new Size(226, 31);
            TinhTrangCbo.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(65, 264);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 14;
            label2.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(239, 175);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 18;
            label4.Text = "Mã phiếu";
            // 
            // MaPhieuCbo
            // 
            MaPhieuCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaPhieuCbo.FormattingEnabled = true;
            MaPhieuCbo.Location = new Point(239, 200);
            MaPhieuCbo.Name = "MaPhieuCbo";
            MaPhieuCbo.Size = new Size(150, 31);
            MaPhieuCbo.TabIndex = 17;
            // 
            // MaUVCbo
            // 
            MaUVCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaUVCbo.FormattingEnabled = true;
            MaUVCbo.Location = new Point(65, 105);
            MaUVCbo.Name = "MaUVCbo";
            MaUVCbo.Size = new Size(150, 31);
            MaUVCbo.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(65, 79);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 15;
            label3.Text = "Mã ứng viên";
            // 
            // GhiChuBox
            // 
            GhiChuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GhiChuBox.Location = new Point(65, 290);
            GhiChuBox.Name = "GhiChuBox";
            GhiChuBox.PlaceholderText = "Ghi chú";
            GhiChuBox.Size = new Size(400, 30);
            GhiChuBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(530, 20);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 4;
            label1.Text = "Thêm hồ sơ";
            // 
            // ThemHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemHoSo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm hồ sơ";
            Load += ThemHoSo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoUuTienUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox GhiChuBox;
        private NumericUpDown DoUuTienUpDown;
        private Label label5;
        private ComboBox TinhTrangCbo;
        private Label label4;
        private ComboBox MaPhieuCbo;
        private ComboBox MaUVCbo;
        private Label label6;
        private Button HuyButton;
        private Button ThemButton;
        private ComboBox MaDNCbo;
        private Label label7;
        private Button ThemGiayToButton;
    }
}