using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedir2
{
    public class Musteri
    {
        public int id { get; set; }
        public  Guid musteriNumara { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime dogumTarih { get; set; }
    }
}
