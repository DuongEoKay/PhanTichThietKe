namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ApDungChienLuocUuDai
{
    partial class ApDungCL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApDungCL));
            panel1 = new Panel();
            HuyButton = new Button();
            ThemButton = new Button();
            label5 = new Label();
            label4 = new Label();
            NgayKTDate = new DateTimePicker();
            NgayBDDate = new DateTimePicker();
            label2 = new Label();
            MaCLCbo = new ComboBox();
            label3 = new Label();
            MaDNCbo = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(HuyButton);
            panel1.Controls.Add(ThemButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(NgayKTDate);
            panel1.Controls.Add(NgayBDDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(MaCLCbo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(MaDNCbo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 353);
            panel1.TabIndex = 0;
            // 
            // HuyButton
            // 
            HuyButton.BackColor = Color.LightSeaGreen;
            HuyButton.FlatAppearance.BorderSize = 0;
            HuyButton.FlatStyle = FlatStyle.Flat;
            HuyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HuyButton.ForeColor = Color.White;
            HuyButton.Location = new Point(266, 260);
            HuyButton.Name = "HuyButton";
            HuyButton.Size = new Size(150, 40);
            HuyButton.TabIndex = 76;
            HuyButton.Text = "Hủy";
            HuyButton.UseVisualStyleBackColor = false;
            HuyButton.Click += HuyButton_Click;
            // 
            // ThemButton
            // 
            ThemButton.BackColor = Color.LightSeaGreen;
            ThemButton.FlatAppearance.BorderSize = 0;
            ThemButton.FlatStyle = FlatStyle.Flat;
            ThemButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemButton.ForeColor = Color.White;
            ThemButton.Location = new Point(66, 260);
            ThemButton.Name = "ThemButton";
            ThemButton.Size = new Size(150, 40);
            ThemButton.TabIndex = 75;
            ThemButton.Text = "Thêm";
            ThemButton.UseVisualStyleBackColor = false;
            ThemButton.Click += ThemButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSeaGreen;
            label5.Location = new Point(266, 164);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 73;
            label5.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(66, 164);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 72;
            label4.Text = "Ngày bắt đầu";
            // 
            // NgayKTDate
            // 
            NgayKTDate.CustomFormat = "dd/MM/yyyy";
            NgayKTDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayKTDate.Format = DateTimePickerFormat.Custom;
            NgayKTDate.Location = new Point(266, 190);
            NgayKTDate.Name = "NgayKTDate";
            NgayKTDate.Size = new Size(150, 30);
            NgayKTDate.TabIndex = 71;
            // 
            // NgayBDDate
            // 
            NgayBDDate.CustomFormat = "dd/MM/yyyy";
            NgayBDDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayBDDate.Format = DateTimePickerFormat.Custom;
            NgayBDDate.Location = new Point(66, 190);
            NgayBDDate.Name = "NgayBDDate";
            NgayBDDate.Size = new Size(150, 30);
            NgayBDDate.TabIndex = 70;
            NgayBDDate.Value = new DateTime(2024, 4, 10, 22, 47, 30, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(266, 84);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 24;
            label2.Text = "Mã chiến lược";
            // 
            // MaCLCbo
            // 
            MaCLCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaCLCbo.FormattingEnabled = true;
            MaCLCbo.Location = new Point(266, 110);
            MaCLCbo.Name = "MaCLCbo";
            MaCLCbo.Size = new Size(150, 31);
            MaCLCbo.TabIndex = 23;
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
            label3.TabIndex = 22;
            label3.Text = "Mã doanh nghiệp";
            // 
            // MaDNCbo
            // 
            MaDNCbo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNCbo.FormattingEnabled = true;
            MaDNCbo.Location = new Point(66, 110);
            MaDNCbo.Name = "MaDNCbo";
            MaDNCbo.Size = new Size(150, 31);
            MaDNCbo.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(58, 20);
            label1.Name = "label1";
            label1.Size = new Size(367, 38);
            label1.TabIndex = 6;
            label1.Text = "Áp dụng chiến lược ưu đãi";
            // 
            // ApDungCL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ApDungCL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Áp dụng chiến lược";
            Load += ApDungCL_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox MaCLCbo;
        private Label label3;
        private ComboBox MaDNCbo;
        private DateTimePicker NgayKTDate;
        private DateTimePicker NgayBDDate;
        private Label label5;
        private Label label4;
        private Button HuyButton;
        private Button ThemButton;
    }
}