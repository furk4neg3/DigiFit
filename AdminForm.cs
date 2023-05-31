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

    //Admin giriş yaptığında göreceği menü
    public partial class AdminForm : Form {
        //MS Access'e bağlanmak için OleDbConnection objesi oluşturulur
        private OleDbConnection connection = new OleDbConnection();

        public AdminForm() {
            InitializeComponent();
            //İlgili veritabanına bağlantı sağlanır
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Excalibur\Desktop\Databases\DigiFitDatabase.accdb;Persist Security Info=False;";

        }

        private void AdminForm_Load(object sender, EventArgs e) {

        }

        //Öğrenci kaydetme butonunun kodları
        private void btn_saveuser_Click(object sender, EventArgs e) {
            //Veritabanıyla olan bağlantı başlatılır
            connection.Open();
            //Değişiklik yapılacağı için command objesi oluşturulur
            OleDbCommand command = new OleDbCommand();
            //Command'in bağlantısı connection objesiyle eşleştirilir
            command.Connection = connection;
            //Veritabanına yeni data girmek için kullanılan kod
            command.CommandText = "insert into UserTable ([Username],[Password],[NameOfUser]) values('" + txt_username.Text + "','" + txt_password.Text + "','" + txt_name.Text + "')";
            //Veritabanında değişiklik yapılacağı için nonquery çağırılır
            command.ExecuteNonQuery();
            //Kullanıcıya işlemin başarılı olduğu bilgisi verilir
            MessageBox.Show("Öğrenci kaydedildi.");
            //Bağlantı sonlandırılır
            connection.Close();
        }

        //Antrenör kaydetmek için kullanılacak kod
        private void btn_savetrai_Click(object sender, EventArgs e) {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //Bu sefer antrenör gireceğimiz için UserTable yerine TrainerTable'da işlem yapıyoruz
            command.CommandText = "insert into TrainerTable ([Username],[Password],[NameOfTrainer]) values('" + txt_username.Text + "','" + txt_password.Text + "','" + txt_name.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Antrenör kaydedildi.");
            connection.Close();
        }

        //Öğrenci bilgilerini değiştirmek için kullanılacak kod
        private void btn_edituser_Click(object sender, EventArgs e) {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //Veritabanının syntaxına göre veri değiştirme işlemi bu şekilde yapılır
            command.CommandText = "update UserTable set [Username]='" + txt_username.Text + "', [Password]='" + txt_password.Text + "', [NameOfUser]='" + txt_name.Text + "' where [ID]=" + txt_UID.Text + "";
            command.ExecuteNonQuery();
            MessageBox.Show("Öğrenci bilgileri değiştirildi.");
            connection.Close();
        }

        //Antrenör bilgilerini değiştirmek için kullanılacak kod
        private void btn_edittrai_Click(object sender, EventArgs e) {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //UserTable yerine TrainerTable yazılır, yapılan iş öğrenci bilgisi değiştirmekle aynı
            command.CommandText = "update TrainerTable set [Username]='" + txt_username.Text + "', [Password]='" + txt_password.Text + "', [NameOfTrainer]='" + txt_name.Text + "' where [ID]=" + txt_UID.Text + "";
            command.ExecuteNonQuery();
            MessageBox.Show("Antrenör bilgileri değiştirildi.");
            connection.Close();
        }

        //Öğrenci silmek için kullanılacak kod
        private void btn_deleteuser_Click(object sender, EventArgs e) {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //Veritabanından veri silmek için kullanılan syntax
            command.CommandText = "delete from UserTable where ID =" + txt_UID.Text + "";
            command.ExecuteNonQuery();
            MessageBox.Show("Öğrenci silindi.");
            connection.Close();
        }

        //Antrenör silmek için kullanılacak kod
        private void btn_deletetrai_Click(object sender, EventArgs e) {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //Antrenör silinmek istendiği için UserTable değil TrainerTable çağırılır
            command.CommandText = "delete from TrainerTable where ID =" + txt_UID.Text + "";
            command.ExecuteNonQuery();
            MessageBox.Show("Antrenör silindi.");
            connection.Close();
        }

        //Öğrencileri tablo olarak görmek için kullanılacak kod
        private void btn_showuser_Click(object sender, EventArgs e) {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //Sadece ID, Kullanıcı adı, şifre ve isim bilgileriyle ilgilendiğimiz için sadece bunları çağırıyoruz. İsteğe göre tabloda gösterilen bilgiler değiştirilebilir
            command.CommandText = "select [ID],[Username],[Password],[NameOfUser] from UserTable";
            //Aşağıda yaptığımız işlemler kısa anlatımla istediğimiz bilgilerle bir tablo oluşturup bunu kullanıcıya göstermek 
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        //Antrenör bilgilerini tablo olarak göstermek için kullanılacak kod
        private void btn_showtrai_Click(object sender, EventArgs e) {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select [ID],[Username],[Password],[NameOfTrainer] from TrainerTable";
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        //Tabloda seçilen kullanıcının bilgilerinin textboxlarda gösterilmesi için kullanılacak kod
        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
            //Aşağıdaki null tanımlaması ve döngü hangi kullanıcının seçildiğini anlamak için kullanılır
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells) {
                cell = selectedCell;
                break;
            }
            //Buradaki if statementta eğer bir kullanıcı seçilmişse yani cell null değilse kullanıcının bilgileri ilgili textboxlara yazdırılır
            if (cell != null) {
                DataGridViewRow row = cell.OwningRow;
                //Textboxların veya tablonun sırasına göre yazılan bir kod, tabloda ilk sırada olduğu için dizinin ilk elemanı yani tablonun ilk sütunundaki bilgi 
                //ID için olan textboxa yazılır, 2. sırasındaki kullanıcı adı için olana yazılır ve böyle devam eder
                txt_UID.Text = row.Cells[0].Value.ToString();
                txt_username.Text = row.Cells[1].Value.ToString();
                txt_password.Text = row.Cells[2].Value.ToString();
                txt_name.Text = row.Cells[3].Value.ToString();
            }
        }
        
        private void label5_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
