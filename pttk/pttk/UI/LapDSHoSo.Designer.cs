namespace pttk.UI
{
    partial class LapDSHoSo
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
            DanhSachLapHS_dgv = new DataGridView();
            label3 = new Label();
            IDDoanhNghiep_tb = new TextBox();
            IDPhieuTTDT_tb = new TextBox();
            btnXuatFile = new Button();
            DoUuTien_tb = new TextBox();
            label2 = new Label();
            label7 = new Label();
            LapDSButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DanhSachLapHS_dgv).BeginInit();
            SuspendLayout();
            // 
            // DanhSachLapHS_dgv
            // 
            DanhSachLapHS_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DanhSachLapHS_dgv.Location = new Point(0, 312);
            DanhSachLapHS_dgv.Name = "DanhSachLapHS_dgv";
            DanhSachLapHS_dgv.RowHeadersWidth = 82;
            DanhSachLapHS_dgv.Size = new Size(1108, 900);
            DanhSachLapHS_dgv.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(430, 70);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 38);
            label3.TabIndex = 51;
            label3.Text = "Uu tien";
            // 
            // IDDoanhNghiep_tb
            // 
            IDDoanhNghiep_tb.AcceptsReturn = true;
            IDDoanhNghiep_tb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDDoanhNghiep_tb.Location = new Point(80, 111);
            IDDoanhNghiep_tb.Margin = new Padding(5);
            IDDoanhNghiep_tb.Name = "IDDoanhNghiep_tb";
            IDDoanhNghiep_tb.PlaceholderText = "Mã doanh nghiệp";
            IDDoanhNghiep_tb.Size = new Size(282, 44);
            IDDoanhNghiep_tb.TabIndex = 50;
            // 
            // IDPhieuTTDT_tb
            // 
            IDPhieuTTDT_tb.AcceptsReturn = true;
            IDPhieuTTDT_tb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDPhieuTTDT_tb.Location = new Point(80, 225);
            IDPhieuTTDT_tb.Margin = new Padding(5);
            IDPhieuTTDT_tb.Name = "IDPhieuTTDT_tb";
            IDPhieuTTDT_tb.PlaceholderText = "Mã phiếu";
            IDPhieuTTDT_tb.Size = new Size(282, 44);
            IDPhieuTTDT_tb.TabIndex = 49;
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.MidnightBlue;
            btnXuatFile.FlatAppearance.BorderSize = 0;
            btnXuatFile.FlatStyle = FlatStyle.Flat;
            btnXuatFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatFile.ForeColor = Color.White;
            btnXuatFile.Location = new Point(794, 205);
            btnXuatFile.Margin = new Padding(5);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(162, 64);
            btnXuatFile.TabIndex = 48;
            btnXuatFile.Text = "Xuat";
            btnXuatFile.UseVisualStyleBackColor = false;
            btnXuatFile.Click += btnXuatFile_Click;
            // 
            // DoUuTien_tb
            // 
            DoUuTien_tb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoUuTien_tb.Location = new Point(430, 113);
            DoUuTien_tb.Margin = new Padding(5);
            DoUuTien_tb.Name = "DoUuTien_tb";
            DoUuTien_tb.PlaceholderText = "Ghi chú";
            DoUuTien_tb.Size = new Size(282, 44);
            DoUuTien_tb.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(80, 185);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 38);
            label2.TabIndex = 46;
            label2.Text = "Mã phiếu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(80, 70);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(107, 38);
            label7.TabIndex = 45;
            label7.Text = "Mã DN";
            // 
            // LapDSButton
            // 
            LapDSButton.BackColor = Color.MidnightBlue;
            LapDSButton.FlatAppearance.BorderSize = 0;
            LapDSButton.FlatStyle = FlatStyle.Flat;
            LapDSButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapDSButton.ForeColor = Color.White;
            LapDSButton.Location = new Point(794, 102);
            LapDSButton.Margin = new Padding(5);
            LapDSButton.Name = "LapDSButton";
            LapDSButton.Size = new Size(162, 64);
            LapDSButton.TabIndex = 44;
            LapDSButton.Text = "Lập";
            LapDSButton.UseVisualStyleBackColor = false;
            LapDSButton.Click += LapDSButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(407, 5);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 50);
            label1.TabIndex = 43;
            label1.Text = "Lập danh sách";
            // 
            // LapDSHoSo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 1183);
            Controls.Add(DanhSachLapHS_dgv);
            Controls.Add(label3);
            Controls.Add(IDDoanhNghiep_tb);
            Controls.Add(IDPhieuTTDT_tb);
            Controls.Add(btnXuatFile);
            Controls.Add(DoUuTien_tb);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(LapDSButton);
            Controls.Add(label1);
            Name = "LapDSHoSo";
            Text = "LapDSHoSo";
            ((System.ComponentModel.ISupportInitialize)DanhSachLapHS_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DanhSachLapHS_dgv;
        private Label label3;
        private TextBox IDDoanhNghiep_tb;
        private TextBox IDPhieuTTDT_tb;
        private Button btnXuatFile;
        private TextBox DoUuTien_tb;
        private Label label2;
        private Label label7;
        private Button LapDSButton;
        private Label label1;
    }
}