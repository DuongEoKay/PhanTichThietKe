namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.HoSoTuyenDung
{
    partial class DuyetHoSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuyetHoSo));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            MaDNBox = new TextBox();
            MaPhieuBox = new TextBox();
            MaUVBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            UuTienUpDown = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            GhiChuBox = new TextBox();
            label5 = new Label();
            HuyButton = new Button();
            TinhTrangCbo = new ComboBox();
            LamMoiButton = new Button();
            label3 = new Label();
            DuyetButton = new Button();
            HoSoData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UuTienUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HoSoData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(HoSoData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 653);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(353, 10);
            label1.Name = "label1";
            label1.Size = new Size(176, 38);
            label1.TabIndex = 5;
            label1.Text = "Duyệt hồ sơ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(MaDNBox);
            panel2.Controls.Add(MaPhieuBox);
            panel2.Controls.Add(MaUVBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(UuTienUpDown);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(GhiChuBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(HuyButton);
            panel2.Controls.Add(TinhTrangCbo);
            panel2.Controls.Add(LamMoiButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(DuyetButton);
            panel2.Location = new Point(25, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(832, 250);
            panel2.TabIndex = 1;
            // 
            // MaDNBox
            // 
            MaDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNBox.Location = new Point(85, 126);
            MaDNBox.Name = "MaDNBox";
            MaDNBox.PlaceholderText = "Mã doanh nghiệp";
            MaDNBox.ReadOnly = true;
            MaDNBox.Size = new Size(150, 30);
            MaDNBox.TabIndex = 36;
            // 
            // MaPhieuBox
            // 
            MaPhieuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaPhieuBox.Location = new Point(259, 126);
            MaPhieuBox.Name = "MaPhieuBox";
            MaPhieuBox.PlaceholderText = "Mã phiếu";
            MaPhieuBox.ReadOnly = true;
            MaPhieuBox.Size = new Size(150, 30);
            MaPhieuBox.TabIndex = 35;
            // 
            // MaUVBox
            // 
            MaUVBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaUVBox.Location = new Point(85, 55);
            MaUVBox.Name = "MaUVBox";
            MaUVBox.PlaceholderText = "Mã ứng viên";
            MaUVBox.ReadOnly = true;
            MaUVBox.Size = new Size(150, 30);
            MaUVBox.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightSeaGreen;
            label7.Location = new Point(85, 100);
            label7.Name = "label7";
            label7.Size = new Size(147, 23);
            label7.TabIndex = 33;
            label7.Text = "Mã doanh nghiệp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(435, 100);
            label6.Name = "label6";
            label6.Size = new Size(67, 23);
            label6.TabIndex = 31;
            label6.Text = "Ưu tiên";
            // 
            // UuTienUpDown
            // 
            UuTienUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UuTienUpDown.Location = new Point(435, 126);
            UuTienUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            UuTienUpDown.Name = "UuTienUpDown";
            UuTienUpDown.Size = new Size(50, 30);
            UuTienUpDown.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(85, 169);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 27;
            label2.Text = "Ghi chú";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(259, 100);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 29;
            label4.Text = "Mã phiếu";
            // 
            // GhiChuBox
            // 
            GhiChuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GhiChuBox.Location = new Point(85, 195);
            GhiChuBox.Name = "GhiChuBox";
            GhiChuBox.PlaceholderText = "Ghi chú";
            GhiChuBox.Size = new Size(400, 30);
            GhiChuBox.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(259, 29);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 24;
            label5.Text = "Tình trạng";
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(570, 183);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(175, 40);
            HuyButton.TabIndex = 14;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // TinhTrangCbo
            // 
            TinhTrangCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TinhTrangCbo.FormattingEnabled = true;
            TinhTrangCbo.Items.AddRange(new object[] { "Chưa đủ điều kiện", "Đủ điều kiện", "Đã xử lý", "Đã đạt" });
            TinhTrangCbo.Location = new Point(259, 55);
            TinhTrangCbo.Name = "TinhTrangCbo";
            TinhTrangCbo.Size = new Size(226, 31);
            TinhTrangCbo.TabIndex = 23;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(570, 113);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(175, 40);
            LamMoiButton.TabIndex = 13;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(85, 29);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 21;
            label3.Text = "Mã ứng viên";
            // 
            // DuyetButton
            // 
            DuyetButton.BackColor = Color.LightSeaGreen;
            DuyetButton.FlatAppearance.BorderSize = 0;
            DuyetButton.FlatStyle = FlatStyle.Flat;
            DuyetButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DuyetButton.ForeColor = Color.White;
            DuyetButton.Location = new Point(570, 43);
            DuyetButton.Name = "DuyetButton";
            DuyetButton.Size = new Size(175, 40);
            DuyetButton.TabIndex = 12;
            DuyetButton.Text = "Duyệt";
            DuyetButton.UseVisualStyleBackColor = false;
            DuyetButton.Click += DuyetButton_Click;
            // 
            // HoSoData
            // 
            HoSoData.AllowUserToAddRows = false;
            HoSoData.AllowUserToDeleteRows = false;
            HoSoData.AllowUserToResizeColumns = false;
            HoSoData.AllowUserToResizeRows = false;
            HoSoData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HoSoData.BorderStyle = BorderStyle.None;
            HoSoData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HoSoData.Dock = DockStyle.Bottom;
            HoSoData.Location = new Point(0, 303);
            HoSoData.Name = "HoSoData";
            HoSoData.ReadOnly = true;
            HoSoData.RowHeadersVisible = false;
            HoSoData.RowHeadersWidth = 51;
            HoSoData.Size = new Size(882, 350);
            HoSoData.TabIndex = 0;
            HoSoData.CellClick += HoSoData_CellClick;
            // 
            // DuyetHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DuyetHoSo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Duyệt hồ sơ";
            Load += DuyetHoSo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UuTienUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)HoSoData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView HoSoData;
        private Panel panel2;
        private Label label1;
        private Button HuyButton;
        private Button LamMoiButton;
        private Button DuyetButton;
        private Label label5;
        private ComboBox TinhTrangCbo;
        private Label label3;
        private Label label7;
        private Label label6;
        private NumericUpDown UuTienUpDown;
        private Label label2;
        private Label label4;
        private TextBox GhiChuBox;
        private TextBox MaUVBox;
        private TextBox MaPhieuBox;
        private TextBox MaDNBox;
    }
}