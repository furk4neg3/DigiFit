//Ana giriþ menüsü
namespace DigiFit {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //Kapatma tuþu için kullanýlacak kod
        private void button4_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //Kullanýcýyý öðrenci giriþine yönlendirmek için kullanýlacak kod
        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }

        //Kullanýcýyý antrenör giriþine yönlendirmek için kullanýlacak kod
        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            TrainerLogin trainerLogin = new TrainerLogin();
            trainerLogin.Show();
        }

        //Kullanýcýyý admin giriþine yönlendirmek için kullanýlacak kod
        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }
    }
}