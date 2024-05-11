namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.QuanLyUngVien
{
    partial class DangKyUngVien
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
            label5 = new Label();
            NVPhuTrachBox = new TextBox();
            EmailBox = new TextBox();
            label9 = new Label();
            SoDienThoaiBox = new TextBox();
            label7 = new Label();
            LamMoiButton = new Button();
            ThemUVButton = new Button();
            label4 = new Label();
            DiaChiBox = new TextBox();
            HoTenBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            MaUVBox = new TextBox();
            UngVienData = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UngVienData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(UngVienData);
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
            label2.Location = new Point(349, 12);
            label2.Name = "label2";
            label2.Size = new Size(202, 31);
            label2.TabIndex = 9;
            label2.Text = "Đăng ký ứng viên";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(NVPhuTrachBox);
            panel3.Controls.Add(EmailBox);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(SoDienThoaiBox);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(ThemUVButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(DiaChiBox);
            panel3.Controls.Add(HoTenBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(MaUVBox);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(620, 42);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 33;
            label5.Text = "Mã NV phụ trách";
            // 
            // NVPhuTrachBox
            // 
            NVPhuTrachBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NVPhuTrachBox.Location = new Point(620, 68);
            NVPhuTrachBox.Name = "NVPhuTrachBox";
            NVPhuTrachBox.PlaceholderText = "Mã nhân viên";
            NVPhuTrachBox.ReadOnly = true;
            NVPhuTrachBox.Size = new Size(150, 30);
            NVPhuTrachBox.TabIndex = 32;
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(280, 128);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Email";
            EmailBox.ReadOnly = true;
            EmailBox.Size = new Size(300, 30);
            EmailBox.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(280, 102);
            label9.Name = "label9";
            label9.Size = new Size(51, 23);
            label9.TabIndex = 29;
            label9.Text = "Email";
            // 
            // SoDienThoaiBox
            // 
            SoDienThoaiBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoDienThoaiBox.Location = new Point(105, 128);
            SoDienThoaiBox.Name = "SoDienThoaiBox";
            SoDienThoaiBox.PlaceholderText = "Số điện thoại";
            SoDienThoaiBox.ReadOnly = true;
            SoDienThoaiBox.Size = new Size(150, 30);
            SoDienThoaiBox.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(105, 102);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 24;
            label7.Text = "Số điện thoại";
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(620, 178);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(150, 40);
            LamMoiButton.TabIndex = 23;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // ThemUVButton
            // 
            ThemUVButton.BackColor = Color.LightSeaGreen;
            ThemUVButton.FlatAppearance.BorderSize = 0;
            ThemUVButton.FlatStyle = FlatStyle.Flat;
            ThemUVButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemUVButton.ForeColor = Color.White;
            ThemUVButton.Location = new Point(620, 118);
            ThemUVButton.Name = "ThemUVButton";
            ThemUVButton.Size = new Size(150, 40);
            ThemUVButton.TabIndex = 6;
            ThemUVButton.Text = "Thêm ứng viên";
            ThemUVButton.UseVisualStyleBackColor = false;
            ThemUVButton.Click += ThemUVButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(105, 162);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 20;
            label4.Text = "Địa chỉ";
            // 
            // DiaChiBox
            // 
            DiaChiBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiaChiBox.Location = new Point(105, 188);
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.PlaceholderText = "Địa chỉ";
            DiaChiBox.ReadOnly = true;
            DiaChiBox.Size = new Size(475, 30);
            DiaChiBox.TabIndex = 19;
            // 
            // HoTenBox
            // 
            HoTenBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HoTenBox.Location = new Point(280, 68);
            HoTenBox.Name = "HoTenBox";
            HoTenBox.PlaceholderText = "Họ tên";
            HoTenBox.ReadOnly = true;
            HoTenBox.Size = new Size(300, 30);
            HoTenBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(280, 42);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 17;
            label3.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(105, 42);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 16;
            label1.Text = "Mã ứng viên";
            // 
            // MaUVBox
            // 
            MaUVBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaUVBox.Location = new Point(105, 68);
            MaUVBox.Name = "MaUVBox";
            MaUVBox.PlaceholderText = "Mã UV";
            MaUVBox.ReadOnly = true;
            MaUVBox.Size = new Size(150, 30);
            MaUVBox.TabIndex = 15;
            // 
            // UngVienData
            // 
            UngVienData.AllowUserToAddRows = false;
            UngVienData.AllowUserToDeleteRows = false;
            UngVienData.AllowUserToResizeColumns = false;
            UngVienData.AllowUserToResizeRows = false;
            UngVienData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            UngVienData.BorderStyle = BorderStyle.None;
            UngVienData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UngVienData.Dock = DockStyle.Bottom;
            UngVienData.Location = new Point(0, 300);
            UngVienData.Name = "UngVienData";
            UngVienData.ReadOnly = true;
            UngVienData.RowHeadersVisible = false;
            UngVienData.RowHeadersWidth = 51;
            UngVienData.Size = new Size(900, 400);
            UngVienData.TabIndex = 10;
            UngVienData.CellClick += UngVienData_CellClick;
            // 
            // DangKyUngVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangKyUngVien";
            Text = "DangKyUngVien";
            Load += DangKyUngVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UngVienData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Label label9;
        private TextBox SoDienThoaiBox;
        private Label label7;
        private Button LamMoiButton;
        private Button ThemUVButton;
        private Label label4;
        private TextBox DiaChiBox;
        private TextBox HoTenBox;
        private Label label3;
        private Label label1;
        private TextBox MaUVBox;
        private DataGridView UngVienData;
        private TextBox EmailBox;
        private Label label5;
        private TextBox NVPhuTrachBox;
    }
}