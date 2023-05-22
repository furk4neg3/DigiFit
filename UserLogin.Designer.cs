namespace DigiFit {
    partial class UserLogin {
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
            txt_password = new TextBox();
            label3 = new Label();
            txt_username = new TextBox();
            checkBox1 = new CheckBox();
            btn_login = new Button();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Violet;
            label1.Location = new Point(73, 82);
            label1.Name = "label1";
            label1.Size = new Size(244, 34);
            label1.TabIndex = 0;
            label1.Text = "Keyifli Sporlar! ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(73, 217);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.White;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(73, 243);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(216, 20);
            txt_password.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(73, 147);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 1;
            label3.Text = "Kullanıcı Adı";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.White;
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(73, 173);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(216, 20);
            txt_username.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.ForeColor = Color.GhostWhite;
            checkBox1.Location = new Point(73, 293);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 27);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(116, 86, 174);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(73, 347);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(216, 35);
            btn_login.TabIndex = 4;
            btn_login.Text = "Giriş Yap";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(116, 86, 174);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(73, 399);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 4;
            button2.Text = "Ana Menüye Dön";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 41);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 5;
            label4.Text = "Öğrenci Girişi";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(314, -1);
            button3.Name = "button3";
            button3.Size = new Size(56, 65);
            button3.TabIndex = 6;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 10, 80);
            ClientSize = new Size(371, 518);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(btn_login);
            Controls.Add(checkBox1);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogin";
            Load += UserLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_password;
        private Label label3;
        private TextBox txt_username;
        private CheckBox checkBox1;
        private Button btn_login;
        private Button button2;
        private Label label4;
        private Button button3;
    }
}