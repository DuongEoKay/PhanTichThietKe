namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ChiTietHoaDon
{
    partial class ThemChiTietHoaDon
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
            panel1 = new Panel();
            HoaDonData = new DataGridView();
            label2 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            NgayTraDate = new DateTimePicker();
            label6 = new Label();
            SoTienBox = new TextBox();
            label8 = new Label();
            MaPhieuBox = new TextBox();
            LamMoiButton = new Button();
            label4 = new Label();
            PhuongThucBox = new TextBox();
            MaCTBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            MaDNBox = new TextBox();
            label5 = new Label();
            TenCtyBox = new TextBox();
            ThemCTHoaDonButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HoaDonData).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(HoaDonData);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 2;
            // 
            // HoaDonData
            // 
            HoaDonData.AllowUserToAddRows = false;
            HoaDonData.AllowUserToDeleteRows = false;
            HoaDonData.AllowUserToResizeColumns = false;
            HoaDonData.AllowUserToResizeRows = false;
            HoaDonData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            HoaDonData.BorderStyle = BorderStyle.None;
            HoaDonData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HoaDonData.Dock = DockStyle.Bottom;
            HoaDonData.Location = new Point(0, 300);
            HoaDonData.Name = "HoaDonData";
            HoaDonData.ReadOnly = true;
            HoaDonData.RowHeadersVisible = false;
            HoaDonData.RowHeadersWidth = 51;
            HoaDonData.Size = new Size(900, 400);
            HoaDonData.TabIndex = 10;
            HoaDonData.CellClick += HoaDonData_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(357, 11);
            label2.Name = "label2";
            label2.Size = new Size(187, 31);
            label2.TabIndex = 9;
            label2.Text = "Chi tiết hóa đơn";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(NgayTraDate);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(SoTienBox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(MaPhieuBox);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(PhuongThucBox);
            panel3.Controls.Add(MaCTBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(MaDNBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(TenCtyBox);
            panel3.Controls.Add(ThemCTHoaDonButton);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Enabled = false;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(492, 94);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 64;
            label7.Text = "Ngày trả";
            // 
            // NgayTraDate
            // 
            NgayTraDate.CustomFormat = "dd/MM/yyyy";
            NgayTraDate.Enabled = false;
            NgayTraDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayTraDate.Format = DateTimePickerFormat.Custom;
            NgayTraDate.Location = new Point(492, 120);
            NgayTraDate.Name = "NgayTraDate";
            NgayTraDate.Size = new Size(125, 30);
            NgayTraDate.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(343, 94);
            label6.Name = "label6";
            label6.Size = new Size(63, 23);
            label6.TabIndex = 29;
            label6.Text = "Số tiền";
            // 
            // SoTienBox
            // 
            SoTienBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoTienBox.Location = new Point(343, 120);
            SoTienBox.Name = "SoTienBox";
            SoTienBox.PlaceholderText = "Số tiền";
            SoTienBox.ReadOnly = true;
            SoTienBox.Size = new Size(100, 30);
            SoTienBox.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(94, 94);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 27;
            label8.Text = "Mã phiếu";
            // 
            // MaPhieuBox
            // 
            MaPhieuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaPhieuBox.Location = new Point(94, 120);
            MaPhieuBox.Name = "MaPhieuBox";
            MaPhieuBox.PlaceholderText = "Mã phiếu";
            MaPhieuBox.ReadOnly = true;
            MaPhieuBox.Size = new Size(100, 30);
            MaPhieuBox.TabIndex = 26;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(680, 170);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(100, 40);
            LamMoiButton.TabIndex = 23;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(94, 154);
            label4.Name = "label4";
            label4.Size = new Size(201, 23);
            label4.TabIndex = 20;
            label4.Text = "Phương thức thanh toán";
            // 
            // PhuongThucBox
            // 
            PhuongThucBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhuongThucBox.Location = new Point(94, 180);
            PhuongThucBox.Name = "PhuongThucBox";
            PhuongThucBox.PlaceholderText = "Phương thức thanh toán";
            PhuongThucBox.ReadOnly = true;
            PhuongThucBox.Size = new Size(523, 30);
            PhuongThucBox.TabIndex = 19;
            // 
            // MaCTBox
            // 
            MaCTBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaCTBox.Location = new Point(217, 120);
            MaCTBox.Name = "MaCTBox";
            MaCTBox.PlaceholderText = "Mã CT";
            MaCTBox.ReadOnly = true;
            MaCTBox.Size = new Size(100, 30);
            MaCTBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(217, 94);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 17;
            label3.Text = "Mã CT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(94, 34);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 16;
            label1.Text = "Mã DN";
            // 
            // MaDNBox
            // 
            MaDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNBox.Location = new Point(94, 60);
            MaDNBox.Name = "MaDNBox";
            MaDNBox.PlaceholderText = "Mã DN";
            MaDNBox.ReadOnly = true;
            MaDNBox.Size = new Size(100, 30);
            MaDNBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(217, 34);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 14;
            label5.Text = "Tên công ty";
            // 
            // TenCtyBox
            // 
            TenCtyBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenCtyBox.Location = new Point(217, 60);
            TenCtyBox.Name = "TenCtyBox";
            TenCtyBox.PlaceholderText = "Tên công ty";
            TenCtyBox.ReadOnly = true;
            TenCtyBox.Size = new Size(400, 30);
            TenCtyBox.TabIndex = 13;
            // 
            // ThemCTHoaDonButton
            // 
            ThemCTHoaDonButton.BackColor = Color.LightSeaGreen;
            ThemCTHoaDonButton.FlatAppearance.BorderSize = 0;
            ThemCTHoaDonButton.FlatStyle = FlatStyle.Flat;
            ThemCTHoaDonButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemCTHoaDonButton.ForeColor = Color.White;
            ThemCTHoaDonButton.Location = new Point(680, 114);
            ThemCTHoaDonButton.Name = "ThemCTHoaDonButton";
            ThemCTHoaDonButton.Size = new Size(100, 40);
            ThemCTHoaDonButton.TabIndex = 6;
            ThemCTHoaDonButton.Text = "Thêm";
            ThemCTHoaDonButton.UseVisualStyleBackColor = false;
            ThemCTHoaDonButton.Click += ThemCTHoaDonButton_Click;
            // 
            // ThemChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThemChiTietHoaDon";
            Text = "ThemChiTietHoaDon";
            Load += ThemChiTietHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HoaDonData).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Label label8;
        private TextBox MaPhieuBox;
        private Button LamMoiButton;
        private Label label4;
        private TextBox PhuongThucBox;
        private TextBox MaCTBox;
        private Label label3;
        private Label label1;
        private TextBox MaDNBox;
        private Label label5;
        private TextBox TenCtyBox;
        private Button ThemCTHoaDonButton;
        private DataGridView HoaDonData;
        private TextBox SoTienBox;
        private Label label6;
        private Label label7;
        private DateTimePicker NgayTraDate;
    }
}