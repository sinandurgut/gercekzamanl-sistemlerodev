using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerçek_Zamanlı_Sistemler.Classes.UserOperations
{
    public class UserService
    {
        ArduinoEntities dbContext;
        public static string Username = "";

        public UserService()
        {
            dbContext = new ArduinoEntities();
        }

        public bool Login(string username, string password)
        {
            if (dbContext.USER.Where(x => x.KULLANICI_ADI.Equals(username) && x.SIFRE.Equals(password)).Any())
                return true;
            return false;
        }

        public USER getUser(string username)
        {
          return  dbContext.USER.Where(x => x.KULLANICI_ADI.Equals(username)).FirstOrDefault();
        }
    }
}
