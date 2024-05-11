namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class LapDSTiemNang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapDSTiemNang));
            panel1 = new Panel();
            LamMoiButton = new Button();
            LapDSButton = new Button();
            CanTrenUpDown = new NumericUpDown();
            CanDuoiUpDown = new NumericUpDown();
            DSTiemNangData = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CanTrenUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CanDuoiUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DSTiemNangData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(LamMoiButton);
            panel1.Controls.Add(LapDSButton);
            panel1.Controls.Add(CanTrenUpDown);
            panel1.Controls.Add(CanDuoiUpDown);
            panel1.Controls.Add(DSTiemNangData);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 653);
            panel1.TabIndex = 0;
            // 
            // LamMoiButton
            // 
            LamMoiButton.BackColor = Color.LightSeaGreen;
            LamMoiButton.FlatAppearance.BorderSize = 0;
            LamMoiButton.FlatStyle = FlatStyle.Flat;
            LamMoiButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LamMoiButton.ForeColor = Color.White;
            LamMoiButton.Location = new Point(143, 106);
            LamMoiButton.Name = "LamMoiButton";
            LamMoiButton.Size = new Size(125, 40);
            LamMoiButton.TabIndex = 15;
            LamMoiButton.Text = "Làm mới";
            LamMoiButton.UseVisualStyleBackColor = false;
            LamMoiButton.Click += LamMoiButton_Click;
            // 
            // LapDSButton
            // 
            LapDSButton.BackColor = Color.LightSeaGreen;
            LapDSButton.FlatAppearance.BorderSize = 0;
            LapDSButton.FlatStyle = FlatStyle.Flat;
            LapDSButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LapDSButton.ForeColor = Color.White;
            LapDSButton.Location = new Point(12, 107);
            LapDSButton.Name = "LapDSButton";
            LapDSButton.Size = new Size(125, 40);
            LapDSButton.TabIndex = 14;
            LapDSButton.Text = "Lập DS";
            LapDSButton.UseVisualStyleBackColor = false;
            LapDSButton.Click += LapDSButton_Click;
            // 
            // CanTrenUpDown
            // 
            CanTrenUpDown.DecimalPlaces = 2;
            CanTrenUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            CanTrenUpDown.Location = new Point(470, 64);
            CanTrenUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            CanTrenUpDown.Name = "CanTrenUpDown";
            CanTrenUpDown.Size = new Size(70, 27);
            CanTrenUpDown.TabIndex = 13;
            CanTrenUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // CanDuoiUpDown
            // 
            CanDuoiUpDown.DecimalPlaces = 2;
            CanDuoiUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            CanDuoiUpDown.Location = new Point(143, 64);
            CanDuoiUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            CanDuoiUpDown.Name = "CanDuoiUpDown";
            CanDuoiUpDown.Size = new Size(70, 27);
            CanDuoiUpDown.TabIndex = 12;
            // 
            // DSTiemNangData
            // 
            DSTiemNangData.AllowUserToAddRows = false;
            DSTiemNangData.AllowUserToDeleteRows = false;
            DSTiemNangData.AllowUserToResizeColumns = false;
            DSTiemNangData.AllowUserToResizeRows = false;
            DSTiemNangData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DSTiemNangData.BorderStyle = BorderStyle.None;
            DSTiemNangData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DSTiemNangData.Dock = DockStyle.Bottom;
            DSTiemNangData.Location = new Point(0, 153);
            DSTiemNangData.Name = "DSTiemNangData";
            DSTiemNangData.ReadOnly = true;
            DSTiemNangData.RowHeadersVisible = false;
            DSTiemNangData.RowHeadersWidth = 51;
            DSTiemNangData.Size = new Size(682, 500);
            DSTiemNangData.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(219, 62);
            label3.Name = "label3";
            label3.Size = new Size(245, 30);
            label3.TabIndex = 8;
            label3.Text = "<= AVG(TiemNang) <=";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(74, 10);
            label1.Name = "label1";
            label1.Size = new Size(534, 38);
            label1.TabIndex = 4;
            label1.Text = "Lập danh sách doanh nghiệp tiềm năng";
            // 
            // LapDSTiemNang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 653);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LapDSTiemNang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập danh sách tiềm năng";
            Load += LapDSTiemNang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CanTrenUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CanDuoiUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DSTiemNangData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private DataGridView DSTiemNangData;
        private NumericUpDown CanDuoiUpDown;
        private NumericUpDown CanTrenUpDown;
        private Button LapDSButton;
        private Button LamMoiButton;
    }
}