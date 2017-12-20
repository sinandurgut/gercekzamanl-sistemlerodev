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
    public partial class UserAdd : Form
    {
        ArduinoEntities db;

        public UserAdd()
        {
            InitializeComponent();
            db = new ArduinoEntities();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!db.USER.Where(x => x.KULLANICI_ADI == txt_kAdi.Text.ToString()).Any())
                {
                    db.USER.Add(new USER
                    {
                        KULLANICI_ADI = txt_kAdi.Text.ToString()
                       ,
                        ISIM = txt_ad.Text.ToString(),
                        SOYISIM = txt_soyad.Text.ToString(),
                        SIFRE = txt_sifre.Text.ToString()
                    });
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı Kayıt Edildi");

                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı daha önceden kayıtlı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik Hata " + ex.Message.ToString());

            }

        }
    }
}
