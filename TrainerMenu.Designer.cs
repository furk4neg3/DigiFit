namespace DigiFit {
    partial class TrainerMenu {
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
            panel1 = new Panel();
            panel8 = new Panel();
            btn_triceps = new Button();
            btn_back = new Button();
            btn_shoulder = new Button();
            btn_cardio = new Button();
            btn_chest = new Button();
            btn_biceps = new Button();
            btn_bacak = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            lbl_close = new Label();
            lbl_name = new Label();
            panel4 = new Panel();
            lbl_uskilo1 = new Label();
            lbl_kilo1 = new Label();
            txt_firstset = new TextBox();
            txt_firstex = new TextBox();
            panel5 = new Panel();
            lbl_uskilo2 = new Label();
            lbl_kilo2 = new Label();
            txt_secondset = new TextBox();
            txt_secondex = new TextBox();
            panel6 = new Panel();
            lbl_uskilo3 = new Label();
            lbl_kilo3 = new Label();
            txt_thirdset = new TextBox();
            txt_thirdex = new TextBox();
            panel7 = new Panel();
            lbl_uskilo4 = new Label();
            lbl_kilo4 = new Label();
            txt_lastset = new TextBox();
            txt_lastex = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(btn_triceps);
            panel1.Controls.Add(btn_back);
            panel1.Controls.Add(btn_shoulder);
            panel1.Controls.Add(btn_cardio);
            panel1.Controls.Add(btn_chest);
            panel1.Controls.Add(btn_biceps);
            panel1.Controls.Add(btn_bacak);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 587);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(178, 8, 55);
            panel8.Location = new Point(1, 139);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 64);
            panel8.TabIndex = 0;
            // 
            // btn_triceps
            // 
            btn_triceps.Cursor = Cursors.Hand;
            btn_triceps.FlatAppearance.BorderSize = 0;
            btn_triceps.FlatStyle = FlatStyle.Flat;
            btn_triceps.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_triceps.ForeColor = Color.WhiteSmoke;
            btn_triceps.Location = new Point(12, 519);
            btn_triceps.Name = "btn_triceps";
            btn_triceps.Size = new Size(208, 64);
            btn_triceps.TabIndex = 7;
            btn_triceps.Text = "Triceps";
            btn_triceps.UseVisualStyleBackColor = true;
            btn_triceps.Click += btn_triceps_Click;
            // 
            // btn_back
            // 
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = Color.WhiteSmoke;
            btn_back.Location = new Point(12, 456);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(208, 64);
            btn_back.TabIndex = 6;
            btn_back.Text = "Sırt";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_shoulder
            // 
            btn_shoulder.Cursor = Cursors.Hand;
            btn_shoulder.FlatAppearance.BorderSize = 0;
            btn_shoulder.FlatStyle = FlatStyle.Flat;
            btn_shoulder.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_shoulder.ForeColor = Color.WhiteSmoke;
            btn_shoulder.Location = new Point(12, 393);
            btn_shoulder.Name = "btn_shoulder";
            btn_shoulder.Size = new Size(208, 64);
            btn_shoulder.TabIndex = 5;
            btn_shoulder.Text = "Omuz";
            btn_shoulder.UseVisualStyleBackColor = true;
            btn_shoulder.Click += btn_shoulder_Click;
            // 
            // btn_cardio
            // 
            btn_cardio.Cursor = Cursors.Hand;
            btn_cardio.FlatAppearance.BorderSize = 0;
            btn_cardio.FlatStyle = FlatStyle.Flat;
            btn_cardio.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cardio.ForeColor = Color.WhiteSmoke;
            btn_cardio.Location = new Point(12, 330);
            btn_cardio.Name = "btn_cardio";
            btn_cardio.Size = new Size(208, 64);
            btn_cardio.TabIndex = 4;
            btn_cardio.Text = "Kardiyo";
            btn_cardio.UseVisualStyleBackColor = true;
            btn_cardio.Click += btn_cardio_Click;
            // 
            // btn_chest
            // 
            btn_chest.Cursor = Cursors.Hand;
            btn_chest.FlatAppearance.BorderSize = 0;
            btn_chest.FlatStyle = FlatStyle.Flat;
            btn_chest.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_chest.ForeColor = Color.WhiteSmoke;
            btn_chest.Location = new Point(12, 267);
            btn_chest.Name = "btn_chest";
            btn_chest.Size = new Size(208, 64);
            btn_chest.TabIndex = 3;
            btn_chest.Text = "Göğüs";
            btn_chest.UseVisualStyleBackColor = true;
            btn_chest.Click += btn_chest_Click;
            // 
            // btn_biceps
            // 
            btn_biceps.Cursor = Cursors.Hand;
            btn_biceps.FlatAppearance.BorderSize = 0;
            btn_biceps.FlatStyle = FlatStyle.Flat;
            btn_biceps.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_biceps.ForeColor = Color.WhiteSmoke;
            btn_biceps.Location = new Point(12, 204);
            btn_biceps.Name = "btn_biceps";
            btn_biceps.Size = new Size(208, 64);
            btn_biceps.TabIndex = 2;
            btn_biceps.Text = "Biceps";
            btn_biceps.UseVisualStyleBackColor = true;
            btn_biceps.Click += btn_biceps_Click;
            // 
            // btn_bacak
            // 
            btn_bacak.Cursor = Cursors.Hand;
            btn_bacak.FlatAppearance.BorderSize = 0;
            btn_bacak.FlatStyle = FlatStyle.Flat;
            btn_bacak.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_bacak.ForeColor = Color.WhiteSmoke;
            btn_bacak.Location = new Point(12, 139);
            btn_bacak.Name = "btn_bacak";
            btn_bacak.Size = new Size(208, 64);
            btn_bacak.TabIndex = 1;
            btn_bacak.Text = "Bacak";
            btn_bacak.UseVisualStyleBackColor = true;
            btn_bacak.Click += btn_bacak_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 33, 34);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(178, 8, 55);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 140);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 140);
            label1.TabIndex = 0;
            label1.Text = "DigiFit";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Controls.Add(lbl_close);
            panel3.Controls.Add(lbl_name);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(220, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 75);
            panel3.TabIndex = 1;
            // 
            // lbl_close
            // 
            lbl_close.Cursor = Cursors.Hand;
            lbl_close.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_close.Location = new Point(788, 0);
            lbl_close.Name = "lbl_close";
            lbl_close.Size = new Size(62, 75);
            lbl_close.TabIndex = 0;
            lbl_close.Text = "X";
            lbl_close.TextAlign = ContentAlignment.MiddleCenter;
            lbl_close.Click += lbl_close_Click;
            // 
            // lbl_name
            // 
            lbl_name.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.ForeColor = Color.WhiteSmoke;
            lbl_name.Location = new Point(0, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(782, 75);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Burak Enes Portakal'ın Bilgileri";
            lbl_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 45, 45);
            panel4.Controls.Add(lbl_uskilo1);
            panel4.Controls.Add(lbl_kilo1);
            panel4.Controls.Add(txt_firstset);
            panel4.Controls.Add(txt_firstex);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(220, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(850, 128);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // lbl_uskilo1
            // 
            lbl_uskilo1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_uskilo1.ForeColor = Color.FromArgb(178, 8, 55);
            lbl_uskilo1.Location = new Point(641, 0);
            lbl_uskilo1.Name = "lbl_uskilo1";
            lbl_uskilo1.Size = new Size(159, 128);
            lbl_uskilo1.TabIndex = 4;
            lbl_uskilo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_kilo1
            // 
            lbl_kilo1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kilo1.ForeColor = Color.FromArgb(178, 8, 55);
            lbl_kilo1.Location = new Point(524, 0);
            lbl_kilo1.Name = "lbl_kilo1";
            lbl_kilo1.Size = new Size(159, 128);
            lbl_kilo1.TabIndex = 2;
            lbl_kilo1.Text = "Kilo:";
            lbl_kilo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_firstset
            // 
            txt_firstset.BackColor = Color.FromArgb(45, 45, 45);
            txt_firstset.BorderStyle = BorderStyle.FixedSingle;
            txt_firstset.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_firstset.ForeColor = Color.FromArgb(178, 8, 55);
            txt_firstset.Location = new Point(281, 0);
            txt_firstset.Multiline = true;
            txt_firstset.Name = "txt_firstset";
            txt_firstset.Size = new Size(222, 128);
            txt_firstset.TabIndex = 1;
            txt_firstset.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_firstex
            // 
            txt_firstex.BackColor = Color.FromArgb(45, 45, 45);
            txt_firstex.BorderStyle = BorderStyle.FixedSingle;
            txt_firstex.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_firstex.ForeColor = Color.FromArgb(178, 8, 55);
            txt_firstex.Location = new Point(0, 0);
            txt_firstex.Multiline = true;
            txt_firstex.Name = "txt_firstex";
            txt_firstex.Size = new Size(222, 128);
            txt_firstex.TabIndex = 0;
            txt_firstex.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 45, 45);
            panel5.Controls.Add(lbl_uskilo2);
            panel5.Controls.Add(lbl_kilo2);
            panel5.Controls.Add(txt_secondset);
            panel5.Controls.Add(txt_secondex);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(220, 203);
            panel5.Name = "panel5";
            panel5.Size = new Size(850, 128);
            panel5.TabIndex = 3;
            // 
            // lbl_uskilo2
            // 
            lbl_uskilo2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_uskilo2.ForeColor = Color.FromArgb(178, 8, 55);
            lbl_uskilo2.Location = new Point(641, 0);
            lbl_uskilo2.Name = "lbl_uskilo2";
            lbl_uskilo2.Size = new Size(159, 128);
            lbl_uskilo2.TabIndex = 5;
            lbl_uskilo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_kilo2
            // 
            lbl_kilo2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kilo2.ForeColor = Color.FromArgb(178, 8, 55);
            lbl_kilo2.Location = new Point(524, 0);
            lbl_kilo2.Name = "lbl_kilo2";
            lbl_kilo2.Size = new Size(159, 128);
            lbl_kilo2.TabIndex = 3;
            lbl_kilo2.Text = "Kilo:";
            lbl_kilo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_secondset
            // 
            txt_secondset.BackColor = Color.FromArgb(45, 45, 45);
            txt_secondset.BorderStyle = BorderStyle.FixedSingle;
            txt_secondset.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_secondset.ForeColor = Color.FromArgb(178, 8, 55);
            txt_secondset.Location = new Point(281, 0);
            txt_secondset.Multiline = true;
            txt_secondset.Name = "txt_secondset";
            txt_secondset.Size = new Size(222, 128);
            txt_secondset.TabIndex = 2;
            txt_secondset.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_secondex
            // 
            txt_secondex.BackColor = Color.FromArgb(45, 45, 45);
            txt_secondex.BorderStyle = BorderStyle.FixedSingle;
            txt_secondex.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_secondex.ForeColor = Color.FromArgb(178, 8, 55);
            txt_secondex.Location = new Point(0, 0);
            txt_secondex.Multiline = true;
            txt_secondex.Name = "txt_secondex";
            txt_secondex.Size = new Size(222, 128);
            txt_secondex.TabIndex = 1;
            txt_secondex.TextAlign = HorizontalAlignment.Center;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(45, 45, 45);
            panel6.Controls.Add(lbl_uskilo3);
            panel6.Controls.Add(lbl_kilo3);
            panel6.Controls.Add(txt_thirdset);
            panel6.Controls.Add(txt_thirdex);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(220, 331);
            panel6.Name = "panel6";
            panel6.Size = new Size(850, 128);
            panel6.TabIndex = 4;
            // 
            // lbl_uskilo3
            // 
            lbl_uskilo3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_uskilo3.ForeColor = Color.FromArgb(178, 8, 55);
            lbl_uskilo3.Location = new Point(641, 0);
            lbl_uskilo3.Name = "lbl_uskilo3";
            lbl_uskilo3.Size = new Size(159, 128);
            lbl_uskilo3.TabIndex = 6;
            lbl_uskilo3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_kilo3
            // 
            lbl_kilo3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kilo3.ForeColor = Color.FromArgb(178, 8, 55);
            lbl_kilo3.Location = new Point(524, 0);
            lbl_kilo3.Name = "lbl_kilo3";
            lbl_kilo3.Size = new Size(159, 128);
            lbl_kilo3.TabIndex = 3;
            lbl_kilo3.Text = "Kilo:";
            lbl_kilo3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_thirdset
            // 
            txt_thirdset.BackColor = Color.FromArgb(45, 45, 45);
            txt_thirdset.BorderStyle = BorderStyle.FixedSingle;
            txt_thirdset.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_thirdset.ForeColor = Color.FromArgb(178, 8, 55);
            txt_thirdset.Location = new Point(281, 0);
            txt_thirdset.Multiline = true;
            txt_thirdset.Name = "txt_thirdset";
            txt_thirdset.Size = new Size(222, 128);
            txt_thirdset.TabIndex = 2;
            txt_thirdset.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_thirdex
            // 
            txt_thirdex.BackColor = Color.FromArgb(45, 45, 45);
            txt_thirdex.BorderStyle = BorderStyle.FixedSingle;
            txt_thirdex.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_thirdex.ForeColor = Color.FromArgb(178, 8, 55);
            txt_thirdex.Location = new Point(0, 0);
            txt_thirdex.Multiline = true;
            txt_thirdex.Name = "txt_thirdex";
            txt_thirdex.Size = new Size(222, 128);
            txt_thirdex.TabIndex = 1;
            txt_thirdex.TextAlign = HorizontalAlignment.Center;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(45, 45, 45);
            panel7.Controls.Add(lbl_uskilo4);
            panel7.Controls.Add(lbl_kilo4);
            panel7.Controls.Add(txt_lastset);
            panel7.Controls.Add(txt_lastex);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(220, 459);
            panel7.Name = "panel7";
            panel7.Size = new Size(850, 128);
            panel7.TabIndex = 5;
            // 
            // lbl_uskilo4
            // 
            lbl_uskilo4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_uskilo4.ForeColor = Color.FromArgb(178, 8, 55);
            lbl_uskilo4.Location = new Point(641, 0);
            lbl_uskilo4.Name = "lbl_uskilo4";
            lbl_uskilo4.Size = new Size(159, 128);
            lbl_uskilo4.TabIndex = 7;
            lbl_uskilo4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_kilo4
            // 
            lbl_kilo4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kilo4.ForeColor = Color.FromArgb(178, 8, 55);
            lbl_kilo4.Location = new Point(524, 0);
            lbl_kilo4.Name = "lbl_kilo4";
            lbl_kilo4.Size = new Size(159, 128);
            lbl_kilo4.TabIndex = 4;
            lbl_kilo4.Text = "Kilo:";
            lbl_kilo4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_lastset
            // 
            txt_lastset.BackColor = Color.FromArgb(45, 45, 45);
            txt_lastset.BorderStyle = BorderStyle.FixedSingle;
            txt_lastset.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_lastset.ForeColor = Color.FromArgb(178, 8, 55);
            txt_lastset.Location = new Point(281, 0);
            txt_lastset.Multiline = true;
            txt_lastset.Name = "txt_lastset";
            txt_lastset.Size = new Size(222, 128);
            txt_lastset.TabIndex = 4;
            txt_lastset.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_lastex
            // 
            txt_lastex.BackColor = Color.FromArgb(45, 45, 45);
            txt_lastex.BorderStyle = BorderStyle.FixedSingle;
            txt_lastex.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txt_lastex.ForeColor = Color.FromArgb(178, 8, 55);
            txt_lastex.Location = new Point(0, 0);
            txt_lastex.Multiline = true;
            txt_lastex.Name = "txt_lastex";
            txt_lastex.Size = new Size(222, 128);
            txt_lastex.TabIndex = 3;
            txt_lastex.TextAlign = HorizontalAlignment.Center;
            // 
            // TrainerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 587);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrainerMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrainerMenu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_bacak;
        private Button btn_back;
        private Button btn_shoulder;
        private Button btn_cardio;
        private Button btn_chest;
        private Button btn_biceps;
        private Button btn_triceps;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label1;
        private Label lbl_close;
        private Label lbl_name;
        private TextBox txt_firstex;
        private TextBox txt_firstset;
        private TextBox txt_secondset;
        private TextBox txt_secondex;
        private TextBox txt_thirdset;
        private TextBox txt_thirdex;
        private TextBox txt_lastset;
        private TextBox txt_lastex;
        private Label lbl_uskilo1;
        private Label lbl_kilo1;
        private Label lbl_uskilo2;
        private Label lbl_kilo2;
        private Label lbl_uskilo3;
        private Label lbl_kilo3;
        private Label lbl_uskilo4;
        private Label lbl_kilo4;
    }
}