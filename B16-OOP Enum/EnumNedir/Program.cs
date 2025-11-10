using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.musteriNumara = "MSN001";
            M1.isim = "Alperen";
            M1.soyisim = "Pişkin";
            M1.emailAdres = "alperen.piskin@hotmail.com";

            sanalDatabase SB = new sanalDatabase();
            musteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);

            int enumInt = (int)musteriReturnValue.kayitBasarisiz;
            Console.WriteLine(enumInt);

            //if (musteriKayitSonuc == musteriReturnValue.kayitBasarili) 
            //{ 

            //}
        }
    }
}
