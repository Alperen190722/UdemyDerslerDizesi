using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    public sealed class Ogrenci:temelTip
    {
        public string bolum { get; set; }
        public int Seviye { get; set; }

        public Ogrenci() 
        {
            Console.WriteLine("Ogrenci nesnesinin yapıcı metotu çalıştı");

            // TemelTipMetot2(); protected plarak işaretlendiği için ve bu nesne kendisini temeltip
            // nesnesinden kalıtığı için protected seviyesinde olan field veya metotlara erişilebilir.
        }
    }
}
