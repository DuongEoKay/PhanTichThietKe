namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class DanhGiaTiemNang
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            XemDGTitleLabel = new Label();
            panel3 = new Panel();
            TiemNangLabel = new Label();
            TiemNangBox = new TextBox();
            TenDNLabel = new Label();
            TenLDLabel = new Label();
            TenDNBox = new TextBox();
            TenLDBox = new TextBox();
            GhiChuLabel = new Label();
            GhiChuBox = new TextBox();
            DanhGiaDNTitleLabel = new Label();
            DanhGiaData = new DataGridView();
            panel2 = new Panel();
            LamMoiButton = new Button();
            LapDSTNButton = new Button();
            DNThongKeBox = new TextBox();
            ThemDGButton = new Button();
            ThongKeButton = new Button();
            LapDSTiemNangTip = new ToolTip(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DanhGiaData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(XemDGTitleLabel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(DanhGiaDNTitleLabel);
            panel1.Controls.Add(DanhGiaData);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 0;
            // 
            // XemDGTitleLabel
            // 
            XemDGTitleLabel.AutoSize = true;
            XemDGTitleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XemDGTitleLabel.ForeColor = Color.LightSeaGreen;
            XemDGTitleLabel.Location = new Point(547, 13);
            XemDGTitleLabel.Name = "XemDGTitleLabel";
            XemDGTitleLabel.Size = new Size(162, 31);
            XemDGTitleLabel.TabIndex = 8;
            XemDGTitleLabel.Text = "Xem đánh giá";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TiemNangLabel);
            panel3.Controls.Add(TiemNangBox);
            panel3.Controls.Add(TenDNLabel);
            panel3.Controls.Add(TenLDLabel);
            panel3.Controls.Add(TenDNBox);
            panel3.Controls.Add(TenLDBox);
            panel3.Controls.Add(GhiChuLabel);
            panel3.Controls.Add(GhiChuBox);
            panel3.Location = new Point(368, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(520, 250);
            panel3.TabIndex = 7;
            // 
            // TiemNangLabel
            // 
            TiemNangLabel.AutoSize = true;
            TiemNangLabel.BackColor = Color.Transparent;
            TiemNangLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TiemNangLabel.ForeColor = Color.LightSeaGreen;
            TiemNangLabel.Location = new Point(375, 94);
            TiemNangLabel.Name = "TiemNangLabel";
            TiemNangLabel.Size = new Size(91, 23);
            TiemNangLabel.TabIndex = 14;
            TiemNangLabel.Text = "Tiềm năng";
            // 
            // TiemNangBox
            // 
            TiemNangBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TiemNangBox.Location = new Point(384, 120);
            TiemNangBox.Name = "TiemNangBox";
            TiemNangBox.PlaceholderText = "Tiềm năng";
            TiemNangBox.ReadOnly = true;
            TiemNangBox.Size = new Size(75, 30);
            TiemNangBox.TabIndex = 13;
            // 
            // TenDNLabel
            // 
            TenDNLabel.AutoSize = true;
            TenDNLabel.BackColor = Color.Transparent;
            TenDNLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenDNLabel.ForeColor = Color.LightSeaGreen;
            TenDNLabel.Location = new Point(59, 24);
            TenDNLabel.Name = "TenDNLabel";
            TenDNLabel.Size = new Size(148, 23);
            TenDNLabel.TabIndex = 12;
            TenDNLabel.Text = "Tên doanh nghiệp";
            // 
            // TenLDLabel
            // 
            TenLDLabel.AutoSize = true;
            TenLDLabel.BackColor = Color.Transparent;
            TenLDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenLDLabel.ForeColor = Color.LightSeaGreen;
            TenLDLabel.Location = new Point(59, 94);
            TenLDLabel.Name = "TenLDLabel";
            TenLDLabel.Size = new Size(180, 23);
            TenLDLabel.TabIndex = 11;
            TenLDLabel.Text = "Tên lãnh đạo đánh giá";
            // 
            // TenDNBox
            // 
            TenDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenDNBox.Location = new Point(59, 50);
            TenDNBox.Name = "TenDNBox";
            TenDNBox.PlaceholderText = "Tên doanh nghiệp";
            TenDNBox.ReadOnly = true;
            TenDNBox.Size = new Size(400, 30);
            TenDNBox.TabIndex = 11;
            // 
            // TenLDBox
            // 
            TenLDBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenLDBox.Location = new Point(59, 120);
            TenLDBox.Name = "TenLDBox";
            TenLDBox.PlaceholderText = "Tên lãnh đạo đánh giá";
            TenLDBox.ReadOnly = true;
            TenLDBox.Size = new Size(300, 30);
            TenLDBox.TabIndex = 10;
            // 
            // GhiChuLabel
            // 
            GhiChuLabel.AutoSize = true;
            GhiChuLabel.BackColor = Color.Transparent;
            GhiChuLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GhiChuLabel.ForeColor = Color.LightSeaGreen;
            GhiChuLabel.Location = new Point(59, 164);
            GhiChuLabel.Name = "GhiChuLabel";
            GhiChuLabel.Size = new Size(69, 23);
            GhiChuLabel.TabIndex = 9;
            GhiChuLabel.Text = "Ghi chú";
            // 
            // GhiChuBox
            // 
            GhiChuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GhiChuBox.Location = new Point(59, 190);
            GhiChuBox.Name = "GhiChuBox";
            GhiChuBox.PlaceholderText = "Ghi chú";
            GhiChuBox.ReadOnly = true;
            GhiChuBox.Size = new Size(400, 30);
            GhiChuBox.TabIndex = 4;
            // 
            // DanhGiaDNTitleLabel
            // 
            DanhGiaDNTitleLabel.AutoSize = true;
            DanhGiaDNTitleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DanhGiaDNTitleLabel.ForeColor = Color.LightSeaGreen;
            DanhGiaDNTitleLabel.Location = new Point(55, 15);
            DanhGiaDNTitleLabel.Name = "DanhGiaDNTitleLabel";
            DanhGiaDNTitleLabel.Size = new Size(265, 31);
            DanhGiaDNTitleLabel.TabIndex = 2;
            DanhGiaDNTitleLabel.Text = "Đánh giá doanh nghiệp";
            // 
            // DanhGiaData
            // 
            DanhGiaData.AllowUserToAddRows = false;
            DanhGiaData.AllowUserToDeleteRows = false;
            DanhGiaData.AllowUserToResizeColumns = false;
            DanhGiaData.AllowUserToResizeRows = false;
            DanhGiaData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DanhGiaData.BorderStyle = BorderStyle.None;
            DanhGiaData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhGiaData.Dock = DockStyle.Bottom;
            DanhGiaData.Location = new Point(0, 300);
            DanhGiaData.Name = "DanhGiaData";
            DanhGiaData.ReadOnly = true;
            DanhGiaData.RowHeadersVisible = false;
            DanhGiaData.RowHeadersWidth = 51;
            DanhGiaData.Size = new Size(900, 400);
            DanhGiaData.TabIndex = 0;
            DanhGiaData.CellClick += DanhGiaData_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(LamMoiButton);
            panel2.Controls.Add(LapDSTNButton);
            panel2.Controls.Add(DNThongKeBox);
            panel2.Controls.Add(ThemDGButton);
            panel2.Controls.Add(ThongKeButton);
            panel2.Location = new Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 250);
            panel2.TabIndex = 1;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(212, 105);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(100, 40);
            LamMoiButton.TabIndex = 7;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // LapDSTNButton
            // 
            LapDSTNButton.BackColor = Color.LightSeaGreen;
            LapDSTNButton.FlatAppearance.BorderSize = 0;
            LapDSTNButton.FlatStyle = FlatStyle.Flat;
            LapDSTNButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapDSTNButton.ForeColor = Color.White;
            LapDSTNButton.Location = new Point(37, 175);
            LapDSTNButton.Name = "LapDSTNButton";
            LapDSTNButton.Size = new Size(275, 40);
            LapDSTNButton.TabIndex = 6;
            LapDSTNButton.Text = "Lập danh sách tiềm năng";
            LapDSTiemNangTip.SetToolTip(LapDSTNButton, "Toàn bảng sẽ được copy vào clipboard. Nếu Excel không tự động mở, vui lòng paste vào nơi cần thiết.");
            LapDSTNButton.UseVisualStyleBackColor = false;
            LapDSTNButton.Click += LapDSTNButton_Click;
            // 
            // DNThongKeBox
            // 
            DNThongKeBox.CharacterCasing = CharacterCasing.Upper;
            DNThongKeBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DNThongKeBox.Location = new Point(187, 45);
            DNThongKeBox.Name = "DNThongKeBox";
            DNThongKeBox.PlaceholderText = "Mã doanh nghiệp";
            DNThongKeBox.Size = new Size(125, 30);
            DNThongKeBox.TabIndex = 4;
            // 
            // ThemDGButton
            // 
            ThemDGButton.BackColor = Color.LightSeaGreen;
            ThemDGButton.FlatAppearance.BorderSize = 0;
            ThemDGButton.FlatStyle = FlatStyle.Flat;
            ThemDGButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemDGButton.ForeColor = Color.White;
            ThemDGButton.Location = new Point(37, 105);
            ThemDGButton.Name = "ThemDGButton";
            ThemDGButton.Size = new Size(150, 40);
            ThemDGButton.TabIndex = 5;
            ThemDGButton.Text = "Thêm đánh giá";
            ThemDGButton.UseVisualStyleBackColor = false;
            ThemDGButton.Click += ThemDGButton_Click;
            // 
            // ThongKeButton
            // 
            ThongKeButton.BackColor = Color.LightSeaGreen;
            ThongKeButton.FlatAppearance.BorderSize = 0;
            ThongKeButton.FlatStyle = FlatStyle.Flat;
            ThongKeButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThongKeButton.ForeColor = Color.White;
            ThongKeButton.Location = new Point(37, 35);
            ThongKeButton.Name = "ThongKeButton";
            ThongKeButton.Size = new Size(125, 40);
            ThongKeButton.TabIndex = 3;
            ThongKeButton.Text = "Thống kê";
            ThongKeButton.UseVisualStyleBackColor = false;
            ThongKeButton.Click += ThongKeButton_Click;
            // 
            // DanhGiaTiemNang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DanhGiaTiemNang";
            Text = "DanhGiaTiemNang";
            Load += DanhGiaTiemNang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DanhGiaData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DanhGiaData;
        private Panel panel2;
        private Label DanhGiaDNTitleLabel;
        private Button ThemDGButton;
        private TextBox DNThongKeBox;
        private Button ThongKeButton;
        private Button LapDSTNButton;
        private Label XemDGTitleLabel;
        private Panel panel3;
        private TextBox GhiChuBox;
        private Label GhiChuLabel;
        private Label TenLDLabel;
        private TextBox TenDNBox;
        private TextBox TenLDBox;
        private Label TenDNLabel;
        private Label TiemNangLabel;
        private TextBox TiemNangBox;
        private Button LamMoiButton;
        private ToolTip LapDSTiemNangTip;
    }
}