using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.tcKimlikNumarasi = " 12254401285";
            M1.isim = "Alperen";
            M1.soyisim = "Pişkin";
            M1.olusturmaTarih = DateTime.Now;

            //M1.musteriAdresleri = new MusteriAdres[5];
            // Asla yapmayın...

            M1.musteriAdresleri[0] = new MusteriAdres() 
            { 
                Il = "İstanbul",
                Ilce = "Kadıköy",
                Adres = "Adres ...",
                adresTip = "İş Yeri"
            };
            M1.musteriAdresleri[0].MusteriAdresTestMetot();
            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "SIP0001"
            };           
            M1.musteriSiparisBilgileri[0].MusteriSiparisBilgisiTestMetot();
            M1.urunler[0] = new Urun()
            {
                urunId = 1,
                Tanim = "Telefon",
                fiyat = 15000
            };
            M1.urunler[0].UrunTestMetot();
        }
    }
}
