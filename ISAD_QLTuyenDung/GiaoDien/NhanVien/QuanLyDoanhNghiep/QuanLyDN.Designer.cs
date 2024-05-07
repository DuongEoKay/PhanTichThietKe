namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    partial class QuanLyDN
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
            ThongKeHDButton = new Button();
            ThemDNButton = new Button();
            NVPhuTrachBox = new TextBox();
            CapNhatButton = new Button();
            TimDNButton = new Button();
            label10 = new Label();
            LamMoiButton = new Button();
            label9 = new Label();
            TenCtyBox = new TextBox();
            DiaChiBox = new TextBox();
            MaDNBox = new TextBox();
            label8 = new Label();
            MaSoThueBox = new TextBox();
            NgDaiDienBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label1 = new Label();
            NgayHHDate = new DateTimePicker();
            EmailBox = new TextBox();
            label6 = new Label();
            label3 = new Label();
            NgayLapDate = new DateTimePicker();
            label4 = new Label();
            DoanhNghiepData = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoanhNghiepData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(DoanhNghiepData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(325, 11);
            label2.Name = "label2";
            label2.Size = new Size(251, 31);
            label2.TabIndex = 9;
            label2.Text = "Quản lý doanh nghiệp";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(ThongKeHDButton);
            panel3.Controls.Add(ThemDNButton);
            panel3.Controls.Add(NVPhuTrachBox);
            panel3.Controls.Add(CapNhatButton);
            panel3.Controls.Add(TimDNButton);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(TenCtyBox);
            panel3.Controls.Add(DiaChiBox);
            panel3.Controls.Add(MaDNBox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(MaSoThueBox);
            panel3.Controls.Add(NgDaiDienBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(NgayHHDate);
            panel3.Controls.Add(EmailBox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(NgayLapDate);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 316);
            panel3.TabIndex = 8;
            // 
            // ThongKeHDButton
            // 
            ThongKeHDButton.BackColor = Color.LightSeaGreen;
            ThongKeHDButton.FlatAppearance.BorderSize = 0;
            ThongKeHDButton.FlatStyle = FlatStyle.Flat;
            ThongKeHDButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThongKeHDButton.ForeColor = Color.White;
            ThongKeHDButton.Location = new Point(412, 250);
            ThongKeHDButton.Name = "ThongKeHDButton";
            ThongKeHDButton.Size = new Size(205, 40);
            ThongKeHDButton.TabIndex = 72;
            ThongKeHDButton.Text = "Thống kê hạn hợp đồng";
            ThongKeHDButton.UseVisualStyleBackColor = false;
            ThongKeHDButton.Click += ThongKeHDButton_Click;
            // 
            // ThemDNButton
            // 
            ThemDNButton.BackColor = Color.LightSeaGreen;
            ThemDNButton.FlatAppearance.BorderSize = 0;
            ThemDNButton.FlatStyle = FlatStyle.Flat;
            ThemDNButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemDNButton.ForeColor = Color.White;
            ThemDNButton.Location = new Point(231, 250);
            ThemDNButton.Name = "ThemDNButton";
            ThemDNButton.Size = new Size(175, 40);
            ThemDNButton.TabIndex = 11;
            ThemDNButton.Text = "Thêm doanh nghiệp";
            ThemDNButton.UseVisualStyleBackColor = false;
            ThemDNButton.Click += ThemDNButton_Click;
            // 
            // NVPhuTrachBox
            // 
            NVPhuTrachBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NVPhuTrachBox.Location = new Point(656, 51);
            NVPhuTrachBox.Name = "NVPhuTrachBox";
            NVPhuTrachBox.PlaceholderText = "Nhân viên";
            NVPhuTrachBox.ReadOnly = true;
            NVPhuTrachBox.Size = new Size(153, 30);
            NVPhuTrachBox.TabIndex = 71;
            // 
            // CapNhatButton
            // 
            CapNhatButton.BackColor = Color.LightSeaGreen;
            CapNhatButton.FlatAppearance.BorderSize = 0;
            CapNhatButton.FlatStyle = FlatStyle.Flat;
            CapNhatButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CapNhatButton.ForeColor = Color.White;
            CapNhatButton.Location = new Point(623, 250);
            CapNhatButton.Name = "CapNhatButton";
            CapNhatButton.Size = new Size(90, 40);
            CapNhatButton.TabIndex = 70;
            CapNhatButton.Text = "Cập nhật";
            CapNhatButton.UseVisualStyleBackColor = false;
            CapNhatButton.Click += CapNhatButton_Click;
            // 
            // TimDNButton
            // 
            TimDNButton.BackColor = Color.LightSeaGreen;
            TimDNButton.FlatAppearance.BorderSize = 0;
            TimDNButton.FlatStyle = FlatStyle.Flat;
            TimDNButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimDNButton.ForeColor = Color.White;
            TimDNButton.Location = new Point(65, 250);
            TimDNButton.Name = "TimDNButton";
            TimDNButton.Size = new Size(160, 40);
            TimDNButton.TabIndex = 6;
            TimDNButton.Text = "Tìm doanh nghiệp";
            TimDNButton.UseVisualStyleBackColor = false;
            TimDNButton.Click += TimDNButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.LightSeaGreen;
            label10.Location = new Point(656, 25);
            label10.Name = "label10";
            label10.Size = new Size(113, 23);
            label10.TabIndex = 69;
            label10.Text = "NV phụ trách";
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(719, 250);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(90, 40);
            LamMoiButton.TabIndex = 23;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(381, 165);
            label9.Name = "label9";
            label9.Size = new Size(62, 23);
            label9.TabIndex = 67;
            label9.Text = "Địa chỉ";
            // 
            // TenCtyBox
            // 
            TenCtyBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenCtyBox.Location = new Point(180, 51);
            TenCtyBox.Name = "TenCtyBox";
            TenCtyBox.PlaceholderText = "Tên công ty";
            TenCtyBox.ReadOnly = true;
            TenCtyBox.Size = new Size(450, 30);
            TenCtyBox.TabIndex = 52;
            // 
            // DiaChiBox
            // 
            DiaChiBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiaChiBox.Location = new Point(381, 191);
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.PlaceholderText = "Địa chỉ";
            DiaChiBox.ReadOnly = true;
            DiaChiBox.Size = new Size(428, 30);
            DiaChiBox.TabIndex = 66;
            // 
            // MaDNBox
            // 
            MaDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNBox.Location = new Point(65, 51);
            MaDNBox.Name = "MaDNBox";
            MaDNBox.PlaceholderText = "Mã DN";
            MaDNBox.ReadOnly = true;
            MaDNBox.Size = new Size(100, 30);
            MaDNBox.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(531, 95);
            label8.Name = "label8";
            label8.Size = new Size(124, 23);
            label8.TabIndex = 65;
            label8.Text = "Người đại diện";
            // 
            // MaSoThueBox
            // 
            MaSoThueBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaSoThueBox.Location = new Point(65, 121);
            MaSoThueBox.Name = "MaSoThueBox";
            MaSoThueBox.PlaceholderText = "Mã số thuế";
            MaSoThueBox.ReadOnly = true;
            MaSoThueBox.Size = new Size(150, 30);
            MaSoThueBox.TabIndex = 54;
            // 
            // NgDaiDienBox
            // 
            NgDaiDienBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgDaiDienBox.Location = new Point(531, 121);
            NgDaiDienBox.Name = "NgDaiDienBox";
            NgDaiDienBox.PlaceholderText = "Người đại diện";
            NgDaiDienBox.ReadOnly = true;
            NgDaiDienBox.Size = new Size(278, 30);
            NgDaiDienBox.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(180, 25);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 55;
            label5.Text = "Tên công ty";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(213, 165);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 63;
            label7.Text = "Ngày hết hạn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(65, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 56;
            label1.Text = "Mã DN";
            // 
            // NgayHHDate
            // 
            NgayHHDate.CustomFormat = "dd/MM/yyyy";
            NgayHHDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayHHDate.Format = DateTimePickerFormat.Custom;
            NgayHHDate.Location = new Point(214, 191);
            NgayHHDate.Name = "NgayHHDate";
            NgayHHDate.Size = new Size(125, 30);
            NgayHHDate.TabIndex = 62;
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(238, 121);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Email";
            EmailBox.ReadOnly = true;
            EmailBox.Size = new Size(250, 30);
            EmailBox.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(65, 165);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 61;
            label6.Text = "Ngày lập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(65, 95);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 58;
            label3.Text = "Mã số thuế";
            // 
            // NgayLapDate
            // 
            NgayLapDate.CustomFormat = "dd/MM/yyyy";
            NgayLapDate.Enabled = false;
            NgayLapDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayLapDate.Format = DateTimePickerFormat.Custom;
            NgayLapDate.Location = new Point(65, 191);
            NgayLapDate.Name = "NgayLapDate";
            NgayLapDate.Size = new Size(125, 30);
            NgayLapDate.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(238, 95);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 59;
            label4.Text = "Email";
            // 
            // DoanhNghiepData
            // 
            DoanhNghiepData.AllowUserToAddRows = false;
            DoanhNghiepData.AllowUserToDeleteRows = false;
            DoanhNghiepData.AllowUserToResizeColumns = false;
            DoanhNghiepData.AllowUserToResizeRows = false;
            DoanhNghiepData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DoanhNghiepData.BorderStyle = BorderStyle.None;
            DoanhNghiepData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoanhNghiepData.Dock = DockStyle.Bottom;
            DoanhNghiepData.Location = new Point(0, 350);
            DoanhNghiepData.Name = "DoanhNghiepData";
            DoanhNghiepData.ReadOnly = true;
            DoanhNghiepData.RowHeadersVisible = false;
            DoanhNghiepData.RowHeadersWidth = 51;
            DoanhNghiepData.Size = new Size(900, 350);
            DoanhNghiepData.TabIndex = 10;
            DoanhNghiepData.CellClick += DoanhNghiepData_CellClick;
            // 
            // QuanLyDN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuanLyDN";
            Text = "QuanLyDN";
            Load += QuanLyDN_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoanhNghiepData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView DoanhNghiepData;
        private Label label2;
        private Panel panel3;
        private Button LamMoiButton;
        private Button TimDNButton;
        private Label label10;
        private Label label9;
        private TextBox TenCtyBox;
        private TextBox DiaChiBox;
        private TextBox MaDNBox;
        private Label label8;
        private TextBox MaSoThueBox;
        private TextBox NgDaiDienBox;
        private Label label5;
        private Label label7;
        private Label label1;
        private DateTimePicker NgayHHDate;
        private TextBox EmailBox;
        private Label label6;
        private Label label3;
        private DateTimePicker NgayLapDate;
        private Label label4;
        private TextBox NVPhuTrachBox;
        private Button CapNhatButton;
        private Button ThemDNButton;
        private Button ThongKeHDButton;
    }
}