namespace SwitchCaseUygulama
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

            double sayi1 = Convert.ToDouble(kullaniciDeger1);
            double sayi2 = Convert.ToDouble(kullaniciDeger2);
            double islemSonuc = 0;

            switch (kullaniciSecim)
            {
                case "1":
                    islemSonuc = sayi1 + sayi2;
                    break;
                case "2":
                        islemSonuc = sayi1 - sayi2;
                    break;
                case "3":
                    islemSonuc = sayi1 * sayi2;
                    break;
                case "4":
                    islemSonuc = sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Seçim değeriniz hatalı");
                    break;
            }

            Console.WriteLine("İşlem sonucunuz :" + islemSonuc);
        }
    }
}
