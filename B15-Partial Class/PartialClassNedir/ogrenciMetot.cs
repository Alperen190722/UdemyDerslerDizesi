using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassNedir
{
    public partial class ogrenci
    {
        public int yeniKayit(ogrenci o) 
        {
            Console.WriteLine("Kayıt işlemi başarılı");
            return 1;
        }

        public int kayitGuncelle(ogrenci o) 
        {
            Console.WriteLine("Ogrenci kayıt güncelleme başarılı");
            return 1;
        }

        public int kayitSil(int id) 
        {
            Console.WriteLine("ogrenci silindi");
            return 1;
        }
    }
}
