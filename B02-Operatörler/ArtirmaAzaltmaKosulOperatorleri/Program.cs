namespace ArtirmaAzaltmaKosulOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 100;

            // Artırma operatörü ++

            sayi = sayi + 1;
            sayi++;

            // Azaltma operatörü --

            sayi = sayi - 1;
            sayi--;

            // Koşul operatörü

            string durum = (sayi > 105) ? "Sayi değeri 105 değerinden büyük" : "Sayı değeri 105 değerinden " +
             "küçük";
            Console.WriteLine(durum);
        }
    }
}
