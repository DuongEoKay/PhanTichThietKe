namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class ThemChienLuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemChienLuoc));
            panel1 = new Panel();
            panel2 = new Panel();
            TenCLBox = new TextBox();
            HuyButton = new Button();
            ThemButton = new Button();
            label3 = new Label();
            label2 = new Label();
            MoTaBox = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 353);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(TenCLBox);
            panel2.Controls.Add(HuyButton);
            panel2.Controls.Add(ThemButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(MoTaBox);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 353);
            panel2.TabIndex = 1;
            // 
            // TenCLBox
            // 
            TenCLBox.CharacterCasing = CharacterCasing.Upper;
            TenCLBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenCLBox.Location = new Point(54, 112);
            TenCLBox.Name = "TenCLBox";
            TenCLBox.PlaceholderText = "Tên chiến lược";
            TenCLBox.Size = new Size(425, 30);
            TenCLBox.TabIndex = 12;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(54, 86);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 7;
            label3.Text = "Tên chiến lược";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(54, 170);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 5;
            label2.Text = "Mô tả";
            // 
            // MoTaBox
            // 
            MoTaBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MoTaBox.Location = new Point(54, 196);
            MoTaBox.Name = "MoTaBox";
            MoTaBox.PlaceholderText = "Mô tả";
            MoTaBox.Size = new Size(425, 30);
            MoTaBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(102, 20);
            label1.Name = "label1";
            label1.Size = new Size(328, 38);
            label1.TabIndex = 3;
            label1.Text = "Thêm chiến lược ưu đãi";
            // 
            // ThemChienLuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 353);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThemChienLuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm chiến lược ưu đãi";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button HuyButton;
        private Button ThemButton;
        private Label label3;
        private Label label2;
        private TextBox MoTaBox;
        private Label label1;
        private TextBox TenCLBox;
    }
}