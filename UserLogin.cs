using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace DigiFit {

    //Öğrenci giriş menüsü
    public partial class UserLogin : Form {
        //MS Access'e bağlanmak için OleDbConnection objesi oluşturulur
        private OleDbConnection connection = new OleDbConnection();
        //Giriş yapıldıktan sonra girişi yapan kişinin bilgilerini gösterebilmek için ID verisi öğrenci menüsünde kullanılmak üzere public olarak tanımlanır
        public string userID { get; private set; }
        public UserLogin() {
            InitializeComponent();
            //İlgili veritabanına bağlantı sağlanır
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Excalibur\Desktop\Databases\DigiFitDatabase.accdb;Persist Security Info=False;";
            //Beni hatırla özelliği için oluşturulan fonksiyon çağırılır
            Init_Data();
        }

        private void UserLogin_Load(object sender, EventArgs e) {

        }

        //Çıkış butonu için kullanılacak kod
        private void button3_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //Ana menüye dönmek için kullanılacak kod
        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        //Giriş yapmak için kullanılacak kod
        private void btn_login_Click(object sender, EventArgs e) {
            //Veritabanına bağlantı sağlanır
            connection.Open();
            //Okuma işleminin yapılabilmesi için command objesi oluşturulur
            OleDbCommand command = new OleDbCommand();
            //Aynı kullanıcı adını kullanan birisi varsa da sıkıntı çıkacağından bunu kontrol etmek için de bir obje oluşturulur
            OleDbCommand cmd = new OleDbCommand();
            //Oluşturulan cmd ve command objesi connection yardımıyla veritabanına bağlanır
            command.Connection = connection;
            cmd.Connection = connection;
            //UserTable'daki kullanıcı adı ve şifre girilen kullanıcı adı ve şifreye eşit olan tüm veriler okunur, ardından kullanıcı adına eşit olan veriler okunur
            command.CommandText = "select * from UserTable where Username='" + txt_username.Text + "' and Password='" + txt_password.Text + "'";
            cmd.CommandText = "select * from UserTable where Username='" + txt_username.Text + "'";
            //Verilerde bir değişiklik yapmayacağımız ve sadece okuma işlemi yapacağımız için executequery değil reader çağırıyoruz
            OleDbDataReader reader = command.ExecuteReader();
            OleDbDataReader reader1 = cmd.ExecuteReader();
            int count = 0;
            int count2 = 0;
            //kullanıcı ID'sini alabilmek için int değişken
            int userIDc = 0;
            //Girilen kullanıcı adı ve şifreye, sonrasında sadece girilen kullanıcı adına sahip kaç kullanıcı olduğu sayılır
            while (reader.Read()) {
                //ID verisi alınır
                userIDc = Convert.ToInt32(reader[0]);
                count++;
            }
            while (reader1.Read()) {
                count2++;
            }
            //Eğer sadece 1 kullanıcının kullanıcı adı ve şifre bilgileri girilenle aynıysa ve aynı kullanıcı adına sahip sadece 1 kişi varsa doğru bir giriş yapılmıştır, öğrenci menüsü açılır
            if (count == 1 && count2 == 1) {
                //Artık veritabanıyla bağlantı yapmamızı gerektirecek bir durum olmadığı için bağlantı kapatılır
                connection.Close();
                //Oluşturulan public string öğrenci menüsünde kullanılmak üzere öğrencinin kullanıcı adına eşitlenir
                //Kullanıcı adı ve şifre bilgileri doğru olduğu için bunlar beni hatırla özelliği seçiliyse kaydedilir, bunun için kullanılan fonksiyon çağırılır
                Save_Data();
                this.Hide();
                //ID verisi string halinde userID değişkenine gönderilir.
                userID = userIDc.ToString();
                UserMenu userMenu = new UserMenu(this);
                userMenu.ShowDialog();
                MessageBox.Show("Username and Password are correct");
            //Eğer girilen kullanıcı adı ve şifreye sahip 1den fazla kişi varsa veya aynı kullanıcı adına sahip 1'den fazla kişi varsa istenmeyen bir durum oluşmuştur, kullanıcıya bilgi verilir
            } else if(count > 1 || count2 > 1) {
                MessageBox.Show("Sizinle aynı kullanıcı adına sahip biri tespit edildi. Lütfen antrenörünüzle iletişime geçiniz.");
            //Girilen kullanıcı adı ve şifre değerleri tabloda hiç yoksa giriş yanlıştır. Tekrar denemesi istenir.
            } else {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış, lütfen tekrar deneyiniz.");
            }

            //Veritabanıyla olan bağlantı kapatılır
            connection.Close();
        }

        //Beni hatırla butonu seçildiyse kullanıcı adı ve şifrenin gerekli yerlere yazılması için kullanılacak kod
        private void Init_Data() {
            if (Properties.Settings.Default.UserName != string.Empty) {
                if (Properties.Settings.Default.Remember) {
                    txt_username.Text = Properties.Settings.Default.UserName;
                    txt_password.Text = Properties.Settings.Default.PassWord;
                    checkBox1.Checked = true;
                } else {
                    txt_username.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        //Beni hatırla butonu seçiliyse kullanıcı adı ve şifre bilgilerinin kaydedilmesi için kullanılacak kod
        private void Save_Data() {
            if (checkBox1.Checked) {
                Properties.Settings.Default.UserName = txt_username.Text;
                Properties.Settings.Default.PassWord = txt_password.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            } else {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
