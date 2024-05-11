namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ThongTinDangTuyen
{
    partial class LapPTTDangTuyen
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
            label2 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            label9 = new Label();
            TongTienBox = new TextBox();
            TienDaTraBox = new TextBox();
            label8 = new Label();
            NgayKTDate = new DateTimePicker();
            label7 = new Label();
            LamMoiButton = new Button();
            NgayBDDate = new DateTimePicker();
            ThemPhieuButton = new Button();
            label6 = new Label();
            HTThanhToanBox = new TextBox();
            label4 = new Label();
            YeuCauUVBox = new TextBox();
            ViTriUTBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            MaDNBox = new TextBox();
            label5 = new Label();
            MaPhieuBox = new TextBox();
            PTTDangTuyenData = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PTTDangTuyenData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(PTTDangTuyenData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(295, 11);
            label2.Name = "label2";
            label2.Size = new Size(310, 31);
            label2.TabIndex = 9;
            label2.Text = "Phiếu thông tin đăng tuyển";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(TongTienBox);
            panel3.Controls.Add(TienDaTraBox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(NgayKTDate);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(NgayBDDate);
            panel3.Controls.Add(ThemPhieuButton);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(HTThanhToanBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(YeuCauUVBox);
            panel3.Controls.Add(ViTriUTBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(MaDNBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(MaPhieuBox);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(663, 101);
            label10.Name = "label10";
            label10.Size = new Size(92, 23);
            label10.TabIndex = 30;
            label10.Text = "Tiền đã trả";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(461, 102);
            label9.Name = "label9";
            label9.Size = new Size(83, 23);
            label9.TabIndex = 29;
            label9.Text = "Tổng tiền";
            // 
            // TongTienBox
            // 
            TongTienBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TongTienBox.Location = new Point(461, 128);
            TongTienBox.Name = "TongTienBox";
            TongTienBox.PlaceholderText = "Tổng tiền";
            TongTienBox.ReadOnly = true;
            TongTienBox.Size = new Size(150, 30);
            TongTienBox.TabIndex = 28;
            // 
            // TienDaTraBox
            // 
            TienDaTraBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TienDaTraBox.Location = new Point(663, 128);
            TienDaTraBox.Name = "TienDaTraBox";
            TienDaTraBox.PlaceholderText = "Tiền đã trả";
            TienDaTraBox.ReadOnly = true;
            TienDaTraBox.Size = new Size(150, 30);
            TienDaTraBox.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(266, 102);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 26;
            label8.Text = "Ngày kết thúc";
            // 
            // NgayKTDate
            // 
            NgayKTDate.CustomFormat = "dd/MM/yyyy";
            NgayKTDate.Enabled = false;
            NgayKTDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayKTDate.Format = DateTimePickerFormat.Custom;
            NgayKTDate.Location = new Point(266, 128);
            NgayKTDate.Name = "NgayKTDate";
            NgayKTDate.Size = new Size(150, 30);
            NgayKTDate.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(62, 102);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 24;
            label7.Text = "Ngày bắt đầu";
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(713, 178);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(100, 40);
            LamMoiButton.TabIndex = 23;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // NgayBDDate
            // 
            NgayBDDate.CustomFormat = "dd/MM/yyyy";
            NgayBDDate.Enabled = false;
            NgayBDDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayBDDate.Format = DateTimePickerFormat.Custom;
            NgayBDDate.Location = new Point(62, 128);
            NgayBDDate.Name = "NgayBDDate";
            NgayBDDate.Size = new Size(150, 30);
            NgayBDDate.TabIndex = 23;
            // 
            // ThemPhieuButton
            // 
            ThemPhieuButton.BackColor = Color.LightSeaGreen;
            ThemPhieuButton.FlatAppearance.BorderSize = 0;
            ThemPhieuButton.FlatStyle = FlatStyle.Flat;
            ThemPhieuButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemPhieuButton.ForeColor = Color.White;
            ThemPhieuButton.Location = new Point(577, 178);
            ThemPhieuButton.Name = "ThemPhieuButton";
            ThemPhieuButton.Size = new Size(130, 40);
            ThemPhieuButton.TabIndex = 6;
            ThemPhieuButton.Text = "Thêm phiếu";
            ThemPhieuButton.UseVisualStyleBackColor = false;
            ThemPhieuButton.Click += ThemPhieuButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(636, 42);
            label6.Name = "label6";
            label6.Size = new Size(177, 23);
            label6.TabIndex = 22;
            label6.Text = "Hình thức thanh toán";
            // 
            // HTThanhToanBox
            // 
            HTThanhToanBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HTThanhToanBox.Location = new Point(663, 68);
            HTThanhToanBox.Name = "HTThanhToanBox";
            HTThanhToanBox.PlaceholderText = "Hình thức thanh toán";
            HTThanhToanBox.ReadOnly = true;
            HTThanhToanBox.Size = new Size(150, 30);
            HTThanhToanBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(62, 162);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 20;
            label4.Text = "Yêu cầu ứng viên";
            // 
            // YeuCauUVBox
            // 
            YeuCauUVBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YeuCauUVBox.Location = new Point(62, 188);
            YeuCauUVBox.Name = "YeuCauUVBox";
            YeuCauUVBox.PlaceholderText = "Yêu cầu ứng viên";
            YeuCauUVBox.ReadOnly = true;
            YeuCauUVBox.Size = new Size(475, 30);
            YeuCauUVBox.TabIndex = 19;
            // 
            // ViTriUTBox
            // 
            ViTriUTBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViTriUTBox.Location = new Point(361, 68);
            ViTriUTBox.Name = "ViTriUTBox";
            ViTriUTBox.PlaceholderText = "Vị trí ứng tuyển";
            ViTriUTBox.ReadOnly = true;
            ViTriUTBox.Size = new Size(250, 30);
            ViTriUTBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(361, 42);
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
            label1.Location = new Point(62, 42);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 16;
            label1.Text = "Mã DN";
            // 
            // MaDNBox
            // 
            MaDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNBox.Location = new Point(62, 68);
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
            label5.Location = new Point(211, 42);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 14;
            label5.Text = "Mã phiếu";
            // 
            // MaPhieuBox
            // 
            MaPhieuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaPhieuBox.Location = new Point(211, 68);
            MaPhieuBox.Name = "MaPhieuBox";
            MaPhieuBox.PlaceholderText = "Mã Phiếu";
            MaPhieuBox.ReadOnly = true;
            MaPhieuBox.Size = new Size(100, 30);
            MaPhieuBox.TabIndex = 13;
            // 
            // PTTDangTuyenData
            // 
            PTTDangTuyenData.AllowUserToAddRows = false;
            PTTDangTuyenData.AllowUserToDeleteRows = false;
            PTTDangTuyenData.AllowUserToResizeColumns = false;
            PTTDangTuyenData.AllowUserToResizeRows = false;
            PTTDangTuyenData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            PTTDangTuyenData.BorderStyle = BorderStyle.None;
            PTTDangTuyenData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PTTDangTuyenData.Dock = DockStyle.Bottom;
            PTTDangTuyenData.Location = new Point(0, 300);
            PTTDangTuyenData.Name = "PTTDangTuyenData";
            PTTDangTuyenData.ReadOnly = true;
            PTTDangTuyenData.RowHeadersVisible = false;
            PTTDangTuyenData.RowHeadersWidth = 51;
            PTTDangTuyenData.Size = new Size(900, 400);
            PTTDangTuyenData.TabIndex = 10;
            PTTDangTuyenData.CellClick += PTTDangTuyenData_CellClick;
            // 
            // LapPTTDangTuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LapPTTDangTuyen";
            Text = "LapPTTDangTuyen";
            Load += LapPTTDangTuyen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PTTDangTuyenData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Button LamMoiButton;
        private Label label6;
        private TextBox HTThanhToanBox;
        private Label label4;
        private TextBox YeuCauUVBox;
        private TextBox ViTriUTBox;
        private Label label3;
        private Label label1;
        private TextBox MaDNBox;
        private Label label5;
        private TextBox MaPhieuBox;
        private Button ThemPhieuButton;
        private DataGridView PTTDangTuyenData;
        private DateTimePicker NgayBDDate;
        private Label label8;
        private DateTimePicker NgayKTDate;
        private Label label7;
        private Label label10;
        private Label label9;
        private TextBox TongTienBox;
        private TextBox TienDaTraBox;
    }
}