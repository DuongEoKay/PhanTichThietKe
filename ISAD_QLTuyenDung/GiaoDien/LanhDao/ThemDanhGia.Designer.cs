namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class ThemDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemDanhGia));
            panel1 = new Panel();
            TiemNangUpDown = new NumericUpDown();
            HuyButton = new Button();
            ThemButton = new Button();
            label4 = new Label();
            label3 = new Label();
            TenDNCbo = new ComboBox();
            label2 = new Label();
            GhiChuBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TiemNangUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(TiemNangUpDown);
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(ThemButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TenDNCbo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(GhiChuBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 353);
            panel1.TabIndex = 0;
            // 
            // TiemNangUpDown
            // 
            TiemNangUpDown.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TiemNangUpDown.Location = new Point(404, 112);
            TiemNangUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            TiemNangUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TiemNangUpDown.Name = "TiemNangUpDown";
            TiemNangUpDown.Size = new Size(75, 30);
            TiemNangUpDown.TabIndex = 12;
            TiemNangUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(304, 260);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(175, 40);
            HuyButton.TabIndex = 11;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // ThemButton
            // 
            ThemButton.BackColor = Color.LightSeaGreen;
            ThemButton.FlatAppearance.BorderSize = 0;
            ThemButton.FlatStyle = FlatStyle.Flat;
            ThemButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemButton.ForeColor = Color.White;
            ThemButton.Location = new Point(54, 260);
            ThemButton.Name = "ThemButton";
            ThemButton.Size = new Size(175, 40);
            ThemButton.TabIndex = 10;
            ThemButton.Text = "Thêm";
            ThemButton.UseVisualStyleBackColor = false;
            ThemButton.Click += ThemButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(404, 86);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 9;
            label4.Text = "Tiềm năng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(54, 86);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 7;
            label3.Text = "Tên doanh nghiệp";
            // 
            // TenDNCbo
            // 
            TenDNCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenDNCbo.FormattingEnabled = true;
            TenDNCbo.Location = new Point(54, 112);
            TenDNCbo.Name = "TenDNCbo";
            TenDNCbo.Size = new Size(325, 31);
            TenDNCbo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(54, 170);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 5;
            label2.Text = "Ghi chú";
            // 
            // GhiChuBox
            // 
            GhiChuBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GhiChuBox.Location = new Point(54, 196);
            GhiChuBox.Name = "GhiChuBox";
            GhiChuBox.PlaceholderText = "Ghi chú";
            GhiChuBox.Size = new Size(425, 30);
            GhiChuBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(104, 20);
            label1.Name = "label1";
            label1.Size = new Size(325, 38);
            label1.TabIndex = 3;
            label1.Text = "Đánh giá doanh nghiệp";
            // 
            // ThemDanhGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 353);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemDanhGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm đánh giá doanh nghiệp";
            Load += ThemDanhGia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TiemNangUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox GhiChuBox;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private ComboBox TenDNCbo;
        private Button ThemButton;
        private Button HuyButton;
        private NumericUpDown TiemNangUpDown;
    }
}