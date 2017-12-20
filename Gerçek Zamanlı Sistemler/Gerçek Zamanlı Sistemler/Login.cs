using Gerçek_Zamanlı_Sistemler.Classes.UserOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerçek_Zamanlı_Sistemler
{
    public partial class Login : Form
    {

        UserService userService;
        ArduinoEntities db;
        public Login()
        {
            InitializeComponent();
            userService = new UserService();
            db = new ArduinoEntities();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            string username = txt_kAdi.Text.ToString();
            string password = txt_sifre.Text.ToString();

            if (userService.Login(username, password))
            {
                MessageBox.Show("Giriş Başarılı");
                Form1.user = db.USER.Where(x => x.KULLANICI_ADI.Equals(username)).First();

                Form1 form = new Form1();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız. Lütfen Bilgilerinizi Kontrol Ediniz");
            }

        }


    }
}
