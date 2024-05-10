namespace PTTK_UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            LoginButton = new Button();
            label3 = new Label();
            label2 = new Label();
            password = new TextBox();
            label1 = new Label();
            username = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(username);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 403);
            panel1.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.LightSeaGreen;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(66, 296);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(250, 45);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Đăng nhập";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(66, 200);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(66, 110);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 3;
            label2.Text = "Tên đăng nhập";
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(66, 226);
            password.Name = "password";
            password.Size = new Size(250, 30);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            password.KeyDown += Password_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(91, 45);
            label1.Name = "label1";
            label1.Size = new Size(200, 41);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // username
            // 
            username.CharacterCasing = CharacterCasing.Upper;
            username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(66, 136);
            username.Name = "username";
            username.Size = new Size(250, 30);
            username.TabIndex = 0;
            username.KeyDown += Username_KeyDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 403);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button LoginButton;
        private Label label3;
        private Label label2;
        private TextBox password;
        private Label label1;
        private TextBox username;
    }
}