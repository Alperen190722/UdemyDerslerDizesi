namespace MiniUygulama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double urunFiyat = 1000;
            double yeniFiyat = 1000;

            double indirimYuzde = ((urunFiyat - yeniFiyat) / urunFiyat) * 100;
            bool urunIndirimDurumu = urunFiyat > yeniFiyat;

            Console.WriteLine(urunIndirimDurumu?"Ürün indirim kapsamında" : " Ürün indirimde değil");
            Console.WriteLine("Ürün indirim %" + indirimYuzde);
        }
    }
}
