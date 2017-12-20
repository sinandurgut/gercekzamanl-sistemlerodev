using Gerçek_Zamanlı_Sistemler.Classes.Model;
using Newtonsoft.Json.Linq;
using OneSignal.CSharp.SDK;
using OneSignal.CSharp.SDK.Resources;
using OneSignal.CSharp.SDK.Resources.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerçek_Zamanlı_Sistemler
{
    public partial class Form1 : Form
    {
        public static USER user;
        ArduinoModel model = new ArduinoModel();
        ArduinoEntities db;
        SerialPort serial = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            serial.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            //   serial.Open();
            lbl_portDurum.Text = "Port : Kapalı";
            label1.Text = "Merhaba " + user.ISIM + " " + user.SOYISIM;
            db = new ArduinoEntities();
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String deneme = serial.ReadLine();
            Console.WriteLine(i + " " + deneme.Trim());
            JsonParse(deneme.Trim());
            i++;

        }

        private void btn_portAc_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen)
            {
                serial.Close();
                lbl_portDurum.Text = "Port : Kapalı";
            }
            else
            {
                openPort();
                serial.WriteLine("2" + user.ISIM);

            }
        }


        DateTime lastUyariTime;
        bool uyarilsinmi = false;
        private void JsonParse(string value)
        {
            try
            {
                dynamic parsedString = JObject.Parse(value);
                string derece = parsedString.Sicaklik;
                string mesafe = parsedString.Mesafe;
                string uyariDerece = parsedString.UyariDerece;

                model.Derece = derece;
                model.Mesafe = mesafe;
                model.UyariDerece = uyariDerece;


                model.ConsoleLog();
                setEkran(model);
                db.OLCUM.Add(new OLCUM { DERECE = derece + "", MESAFE = mesafe, TARIH = DateTime.Now });
                db.SaveChanges();

                uyarilsinmi = false;
                var uyari = db.UYARI.Where(x => x.MESSAGE != null).OrderByDescending(y => y.GONDERILME_TARIHI).FirstOrDefault();
                if (uyari != null)
                {
                    if (uyari.GONDERILME_TARIHI.AddSeconds(10) < DateTime.Now)
                    {
                        uyarilsinmi = true;
                    }
                }

                else
                    uyarilsinmi = true;
                float dUyariDerece = float.Parse(uyariDerece);
                float dDerece = float.Parse(derece.Replace(".", ","));
                if ((dUyariDerece < dDerece) && uyarilsinmi)
                    SendUyari(uyariDerece);
               
                   // SendUyariKapi();

            }
            catch (Exception ex)
            {
            }
        }

        private void setEkran(ArduinoModel model)
        {
            lbl_derece.Text = model.Derece + "°";
            int kapıMesafe = int.Parse(model.Mesafe);
            if (kapıMesafe < 0)
            {
                kapıMesafe = 100;
            }
            if (kapıMesafe < 4)
                lbl_kapıState.Text = "Kapalı";
            else
                lbl_kapıState.Text = "Açık";
            lbl_uyariDerece.Text = model.UyariDerece + "°";
            try
            {
                var ortalamaList = db.OLCUM.Where(x => x.TARIH >= DateTime.Today).ToList();
                List<float> listim = new List<float>();
                foreach (var item in ortalamaList)
                {
                    if (!item.DERECE.Contains("-") && item.DERECE != "" && item.DERECE != null)
                        if (item.DERECE.Contains("."))
                            listim.Add(float.Parse(item.DERECE.Replace(".", ",")));
                        else
                            listim.Add(float.Parse(item.DERECE));

                }
                var ortalama = System.Math.Round(listim.Average(), 2); ;
                lbl_Ortalama.Text = ortalama + "°";
            }
            catch (Exception)

            {

            }

        }

        private void openPort()
        {
            try
            {
                serial.Open();
                lbl_portDurum.Text = "Port : Açık";
            }
            catch (Exception ex)
            {
                string exceptionMessage = ex.Message;
                lbl_portDurum.Text = "Port : Kapalı";
            }
        }

        private void btn_uyarıDereceDegistir_Click(object sender, EventArgs e)
        {
            if (txt_uyariDerece.Text.ToString().Count() != 0)
            {
                try
                {
                    string uyariDerece = txt_uyariDerece.Text.ToString().Trim();
                    serial.WriteLine("1" + uyariDerece);
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Derece Girmediniz");
            }


        }

        private void SendUyari(string derece)
        {
            var client = new OneSignalClient("NjVmODdkMmEtZTlkNy00MDNhLTk4MzQtNGE1ZmI0YmU0ODQ3");

            var options = new NotificationCreateOptions();

            options.AppId = Guid.Parse("03c0d86b-b918-49f6-b85e-442303146b60");
            options.IncludedSegments = new List<string> { "All" };
            options.Contents.Add(LanguageCodes.English, derece + " Üzerine çıktı lütfen depoyu kontrol ediniz.");

            client.Notifications.Create(options);
            db.UYARI.Add(new UYARI
            {
                GONDERILME_TARIHI = DateTime.Now,
                MESSAGE = derece + " Üzerine çıktı lütfen depoyu kontrol ediniz."
            });
            db.SaveChanges();
        }
        private void SendUyariKapi()
        {
            var client = new OneSignalClient("NjVmODdkMmEtZTlkNy00MDNhLTk4MzQtNGE1ZmI0YmU0ODQ3");

            var options = new NotificationCreateOptions();

            options.AppId = Guid.Parse("03c0d86b-b918-49f6-b85e-442303146b60");
            options.IncludedSegments = new List<string> { "All" };
            options.Contents.Add(LanguageCodes.English, "Kapı Açık Unutuldu");

            client.Notifications.Create(options);
            db.UYARI.Add(new UYARI
            {
                GONDERILME_TARIHI = DateTime.Now,
                MESSAGE = "Kapı Açık Unutuldu"
            });
            db.SaveChanges();
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            FormRapor formRapor = new FormRapor();
            formRapor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAdd formUser = new UserAdd();
            formUser.Show();
        }
    }
}