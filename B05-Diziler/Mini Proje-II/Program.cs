namespace Mini_Proje_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 34, 54, 2, 12, 56, 777, 89, 56, 345, -6 };

            int toplam = 0;
            int enBuyuk = 0, enKucuk = 0;
            double ortalama = 0;

            for (int i = 0; i < sayilar.Length; i++) 
            {
                toplam += sayilar[i];
                //toplam = toplam + sayilar[i];

                // En büyük değeri bulma adımı
                if (sayilar[i] > enBuyuk) 
                {
                    enBuyuk = sayilar[i];
                }

                // En küçük değeri bulma adımı
                if (sayilar[i] < enKucuk) 
                {
                    enKucuk = sayilar[i];
                }
            }

            ortalama = toplam / sayilar.Length;

            Console.WriteLine("Toplam :" + toplam);
            Console.WriteLine("Ortalama :" + ortalama);
            Console.WriteLine("En Büyük Değer :" + enBuyuk);
            Console.WriteLine("En Küçük Değer :" + enKucuk);
        }
    }
}
