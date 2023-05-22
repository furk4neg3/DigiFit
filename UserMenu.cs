using DigiFit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DigiFit {
    public partial class UserMenu : Form {
        private OleDbConnection connection = new OleDbConnection();
        UserLogin usLo;
        public UserMenu(UserLogin uLo) {
            InitializeComponent();
            txt_firstex.Hide();
            txt_secondex.Hide();
            txt_thirdex.Hide();
            txt_lastex.Hide();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Excalibur\Desktop\Databases\DigiFitDatabase.accdb;Persist Security Info=False;";
            this.usLo = uLo;//I got the username by that way, I can use it wherever I want by just typing usLo.userName
            panel3.Hide();
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + usLo.userName + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                lbl_target.Text = "Hedef: " + reader[4].ToString();
                lbl_kilo.Text = "Güncel Kilo: " + reader[5].ToString();
            }

            connection.Close();
        }

        private void btn_close_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e) {
            panel3.Height = btn_back.Height;
            panel3.Top = btn_back.Top;
            panel3.Show();


            labelkilo1.Text = "Kilo: ";
            labelkilo2.Text = "Kilo: ";
            labelkilo3.Text = "Kilo: ";
            labelkilo4.Text = "Kilo: ";
            txt_firstex.Show();
            txt_lastex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_firstex.Size = new System.Drawing.Size(125, 44);
            txt_firstex.Left = 671;
            txt_secondex.Size = new System.Drawing.Size(125, 44);
            txt_secondex.Left = 671;
            txt_thirdex.Size = new System.Drawing.Size(125, 44);
            txt_thirdex.Left = 671;
            txt_lastex.Size = new System.Drawing.Size(125, 44);
            txt_lastex.Left = 671;

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + usLo.userName + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                lbl_firstex.Text = reader[60].ToString();
                lbl_firstkilo.Text = reader[61].ToString();//9 10 12 13 15 16
                lbl_secondex.Text = reader[63].ToString();
                lbl_secondkilo.Text = reader[64].ToString();
                lbl_thirdex.Text = reader[66].ToString();
                lbl_thirdkilo.Text = reader[67].ToString();
                lbl_lastex.Text = reader[69].ToString();
                lbl_lastkilo.Text = reader[70].ToString();
                txt_firstex.Text = reader[62].ToString();
                txt_secondex.Text = reader[65].ToString();
                txt_thirdex.Text = reader[68].ToString();
                txt_lastex.Text = reader[71].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel3.Top == btn_back.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Sı1Kilo = '" + txt_firstex.Text + "', Sı2Kilo = '" + txt_secondex.Text + "', Sı3Kilo = '" + txt_thirdex.Text + "', Sı4Kilo = '" + txt_lastex.Text + "' where [Username] = '"+usLo.userName+"'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_bacak_Click(object sender, EventArgs e) {
            panel3.Height = btn_back.Height;
            panel3.Top = btn_bacak.Top;
            panel3.Show();
            labelkilo1.Text = "Kilo: ";
            labelkilo2.Text = "Kilo: ";
            labelkilo3.Text = "Kilo: ";
            labelkilo4.Text = "Kilo: ";
            txt_firstex.Show();
            txt_lastex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_firstex.Size = new System.Drawing.Size(125, 44);
            txt_firstex.Left = 671;
            txt_secondex.Size = new System.Drawing.Size(125, 44);
            txt_secondex.Left = 671;
            txt_thirdex.Size = new System.Drawing.Size(125, 44);
            txt_thirdex.Left = 671;
            txt_lastex.Size = new System.Drawing.Size(125, 44);
            txt_lastex.Left = 671;

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + usLo.userName + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                lbl_firstex.Text = reader[6].ToString();
                lbl_firstkilo.Text = reader[7].ToString();//9 10 12 13 15 16
                lbl_secondex.Text = reader[9].ToString();
                lbl_secondkilo.Text = reader[10].ToString();
                lbl_thirdex.Text = reader[12].ToString();
                lbl_thirdkilo.Text = reader[13].ToString();
                lbl_lastex.Text = reader[15].ToString();
                lbl_lastkilo.Text = reader[16].ToString();
                txt_firstex.Text = reader[8].ToString();
                txt_secondex.Text = reader[11].ToString();
                txt_thirdex.Text = reader[14].ToString();
                txt_lastex.Text = reader[17].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel3.Top == btn_bacak.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Ba1Kilo = '" + txt_firstex.Text + "', Ba2Kilo = '" + txt_secondex.Text + "', Ba3Kilo = '" + txt_thirdex.Text + "', Ba4Kilo = '" + txt_lastex.Text + "' where [Username] = '"+usLo.userName+"'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_biceps_Click(object sender, EventArgs e) {
            panel3.Height = btn_back.Height;
            panel3.Top = btn_biceps.Top;
            panel3.Show();

            labelkilo1.Text = "Kilo: ";
            labelkilo2.Text = "Kilo: ";
            labelkilo3.Text = "Kilo: ";
            labelkilo4.Text = "Kilo: ";
            txt_firstex.Show();
            txt_lastex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_firstex.Size = new System.Drawing.Size(125, 44);
            txt_firstex.Left = 671;
            txt_secondex.Size = new System.Drawing.Size(125, 44);
            txt_secondex.Left = 671;
            txt_thirdex.Size = new System.Drawing.Size(125, 44);
            txt_thirdex.Left = 671;
            txt_lastex.Size = new System.Drawing.Size(125, 44);
            txt_lastex.Left = 671;

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + usLo.userName + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                lbl_firstex.Text = reader[18].ToString();
                lbl_firstkilo.Text = reader[19].ToString();//9 10 12 13 15 16
                lbl_secondex.Text = reader[21].ToString();
                lbl_secondkilo.Text = reader[22].ToString();
                lbl_thirdex.Text = reader[24].ToString();
                lbl_thirdkilo.Text = reader[25].ToString();
                lbl_lastex.Text = reader[27].ToString();
                lbl_lastkilo.Text = reader[28].ToString();
                txt_firstex.Text = reader[20].ToString();
                txt_secondex.Text = reader[23].ToString();
                txt_thirdex.Text = reader[26].ToString();
                txt_lastex.Text = reader[29].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel3.Top == btn_biceps.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Bi1Kilo = '" + txt_firstex.Text + "', Bi2Kilo = '" + txt_secondex.Text + "', Bi3Kilo = '" + txt_thirdex.Text + "', Bi4Kilo = '" + txt_lastex.Text + "' where [Username] = '"+usLo.userName+"'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_chest_Click(object sender, EventArgs e) {
            panel3.Height = btn_back.Height;
            panel3.Top = btn_chest.Top;
            panel3.Show();

            labelkilo1.Text = "Kilo: ";
            labelkilo2.Text = "Kilo: ";
            labelkilo3.Text = "Kilo: ";
            labelkilo4.Text = "Kilo: ";
            txt_firstex.Show();
            txt_lastex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_firstex.Size = new System.Drawing.Size(125, 44);
            txt_firstex.Left = 671;
            txt_secondex.Size = new System.Drawing.Size(125, 44);
            txt_secondex.Left = 671;
            txt_thirdex.Size = new System.Drawing.Size(125, 44);
            txt_thirdex.Left = 671;
            txt_lastex.Size = new System.Drawing.Size(125, 44);
            txt_lastex.Left = 671;

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + usLo.userName + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                lbl_firstex.Text = reader[30].ToString();
                lbl_firstkilo.Text = reader[31].ToString();//9 10 12 13 15 16
                lbl_secondex.Text = reader[33].ToString();
                lbl_secondkilo.Text = reader[34].ToString();
                lbl_thirdex.Text = reader[36].ToString();
                lbl_thirdkilo.Text = reader[37].ToString();
                lbl_lastex.Text = reader[39].ToString();
                lbl_lastkilo.Text = reader[40].ToString();
                txt_firstex.Text = reader[32].ToString();
                txt_secondex.Text = reader[35].ToString();
                txt_thirdex.Text = reader[38].ToString();
                txt_lastex.Text = reader[41].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel3.Top == btn_chest.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Go1Kilo = '" + txt_firstex.Text + "', Go2Kilo = '" + txt_secondex.Text + "', Go3Kilo = '" + txt_thirdex.Text + "', Go4Kilo = '" + txt_lastex.Text + "' where [Username] = '"+usLo.userName+"'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_cardio_Click(object sender, EventArgs e) {
            panel3.Height = btn_back.Height;
            panel3.Top = btn_cardio.Top;
            panel3.Show();
            txt_secondex.Hide();
            txt_lastex.Hide();
            txt_firstex.Size = new System.Drawing.Size(125, 44);
            txt_firstex.Left = 671;
            txt_secondex.Size = new System.Drawing.Size(125, 44);
            txt_secondex.Left = 671;
            txt_thirdex.Size = new System.Drawing.Size(125, 44);
            txt_thirdex.Left = 671;
            txt_lastex.Size = new System.Drawing.Size(125, 44);
            txt_lastex.Left = 671;

            labelkilo1.Text = "Süre: ";
            labelkilo3.Text = "Süre: ";
            txt_firstex.Show();
            txt_thirdex.Show();
            labelkilo2.Text = " danışın.";
            labelkilo4.Text = "bırakın.";

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + usLo.userName + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                lbl_firstex.Text = reader[42].ToString();
                lbl_firstkilo.Text = reader[43].ToString();//9 10 12 13 15 16
                lbl_secondex.Text = "Öncelikle ";
                lbl_secondkilo.Text = "antrenörünüze";
                lbl_thirdex.Text = reader[45].ToString();
                lbl_thirdkilo.Text = reader[46].ToString();
                lbl_lastex.Text = "Kötü ";
                lbl_lastkilo.Text = "hissettiğinizde";
                txt_firstex.Text = reader[44].ToString();
                txt_thirdex.Text = reader[47].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel3.Top == btn_cardio.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Ka1Time = '" + txt_firstex.Text + "', Ka2Time = '" + txt_thirdex.Text + "' WHERE [Username]='"+usLo.userName+"'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_shoulder_Click(object sender, EventArgs e) {
            panel3.Height = btn_back.Height;
            panel3.Top = btn_shoulder.Top;
            panel3.Show();

            labelkilo1.Text = "Kilo: ";
            labelkilo2.Text = "Kilo: ";
            labelkilo3.Text = "Kilo: ";
            labelkilo4.Text = "Kilo: ";
            txt_firstex.Show();
            txt_lastex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_firstex.Size = new System.Drawing.Size(125, 44);
            txt_firstex.Left = 671;
            txt_secondex.Size = new System.Drawing.Size(125, 44);
            txt_secondex.Left = 671;
            txt_thirdex.Size = new System.Drawing.Size(125, 44);
            txt_thirdex.Left = 671;
            txt_lastex.Size = new System.Drawing.Size(125, 44);
            txt_lastex.Left = 671;

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + usLo.userName + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                lbl_firstex.Text = reader[48].ToString();
                lbl_firstkilo.Text = reader[49].ToString();//9 10 12 13 15 16
                lbl_secondex.Text = reader[51].ToString();
                lbl_secondkilo.Text = reader[52].ToString();
                lbl_thirdex.Text = reader[54].ToString();
                lbl_thirdkilo.Text = reader[55].ToString();
                lbl_lastex.Text = reader[57].ToString();
                lbl_lastkilo.Text = reader[58].ToString();
                txt_firstex.Text = reader[50].ToString();
                txt_secondex.Text = reader[53].ToString();
                txt_thirdex.Text = reader[56].ToString();
                txt_lastex.Text = reader[59].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel3.Top == btn_shoulder.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Om1Kilo = '" + txt_firstex.Text + "', Om2Kilo = '" + txt_secondex.Text + "', Om3Kilo = '" + txt_thirdex.Text + "', Om4Kilo = '" + txt_lastex.Text + "' where [Username] = '"+usLo.userName+"' ";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_triceps_Click(object sender, EventArgs e) {
            panel3.Height = btn_back.Height;
            panel3.Top = btn_triceps.Top;
            panel3.Show();

            labelkilo1.Text = "Kilo: ";
            labelkilo2.Text = "Kilo: ";
            labelkilo3.Text = "Kilo: ";
            labelkilo4.Text = "Kilo: ";
            txt_firstex.Show();
            txt_lastex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_firstex.Size = new System.Drawing.Size(125, 44);
            txt_firstex.Left = 671;
            txt_secondex.Size = new System.Drawing.Size(125, 44);
            txt_secondex.Left = 671;
            txt_thirdex.Size = new System.Drawing.Size(125, 44);
            txt_thirdex.Left = 671;
            txt_lastex.Size = new System.Drawing.Size(125, 44);
            txt_lastex.Left = 671;

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + usLo.userName + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                lbl_firstex.Text = reader[72].ToString();
                lbl_firstkilo.Text = reader[73].ToString();//9 10 12 13 15 16
                lbl_secondex.Text = reader[75].ToString();
                lbl_secondkilo.Text = reader[76].ToString();
                lbl_thirdex.Text = reader[78].ToString();
                lbl_thirdkilo.Text = reader[79].ToString();
                lbl_lastex.Text = reader[81].ToString();
                lbl_lastkilo.Text = reader[82].ToString();
                txt_firstex.Text = reader[74].ToString();
                txt_secondex.Text = reader[77].ToString();
                txt_thirdex.Text = reader[80].ToString();
                txt_lastex.Text = reader[83].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);


            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel3.Top == btn_triceps.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Tr1Kilo = '" + txt_firstex.Text + "', Tr2Kilo = '" + txt_secondex.Text + "', Tr3Kilo = '" + txt_thirdex.Text + "', Tr4Kilo = '" + txt_lastex.Text + "' where [Username] = '" + usLo.userName + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void btn_home_Click(object sender, EventArgs e) {
            panel3.Hide();
            panel3.Top = 0;
            txt_firstex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_lastex.Show();
            lbl_firstex.Text = "Güncel Kilo:";
            lbl_secondex.Text = "Hedef:";
            lbl_thirdex.Text = "Kullanıcı Adı:";
            lbl_lastex.Text = "Şifre:";
            lbl_firstkilo.Text = "";
            lbl_secondkilo.Text = "";
            lbl_thirdkilo.Text = "";
            lbl_lastkilo.Text = "";
            labelkilo1.Text = "";
            labelkilo2.Text = "";
            labelkilo3.Text = "";
            labelkilo4.Text = "";
            txt_firstex.Size = new System.Drawing.Size(300, 44);
            txt_firstex.Left = 300;
            txt_secondex.Size = new System.Drawing.Size(300, 44);
            txt_secondex.Left = 300;
            txt_thirdex.Size = new System.Drawing.Size(300, 44);
            txt_thirdex.Left = 300;
            txt_lastex.Size = new System.Drawing.Size(300, 44);
            txt_lastex.Left = 300;
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + usLo.userName + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                txt_firstex.Text = reader[5].ToString();
                txt_secondex.Text = reader[4].ToString();
                txt_thirdex.Text = reader[2].ToString();
                txt_lastex.Text = reader[3].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel3.Top == 0) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update [UserTable] set [CurrentKilo] = '" + txt_firstex.Text + "', [Target] = '" + txt_secondex.Text + "', [Username] = '" + txt_thirdex.Text + "', [Password] = '" + txt_lastex.Text + "' where [Username] = '"+usLo.userName+"'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }//try catch eklenecek kilo kısımlarına sayı dışında değer girilirse diye
    }
}
