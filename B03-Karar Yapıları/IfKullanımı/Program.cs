namespace IfKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double urunFiyati = 2000;

            string kullaniciMesaj = (urunFiyati >= 3000) ? "Ürün fiyatı 3000'den büyük veya eşit" : "Ürün " +
                "fiyatı 3000'den küçük";

            Console.WriteLine(kullaniciMesaj);

            /*
            if(koşul veya koşullar)
            {
              işlemler yapılır
            }
            */

            if(urunFiyati >= 3000) // Doğru ise ;
            {
                Console.WriteLine("Kod 1");
                Console.WriteLine("Kod 2");
                Console.WriteLine("Kod 3");
            }
            else if(urunFiyati >= 2000)
            {
                Console.WriteLine("ürün fiyatı 2000 değerine eşit veya büyük");
            }
            else if(urunFiyati >= 1000)
            {
                Console.WriteLine("ürün fiyatı 1000 değerine eşit veya büyük");
            }
            else
            {
                // Eğer yukarıda bulunan şart veya şartlar sağlanmaz ise istediğmiz
                // işlemleri bu alana yazarız.

                Console.WriteLine("Kod X");
                Console.WriteLine("Kod Y");
            }
        }
    }
}
