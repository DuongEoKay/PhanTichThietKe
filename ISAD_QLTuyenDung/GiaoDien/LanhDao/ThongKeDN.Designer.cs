namespace ISAD_QLTuyenDung.GiaoDien.LanhDao
{
    partial class ThongKeDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDN));
            panel1 = new Panel();
            DoanhNghiepData = new DataGridView();
            MaDNBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoanhNghiepData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(DoanhNghiepData);
            panel1.Controls.Add(MaDNBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 653);
            panel1.TabIndex = 0;
            // 
            // DoanhNghiepData
            // 
            DoanhNghiepData.AllowUserToAddRows = false;
            DoanhNghiepData.AllowUserToDeleteRows = false;
            DoanhNghiepData.AllowUserToResizeColumns = false;
            DoanhNghiepData.AllowUserToResizeRows = false;
            DoanhNghiepData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DoanhNghiepData.BorderStyle = BorderStyle.None;
            DoanhNghiepData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoanhNghiepData.Dock = DockStyle.Bottom;
            DoanhNghiepData.Location = new Point(0, 153);
            DoanhNghiepData.Name = "DoanhNghiepData";
            DoanhNghiepData.ReadOnly = true;
            DoanhNghiepData.RowHeadersVisible = false;
            DoanhNghiepData.RowHeadersWidth = 51;
            DoanhNghiepData.Size = new Size(682, 500);
            DoanhNghiepData.TabIndex = 11;
            // 
            // MaDNBox
            // 
            MaDNBox.Location = new Point(291, 100);
            MaDNBox.Name = "MaDNBox";
            MaDNBox.ReadOnly = true;
            MaDNBox.Size = new Size(100, 27);
            MaDNBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(291, 74);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 8;
            label3.Text = "Mã DN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(176, 19);
            label1.Name = "label1";
            label1.Size = new Size(330, 38);
            label1.TabIndex = 4;
            label1.Text = "Thống kê doanh nghiệp";
            // 
            // ThongKeDN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 653);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ThongKeDN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh nghiệp";
            Load += ThongKe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoanhNghiepData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox MaDNBox;
        private Label label3;
        private DataGridView DoanhNghiepData;
    }
}