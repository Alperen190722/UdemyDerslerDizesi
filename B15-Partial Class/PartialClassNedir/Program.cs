using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.id = 1;
            m1.isim = "alperen";
            m1.soyisim = "pişkin";
            m1.emailAdres = "alperen.piskin@hotmail.com";

            int sonuc = m1.yeniKayit(m1);
            if (sonuc > 0) 
            {
                Console.WriteLine("database yeni kayıt eklendi.");
            }

            ogrenci O1 = new ogrenci();
            O1.id = 1;
            O1.yeniKayit(O1);
        }
    }
}
