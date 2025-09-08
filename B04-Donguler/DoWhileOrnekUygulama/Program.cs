namespace DoWhileOrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tutulanSayi = rnd.Next(1, 900);
            int kullaniciTahmin = 0;

            Console.WriteLine("1 ile 900 arasında bir değer seçimi yapınız");

            do
            {
                Console.Write("Tahmin edin : ");
                kullaniciTahmin = int.Parse(Console.ReadLine());

                if (kullaniciTahmin > tutulanSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı girişi yapın");
                }
                else if(kullaniciTahmin < tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı girişi yapın");
                }
            } while (kullaniciTahmin != tutulanSayi);
            Console.WriteLine("Tebrikler !");
        }
    }
}
