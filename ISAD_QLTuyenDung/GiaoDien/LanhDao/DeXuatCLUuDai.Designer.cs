namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class DeXuatCLUuDai
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
            FormTitleLabel = new Label();
            panel3 = new Panel();
            MaCLLabel = new Label();
            MaCLBox = new TextBox();
            TenLDLabel = new Label();
            TenCLLabel = new Label();
            TenLDBox = new TextBox();
            LamMoiButton = new Button();
            ThemCLButton = new Button();
            TenCLBox = new TextBox();
            MoTaLabel = new Label();
            MoTaBox = new TextBox();
            ChienLuocData = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChienLuocData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(FormTitleLabel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(ChienLuocData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 1;
            // 
            // FormTitleLabel
            // 
            FormTitleLabel.AutoSize = true;
            FormTitleLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormTitleLabel.ForeColor = Color.LightSeaGreen;
            FormTitleLabel.Location = new Point(323, 11);
            FormTitleLabel.Name = "FormTitleLabel";
            FormTitleLabel.Size = new Size(254, 31);
            FormTitleLabel.TabIndex = 7;
            FormTitleLabel.Text = "Xem chiến lược ưu đãi";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(MaCLLabel);
            panel3.Controls.Add(MaCLBox);
            panel3.Controls.Add(TenLDLabel);
            panel3.Controls.Add(TenCLLabel);
            panel3.Controls.Add(TenLDBox);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(ThemCLButton);
            panel3.Controls.Add(TenCLBox);
            panel3.Controls.Add(MoTaLabel);
            panel3.Controls.Add(MoTaBox);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 6;
            // 
            // MaCLLabel
            // 
            MaCLLabel.AutoSize = true;
            MaCLLabel.BackColor = Color.Transparent;
            MaCLLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaCLLabel.ForeColor = Color.LightSeaGreen;
            MaCLLabel.Location = new Point(54, 44);
            MaCLLabel.Name = "MaCLLabel";
            MaCLLabel.Size = new Size(119, 23);
            MaCLLabel.TabIndex = 22;
            MaCLLabel.Text = "Mã chiến lược";
            // 
            // MaCLBox
            // 
            MaCLBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaCLBox.Location = new Point(54, 70);
            MaCLBox.Name = "MaCLBox";
            MaCLBox.PlaceholderText = "Mã chiến lược";
            MaCLBox.ReadOnly = true;
            MaCLBox.Size = new Size(119, 30);
            MaCLBox.TabIndex = 21;
            // 
            // TenLDLabel
            // 
            TenLDLabel.AutoSize = true;
            TenLDLabel.BackColor = Color.Transparent;
            TenLDLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenLDLabel.ForeColor = Color.LightSeaGreen;
            TenLDLabel.Location = new Point(546, 44);
            TenLDLabel.Name = "TenLDLabel";
            TenLDLabel.Size = new Size(171, 23);
            TenLDLabel.TabIndex = 20;
            TenLDLabel.Text = "Tên lãnh đạo đề xuất";
            // 
            // TenCLLabel
            // 
            TenCLLabel.AutoSize = true;
            TenCLLabel.BackColor = Color.Transparent;
            TenCLLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenCLLabel.ForeColor = Color.LightSeaGreen;
            TenCLLabel.Location = new Point(202, 44);
            TenCLLabel.Name = "TenCLLabel";
            TenCLLabel.Size = new Size(120, 23);
            TenCLLabel.TabIndex = 19;
            TenCLLabel.Text = "Tên chiến lược";
            // 
            // TenLDBox
            // 
            TenLDBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenLDBox.Location = new Point(546, 70);
            TenLDBox.Name = "TenLDBox";
            TenLDBox.PlaceholderText = "Tên lãnh đạo đề xuất";
            TenLDBox.ReadOnly = true;
            TenLDBox.Size = new Size(275, 30);
            TenLDBox.TabIndex = 17;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(621, 170);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(200, 40);
            LamMoiButton.TabIndex = 5;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // ThemCLButton
            // 
            ThemCLButton.BackColor = Color.LightSeaGreen;
            ThemCLButton.FlatAppearance.BorderSize = 0;
            ThemCLButton.FlatStyle = FlatStyle.Flat;
            ThemCLButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemCLButton.ForeColor = Color.White;
            ThemCLButton.Location = new Point(621, 124);
            ThemCLButton.Name = "ThemCLButton";
            ThemCLButton.Size = new Size(200, 40);
            ThemCLButton.TabIndex = 5;
            ThemCLButton.Text = "Thêm chiến lược";
            ThemCLButton.UseVisualStyleBackColor = false;
            ThemCLButton.Click += ThemChienLuocButton_Click;
            // 
            // TenCLBox
            // 
            TenCLBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenCLBox.Location = new Point(202, 70);
            TenCLBox.Name = "TenCLBox";
            TenCLBox.PlaceholderText = "Tên chiến lược";
            TenCLBox.ReadOnly = true;
            TenCLBox.Size = new Size(302, 30);
            TenCLBox.TabIndex = 15;
            // 
            // MoTaLabel
            // 
            MoTaLabel.AutoSize = true;
            MoTaLabel.BackColor = Color.Transparent;
            MoTaLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoTaLabel.ForeColor = Color.LightSeaGreen;
            MoTaLabel.Location = new Point(54, 150);
            MoTaLabel.Name = "MoTaLabel";
            MoTaLabel.Size = new Size(56, 23);
            MoTaLabel.TabIndex = 14;
            MoTaLabel.Text = "Mô tả";
            // 
            // MoTaBox
            // 
            MoTaBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MoTaBox.Location = new Point(54, 180);
            MoTaBox.Name = "MoTaBox";
            MoTaBox.PlaceholderText = "Mô tả";
            MoTaBox.ReadOnly = true;
            MoTaBox.Size = new Size(500, 30);
            MoTaBox.TabIndex = 13;
            // 
            // ChienLuocData
            // 
            ChienLuocData.AllowUserToAddRows = false;
            ChienLuocData.AllowUserToDeleteRows = false;
            ChienLuocData.AllowUserToResizeColumns = false;
            ChienLuocData.AllowUserToResizeRows = false;
            ChienLuocData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ChienLuocData.BorderStyle = BorderStyle.None;
            ChienLuocData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ChienLuocData.Dock = DockStyle.Bottom;
            ChienLuocData.Location = new Point(0, 300);
            ChienLuocData.Name = "ChienLuocData";
            ChienLuocData.ReadOnly = true;
            ChienLuocData.RowHeadersVisible = false;
            ChienLuocData.RowHeadersWidth = 51;
            ChienLuocData.Size = new Size(900, 400);
            ChienLuocData.TabIndex = 0;
            ChienLuocData.CellClick += ChienLuocData_CellClick;
            // 
            // DeXuatCLUuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeXuatCLUuDai";
            Text = "QuanLyUuDai";
            Load += DeXuatCLUuDai_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ChienLuocData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ThemCLButton;
        private DataGridView ChienLuocData;
        private Panel panel3;
        private Button LamMoiButton;
        private Label FormTitleLabel;
        private Label MoTaLabel;
        private TextBox MoTaBox;
        private TextBox TenCLBox;
        private TextBox TenLDBox;
        private Label TenLDLabel;
        private Label TenCLLabel;
        private Label MaCLLabel;
        private TextBox MaCLBox;
    }
}