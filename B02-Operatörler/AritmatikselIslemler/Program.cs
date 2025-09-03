namespace AritmatikselIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aritmatiksel Islemler ...
            /* 
             + Toplama
             - Çıkarma
             / Bölme
             * Çarpma
             % Mod alma
             */

            // Toplama Operatörü Kullanımı
            int sayi1 = 100;
            int sayi2 = 50;

            int toplam = sayi1 + sayi2;

            // Çıkartma Operatörü

            int cikartma = sayi1 - sayi2;
            cikartma = sayi2 - sayi1;

            // Bölme Operatörü

            decimal sayi3 = 10;
            decimal sayi4 = 3;
            decimal bolme =  sayi3 / sayi4;

            // Çarpma Operatörü

            decimal sayi5 = 10;
            decimal sayi6 = 5;
            decimal carpma = sayi5 * sayi6;

            // Mod alma

            int sayi7 = 10;
            int sayi8 = 2;

            int modislmei = sayi7 % sayi8;
              
        }
    }
}
