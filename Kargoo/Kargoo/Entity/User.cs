using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kargoo.Entity
{
   public class User
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        private static string error ="Kullancı bulunamadı!";

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }

        public static bool IsEqual(User user1, User user2)
        {
            if(user1==null || user2 == null) { return false; }
            
            if(user1.UserName != user2.UserName)
            {
                error = "Böyle bir kullanıcı bulunamadı.";
                return false;
            }
            else if(user1.Password != user2.Password)
            {
                error = "Kullanıcı adı ve parola eşleşmesdi.";
                return false;
            }
            return true;
        }
    }
}
