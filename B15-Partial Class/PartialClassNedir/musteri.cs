using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
    public class musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }

        public int yeniKayit(musteri m) 
        {
            Console.WriteLine("database kayıt işlemi tamamlandı");
            return 1;
        }

        public int kayitGuncelle(musteri m) 
        {
            Console.WriteLine("musteri kaydı güncellendi");
            return 1;
        }

        public int kayitSil(int id) 
        {
            Console.WriteLine("musteri kaydı silindi");
            return 1;
        }
    }
}
