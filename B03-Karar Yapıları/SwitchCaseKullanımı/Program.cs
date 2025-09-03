namespace SwitchCaseKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch (deger)
            //{
            //    case sabitdeger1:

            //    break;
            //    case sabitdeger2:

            //    break;
            //    default:

            //    break;
            //}

            Console.WriteLine("İçecek seçiniz ");
            Console.WriteLine("1. Su");
            Console.WriteLine("2. Çay");
            Console.WriteLine("3. Kahve - Türk");
            Console.WriteLine("4. Kahve - Filtre");
            Console.WriteLine("5. Kahve - Sütlü Filtre");
            Console.Write("Seçim Yapınız : ");

            string kullaniciSecim = Console.ReadLine();

            switch (kullaniciSecim)
            {
                case "1":
                    Console.WriteLine("Su veriliyor....");
                    break;
                case "2":
                    Console.WriteLine("Çay veriliyor....");
                    break;
                case "3":
                    Console.WriteLine("Türk Kahvesi veriliyor....");
                    break;
                case "4":
                case "5":
                    Console.WriteLine("Filtre Kahve veriliyor....");
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız");
                    break;

            }
        }
    }
}
