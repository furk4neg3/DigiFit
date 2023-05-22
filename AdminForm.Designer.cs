namespace DigiFit {
    partial class AdminForm {
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
            txt_name = new TextBox();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_saveuser = new Button();
            btn_savetrai = new Button();
            btn_edituser = new Button();
            btn_edittrai = new Button();
            btn_showuser = new Button();
            btn_showtrai = new Button();
            dataGridView1 = new DataGridView();
            btn_deleteuser = new Button();
            btn_deletetrai = new Button();
            label4 = new Label();
            txt_UID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 205);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı İsmi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(12, 228);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(285, 27);
            txt_name.TabIndex = 3;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(12, 97);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(285, 27);
            txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(12, 164);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(285, 27);
            txt_password.TabIndex = 5;
            // 
            // btn_saveuser
            // 
            btn_saveuser.Location = new Point(12, 310);
            btn_saveuser.Name = "btn_saveuser";
            btn_saveuser.Size = new Size(142, 29);
            btn_saveuser.TabIndex = 6;
            btn_saveuser.Text = "Öğrenci Kaydet";
            btn_saveuser.UseVisualStyleBackColor = true;
            btn_saveuser.Click += btn_saveuser_Click;
            // 
            // btn_savetrai
            // 
            btn_savetrai.Location = new Point(12, 354);
            btn_savetrai.Name = "btn_savetrai";
            btn_savetrai.Size = new Size(142, 29);
            btn_savetrai.TabIndex = 7;
            btn_savetrai.Text = "Antrenör Kaydet";
            btn_savetrai.UseVisualStyleBackColor = true;
            btn_savetrai.Click += btn_savetrai_Click;
            // 
            // btn_edituser
            // 
            btn_edituser.Location = new Point(12, 397);
            btn_edituser.Name = "btn_edituser";
            btn_edituser.Size = new Size(142, 29);
            btn_edituser.TabIndex = 8;
            btn_edituser.Text = "Öğrenci Düzenle";
            btn_edituser.UseVisualStyleBackColor = true;
            btn_edituser.Click += btn_edituser_Click;
            // 
            // btn_edittrai
            // 
            btn_edittrai.Location = new Point(158, 310);
            btn_edittrai.Name = "btn_edittrai";
            btn_edittrai.Size = new Size(146, 29);
            btn_edittrai.TabIndex = 9;
            btn_edittrai.Text = "Antrenör Düzenle";
            btn_edittrai.UseVisualStyleBackColor = true;
            btn_edittrai.Click += btn_edittrai_Click;
            // 
            // btn_showuser
            // 
            btn_showuser.Location = new Point(12, 265);
            btn_showuser.Name = "btn_showuser";
            btn_showuser.Size = new Size(142, 29);
            btn_showuser.TabIndex = 10;
            btn_showuser.Text = "Öğrencileri Göster";
            btn_showuser.UseVisualStyleBackColor = true;
            btn_showuser.Click += btn_showuser_Click;
            // 
            // btn_showtrai
            // 
            btn_showtrai.Location = new Point(160, 265);
            btn_showtrai.Name = "btn_showtrai";
            btn_showtrai.Size = new Size(144, 29);
            btn_showtrai.TabIndex = 11;
            btn_showtrai.Text = "Antrenörleri Göster";
            btn_showtrai.UseVisualStyleBackColor = true;
            btn_showtrai.Click += btn_showtrai_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(338, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(450, 391);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btn_deleteuser
            // 
            btn_deleteuser.Location = new Point(158, 354);
            btn_deleteuser.Name = "btn_deleteuser";
            btn_deleteuser.Size = new Size(146, 29);
            btn_deleteuser.TabIndex = 13;
            btn_deleteuser.Text = "Öğrenci Sil";
            btn_deleteuser.UseVisualStyleBackColor = true;
            btn_deleteuser.Click += btn_deleteuser_Click;
            // 
            // btn_deletetrai
            // 
            btn_deletetrai.Location = new Point(158, 397);
            btn_deletetrai.Name = "btn_deletetrai";
            btn_deletetrai.Size = new Size(146, 29);
            btn_deletetrai.TabIndex = 14;
            btn_deletetrai.Text = "Antrenör Sil";
            btn_deletetrai.UseVisualStyleBackColor = true;
            btn_deletetrai.Click += btn_deletetrai_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 15;
            label4.Text = "Kullanıcı ID'si";
            // 
            // txt_UID
            // 
            txt_UID.Location = new Point(12, 35);
            txt_UID.Name = "txt_UID";
            txt_UID.Size = new Size(285, 27);
            txt_UID.TabIndex = 16;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_UID);
            Controls.Add(label4);
            Controls.Add(btn_deletetrai);
            Controls.Add(btn_deleteuser);
            Controls.Add(dataGridView1);
            Controls.Add(btn_showtrai);
            Controls.Add(btn_showuser);
            Controls.Add(btn_edittrai);
            Controls.Add(btn_edituser);
            Controls.Add(btn_savetrai);
            Controls.Add(btn_saveuser);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(txt_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_name;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_saveuser;
        private Button btn_savetrai;
        private Button btn_edituser;
        private Button btn_edittrai;
        private Button btn_showuser;
        private Button btn_showtrai;
        private DataGridView dataGridView1;
        private Button btn_deleteuser;
        private Button btn_deletetrai;
        private Label label4;
        private TextBox txt_UID;
    }
}