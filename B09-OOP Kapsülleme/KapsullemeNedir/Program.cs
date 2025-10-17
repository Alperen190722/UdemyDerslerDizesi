using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            /*
             * Field değer ataması yapılamasın ama değer okunabilsin.
             * Field değer ataması yapılsın ama değer okumasın.
             * Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.
             * Field değer ataması ve okuma işlemleri yapılsın ama bu iki işleme bizim 
             * belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin.
             */

            // Class
            // Field
            // Property
            // Get & Set

            // M1.emailAdres = "alperen.piskin@hotmail.com"; ( Field )

            // Genel olarak kapsülleme konusuna giriş yaptık.
            //M1.EmailAdres = "alperen.piskin@hotmail.com";
            //Console.Write(M1.EmailAdres);

            //1.Field değer ataması yapılamasın ama değer okunabilsin.

            Console.WriteLine("Musteri Id Değeri = " + M1.ID.ToString());
            // M1.ID = 10;

            M1.TCKimlikNumarasi = "12254402599";
            string TC = M1.TCKimlikNumarasi;

            // isim ve soyisim
            //isim ve soyisim [soyisim] = set
            // email adresi ....
            // email get alperen.pişkin@hotmail.com
            // set : private

            M1.isim = "alperen";
            M1.Soyisim = "pişkin";
            Console.WriteLine(M1.EmailAdres);
        }
    }
}
