//Ana giri� men�s�
namespace DigiFit {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //Kapatma tu�u i�in kullan�lacak kod
        private void button4_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //Kullan�c�y� ��renci giri�ine y�nlendirmek i�in kullan�lacak kod
        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }

        //Kullan�c�y� antren�r giri�ine y�nlendirmek i�in kullan�lacak kod
        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            TrainerLogin trainerLogin = new TrainerLogin();
            trainerLogin.Show();
        }

        //Kullan�c�y� admin giri�ine y�nlendirmek i�in kullan�lacak kod
        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }
    }
}