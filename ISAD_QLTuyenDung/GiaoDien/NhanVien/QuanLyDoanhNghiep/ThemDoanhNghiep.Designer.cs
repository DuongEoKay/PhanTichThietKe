namespace ISAD_QLTuyenDung.GiaoDien.NhanVien
{
    partial class ThemDoanhNghiep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemDoanhNghiep));
            label1 = new Label();
            panel1 = new Panel();
            NVPhuTrachCbo = new ComboBox();
            HuyButton = new Button();
            label9 = new Label();
            label8 = new Label();
            NgayLapDate = new DateTimePicker();
            NgayHHDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            MaSoThueBox = new TextBox();
            label4 = new Label();
            DiaChiBox = new TextBox();
            NguoiDaiDienBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            EmailBox = new TextBox();
            label5 = new Label();
            TenCtyBox = new TextBox();
            ThemButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 38);
            label1.TabIndex = 4;
            label1.Text = "Thêm doanh nghiệp";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(NVPhuTrachCbo);
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(NgayLapDate);
            panel1.Controls.Add(NgayHHDate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(MaSoThueBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DiaChiBox);
            panel1.Controls.Add(NguoiDaiDienBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(EmailBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TenCtyBox);
            panel1.Controls.Add(ThemButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 453);
            panel1.TabIndex = 5;
            // 
            // NVPhuTrachCbo
            // 
            NVPhuTrachCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NVPhuTrachCbo.FormattingEnabled = true;
            NVPhuTrachCbo.Location = new Point(491, 159);
            NVPhuTrachCbo.Name = "NVPhuTrachCbo";
            NVPhuTrachCbo.Size = new Size(125, 31);
            NVPhuTrachCbo.TabIndex = 45;
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(441, 363);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(175, 50);
            HuyButton.TabIndex = 44;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(66, 204);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 43;
            label9.Text = "Ngày lập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSeaGreen;
            label8.Location = new Point(213, 204);
            label8.Name = "label8";
            label8.Size = new Size(136, 23);
            label8.TabIndex = 42;
            label8.Text = "Ngày hoạt động";
            // 
            // NgayLapDate
            // 
            NgayLapDate.CustomFormat = "dd/MM/yyyy";
            NgayLapDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayLapDate.Format = DateTimePickerFormat.Custom;
            NgayLapDate.Location = new Point(66, 230);
            NgayLapDate.Name = "NgayLapDate";
            NgayLapDate.Size = new Size(125, 30);
            NgayLapDate.TabIndex = 41;
            // 
            // NgayHHDate
            // 
            NgayHHDate.CustomFormat = "dd/MM/yyyy";
            NgayHHDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayHHDate.Format = DateTimePickerFormat.Custom;
            NgayHHDate.Location = new Point(213, 230);
            NgayHHDate.Name = "NgayHHDate";
            NgayHHDate.Size = new Size(125, 30);
            NgayHHDate.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(490, 134);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 39;
            label6.Text = "NV phụ trách";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(66, 134);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 37;
            label7.Text = "Mã số thuế";
            // 
            // MaSoThueBox
            // 
            MaSoThueBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaSoThueBox.Location = new Point(66, 160);
            MaSoThueBox.Name = "MaSoThueBox";
            MaSoThueBox.PlaceholderText = "Mã số thuế";
            MaSoThueBox.Size = new Size(175, 30);
            MaSoThueBox.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(66, 274);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 35;
            label4.Text = "Địa chỉ";
            // 
            // DiaChiBox
            // 
            DiaChiBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiaChiBox.Location = new Point(66, 300);
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.PlaceholderText = "Địa chỉ";
            DiaChiBox.Size = new Size(550, 30);
            DiaChiBox.TabIndex = 34;
            // 
            // NguoiDaiDienBox
            // 
            NguoiDaiDienBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NguoiDaiDienBox.Location = new Point(267, 160);
            NguoiDaiDienBox.Name = "NguoiDaiDienBox";
            NguoiDaiDienBox.PlaceholderText = "Người đại diện";
            NguoiDaiDienBox.Size = new Size(200, 30);
            NguoiDaiDienBox.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(267, 134);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 32;
            label3.Text = "Người đại diện";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(366, 204);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 31;
            label2.Text = "Email";
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBox.Location = new Point(366, 230);
            EmailBox.Name = "EmailBox";
            EmailBox.PlaceholderText = "Email";
            EmailBox.Size = new Size(250, 30);
            EmailBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(66, 64);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 29;
            label5.Text = "Tên công ty";
            // 
            // TenCtyBox
            // 
            TenCtyBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenCtyBox.Location = new Point(66, 90);
            TenCtyBox.Name = "TenCtyBox";
            TenCtyBox.PlaceholderText = "Tên công ty";
            TenCtyBox.Size = new Size(550, 30);
            TenCtyBox.TabIndex = 28;
            // 
            // ThemButton
            // 
            ThemButton.BackColor = Color.LightSeaGreen;
            ThemButton.FlatAppearance.BorderSize = 0;
            ThemButton.FlatStyle = FlatStyle.Flat;
            ThemButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemButton.ForeColor = Color.White;
            ThemButton.Location = new Point(66, 363);
            ThemButton.Name = "ThemButton";
            ThemButton.Size = new Size(175, 50);
            ThemButton.TabIndex = 11;
            ThemButton.Text = "Thêm";
            ThemButton.UseVisualStyleBackColor = false;
            ThemButton.Click += ThemButton_Click;
            // 
            // ThemDoanhNghiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemDoanhNghiep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Doanh Nghiệp";
            Load += ThemDoanhNghiep_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button ThemButton;
        private Label label6;
        private Label label7;
        private TextBox MaSoThueBox;
        private Label label4;
        private TextBox DiaChiBox;
        private TextBox NguoiDaiDienBox;
        private Label label3;
        private Label label2;
        private TextBox EmailBox;
        private Label label5;
        private TextBox TenCtyBox;
        private DateTimePicker NgayHHDate;
        private DateTimePicker NgayLapDate;
        private Label label9;
        private Label label8;
        private Button HuyButton;
        private ComboBox NVPhuTrachCbo;
    }
}