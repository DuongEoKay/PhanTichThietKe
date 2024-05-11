namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ChiTietHoaDon
{
    partial class ThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHoaDon));
            panel1 = new Panel();
            HuyButton = new Button();
            LapButton = new Button();
            label6 = new Label();
            PhuongThucTTCbo = new ComboBox();
            label5 = new Label();
            NgayTraDate = new DateTimePicker();
            label4 = new Label();
            SoTienUpDown = new NumericUpDown();
            label2 = new Label();
            MaPhieuCbo = new ComboBox();
            label3 = new Label();
            MaDNCbo = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SoTienUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(LapButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(PhuongThucTTCbo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(NgayTraDate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SoTienUpDown);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(MaPhieuCbo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(MaDNCbo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 453);
            panel1.TabIndex = 0;
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(266, 320);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(150, 40);
            HuyButton.TabIndex = 74;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // LapButton
            // 
            LapButton.BackColor = Color.LightSeaGreen;
            LapButton.FlatAppearance.BorderSize = 0;
            LapButton.FlatStyle = FlatStyle.Flat;
            LapButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapButton.ForeColor = Color.White;
            LapButton.Location = new Point(66, 320);
            LapButton.Name = "LapButton";
            LapButton.Size = new Size(150, 40);
            LapButton.TabIndex = 73;
            LapButton.Text = "Lập";
            LapButton.UseVisualStyleBackColor = false;
            LapButton.Click += LapButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(66, 224);
            label6.Name = "label6";
            label6.Size = new Size(201, 23);
            label6.TabIndex = 72;
            label6.Text = "Phương thức thanh toán";
            // 
            // PhuongThucTTCbo
            // 
            PhuongThucTTCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhuongThucTTCbo.FormattingEnabled = true;
            PhuongThucTTCbo.Items.AddRange(new object[] { "Trực tiếp", "Thông qua thẻ thanh toán" });
            PhuongThucTTCbo.Location = new Point(66, 250);
            PhuongThucTTCbo.Name = "PhuongThucTTCbo";
            PhuongThucTTCbo.Size = new Size(350, 31);
            PhuongThucTTCbo.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(266, 154);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 70;
            label5.Text = "Ngày trả";
            // 
            // NgayTraDate
            // 
            NgayTraDate.CustomFormat = "dd/MM/yyyy";
            NgayTraDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayTraDate.Format = DateTimePickerFormat.Custom;
            NgayTraDate.Location = new Point(266, 180);
            NgayTraDate.Name = "NgayTraDate";
            NgayTraDate.Size = new Size(150, 30);
            NgayTraDate.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(66, 154);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 54;
            label4.Text = "Số tiền";
            // 
            // SoTienUpDown
            // 
            SoTienUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoTienUpDown.Location = new Point(66, 180);
            SoTienUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            SoTienUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SoTienUpDown.Name = "SoTienUpDown";
            SoTienUpDown.Size = new Size(150, 30);
            SoTienUpDown.TabIndex = 53;
            SoTienUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(266, 84);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 20;
            label2.Text = "Mã phiếu";
            // 
            // MaPhieuCbo
            // 
            MaPhieuCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaPhieuCbo.FormattingEnabled = true;
            MaPhieuCbo.Location = new Point(266, 110);
            MaPhieuCbo.Name = "MaPhieuCbo";
            MaPhieuCbo.Size = new Size(150, 31);
            MaPhieuCbo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(66, 84);
            label3.Name = "label3";
            label3.Size = new Size(147, 23);
            label3.TabIndex = 18;
            label3.Text = "Mã doanh nghiệp";
            // 
            // MaDNCbo
            // 
            MaDNCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNCbo.FormattingEnabled = true;
            MaDNCbo.Location = new Point(66, 110);
            MaDNCbo.Name = "MaDNCbo";
            MaDNCbo.Size = new Size(150, 31);
            MaDNCbo.TabIndex = 17;
            MaDNCbo.TextChanged += MaDNCbo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(137, 15);
            label1.Name = "label1";
            label1.Size = new Size(209, 38);
            label1.TabIndex = 5;
            label1.Text = "Thêm hóa đơn";
            // 
            // ThemHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm hóa đơn";
            Load += ThemHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SoTienUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox MaDNCbo;
        private Label label2;
        private ComboBox MaPhieuCbo;
        private Label label3;
        private Label label4;
        private NumericUpDown SoTienUpDown;
        private Label label5;
        private DateTimePicker NgayTraDate;
        private Label label6;
        private ComboBox PhuongThucTTCbo;
        private Button LapButton;
        private Button HuyButton;
    }
}