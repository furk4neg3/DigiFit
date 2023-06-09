﻿using System;
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

    //Adminin giriş menüsü
    public partial class AdminLogin : Form {
        //MS Access'e bağlanmak için OleDbConnection objesi oluşturulur
        private OleDbConnection connection = new OleDbConnection();
        public AdminLogin() {
            InitializeComponent();
            //İlgili veritabanına bağlantı sağlanır
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Excalibur\Desktop\Databases\DigiFitDatabase.accdb;Persist Security Info=False;";
            //Beni hatırla özelliği için oluşturulan fonksiyon çağırılır
            Init_Data();
        }

        //Çıkış butonu için kullanılacak kod
        private void label4_Click(object sender, EventArgs e) {
            //Çıkış butonuna basıldığında uygulama kapatılır
            Application.Exit();
        }

        //Ana menüye dönmek için kullanılacak kod
        private void btn_goback_Click(object sender, EventArgs e) {
            //Giriş menüsü gizlenip ana menü gösterilir
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
            //Oluşturulan command objesi connection yardımıyla veritabanına bağlanır
            command.Connection = connection;
            //AdminTable'daki kullanıcı adı ve şifre girilen kullanıcı adı ve şifreye eşit olan tüm veriler okunur
            command.CommandText = "select * from AdminTable where Username='" + username_txt.Text + "' and Password='" + txt_password.Text + "'";
            //Verilerde bir değişiklik yapmayacağımız ve sadece okuma işlemi yapacağımız için executequery değil reader çağırıyoruz
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            //Girilen kullanıcı adı ve şifreye sahip kaç kullanıcı olduğu sayılır
            while (reader.Read()) {
                count++;
            }
            //Eğer sadece 1 kullanıcının kullanıcı adı ve şifre bilgileri girilenle aynıysa doğru bir giriş yapılmıştır, admin menüsü açılır
            if (count == 1) {
                //Artık veritabanıyla bağlantı yapmamızı gerektirecek bir durum olmadığı için bağlantı kapatılır
                connection.Close();
                //Kullanıcı adı ve şifre bilgileri doğru olduğu için bunlar beni hatırla özelliği seçiliyse kaydedilir, bunun için kullanılan fonksiyon çağırılır
                Save_Data();
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            //Eğer girilen kullanıcı adı ve şifreye sahip 1den fazla kişi varsa admin uyarılır
            } else if (count > 1) {
                MessageBox.Show("Username or Password is duplicated");
            //Girilen kullanıcı adı ve şifre değerleri tabloda hiç yoksa giriş yanlıştır. Tekrar denemesi istenir.
            } else {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış, lütfen tekrar deneyiniz.");
            }

            //Bağlantı kapatılır
            connection.Close();
        }

        //Beni hatırla butonu seçildiyse kullanıcı adı ve şifrenin gerekli yerlere yazılması için kullanılacak kod
        private void Init_Data() {
            if (Properties.Settings.Default.UserName != string.Empty) {
                if (Properties.Settings.Default.Remember) {
                    username_txt.Text = Properties.Settings.Default.UserName;
                    txt_password.Text = Properties.Settings.Default.PassWord;
                    checkBox1.Checked = true;
                } else {
                    username_txt.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        //Beni hatırla butonu seçiliyse kullanıcı adı ve şifre bilgilerinin kaydedilmesi için kullanılacak kod
        private void Save_Data() {
            if (checkBox1.Checked) {
                Properties.Settings.Default.UserName = username_txt.Text;
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
