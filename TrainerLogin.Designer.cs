namespace DigiFit {
    partial class TrainerLogin {
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
            label3 = new Label();
            txt_username = new TextBox();
            label4 = new Label();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_goback = new Button();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            txt_getuser = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(164, 165, 169);
            label1.Location = new Point(120, 49);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 0;
            label1.Text = "Antrenör Girişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(102, 90);
            label2.Name = "label2";
            label2.Size = new Size(167, 34);
            label2.TabIndex = 1;
            label2.Text = "İyi Günler!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(52, 153);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı Adı";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(52, 179);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(273, 27);
            txt_username.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(52, 234);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 4;
            label4.Text = "Şifre";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(52, 260);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(273, 27);
            txt_password.TabIndex = 5;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(0, 0, 170);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(102, 460);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(177, 33);
            btn_login.TabIndex = 6;
            btn_login.Text = "Giriş Yap";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_goback
            // 
            btn_goback.BackColor = Color.FromArgb(0, 0, 170);
            btn_goback.Cursor = Cursors.Hand;
            btn_goback.FlatAppearance.BorderSize = 0;
            btn_goback.FlatStyle = FlatStyle.Flat;
            btn_goback.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_goback.ForeColor = Color.White;
            btn_goback.Location = new Point(102, 515);
            btn_goback.Name = "btn_goback";
            btn_goback.Size = new Size(177, 33);
            btn_goback.TabIndex = 7;
            btn_goback.Text = "Ana Menüye Dön";
            btn_goback.UseVisualStyleBackColor = false;
            btn_goback.Click += btn_goback_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.GhostWhite;
            checkBox1.Location = new Point(52, 404);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 27);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(313, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 51);
            label5.TabIndex = 9;
            label5.Text = "X";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(52, 312);
            label6.Name = "label6";
            label6.Size = new Size(209, 23);
            label6.TabIndex = 10;
            label6.Text = "Görüntülenecek Kullanıcı";
            // 
            // txt_getuser
            // 
            txt_getuser.Location = new Point(52, 338);
            txt_getuser.Name = "txt_getuser";
            txt_getuser.Size = new Size(273, 27);
            txt_getuser.TabIndex = 11;
            // 
            // TrainerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(371, 573);
            Controls.Add(txt_getuser);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(btn_goback);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(label4);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrainerLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrainerLogin";
            Load += TrainerLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private Label label4;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_goback;
        private CheckBox checkBox1;
        private Label label5;
        private Label label6;
        private TextBox txt_getuser;
    }
}