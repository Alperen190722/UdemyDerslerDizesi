using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    public static class Helper
    {
        // Static olarak işaretlenmiş classlar örneklenemez..
        // Helper H1 = new Helper();
        /*
         *     public void Test() 
            { 

            }

              Static olan classlar içerisinde standart metotlar kullanılamaz. { static olmayan metotlar }

              public string Tanim { get; set; }

              Static olan classlar içerisinde static olmayan field tanımları yapılamaz.
            */

        //public Helper()
        //{
        // Her nesne örneği alındığında uygulama standart yapıcı metotu çalıştırır.   
        //}

        static Helper()
        {
            // Uyuglama içerisinde istenildiği kadar çağrılsınlar sadece ilk çağrılmada çalışırlar...
            Console.WriteLine("Helper => Static class => static CTOR"); 
        }

        public static void emailGonder(string aliciEmailAdres, string konu, string icerik) 
        {
          // Email gönderme işlemleri devam edecek ...
          Console.WriteLine("Mail Gönderim işlemi başarılı");
        }

 

    }
}
