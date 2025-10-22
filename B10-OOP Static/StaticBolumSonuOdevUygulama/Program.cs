using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StaticBolumSonuOdevUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Müsteri M1 = new Müsteri();
            M1.musteriID = 1;
            M1.isim = "Alperen";
            M1.soyisim = "Pişkin";
            M1.emailAdres = "alperen.piskin@hotmail.com";
            M1.KullaniciAdi = "alperen.piskin";
            M1.sifre = "1";

            Müsteri.MusteriEkle(M1);

            Müsteri M2 = new Müsteri()
            {
                musteriID = 2,
                isim = "Semih",
                soyisim = "Tecer",
                emailAdres = "semih.tecer@hotmail.com",
                KullaniciAdi = "semih.tecer",
                sifre = "2"
            };

            Müsteri.MusteriEkle(M2);

            Müsteri M3 = new Müsteri();
            M3.musteriID = 1;
            M3.isim = "Alperen";
            M3.soyisim = "Pişkin";
            M3.emailAdres = "alperen.piskin@hotmail.com";
            M3.KullaniciAdi = "alperen.piskin";
            M3.sifre = "1";

            Müsteri.MusteriEkle(M3);
        }
    }
}
