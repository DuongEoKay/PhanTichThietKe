namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    partial class LapHoSoTuyenDung
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
            HoSoData = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            MaPhieuBox = new TextBox();
            label7 = new Label();
            MaDNBox = new TextBox();
            LamMoiButton = new Button();
            label6 = new Label();
            TinhTrangBox = new TextBox();
            label4 = new Label();
            GhiChuBox = new TextBox();
            ViTriUTBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            MaUVBox = new TextBox();
            label5 = new Label();
            TenUVBox = new TextBox();
            ThemHoSoButton = new Button();
            LapDSHSButton = new Button();
            DuyetHSButton = new Button();
            ((System.ComponentModel.ISupportInitialize)HoSoData).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // HoSoData
            // 
            HoSoData.AllowUserToAddRows = false;
            HoSoData.AllowUserToDeleteRows = false;
            HoSoData.AllowUserToResizeColumns = false;
            HoSoData.AllowUserToResizeRows = false;
            HoSoData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HoSoData.BorderStyle = BorderStyle.None;
            HoSoData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HoSoData.Dock = DockStyle.Bottom;
            HoSoData.Location = new Point(0, 300);
            HoSoData.Name = "HoSoData";
            HoSoData.ReadOnly = true;
            HoSoData.RowHeadersVisible = false;
            HoSoData.RowHeadersWidth = 51;
            HoSoData.Size = new Size(900, 400);
            HoSoData.TabIndex = 0;
            HoSoData.CellClick += HoSoData_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(348, 11);
            label2.Name = "label2";
            label2.Size = new Size(205, 31);
            label2.TabIndex = 9;
            label2.Text = "Hồ sơ tuyển dụng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(MaPhieuBox);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(MaDNBox);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(TinhTrangBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(GhiChuBox);
            panel3.Controls.Add(ViTriUTBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(MaUVBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(TenUVBox);
            panel3.Controls.Add(ThemHoSoButton);
            panel3.Controls.Add(LapDSHSButton);
            panel3.Controls.Add(DuyetHSButton);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(201, 95);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 27;
            label8.Text = "Mã phiếu";
            // 
            // MaPhieuBox
            // 
            MaPhieuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaPhieuBox.Location = new Point(201, 120);
            MaPhieuBox.Name = "MaPhieuBox";
            MaPhieuBox.PlaceholderText = "Mã phiếu";
            MaPhieuBox.ReadOnly = true;
            MaPhieuBox.Size = new Size(100, 30);
            MaPhieuBox.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(78, 95);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 25;
            label7.Text = "Mã DN";
            // 
            // MaDNBox
            // 
            MaDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNBox.Location = new Point(78, 120);
            MaDNBox.Name = "MaDNBox";
            MaDNBox.PlaceholderText = "Mã DN";
            MaDNBox.ReadOnly = true;
            MaDNBox.Size = new Size(100, 30);
            MaDNBox.TabIndex = 24;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(596, 202);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(200, 40);
            LamMoiButton.TabIndex = 23;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(397, 34);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 22;
            label6.Text = "Tình trạng";
            // 
            // TinhTrangBox
            // 
            TinhTrangBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TinhTrangBox.Location = new Point(397, 60);
            TinhTrangBox.Name = "TinhTrangBox";
            TinhTrangBox.PlaceholderText = "Tình trạng";
            TinhTrangBox.ReadOnly = true;
            TinhTrangBox.Size = new Size(130, 30);
            TinhTrangBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(78, 153);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 20;
            label4.Text = "Ghi chú";
            // 
            // GhiChuBox
            // 
            GhiChuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GhiChuBox.Location = new Point(78, 180);
            GhiChuBox.Name = "GhiChuBox";
            GhiChuBox.PlaceholderText = "Ghi chú";
            GhiChuBox.ReadOnly = true;
            GhiChuBox.Size = new Size(449, 30);
            GhiChuBox.TabIndex = 19;
            // 
            // ViTriUTBox
            // 
            ViTriUTBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViTriUTBox.Location = new Point(327, 120);
            ViTriUTBox.Name = "ViTriUTBox";
            ViTriUTBox.PlaceholderText = "Vị trí ứng tuyển";
            ViTriUTBox.ReadOnly = true;
            ViTriUTBox.Size = new Size(200, 30);
            ViTriUTBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(327, 94);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 17;
            label3.Text = "Vị trí ứng tuyển";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(78, 34);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 16;
            label1.Text = "Mã ứng viên";
            // 
            // MaUVBox
            // 
            MaUVBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaUVBox.Location = new Point(78, 60);
            MaUVBox.Name = "MaUVBox";
            MaUVBox.PlaceholderText = "Mã ứng viên";
            MaUVBox.ReadOnly = true;
            MaUVBox.Size = new Size(100, 30);
            MaUVBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(201, 34);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 14;
            label5.Text = "Tên ứng viên";
            // 
            // TenUVBox
            // 
            TenUVBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenUVBox.Location = new Point(201, 60);
            TenUVBox.Name = "TenUVBox";
            TenUVBox.PlaceholderText = "Tên ứng viên";
            TenUVBox.ReadOnly = true;
            TenUVBox.Size = new Size(180, 30);
            TenUVBox.TabIndex = 13;
            // 
            // ThemHoSoButton
            // 
            ThemHoSoButton.BackColor = Color.LightSeaGreen;
            ThemHoSoButton.FlatAppearance.BorderSize = 0;
            ThemHoSoButton.FlatStyle = FlatStyle.Flat;
            ThemHoSoButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemHoSoButton.ForeColor = Color.White;
            ThemHoSoButton.Location = new Point(596, 22);
            ThemHoSoButton.Name = "ThemHoSoButton";
            ThemHoSoButton.Size = new Size(200, 40);
            ThemHoSoButton.TabIndex = 6;
            ThemHoSoButton.Text = "Thêm hồ sơ";
            ThemHoSoButton.UseVisualStyleBackColor = false;
            ThemHoSoButton.Click += ThemHoSoButton_Click;
            // 
            // LapDSHSButton
            // 
            LapDSHSButton.BackColor = Color.LightSeaGreen;
            LapDSHSButton.FlatAppearance.BorderSize = 0;
            LapDSHSButton.FlatStyle = FlatStyle.Flat;
            LapDSHSButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapDSHSButton.ForeColor = Color.White;
            LapDSHSButton.Location = new Point(596, 142);
            LapDSHSButton.Name = "LapDSHSButton";
            LapDSHSButton.Size = new Size(200, 40);
            LapDSHSButton.TabIndex = 5;
            LapDSHSButton.Text = "Lập danh sách hồ sơ";
            LapDSHSButton.UseVisualStyleBackColor = false;
            LapDSHSButton.Click += LapDSHSButton_Click;
            // 
            // DuyetHSButton
            // 
            DuyetHSButton.BackColor = Color.LightSeaGreen;
            DuyetHSButton.FlatAppearance.BorderSize = 0;
            DuyetHSButton.FlatStyle = FlatStyle.Flat;
            DuyetHSButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DuyetHSButton.ForeColor = Color.White;
            DuyetHSButton.Location = new Point(596, 82);
            DuyetHSButton.Name = "DuyetHSButton";
            DuyetHSButton.Size = new Size(200, 40);
            DuyetHSButton.TabIndex = 5;
            DuyetHSButton.Text = "Duyệt hồ sơ";
            DuyetHSButton.UseVisualStyleBackColor = false;
            DuyetHSButton.Click += DuyetHSButton_Click;
            // 
            // LapHoSoTuyenDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(HoSoData);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LapHoSoTuyenDung";
            Text = "LapHoSoTuyenDung";
            Load += LapHoSoTuyenDung_Load;
            ((System.ComponentModel.ISupportInitialize)HoSoData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HoSoData;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Button LapDSHSButton;
        private Button DuyetHSButton;
        private Button ThemHoSoButton;
        private Label label5;
        private TextBox TenUVBox;
        private Label label1;
        private TextBox MaUVBox;
        private Label label3;
        private TextBox ViTriUTBox;
        private Label label4;
        private TextBox GhiChuBox;
        private Label label6;
        private TextBox TinhTrangBox;
        private Button LamMoiButton;
        private Label label7;
        private TextBox MaDNBox;
        private Label label8;
        private TextBox MaPhieuBox;
    }
}