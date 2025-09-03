namespace IfOrnekKullanım2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan : 2 farklı değer isteyelim
            /*
            * İşleminizi seçiniz
            * 
            * 1 - Toplama
            * 2 - Çıkarma
            * 3 - Çarpma
            * 4 - Bölme
            * Seçim yapınız :
            *
            * Seçmiş olduğunuz işlem ... işlmeidir.
            * Sonuç : XX
            */

            Console.Write("1. değeri giriniz : ");
            string kullaniciDeger1 = Console.ReadLine();

            Console.Write("2. değeri giriniz : ");
            string kullaniciDeger2 = Console.ReadLine();

            Console.WriteLine("İşleminizi seçiniz");
            Console.WriteLine("1 - Toplama ");
            Console.WriteLine("2 - Çıkarma ");
            Console.WriteLine("3 - Çarpma ");
            Console.WriteLine("4 - Bölme ");
            Console.Write("Seçim yapınız : ");
            string kullaniciSecim = Console.ReadLine();

            double deger1 = 0;
            double deger2 = 0;
            double sonuc = 0;

            deger1 = Convert.ToDouble(kullaniciDeger1);
            deger2 = Convert.ToDouble(kullaniciDeger2);


            if (kullaniciSecim == "1")
            {
                sonuc = deger1 + deger2;
                Console.WriteLine("Sonuc : " + sonuc);
            }
            else if(kullaniciSecim == "2")
            {
                sonuc = deger1 - deger2;
                Console.WriteLine("Sonuc : " + sonuc);
            }
            else if(kullaniciSecim == "3")
            {
                sonuc = deger1 * deger2;
                Console.WriteLine("Sonuc : " + sonuc);
            }
            else if(kullaniciSecim == "4")
            {
                sonuc = deger1 / deger2;
                Console.WriteLine("Sonuc : " + sonuc);
            }
            else
            {
                Console.WriteLine("Size verilen işlem tablosu dışında veri girişi yaptınız");
            }

        }
    }
}
