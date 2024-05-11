namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    partial class LapDSHoSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapDSHoSo));
            DanhSachHoSoData = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            UuTienHighUpDown = new NumericUpDown();
            MaDNBox = new TextBox();
            MaPhieuBox = new TextBox();
            MaNVDuyetBox = new TextBox();
            LamMoiButton = new Button();
            label5 = new Label();
            label3 = new Label();
            TinhTrangCbo = new ComboBox();
            label4 = new Label();
            GhiChuBox = new TextBox();
            label6 = new Label();
            UuTienLowUpDown = new NumericUpDown();
            label2 = new Label();
            label7 = new Label();
            HuyButton = new Button();
            LapDSButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DanhSachHoSoData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UuTienHighUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UuTienLowUpDown).BeginInit();
            SuspendLayout();
            // 
            // DanhSachHoSoData
            // 
            DanhSachHoSoData.AllowUserToAddRows = false;
            DanhSachHoSoData.AllowUserToDeleteRows = false;
            DanhSachHoSoData.AllowUserToResizeColumns = false;
            DanhSachHoSoData.AllowUserToResizeRows = false;
            DanhSachHoSoData.BorderStyle = BorderStyle.None;
            DanhSachHoSoData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachHoSoData.Dock = DockStyle.Bottom;
            DanhSachHoSoData.Location = new Point(0, 253);
            DanhSachHoSoData.Name = "DanhSachHoSoData";
            DanhSachHoSoData.ReadOnly = true;
            DanhSachHoSoData.RowHeadersVisible = false;
            DanhSachHoSoData.RowHeadersWidth = 51;
            DanhSachHoSoData.Size = new Size(682, 400);
            DanhSachHoSoData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(227, 10);
            label1.Name = "label1";
            label1.Size = new Size(229, 31);
            label1.TabIndex = 5;
            label1.Text = "Lập danh sách hồ sơ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(UuTienHighUpDown);
            panel1.Controls.Add(MaDNBox);
            panel1.Controls.Add(MaPhieuBox);
            panel1.Controls.Add(MaNVDuyetBox);
            panel1.Controls.Add(LamMoiButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TinhTrangCbo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(GhiChuBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(UuTienLowUpDown);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(DanhSachHoSoData);
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(LapDSButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 653);
            panel1.TabIndex = 6;
            // 
            // UuTienHighUpDown
            // 
            UuTienHighUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UuTienHighUpDown.Location = new Point(424, 72);
            UuTienHighUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            UuTienHighUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UuTienHighUpDown.Name = "UuTienHighUpDown";
            UuTienHighUpDown.Size = new Size(50, 30);
            UuTienHighUpDown.TabIndex = 41;
            UuTienHighUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // MaDNBox
            // 
            MaDNBox.AcceptsReturn = true;
            MaDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNBox.Location = new Point(49, 72);
            MaDNBox.Name = "MaDNBox";
            MaDNBox.PlaceholderText = "Mã doanh nghiệp";
            MaDNBox.Size = new Size(175, 30);
            MaDNBox.TabIndex = 40;
            // 
            // MaPhieuBox
            // 
            MaPhieuBox.AcceptsReturn = true;
            MaPhieuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaPhieuBox.Location = new Point(324, 131);
            MaPhieuBox.Name = "MaPhieuBox";
            MaPhieuBox.PlaceholderText = "Mã phiếu";
            MaPhieuBox.Size = new Size(150, 30);
            MaPhieuBox.TabIndex = 39;
            // 
            // MaNVDuyetBox
            // 
            MaNVDuyetBox.AcceptsReturn = true;
            MaNVDuyetBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaNVDuyetBox.Location = new Point(324, 192);
            MaNVDuyetBox.Name = "MaNVDuyetBox";
            MaNVDuyetBox.PlaceholderText = "Nhân viên";
            MaNVDuyetBox.Size = new Size(150, 30);
            MaNVDuyetBox.TabIndex = 38;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(533, 126);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(100, 40);
            LamMoiButton.TabIndex = 37;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(324, 166);
            label5.Name = "label5";
            label5.Size = new Size(165, 23);
            label5.TabIndex = 36;
            label5.Text = "Mã nhân viên duyệt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(49, 106);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 34;
            label3.Text = "Tình trạng";
            // 
            // TinhTrangCbo
            // 
            TinhTrangCbo.FormattingEnabled = true;
            TinhTrangCbo.Items.AddRange(new object[] { "-- Tất cả --", "Chưa đủ điều kiện ứng tuyển", "Đủ điều kiện ứng tuyển", "Đã xử lý", "Đã đạt" });
            TinhTrangCbo.Location = new Point(49, 132);
            TinhTrangCbo.Name = "TinhTrangCbo";
            TinhTrangCbo.Size = new Size(250, 28);
            TinhTrangCbo.TabIndex = 33;
            TinhTrangCbo.Text = "-- Tất cả --";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(49, 166);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 32;
            label4.Text = "Ghi chú";
            // 
            // GhiChuBox
            // 
            GhiChuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GhiChuBox.Location = new Point(49, 192);
            GhiChuBox.Name = "GhiChuBox";
            GhiChuBox.PlaceholderText = "Ghi chú";
            GhiChuBox.Size = new Size(250, 30);
            GhiChuBox.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(308, 77);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 30;
            label6.Text = "<= Ưu tiên <=";
            // 
            // UuTienLowUpDown
            // 
            UuTienLowUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UuTienLowUpDown.Location = new Point(249, 72);
            UuTienLowUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            UuTienLowUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UuTienLowUpDown.Name = "UuTienLowUpDown";
            UuTienLowUpDown.Size = new Size(50, 30);
            UuTienLowUpDown.TabIndex = 29;
            UuTienLowUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(324, 106);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 28;
            label2.Text = "Mã phiếu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(49, 46);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 26;
            label7.Text = "Mã DN";
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(533, 182);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(100, 40);
            HuyButton.TabIndex = 8;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // LapDSButton
            // 
            LapDSButton.BackColor = Color.LightSeaGreen;
            LapDSButton.FlatAppearance.BorderSize = 0;
            LapDSButton.FlatStyle = FlatStyle.Flat;
            LapDSButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapDSButton.ForeColor = Color.White;
            LapDSButton.Location = new Point(533, 72);
            LapDSButton.Name = "LapDSButton";
            LapDSButton.Size = new Size(100, 40);
            LapDSButton.TabIndex = 7;
            LapDSButton.Text = "Lập";
            LapDSButton.UseVisualStyleBackColor = false;
            LapDSButton.Click += LapDSButton_Click;
            // 
            // LapDSHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 653);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LapDSHoSo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách hồ sơ";
            Load += LapDSHoSo_Load;
            ((System.ComponentModel.ISupportInitialize)DanhSachHoSoData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UuTienHighUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)UuTienLowUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DanhSachHoSoData;
        private Label label1;
        private Panel panel1;
        private Button LapDSButton;
        private Button HuyButton;
        private Label label7;
        private Label label2;
        private Label label6;
        private NumericUpDown UuTienLowUpDown;
        private Label label4;
        private TextBox GhiChuBox;
        private ComboBox TinhTrangCbo;
        private Label label3;
        private Label label5;
        private Button LamMoiButton;
        private TextBox MaNVDuyetBox;
        private TextBox MaDNBox;
        private TextBox MaPhieuBox;
        private NumericUpDown UuTienHighUpDown;
    }
}