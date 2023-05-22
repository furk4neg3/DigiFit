namespace DigiFit {
    partial class AdminLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            txt_username = new Label();
            username_txt = new TextBox();
            label3 = new Label();
            txt_password = new TextBox();
            checkBox1 = new CheckBox();
            btn_login = new Button();
            btn_goback = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(164, 165, 169);
            label1.Location = new Point(131, 60);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "Admin Girişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGreen;
            label2.Location = new Point(95, 89);
            label2.Name = "label2";
            label2.Size = new Size(193, 34);
            label2.TabIndex = 1;
            label2.Text = "Hoşgeldiniz!";
            // 
            // txt_username
            // 
            txt_username.AutoSize = true;
            txt_username.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txt_username.ForeColor = Color.Gainsboro;
            txt_username.Location = new Point(48, 158);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(111, 23);
            txt_username.TabIndex = 2;
            txt_username.Text = "Kullanıcı Adı";
            // 
            // username_txt
            // 
            username_txt.Location = new Point(48, 184);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(268, 27);
            username_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(48, 237);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 4;
            label3.Text = "Şifre";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(48, 265);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(268, 27);
            txt_password.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.GhostWhite;
            checkBox1.Location = new Point(48, 319);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 27);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(0, 120, 0);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(95, 381);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(193, 32);
            btn_login.TabIndex = 7;
            btn_login.Text = "Giriş Yap";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_goback
            // 
            btn_goback.BackColor = Color.FromArgb(0, 120, 0);
            btn_goback.Cursor = Cursors.Hand;
            btn_goback.FlatAppearance.BorderSize = 0;
            btn_goback.FlatStyle = FlatStyle.Flat;
            btn_goback.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_goback.ForeColor = Color.White;
            btn_goback.Location = new Point(95, 434);
            btn_goback.Name = "btn_goback";
            btn_goback.Size = new Size(193, 32);
            btn_goback.TabIndex = 8;
            btn_goback.Text = "Ana Menüye Dön";
            btn_goback.UseVisualStyleBackColor = false;
            btn_goback.Click += btn_goback_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(307, 2);
            label4.Name = "label4";
            label4.Size = new Size(62, 48);
            label4.TabIndex = 9;
            label4.Text = "X";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 80, 0);
            ClientSize = new Size(371, 518);
            Controls.Add(label4);
            Controls.Add(btn_goback);
            Controls.Add(btn_login);
            Controls.Add(checkBox1);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(username_txt);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label txt_username;
        private TextBox username_txt;
        private Label label3;
        private TextBox txt_password;
        private CheckBox checkBox1;
        private Button btn_login;
        private Button btn_goback;
        private Label label4;
    }
}