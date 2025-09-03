namespace KarsilastirmaOperatorleriİnceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 15;

            // == Eşit mi kontrolü

            bool esitmi = sayi1 == sayi2;

            // != Eşit değil mi kontrolü

            bool esitDegilmi = sayi1 != sayi2;

            // > Büyük mü kontrolü 

            bool buyukmu = sayi1 > sayi2;

            // < Küçük mü kontrolü

            bool kucukmu = sayi1 < sayi2;

            // >= Büyük veya eşit mi kontrolü

            sayi1 = 21;
            sayi2 = 20;

            bool buyukEsitmiI = sayi1 >= sayi2;

            // <= Küçük veya eşit mi kontorlü

            sayi1 = 15;
            bool kucukEsitmi = sayi1 <= sayi2;
        }
    }
}
