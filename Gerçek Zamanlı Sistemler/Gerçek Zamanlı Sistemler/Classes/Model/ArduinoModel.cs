using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerçek_Zamanlı_Sistemler.Classes.Model
{
    public class ArduinoModel
    {

        public string Derece { get; set; }
        public string Mesafe { get; set; }
        public string UyariDerece { get; set; }

        public override string ToString()
        {
            return string.Format("Derece : {0} Mesafe : {1} Uyarı Derece : {2} ",Derece,Mesafe,UyariDerece);
        }
        public void ConsoleLog()
        {
            Console.WriteLine(string.Format("Derece : {0} Mesafe : {1} Uyarı Derece : {2} ", Derece, Mesafe, UyariDerece));
        }
    }
}
