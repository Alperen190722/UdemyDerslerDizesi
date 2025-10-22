using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.Isim = "Alperen";
            P1.Soyisim = "Pişkin";
            P1.Emailadres = "alperen.piskin";
            P1.Cinsiyet = 717770001; // Bay 717770002 - Bayan

            Personel P2 = new Personel();
            P2.Isim = "Alperen";
            P2.Soyisim = "Pişkin";
            P2.Emailadres = "alperen.piskin";
            P2.Cinsiyet = 717770001; // Bay 717770002 - Bayan


            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
        }
    }
}
