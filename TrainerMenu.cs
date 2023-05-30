using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiFit {

    //Antrenörün giriş yaptıktan sonra göreceği menü
    public partial class TrainerMenu : Form {
        //MS Access'e bağlanmak için OleDbConnection objesi oluşturulur
        private OleDbConnection connection = new OleDbConnection();
        //Girişte istenen kullanıcı adı bilgisine erişmek için trainer login sınıfından obje oluşturulur
        TrainerLogin trLo;
        public TrainerMenu(TrainerLogin tLo) {
            InitializeComponent();
            //Gerekli görsel dokunuşlar yapılır
            txt_firstex.Hide();
            txt_lastex.Hide();
            txt_secondex.Hide();
            txt_thirdex.Hide();
            txt_firstset.Hide();
            txt_lastset.Hide();
            txt_secondset.Hide();
            txt_thirdset.Hide();
            lbl_kilo1.Hide();
            lbl_kilo2.Hide();
            lbl_kilo3.Hide();
            lbl_kilo4.Hide();
            panel8.Hide();
            //İlgili veritabanına bağlantı sağlanır
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Excalibur\Desktop\Databases\DigiFitDatabase.accdb;Persist Security Info=False;";
            //Oluşturulan obje parametre olarak alınan objeye eşitlenir
            trLo = tLo;
            //Veritabanına bağlantı sağlanır
            connection.Open();
            //Hangi öğrencinin bilgilerinin görüntülendiği, kullanıcının güncel kilosu ve hedefi yazdırılır.
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + trLo.userNAme + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                lbl_name.Text = reader[1].ToString() + "'in Bilgileri";
                label2.Text = "Kilo: " + reader[5].ToString();
                label3.Text = "Hedef: " + reader[4].ToString();
            }

            //Bağlantı sonlandırılır
            connection.Close();

            this.trLo = tLo;
        }

        //Bacak antrenmanlarını görüntülemek için kullanılacak kod
        private void btn_bacak_Click(object sender, EventArgs e) {
            //Gerekli görsel düzenlemeler yapılır
            panel8.Height = btn_bacak.Height;
            panel8.Top = btn_bacak.Top;
            panel8.Show();

            lbl_kilo1.Text = "Kilo:";
            lbl_kilo3.Text = "Kilo:";
            lbl_kilo1.Show();
            lbl_kilo2.Show();
            lbl_kilo3.Show();
            lbl_kilo4.Show();
            txt_firstex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_lastex.Show();
            txt_firstset.Show();
            txt_secondset.Show();
            txt_thirdset.Show();
            txt_lastset.Show();

            connection.Open();
            OleDbDataReader reader = null;
            //Login formundan alınan kullanıcı adına sahip kişinin antrenmanları, set bilgileri ve bunu hangi kilolarla yaptığı yazdırılır
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + trLo.userNAme + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                txt_firstex.Text = reader[6].ToString();
                txt_firstset.Text = reader[7].ToString();
                txt_secondex.Text = reader[9].ToString();
                txt_secondset.Text = reader[10].ToString();
                txt_thirdex.Text = reader[12].ToString();
                txt_thirdset.Text = reader[13].ToString();
                txt_lastex.Text = reader[15].ToString();
                txt_lastset.Text = reader[16].ToString();
                lbl_uskilo1.Text = reader[8].ToString();
                lbl_uskilo2.Text = reader[11].ToString();
                lbl_uskilo3.Text = reader[14].ToString();
                lbl_uskilo4.Text = reader[17].ToString();
            }
            //Enter tuşuna basıldığında verilerin kaydedilmesi için gerekli işlemler yapılır
            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_firstset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastset.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                //if statement'taki panel8.Top == btn_bacak.Top kısmının sebebi enter tuşuna basıldığında sadece bacak antrenmanı bilgilerinin güncellendiğinden
                //emin olmaktır. Diğer türlü bilgi kaydedildiğinde önceden açılmış tüm bölgelerdeki hareketlere aynı bilgi giriliyor
                if (e.KeyCode == Keys.Enter && panel8.Top == btn_bacak.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Ba1Ex = '" + txt_firstex.Text + "', Ba2Ex = '" + txt_secondex.Text + "', Ba3Ex = '" + txt_thirdex.Text + "', Ba4Ex = '" + txt_lastex.Text + "', Ba1Set='" + txt_firstset.Text + "', Ba2Set='" + txt_secondset.Text + "', Ba3Set='" + txt_thirdset.Text + "', Ba4Set='" + txt_lastset.Text + "' where [Username] = '" + trLo.userNAme + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void panel4_Paint(object sender, PaintEventArgs e) {

        }

        //Kapatma tuşu
        private void lbl_close_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //Biceps antrenmanlarını görüntülemek için kullanılacak kod
        //Bundan sonraki tüm bölgelerin kodları bacak antrenmanları için olan kodlarla aynı, açıklama gerekliyse oradaki açıklamalar okunabilir
        private void btn_biceps_Click(object sender, EventArgs e) {
            //Gerekli görsel düzenlemeler yapılır
            panel8.Height = btn_biceps.Height;
            panel8.Top = btn_biceps.Top;
            panel8.Show();

            lbl_kilo1.Text = "Kilo:";
            lbl_kilo3.Text = "Kilo:";
            lbl_uskilo2.Show();
            lbl_uskilo4.Show();
            lbl_kilo1.Show();
            lbl_kilo2.Show();
            lbl_kilo3.Show();
            lbl_kilo4.Show();
            txt_firstex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_lastex.Show();
            txt_firstset.Show();
            txt_secondset.Show();
            txt_thirdset.Show();
            txt_lastset.Show();

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + trLo.userNAme + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                txt_firstex.Text = reader[18].ToString();
                txt_firstset.Text = reader[19].ToString();
                txt_secondex.Text = reader[21].ToString();
                txt_secondset.Text = reader[22].ToString();
                txt_thirdex.Text = reader[24].ToString();
                txt_thirdset.Text = reader[25].ToString();
                txt_lastex.Text = reader[27].ToString();
                txt_lastset.Text = reader[28].ToString();
                lbl_uskilo1.Text = reader[20].ToString();
                lbl_uskilo2.Text = reader[23].ToString();
                lbl_uskilo3.Text = reader[26].ToString();
                lbl_uskilo4.Text = reader[29].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_firstset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastset.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel8.Top == btn_biceps.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Bi1Ex = '" + txt_firstex.Text + "', Bi2Ex = '" + txt_secondex.Text + "', Bi3Ex = '" + txt_thirdex.Text + "', Bi4Ex = '" + txt_lastex.Text + "', Bi1Set='" + txt_firstset.Text + "', Bi2Set='" + txt_secondset.Text + "', Bi3Set='" + txt_thirdset.Text + "', Bi4Set='" + txt_lastset.Text + "' where [Username] = '" + trLo.userNAme + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }


        //Göğüs antrenmanlarını görüntülemek için kullanılacak kod
        private void btn_chest_Click(object sender, EventArgs e) {
            panel8.Height = btn_chest.Height;
            panel8.Top = btn_chest.Top;
            panel8.Show();

            lbl_kilo1.Text = "Kilo:";
            lbl_kilo3.Text = "Kilo:";
            lbl_uskilo2.Show();
            lbl_uskilo4.Show();
            lbl_kilo1.Show();
            lbl_kilo2.Show();
            lbl_kilo3.Show();
            lbl_kilo4.Show();
            txt_firstex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_lastex.Show();
            txt_firstset.Show();
            txt_secondset.Show();
            txt_thirdset.Show();
            txt_lastset.Show();

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + trLo.userNAme + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                txt_firstex.Text = reader[30].ToString();
                txt_firstset.Text = reader[31].ToString();
                txt_secondex.Text = reader[33].ToString();
                txt_secondset.Text = reader[34].ToString();
                txt_thirdex.Text = reader[36].ToString();
                txt_thirdset.Text = reader[37].ToString();
                txt_lastex.Text = reader[39].ToString();
                txt_lastset.Text = reader[40].ToString();
                lbl_uskilo1.Text = reader[32].ToString();
                lbl_uskilo2.Text = reader[35].ToString();
                lbl_uskilo3.Text = reader[38].ToString();
                lbl_uskilo4.Text = reader[41].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_firstset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastset.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel8.Top == btn_chest.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Go1Ex = '" + txt_firstex.Text + "', Go2Ex = '" + txt_secondex.Text + "', Go3Ex = '" + txt_thirdex.Text + "', Go4Ex = '" + txt_lastex.Text + "', Go1Set='" + txt_firstset.Text + "', Go2Set='" + txt_secondset.Text + "', Go3Set='" + txt_thirdset.Text + "', Go4Set='" + txt_lastset.Text + "' where [Username] = '" + trLo.userNAme + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_cardio_Click(object sender, EventArgs e) {
            panel8.Height = btn_cardio.Height;
            panel8.Top = btn_cardio.Top;
            panel8.Show();


            lbl_kilo1.Text = "Süre:";
            lbl_kilo3.Text = "Süre:";
            lbl_uskilo2.Hide();
            lbl_uskilo4.Hide();
            lbl_kilo1.Show();
            lbl_kilo2.Hide();
            lbl_kilo3.Show();
            lbl_kilo4.Hide();
            txt_firstex.Show();
            txt_secondex.Hide();
            txt_thirdex.Show();
            txt_lastex.Hide();
            txt_firstset.Show();
            txt_secondset.Hide();
            txt_thirdset.Show();
            txt_lastset.Hide();

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + trLo.userNAme + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                txt_firstex.Text = reader[42].ToString();
                txt_firstset.Text = reader[43].ToString();//9 10 12 13 15 16
                txt_thirdex.Text = reader[45].ToString();
                txt_thirdset.Text = reader[46].ToString();
                lbl_uskilo1.Text = reader[44].ToString();
                lbl_uskilo3.Text = reader[47].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_firstset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdset.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel8.Top == btn_cardio.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Ka1Ex = '" + txt_firstex.Text + "', Ka2Ex = '" + txt_thirdex.Text + "', Ka1Tempo = '" + txt_firstset.Text + "', Ka2Tempo = '" + txt_thirdset.Text + "' WHERE [Username] = '" + trLo.userNAme + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_shoulder_Click(object sender, EventArgs e) {
            panel8.Height = btn_shoulder.Height;
            panel8.Top = btn_shoulder.Top;
            panel8.Show();

            lbl_kilo1.Text = "Kilo:";
            lbl_kilo3.Text = "Kilo:";
            lbl_uskilo2.Show();
            lbl_uskilo4.Show();
            lbl_kilo1.Show();
            lbl_kilo2.Show();
            lbl_kilo3.Show();
            lbl_kilo4.Show();
            txt_firstex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_lastex.Show();
            txt_firstset.Show();
            txt_secondset.Show();
            txt_thirdset.Show();
            txt_lastset.Show();

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + trLo.userNAme + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                txt_firstex.Text = reader[48].ToString();
                txt_firstset.Text = reader[49].ToString();
                txt_secondex.Text = reader[51].ToString();
                txt_secondset.Text = reader[52].ToString();
                txt_thirdex.Text = reader[54].ToString();
                txt_thirdset.Text = reader[55].ToString();
                txt_lastex.Text = reader[57].ToString();
                txt_lastset.Text = reader[58].ToString();
                lbl_uskilo1.Text = reader[50].ToString();
                lbl_uskilo2.Text = reader[53].ToString();
                lbl_uskilo3.Text = reader[56].ToString();
                lbl_uskilo4.Text = reader[59].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_firstset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastset.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel8.Top == btn_shoulder.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Om1Ex = '" + txt_firstex.Text + "', Om2Ex = '" + txt_secondex.Text + "', Om3Ex = '" + txt_thirdex.Text + "', Om4Ex = '" + txt_lastex.Text + "', Om1Set='" + txt_firstset.Text + "', Om2Set='" + txt_secondset.Text + "', Om3Set='" + txt_thirdset.Text + "', Om4Set='" + txt_lastset.Text + "' where [Username] = '" + trLo.userNAme + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_back_Click(object sender, EventArgs e) {
            panel8.Height = btn_back.Height;
            panel8.Top = btn_back.Top;
            panel8.Show();

            lbl_kilo1.Text = "Kilo:";
            lbl_kilo3.Text = "Kilo:";
            lbl_uskilo2.Show();
            lbl_uskilo4.Show();
            lbl_kilo1.Show();
            lbl_kilo2.Show();
            lbl_kilo3.Show();
            lbl_kilo4.Show();
            txt_firstex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_lastex.Show();
            txt_firstset.Show();
            txt_secondset.Show();
            txt_thirdset.Show();
            txt_lastset.Show();

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + trLo.userNAme + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                txt_firstex.Text = reader[60].ToString();
                txt_firstset.Text = reader[61].ToString();
                txt_secondex.Text = reader[63].ToString();
                txt_secondset.Text = reader[64].ToString();
                txt_thirdex.Text = reader[66].ToString();
                txt_thirdset.Text = reader[67].ToString();
                txt_lastex.Text = reader[69].ToString();
                txt_lastset.Text = reader[70].ToString();
                lbl_uskilo1.Text = reader[62].ToString();
                lbl_uskilo2.Text = reader[65].ToString();
                lbl_uskilo3.Text = reader[68].ToString();
                lbl_uskilo4.Text = reader[71].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_firstset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastset.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel8.Top == btn_back.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Sı1Ex = '" + txt_firstex.Text + "', Sı2Ex = '" + txt_secondex.Text + "', Sı3Ex = '" + txt_thirdex.Text + "', Sı4Ex = '" + txt_lastex.Text + "', Sı1Set='" + txt_firstset.Text + "', Sı2Set='" + txt_secondset.Text + "', Sı3Set='" + txt_thirdset.Text + "', Sı4Set='" + txt_lastset.Text + "' where [Username] = '" + trLo.userNAme + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void btn_triceps_Click(object sender, EventArgs e) {
            panel8.Height = btn_triceps.Height;
            panel8.Top = btn_triceps.Top;
            panel8.Show();

            lbl_kilo1.Text = "Kilo:";
            lbl_kilo3.Text = "Kilo:";
            lbl_uskilo2.Show();
            lbl_uskilo4.Show();
            lbl_kilo1.Show();
            lbl_kilo2.Show();
            lbl_kilo3.Show();
            lbl_kilo4.Show();
            txt_firstex.Show();
            txt_secondex.Show();
            txt_thirdex.Show();
            txt_lastex.Show();
            txt_firstset.Show();
            txt_secondset.Show();
            txt_thirdset.Show();
            txt_lastset.Show();

            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  UserTable WHERE Username='" + trLo.userNAme + "'", connection);
            reader = command.ExecuteReader();

            while (reader.Read()) {
                txt_firstex.Text = reader[72].ToString();
                txt_firstset.Text = reader[73].ToString();
                txt_secondex.Text = reader[75].ToString();
                txt_secondset.Text = reader[76].ToString();
                txt_thirdex.Text = reader[78].ToString();
                txt_thirdset.Text = reader[79].ToString();
                txt_lastex.Text = reader[81].ToString();
                txt_lastset.Text = reader[82].ToString();
                lbl_uskilo1.Text = reader[74].ToString();
                lbl_uskilo2.Text = reader[77].ToString();
                lbl_uskilo3.Text = reader[80].ToString();
                lbl_uskilo4.Text = reader[83].ToString();
            }

            txt_firstex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastex.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_firstset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_secondset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_thirdset.KeyDown += new KeyEventHandler(tb_KeyDown);
            txt_lastset.KeyDown += new KeyEventHandler(tb_KeyDown);

            void tb_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter && panel8.Top == btn_triceps.Top) {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "update UserTable set Tr1Ex = '" + txt_firstex.Text + "', Tr2Ex = '" + txt_secondex.Text + "', Tr3Ex = '" + txt_thirdex.Text + "', Tr4Ex = '" + txt_lastex.Text + "', Tr1Set='" + txt_firstset.Text + "', Tr2Set='" + txt_secondset.Text + "', Tr3Set='" + txt_thirdset.Text + "', Tr4Set='" + txt_lastset.Text + "' where [Username] = '" + trLo.userNAme + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }

            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
