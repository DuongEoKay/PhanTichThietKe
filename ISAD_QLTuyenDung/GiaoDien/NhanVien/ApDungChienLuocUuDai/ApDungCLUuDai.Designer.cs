namespace ISAD_QLTuyenDung.GiaoDien.NhanVien.ApDungChienLuocUuDai
{
    partial class ApDungCLUuDai
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
            CLUuDaiData = new DataGridView();
            label2 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            NgayKTDate = new DateTimePicker();
            NgayBDDate = new DateTimePicker();
            label6 = new Label();
            TenCLBox = new TextBox();
            LamMoiButton = new Button();
            label4 = new Label();
            MaCLBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            MaDNBox = new TextBox();
            label5 = new Label();
            TenCtyBox = new TextBox();
            ThemADCLButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CLUuDaiData).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(CLUuDaiData);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 3;
            // 
            // CLUuDaiData
            // 
            CLUuDaiData.AllowUserToAddRows = false;
            CLUuDaiData.AllowUserToDeleteRows = false;
            CLUuDaiData.AllowUserToResizeColumns = false;
            CLUuDaiData.AllowUserToResizeRows = false;
            CLUuDaiData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CLUuDaiData.BorderStyle = BorderStyle.None;
            CLUuDaiData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CLUuDaiData.Dock = DockStyle.Bottom;
            CLUuDaiData.Location = new Point(0, 300);
            CLUuDaiData.Name = "CLUuDaiData";
            CLUuDaiData.ReadOnly = true;
            CLUuDaiData.RowHeadersVisible = false;
            CLUuDaiData.RowHeadersWidth = 51;
            CLUuDaiData.Size = new Size(900, 400);
            CLUuDaiData.TabIndex = 10;
            CLUuDaiData.CellClick += CLUuDaiData_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(349, 11);
            label2.Name = "label2";
            label2.Size = new Size(203, 31);
            label2.TabIndex = 9;
            label2.Text = "Chiến lược ưu đãi";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(NgayKTDate);
            panel3.Controls.Add(NgayBDDate);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(TenCLBox);
            panel3.Controls.Add(LamMoiButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(MaCLBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(MaDNBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(TenCtyBox);
            panel3.Controls.Add(ThemADCLButton);
            panel3.Location = new Point(12, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 266);
            panel3.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightSeaGreen;
            label9.Location = new Point(371, 174);
            label9.Name = "label9";
            label9.Size = new Size(119, 23);
            label9.TabIndex = 66;
            label9.Text = "Ngày kết thúc";
            // 
            // NgayKTDate
            // 
            NgayKTDate.CustomFormat = "dd/MM/yyyy";
            NgayKTDate.Enabled = false;
            NgayKTDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayKTDate.Format = DateTimePickerFormat.Custom;
            NgayKTDate.Location = new Point(371, 200);
            NgayKTDate.Name = "NgayKTDate";
            NgayKTDate.Size = new Size(200, 30);
            NgayKTDate.TabIndex = 65;
            // 
            // NgayBDDate
            // 
            NgayBDDate.CustomFormat = "dd/MM/yyyy";
            NgayBDDate.Enabled = false;
            NgayBDDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayBDDate.Format = DateTimePickerFormat.Custom;
            NgayBDDate.Location = new Point(121, 200);
            NgayBDDate.Name = "NgayBDDate";
            NgayBDDate.Size = new Size(200, 30);
            NgayBDDate.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSeaGreen;
            label6.Location = new Point(244, 104);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 25;
            label6.Text = "Tên chiến lược";
            // 
            // TenCLBox
            // 
            TenCLBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenCLBox.Location = new Point(244, 130);
            TenCLBox.Name = "TenCLBox";
            TenCLBox.PlaceholderText = "Tên chiến lược";
            TenCLBox.ReadOnly = true;
            TenCLBox.Size = new Size(327, 30);
            TenCLBox.TabIndex = 24;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(603, 190);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(150, 40);
            LamMoiButton.TabIndex = 23;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(121, 174);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 20;
            label4.Text = "Ngày bắt đầu";
            // 
            // MaCLBox
            // 
            MaCLBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaCLBox.Location = new Point(121, 130);
            MaCLBox.Name = "MaCLBox";
            MaCLBox.PlaceholderText = "Mã chiến lược";
            MaCLBox.ReadOnly = true;
            MaCLBox.Size = new Size(100, 30);
            MaCLBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(121, 104);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 17;
            label3.Text = "Mã chiến lược";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(121, 34);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 16;
            label1.Text = "Mã DN";
            // 
            // MaDNBox
            // 
            MaDNBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaDNBox.Location = new Point(121, 60);
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
            label5.Location = new Point(244, 34);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 14;
            label5.Text = "Tên công ty";
            // 
            // TenCtyBox
            // 
            TenCtyBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenCtyBox.Location = new Point(244, 60);
            TenCtyBox.Name = "TenCtyBox";
            TenCtyBox.PlaceholderText = "Tên công ty";
            TenCtyBox.ReadOnly = true;
            TenCtyBox.Size = new Size(509, 30);
            TenCtyBox.TabIndex = 13;
            // 
            // ThemADCLButton
            // 
            ThemADCLButton.BackColor = Color.LightSeaGreen;
            ThemADCLButton.FlatAppearance.BorderSize = 0;
            ThemADCLButton.FlatStyle = FlatStyle.Flat;
            ThemADCLButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemADCLButton.ForeColor = Color.White;
            ThemADCLButton.Location = new Point(603, 130);
            ThemADCLButton.Name = "ThemADCLButton";
            ThemADCLButton.Size = new Size(150, 40);
            ThemADCLButton.TabIndex = 6;
            ThemADCLButton.Text = "Thêm áp dụng";
            ThemADCLButton.UseVisualStyleBackColor = false;
            ThemADCLButton.Click += ThemADCLButton_Click;
            // 
            // ApDungCLUuDai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApDungCLUuDai";
            Text = "ApDungCLUuDai";
            Load += ApDungCLUuDai_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CLUuDaiData).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView CLUuDaiData;
        private Panel panel3;
        private Label label9;
        private DateTimePicker NgayKTDate;
        private DateTimePicker NgayBDDate;
        private Label label6;
        private TextBox TenCLBox;
        private Button LamMoiButton;
        private Label label4;
        private TextBox MaCLBox;
        private Label label3;
        private Label label1;
        private TextBox MaDNBox;
        private Label label5;
        private TextBox TenCtyBox;
        private Button ThemADCLButton;
    }
}