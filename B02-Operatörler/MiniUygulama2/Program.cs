namespace MiniUygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan isim soyisim ve doğum tarihini isteyelim. Girilen doğum tarihine göre
            //kullanıcının yaş değerini ekrana yazalım

            Console.Write("İsim ve soyisim değerlerinizi giriniz : ");
            string tamAd = Console.ReadLine();

            Console.Write("Doğum tarihinizi (yyyy-MM-dd) olarak giriniz : ");
            string dogumTarihi = Console.ReadLine();

            DateTime kullaniciDogumTarih = Convert.ToDateTime(dogumTarihi);
            DateTime bugun = DateTime.Now;

            int kullaniciYas = bugun.Year - kullaniciDogumTarih.Year;

            Console.WriteLine("Yaşınız :" + kullaniciYas);
        }
    }
}
