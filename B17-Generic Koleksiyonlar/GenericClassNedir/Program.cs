using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.isim = "Alperen";
            M1.soyisim = "Pişkin";
            M1.TcKimlikNumarasi = "12254401254";
            M1.musteriNumara = "MS123";
            M1.DogumTarih = DateTime.Parse("21.08.2003");

            MusteriGeneric<int> MusteriGeneric1 = new MusteriGeneric<int>();
            MusteriGeneric1.id = 1;
            MusteriGeneric1.musteriNumarasiAl();

            MusteriGeneric<Guid> MusteriGeneric2 = new MusteriGeneric<Guid>();
            MusteriGeneric2.musteriNumarasiAl();


        }
    }
}
